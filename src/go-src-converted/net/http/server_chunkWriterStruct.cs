//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:02 UTC
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
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using net = go.net_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct chunkWriter
        {
            // Constructors
            public chunkWriter(NilType _)
            {
                this.res = default;
                this.header = default;
                this.wroteHeader = default;
                this.chunking = default;
            }

            public chunkWriter(ref ptr<response> res = default, Header header = default, bool wroteHeader = default, bool chunking = default)
            {
                this.res = res;
                this.header = header;
                this.wroteHeader = wroteHeader;
                this.chunking = chunking;
            }

            // Enable comparisons between nil and chunkWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(chunkWriter value, NilType nil) => value.Equals(default(chunkWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(chunkWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, chunkWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, chunkWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chunkWriter(NilType nil) => default(chunkWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static chunkWriter chunkWriter_cast(dynamic value)
        {
            return new chunkWriter(ref value.res, value.header, value.wroteHeader, value.chunking);
        }
    }
}}