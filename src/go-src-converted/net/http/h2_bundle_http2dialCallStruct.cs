//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:17 UTC
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
using time = go.time_package;
using hpack = go.golang_org.x.net.http2.hpack_package;
using idna = go.golang_org.x.net.idna_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2dialCall
        {
            // Constructors
            public http2dialCall(NilType _)
            {
                this.p = default;
                this.done = default;
                this.res = default;
                this.err = default;
            }

            public http2dialCall(ref ptr<http2clientConnPool> p = default, channel<object> done = default, ref ptr<http2ClientConn> res = default, error err = default)
            {
                this.p = p;
                this.done = done;
                this.res = res;
                this.err = err;
            }

            // Enable comparisons between nil and http2dialCall struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2dialCall value, NilType nil) => value.Equals(default(http2dialCall));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2dialCall value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2dialCall value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2dialCall value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2dialCall(NilType nil) => default(http2dialCall);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static http2dialCall http2dialCall_cast(dynamic value)
        {
            return new http2dialCall(ref value.p, value.done, ref value.res, value.err);
        }
    }
}}