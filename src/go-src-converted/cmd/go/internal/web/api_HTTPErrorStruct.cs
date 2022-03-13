//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:30:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using fs = go.io.fs_package;
using url = go.net.url_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class web_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct HTTPError
        {
            // Constructors
            public HTTPError(NilType _)
            {
                this.URL = default;
                this.Status = default;
                this.StatusCode = default;
                this.Err = default;
                this.Detail = default;
            }

            public HTTPError(@string URL = default, @string Status = default, nint StatusCode = default, error Err = default, @string Detail = default)
            {
                this.URL = URL;
                this.Status = Status;
                this.StatusCode = StatusCode;
                this.Err = Err;
                this.Detail = Detail;
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

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static HTTPError HTTPError_cast(dynamic value)
        {
            return new HTTPError(value.URL, value.Status, value.StatusCode, value.Err, value.Detail);
        }
    }
}}}}