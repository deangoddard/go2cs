//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct PushOptions
        {
            // Constructors
            public PushOptions(NilType _)
            {
                this.Method = default;
                this.Header = default;
            }

            public PushOptions(@string Method = default, Header Header = default)
            {
                this.Method = Method;
                this.Header = Header;
            }

            // Enable comparisons between nil and PushOptions struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PushOptions value, NilType nil) => value.Equals(default(PushOptions));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PushOptions value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PushOptions value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PushOptions value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PushOptions(NilType nil) => default(PushOptions);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static PushOptions PushOptions_cast(dynamic value)
        {
            return new PushOptions(value.Method, value.Header);
        }
    }
}}