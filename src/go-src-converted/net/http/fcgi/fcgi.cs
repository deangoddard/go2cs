// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package fcgi implements the FastCGI protocol.
//
// The protocol is not an official standard and the original
// documentation is no longer online. See the Internet Archive's
// mirror at: https://web.archive.org/web/20150420080736/http://www.fastcgi.com/drupal/node/6?q=node/22
//
// Currently only the responder role is supported.
// package fcgi -- go2cs converted at 2020 August 29 08:34:11 UTC
// import "net/http/fcgi" ==> using fcgi = go.net.http.fcgi_package
// Original source: C:\Go\src\net\http\fcgi\fcgi.go
// This file defines the raw protocol and some utilities used by the child and
// the host.

using bufio = go.bufio_package;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using io = go.io_package;
using sync = go.sync_package;
using static go.builtin;

namespace go {
namespace net {
namespace http
{
    public static partial class fcgi_package
    {
        // recType is a record type, as defined by
        // https://web.archive.org/web/20150420080736/http://www.fastcgi.com/drupal/node/6?q=node/22#S8
        private partial struct recType // : byte
        {
        }

        private static readonly recType typeBeginRequest = 1L;
        private static readonly recType typeAbortRequest = 2L;
        private static readonly recType typeEndRequest = 3L;
        private static readonly recType typeParams = 4L;
        private static readonly recType typeStdin = 5L;
        private static readonly recType typeStdout = 6L;
        private static readonly recType typeStderr = 7L;
        private static readonly recType typeData = 8L;
        private static readonly recType typeGetValues = 9L;
        private static readonly recType typeGetValuesResult = 10L;
        private static readonly recType typeUnknownType = 11L;

        // keep the connection between web-server and responder open after request
        private static readonly long flagKeepConn = 1L;



        private static readonly long maxWrite = 65535L; // maximum record body
        private static readonly long maxPad = 255L;

        private static readonly var roleResponder = iota + 1L; // only Responders are implemented.
        private static readonly var roleAuthorizer = 0;
        private static readonly var roleFilter = 1;

        private static readonly var statusRequestComplete = iota;
        private static readonly var statusCantMultiplex = 0;
        private static readonly var statusOverloaded = 1;
        private static readonly var statusUnknownRole = 2;

        private partial struct header
        {
            public byte Version;
            public recType Type;
            public ushort Id;
            public ushort ContentLength;
            public byte PaddingLength;
            public byte Reserved;
        }

        private partial struct beginRequest
        {
            public ushort role;
            public byte flags;
            public array<byte> reserved;
        }

        private static error read(this ref beginRequest br, slice<byte> content)
        {
            if (len(content) != 8L)
            {
                return error.As(errors.New("fcgi: invalid begin request record"));
            }
            br.role = binary.BigEndian.Uint16(content);
            br.flags = content[2L];
            return error.As(null);
        }

        // for padding so we don't have to allocate all the time
        // not synchronized because we don't care what the contents are
        private static array<byte> pad = new array<byte>(maxPad);

        private static void init(this ref header h, recType recType, ushort reqId, long contentLength)
        {
            h.Version = 1L;
            h.Type = recType;
            h.Id = reqId;
            h.ContentLength = uint16(contentLength);
            h.PaddingLength = uint8(-contentLength & 7L);
        }

        // conn sends records over rwc
        private partial struct conn
        {
            public sync.Mutex mutex;
            public io.ReadWriteCloser rwc; // to avoid allocations
            public bytes.Buffer buf;
            public header h;
        }

        private static ref conn newConn(io.ReadWriteCloser rwc)
        {
            return ref new conn(rwc:rwc);
        }

        private static error Close(this ref conn _c) => func(_c, (ref conn c, Defer defer, Panic _, Recover __) =>
        {
            c.mutex.Lock();
            defer(c.mutex.Unlock());
            return error.As(c.rwc.Close());
        });

        private partial struct record
        {
            public header h;
            public array<byte> buf;
        }

        private static error read(this ref record rec, io.Reader r)
        {
            err = binary.Read(r, binary.BigEndian, ref rec.h);

            if (err != null)
            {
                return error.As(err);
            }
            if (rec.h.Version != 1L)
            {
                return error.As(errors.New("fcgi: invalid header version"));
            }
            var n = int(rec.h.ContentLength) + int(rec.h.PaddingLength);
            _, err = io.ReadFull(r, rec.buf[..n]);

            if (err != null)
            {
                return error.As(err);
            }
            return error.As(null);
        }

        private static slice<byte> content(this ref record r)
        {
            return r.buf[..r.h.ContentLength];
        }

