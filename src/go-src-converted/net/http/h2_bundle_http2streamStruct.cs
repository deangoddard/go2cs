//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:56:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using context = go.context_package;
using rand = go.crypto.rand_package;
using tls = go.crypto.tls_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using math = go.math_package;
using mathrand = go.math.rand_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using hpack = go.golang.org.x.net.http2.hpack_package;
using idna = go.golang.org.x.net.idna_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2stream
        {
            // Constructors
            public http2stream(NilType _)
            {
                this.sc = default;
                this.id = default;
                this.body = default;
                this.cw = default;
                this.ctx = default;
                this.cancelCtx = default;
                this.bodyBytes = default;
                this.declBodyBytes = default;
                this.flow = default;
                this.inflow = default;
                this.state = default;
                this.resetQueued = default;
                this.gotTrailerHeader = default;
                this.wroteHeaders = default;
                this.writeDeadline = default;
                this.trailer = default;
                this.reqTrailer = default;
            }

            public http2stream(ref ptr<http2serverConn> sc = default, uint id = default, ref ptr<http2pipe> body = default, http2closeWaiter cw = default, context.Context ctx = default, Action cancelCtx = default, long bodyBytes = default, long declBodyBytes = default, http2flow flow = default, http2flow inflow = default, http2streamState state = default, bool resetQueued = default, bool gotTrailerHeader = default, bool wroteHeaders = default, ref ptr<time.Timer> writeDeadline = default, Header trailer = default, Header reqTrailer = default)
            {
                this.sc = sc;
                this.id = id;
                this.body = body;
                this.cw = cw;
                this.ctx = ctx;
                this.cancelCtx = cancelCtx;
                this.bodyBytes = bodyBytes;
                this.declBodyBytes = declBodyBytes;
                this.flow = flow;
                this.inflow = inflow;
                this.state = state;
                this.resetQueued = resetQueued;
                this.gotTrailerHeader = gotTrailerHeader;
                this.wroteHeaders = wroteHeaders;
                this.writeDeadline = writeDeadline;
                this.trailer = trailer;
                this.reqTrailer = reqTrailer;
            }

            // Enable comparisons between nil and http2stream struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2stream value, NilType nil) => value.Equals(default(http2stream));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2stream value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2stream value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2stream value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2stream(NilType nil) => default(http2stream);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static http2stream http2stream_cast(dynamic value)
        {
            return new http2stream(ref value.sc, value.id, ref value.body, value.cw, value.ctx, value.cancelCtx, value.bodyBytes, value.declBodyBytes, value.flow, value.inflow, value.state, value.resetQueued, value.gotTrailerHeader, value.wroteHeaders, ref value.writeDeadline, value.trailer, value.reqTrailer);
        }
    }
}}