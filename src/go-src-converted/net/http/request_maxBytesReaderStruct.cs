//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:22:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using context = go.context_package;
using tls = go.crypto.tls_package;
using base64 = go.encoding.base64_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using mime = go.mime_package;
using multipart = go.mime.multipart_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using ascii = go.net.http.@internal.ascii_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using idna = go.golang.org.x.net.idna_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct maxBytesReader
        {
            // Constructors
            public maxBytesReader(NilType _)
            {
                this.w = default;
                this.r = default;
                this.n = default;
                this.err = default;
            }

            public maxBytesReader(ResponseWriter w = default, io.ReadCloser r = default, long n = default, error err = default)
            {
                this.w = w;
                this.r = r;
                this.n = n;
                this.err = err;
            }

            // Enable comparisons between nil and maxBytesReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(maxBytesReader value, NilType nil) => value.Equals(default(maxBytesReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(maxBytesReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, maxBytesReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, maxBytesReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator maxBytesReader(NilType nil) => default(maxBytesReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static maxBytesReader maxBytesReader_cast(dynamic value)
        {
            return new maxBytesReader(value.w, value.r, value.n, value.err);
        }
    }
}}