        // writeRecord writes and sends a single record.
        private static error writeRecord(this ref conn _c, recType recType, ushort reqId, slice<byte> b) => func(_c, (ref conn c, Defer defer, Panic _, Recover __) =>
        {
            c.mutex.Lock();
            defer(c.mutex.Unlock());
            c.buf.Reset();
            c.h.init(recType, reqId, len(b));
            {
                var err = binary.Write(ref c.buf, binary.BigEndian, c.h);

                if (err != null)
                {
                    return error.As(err);
                }

            }
            {
                var (_, err) = c.buf.Write(b);

                if (err != null)
                {
                    return error.As(err);
                }

            }
            {
                (_, err) = c.buf.Write(pad[..c.h.PaddingLength]);

                if (err != null)
                {
                    return error.As(err);
                }

            }
            (_, err) = c.rwc.Write(c.buf.Bytes());
            return error.As(err);
        });

        private static error writeEndRequest(this ref conn c, ushort reqId, long appStatus, byte protocolStatus)
        {
            var b = make_slice<byte>(8L);
            binary.BigEndian.PutUint32(b, uint32(appStatus));
            b[4L] = protocolStatus;
            return error.As(c.writeRecord(typeEndRequest, reqId, b));
        }

        private static error writePairs(this ref conn c, recType recType, ushort reqId, map<@string, @string> pairs)
        {
            var w = newWriter(c, recType, reqId);
            var b = make_slice<byte>(8L);
            foreach (var (k, v) in pairs)
            {
                var n = encodeSize(b, uint32(len(k)));
                n += encodeSize(b[n..], uint32(len(v)));
                {
                    var (_, err) = w.Write(b[..n]);

                    if (err != null)
                    {
                        return error.As(err);
                    }

                }
                {
                    (_, err) = w.WriteString(k);

                    if (err != null)
                    {
                        return error.As(err);
                    }

                }
                {
                    (_, err) = w.WriteString(v);

                    if (err != null)
                    {
                        return error.As(err);
                    }

                }
            }
            w.Close();
            return error.As(null);
        }

        private static (uint, long) readSize(slice<byte> s)
        {
            if (len(s) == 0L)
            {
                return (0L, 0L);
            }
            var size = uint32(s[0L]);
            long n = 1L;
            if (size & (1L << (int)(7L)) != 0L)
            {
                if (len(s) < 4L)
                {
                    return (0L, 0L);
                }
                n = 4L;
                size = binary.BigEndian.Uint32(s);
                size &= 1L << (int)(31L);
            }
            return (size, n);
        }

        private static @string readString(slice<byte> s, uint size)
        {
            if (size > uint32(len(s)))
            {
                return "";
            }
            return string(s[..size]);
        }

        private static long encodeSize(slice<byte> b, uint size)
        {
            if (size > 127L)
            {
                size |= 1L << (int)(31L);
                binary.BigEndian.PutUint32(b, size);
                return 4L;
            }
            b[0L] = byte(size);
            return 1L;
        }

        // bufWriter encapsulates bufio.Writer but also closes the underlying stream when
        // Closed.
        private partial struct bufWriter
        {
            public io.Closer closer;
            public ref bufio.Writer Writer => ref Writer_ptr;
        }

        private static error Close(this ref bufWriter w)
        {
            {
                var err = w.Writer.Flush();

                if (err != null)
                {
                    w.closer.Close();
                    return error.As(err);
                }

            }
            return error.As(w.closer.Close());
        }

        private static ref bufWriter newWriter(ref conn c, recType recType, ushort reqId)
        {
            streamWriter s = ref new streamWriter(c:c,recType:recType,reqId:reqId);
            var w = bufio.NewWriterSize(s, maxWrite);
            return ref new bufWriter(s,w);
        }

        // streamWriter abstracts out the separation of a stream into discrete records.
        // It only writes maxWrite bytes at a time.
        private partial struct streamWriter
        {
            public ptr<conn> c;
            public recType recType;
            public ushort reqId;
        }

        private static (long, error) Write(this ref streamWriter w, slice<byte> p)
        {
            long nn = 0L;
            while (len(p) > 0L)
            {
                var n = len(p);
                if (n > maxWrite)
                {
                    n = maxWrite;
                }
                {
                    var err = w.c.writeRecord(w.recType, w.reqId, p[..n]);

                    if (err != null)
                    {
                        return (nn, err);
                    }

                }
                nn += n;
                p = p[n..];
            }

            return (nn, null);
        }

        private static error Close(this ref streamWriter w)
        { 
            // send empty record to close the stream
            return error.As(w.c.writeRecord(w.recType, w.reqId, null));
        }
    }
}}}
