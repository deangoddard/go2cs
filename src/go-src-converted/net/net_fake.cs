// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Fake networking for js/wasm. It is intended to allow tests of other package to pass.

// +build js,wasm

// package net -- go2cs converted at 2020 October 09 04:52:07 UTC
// import "net" ==> using net = go.net_package
// Original source: C:\Go\src\net\net_fake.go
using context = go.context_package;
using poll = go.@internal.poll_package;
using io = go.io_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;
using static go.builtin;
using System;

namespace go
{
    public static partial class net_package
    {
        private static sync.Mutex listenersMu = default;
        private static var listeners = make_map<@string, ptr<netFD>>();

        private static sync.Mutex portCounterMu = default;
        private static long portCounter = 0L;

        private static long nextPort() => func((defer, _, __) =>
        {
            portCounterMu.Lock();
            defer(portCounterMu.Unlock());
            portCounter++;
            return portCounter;
        });

        // Network file descriptor.
        private partial struct netFD
        {
            public ptr<bufferedPipe> r;
            public ptr<bufferedPipe> w;
            public channel<ptr<netFD>> incoming;
            public sync.Mutex closedMu;
            public bool closed; // immutable until Close
            public bool listener;
            public long family;
            public long sotype;
            public @string net;
            public Addr laddr;
            public Addr raddr; // unused
            public poll.FD pfd;
            public bool isConnected; // handshake completed or use of association with peer
        }

        // socket returns a network file descriptor that is ready for
        // asynchronous I/O using the network poller.
        private static (ptr<netFD>, error) socket(context.Context ctx, @string net, long family, long sotype, long proto, bool ipv6only, sockaddr laddr, sockaddr raddr, Func<@string, @string, syscall.RawConn, error> ctrlFn)
        {
            ptr<netFD> _p0 = default!;
            error _p0 = default!;

            ptr<netFD> fd = addr(new netFD(family:family,sotype:sotype,net:net));

            if (laddr != null && raddr == null)
            { // listener
                ptr<TCPAddr> l = laddr._<ptr<TCPAddr>>();
                fd.laddr = addr(new TCPAddr(IP:l.IP,Port:nextPort(),Zone:l.Zone,));
                fd.listener = true;
                fd.incoming = make_channel<ptr<netFD>>(1024L);
                listenersMu.Lock();
                listeners[fd.laddr._<ptr<TCPAddr>>().String()] = fd;
                listenersMu.Unlock();
                return (_addr_fd!, error.As(null!)!);

            }

            fd.laddr = addr(new TCPAddr(IP:IPv4(127,0,0,1),Port:nextPort(),));
            fd.raddr = raddr;
            fd.r = newBufferedPipe(65536L);
            fd.w = newBufferedPipe(65536L);

            ptr<netFD> fd2 = addr(new netFD(family:fd.family,sotype:sotype,net:net));
            fd2.laddr = fd.raddr;
            fd2.raddr = fd.laddr;
            fd2.r = fd.w;
            fd2.w = fd.r;
            listenersMu.Lock();
            var (l, ok) = listeners[fd.raddr._<ptr<TCPAddr>>().String()];
            if (!ok)
            {
                listenersMu.Unlock();
                return (_addr_null!, error.As(syscall.ECONNREFUSED)!);
            }

            l.incoming.Send(fd2);
            listenersMu.Unlock();

            return (_addr_fd!, error.As(null!)!);

        }

        private static (long, error) Read(this ptr<netFD> _addr_fd, slice<byte> p)
        {
            long n = default;
            error err = default!;
            ref netFD fd = ref _addr_fd.val;

            return fd.r.Read(p);
        }

        private static (long, error) Write(this ptr<netFD> _addr_fd, slice<byte> p)
        {
            long nn = default;
            error err = default!;
            ref netFD fd = ref _addr_fd.val;

            return fd.w.Write(p);
        }

        private static error Close(this ptr<netFD> _addr_fd)
        {
            ref netFD fd = ref _addr_fd.val;

            fd.closedMu.Lock();
            if (fd.closed)
            {
                fd.closedMu.Unlock();
                return error.As(null!)!;
            }

            fd.closed = true;
            fd.closedMu.Unlock();

            if (fd.listener)
            {
                listenersMu.Lock();
                delete(listeners, fd.laddr.String());
                close(fd.incoming);
                fd.listener = false;
                listenersMu.Unlock();
                return error.As(null!)!;
            }

            fd.r.Close();
            fd.w.Close();
            return error.As(null!)!;

        }

        private static error closeRead(this ptr<netFD> _addr_fd)
        {
            ref netFD fd = ref _addr_fd.val;

            fd.r.Close();
            return error.As(null!)!;
        }

        private static error closeWrite(this ptr<netFD> _addr_fd)
        {
            ref netFD fd = ref _addr_fd.val;

            fd.w.Close();
            return error.As(null!)!;
        }

        private static (ptr<netFD>, error) accept(this ptr<netFD> _addr_fd)
        {
            ptr<netFD> _p0 = default!;
            error _p0 = default!;
            ref netFD fd = ref _addr_fd.val;

            var (c, ok) = fd.incoming.Receive();
            if (!ok)
            {
                return (_addr_null!, error.As(syscall.EINVAL)!);
            }

            return (_addr_c!, error.As(null!)!);

        }

        private static error SetDeadline(this ptr<netFD> _addr_fd, time.Time t)
        {
            ref netFD fd = ref _addr_fd.val;

            fd.r.SetReadDeadline(t);
            fd.w.SetWriteDeadline(t);
            return error.As(null!)!;
        }

        private static error SetReadDeadline(this ptr<netFD> _addr_fd, time.Time t)
        {
            ref netFD fd = ref _addr_fd.val;

            fd.r.SetReadDeadline(t);
            return error.As(null!)!;
        }

