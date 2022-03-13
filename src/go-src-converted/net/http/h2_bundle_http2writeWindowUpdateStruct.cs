//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct http2writeWindowUpdate
        {
            // Constructors
            public http2writeWindowUpdate(NilType _)
            {
                this.streamID = default;
                this.n = default;
            }

            public http2writeWindowUpdate(uint streamID = default, uint n = default)
            {
                this.streamID = streamID;
                this.n = n;
            }

            // Enable comparisons between nil and http2writeWindowUpdate struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2writeWindowUpdate value, NilType nil) => value.Equals(default(http2writeWindowUpdate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2writeWindowUpdate value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2writeWindowUpdate value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2writeWindowUpdate value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2writeWindowUpdate(NilType nil) => default(http2writeWindowUpdate);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static http2writeWindowUpdate http2writeWindowUpdate_cast(dynamic value)
        {
            return new http2writeWindowUpdate(value.streamID, value.n);
        }
    }
}}