//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:01:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using tls = go.crypto.tls_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using http = go.net.http_package;
using url = go.net.url_package;
using time = go.time_package;
using cfg = go.cmd.go.@internal.cfg_package;
using browser = go.cmd.@internal.browser_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class web_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct HTTPError
        {
            // Constructors
            public HTTPError(NilType _)
            {
                this.status = default;
                this.StatusCode = default;
                this.url = default;
            }

            public HTTPError(@string status = default, long StatusCode = default, @string url = default)
            {
                this.status = status;
                this.StatusCode = StatusCode;
                this.url = url;
            }

            // Enable comparisons between nil and HTTPError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HTTPError value, NilType nil) => value.Equals(default(HTTPError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HTTPError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HTTPError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HTTPError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HTTPError(NilType nil) => default(HTTPError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static HTTPError HTTPError_cast(dynamic value)
        {
            return new HTTPError(value.status, value.StatusCode, value.url);
        }
    }
}}}}