        private static error SetWriteDeadline(this ptr<netFD> _addr_fd, time.Time t)
        {
            ref netFD fd = ref _addr_fd.val;

            fd.w.SetWriteDeadline(t);
            return error.As(null!)!;
        }

        private static ptr<bufferedPipe> newBufferedPipe(long softLimit)
        {
            ptr<bufferedPipe> p = addr(new bufferedPipe(softLimit:softLimit));
            p.rCond.L = _addr_p.mu;
            p.wCond.L = _addr_p.mu;
            return _addr_p!;
        }

        private partial struct bufferedPipe
        {
            public long softLimit;
            public sync.Mutex mu;
            public slice<byte> buf;
            public bool closed;
            public sync.Cond rCond;
            public sync.Cond wCond;
            public time.Time rDeadline;
            public time.Time wDeadline;
        }

        private static (long, error) Read(this ptr<bufferedPipe> _addr_p, slice<byte> b) => func((defer, _, __) =>
        {
            long _p0 = default;
            error _p0 = default!;
            ref bufferedPipe p = ref _addr_p.val;

            p.mu.Lock();
            defer(p.mu.Unlock());

            while (true)
            {
                if (p.closed && len(p.buf) == 0L)
                {
                    return (0L, error.As(io.EOF)!);
                }

                if (!p.rDeadline.IsZero())
                {
                    var d = time.Until(p.rDeadline);
                    if (d <= 0L)
                    {
                        return (0L, error.As(syscall.EAGAIN)!);
                    }

                    time.AfterFunc(d, p.rCond.Broadcast);

                }

                if (len(p.buf) > 0L)
                {
                    break;
                }

                p.rCond.Wait();

            }


            var n = copy(b, p.buf);
            p.buf = p.buf[n..];
            p.wCond.Broadcast();
            return (n, error.As(null!)!);

        });

        private static (long, error) Write(this ptr<bufferedPipe> _addr_p, slice<byte> b) => func((defer, _, __) =>
        {
            long _p0 = default;
            error _p0 = default!;
            ref bufferedPipe p = ref _addr_p.val;

            p.mu.Lock();
            defer(p.mu.Unlock());

            while (true)
            {
                if (p.closed)
                {
                    return (0L, error.As(syscall.ENOTCONN)!);
                }

                if (!p.wDeadline.IsZero())
                {
                    var d = time.Until(p.wDeadline);
                    if (d <= 0L)
                    {
                        return (0L, error.As(syscall.EAGAIN)!);
                    }

                    time.AfterFunc(d, p.wCond.Broadcast);

                }

                if (len(p.buf) <= p.softLimit)
                {
                    break;
                }

                p.wCond.Wait();

            }


            p.buf = append(p.buf, b);
            p.rCond.Broadcast();
            return (len(b), error.As(null!)!);

        });

        private static void Close(this ptr<bufferedPipe> _addr_p) => func((defer, _, __) =>
        {
            ref bufferedPipe p = ref _addr_p.val;

            p.mu.Lock();
            defer(p.mu.Unlock());

            p.closed = true;
            p.rCond.Broadcast();
            p.wCond.Broadcast();
        });

        private static void SetReadDeadline(this ptr<bufferedPipe> _addr_p, time.Time t) => func((defer, _, __) =>
        {
            ref bufferedPipe p = ref _addr_p.val;

            p.mu.Lock();
            defer(p.mu.Unlock());

            p.rDeadline = t;
            p.rCond.Broadcast();
        });

        private static void SetWriteDeadline(this ptr<bufferedPipe> _addr_p, time.Time t) => func((defer, _, __) =>
        {
            ref bufferedPipe p = ref _addr_p.val;

            p.mu.Lock();
            defer(p.mu.Unlock());

            p.wDeadline = t;
            p.wCond.Broadcast();
        });

        private static (long, error) sysSocket(long family, long sotype, long proto)
        {
            long _p0 = default;
            error _p0 = default!;

            return (0L, error.As(syscall.ENOSYS)!);
        }

        private static (long, syscall.Sockaddr, error) readFrom(this ptr<netFD> _addr_fd, slice<byte> p)
        {
            long n = default;
            syscall.Sockaddr sa = default;
            error err = default!;
            ref netFD fd = ref _addr_fd.val;

            return (0L, null, error.As(syscall.ENOSYS)!);
        }

        private static (long, long, long, syscall.Sockaddr, error) readMsg(this ptr<netFD> _addr_fd, slice<byte> p, slice<byte> oob)
        {
            long n = default;
            long oobn = default;
            long flags = default;
            syscall.Sockaddr sa = default;
            error err = default!;
            ref netFD fd = ref _addr_fd.val;

            return (0L, 0L, 0L, null, error.As(syscall.ENOSYS)!);
        }

        private static (long, error) writeTo(this ptr<netFD> _addr_fd, slice<byte> p, syscall.Sockaddr sa)
        {
            long n = default;
            error err = default!;
            ref netFD fd = ref _addr_fd.val;

            return (0L, error.As(syscall.ENOSYS)!);
        }

        private static (long, long, error) writeMsg(this ptr<netFD> _addr_fd, slice<byte> p, slice<byte> oob, syscall.Sockaddr sa)
        {
            long n = default;
            long oobn = default;
            error err = default!;
            ref netFD fd = ref _addr_fd.val;

            return (0L, 0L, error.As(syscall.ENOSYS)!);
        }

        private static (ptr<os.File>, error) dup(this ptr<netFD> _addr_fd)
        {
            ptr<os.File> f = default!;
            error err = default!;
            ref netFD fd = ref _addr_fd.val;

            return (_addr_null!, error.As(syscall.ENOSYS)!);
        }
    }
}
