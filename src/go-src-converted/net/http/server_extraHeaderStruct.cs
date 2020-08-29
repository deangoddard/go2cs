//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:43 UTC
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
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct extraHeader
        {
            // Constructors
            public extraHeader(NilType _)
            {
                this.contentType = default;
                this.connection = default;
                this.transferEncoding = default;
                this.date = default;
                this.contentLength = default;
            }

            public extraHeader(@string contentType = default, @string connection = default, @string transferEncoding = default, slice<byte> date = default, slice<byte> contentLength = default)
            {
                this.contentType = contentType;
                this.connection = connection;
                this.transferEncoding = transferEncoding;
                this.date = date;
                this.contentLength = contentLength;
            }

            // Enable comparisons between nil and extraHeader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(extraHeader value, NilType nil) => value.Equals(default(extraHeader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(extraHeader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, extraHeader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, extraHeader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator extraHeader(NilType nil) => default(extraHeader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static extraHeader extraHeader_cast(dynamic value)
        {
            return new extraHeader(value.contentType, value.connection, value.transferEncoding, value.date, value.contentLength);
        }
    }
}}