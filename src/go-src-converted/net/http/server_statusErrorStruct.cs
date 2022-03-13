//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:32 UTC
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
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using rand = go.math.rand_package;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct statusError
        {
            // Constructors
            public statusError(NilType _)
            {
                this.code = default;
                this.text = default;
            }

            public statusError(nint code = default, @string text = default)
            {
                this.code = code;
                this.text = text;
            }

            // Enable comparisons between nil and statusError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(statusError value, NilType nil) => value.Equals(default(statusError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(statusError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, statusError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, statusError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator statusError(NilType nil) => default(statusError);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static statusError statusError_cast(dynamic value)
        {
            return new statusError(value.code, value.text);
        }
    }
}}