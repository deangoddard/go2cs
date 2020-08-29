//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using gzip = go.compress.gzip_package;
using list = go.container.list_package;
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using url = go.net.url_package;
using os = go.os_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using proxy = go.golang_org.x.net.proxy_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct persistConn
        {
            // Constructors
            public persistConn(NilType _)
            {
                this.alt = default;
                this.t = default;
                this.cacheKey = default;
                this.conn = default;
                this.tlsState = default;
                this.br = default;
                this.bw = default;
                this.nwrite = default;
                this.reqch = default;
                this.writech = default;
                this.closech = default;
                this.isProxy = default;
                this.sawEOF = default;
                this.readLimit = default;
                this.writeErrCh = default;
                this.writeLoopDone = default;
                this.idleAt = default;
                this.idleTimer = default;
                this.mu = default;
                this.numExpectedResponses = default;
                this.closed = default;
                this.canceledErr = default;
                this.broken = default;
                this.reused = default;
                this.mutateHeaderFunc = default;
            }

            public persistConn(RoundTripper alt = default, ref ptr<Transport> t = default, connectMethodKey cacheKey = default, net.Conn conn = default, ref ptr<tls.ConnectionState> tlsState = default, ref ptr<bufio.Reader> br = default, ref ptr<bufio.Writer> bw = default, long nwrite = default, channel<requestAndChan> reqch = default, channel<writeRequest> writech = default, channel<object> closech = default, bool isProxy = default, bool sawEOF = default, long readLimit = default, channel<error> writeErrCh = default, channel<object> writeLoopDone = default, time.Time idleAt = default, ref ptr<time.Timer> idleTimer = default, sync.Mutex mu = default, long numExpectedResponses = default, error closed = default, error canceledErr = default, bool broken = default, bool reused = default, Action<Header> mutateHeaderFunc = default)
            {
                this.alt = alt;
                this.t = t;
                this.cacheKey = cacheKey;
                this.conn = conn;
                this.tlsState = tlsState;
                this.br = br;
                this.bw = bw;
                this.nwrite = nwrite;
                this.reqch = reqch;
                this.writech = writech;
                this.closech = closech;
                this.isProxy = isProxy;
                this.sawEOF = sawEOF;
                this.readLimit = readLimit;
                this.writeErrCh = writeErrCh;
                this.writeLoopDone = writeLoopDone;
                this.idleAt = idleAt;
                this.idleTimer = idleTimer;
                this.mu = mu;
                this.numExpectedResponses = numExpectedResponses;
                this.closed = closed;
                this.canceledErr = canceledErr;
                this.broken = broken;
                this.reused = reused;
                this.mutateHeaderFunc = mutateHeaderFunc;
            }

            // Enable comparisons between nil and persistConn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(persistConn value, NilType nil) => value.Equals(default(persistConn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(persistConn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, persistConn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, persistConn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator persistConn(NilType nil) => default(persistConn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static persistConn persistConn_cast(dynamic value)
        {
            return new persistConn(value.alt, ref value.t, value.cacheKey, value.conn, ref value.tlsState, ref value.br, ref value.bw, value.nwrite, value.reqch, value.writech, value.closech, value.isProxy, value.sawEOF, value.readLimit, value.writeErrCh, value.writeLoopDone, value.idleAt, ref value.idleTimer, value.mu, value.numExpectedResponses, value.closed, value.canceledErr, value.broken, value.reused, value.mutateHeaderFunc);
        }
    }
}}