//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:06:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using net = go.net_package;
using url = go.net.url_package;
using os = go.os_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;
using idna = go.golang.org.x.net.idna_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace http
{
    public static partial class httpproxy_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ipMatch
        {
            // Constructors
            public ipMatch(NilType _)
            {
                this.ip = default;
                this.port = default;
            }

            public ipMatch(net.IP ip = default, @string port = default)
            {
                this.ip = ip;
                this.port = port;
            }

            // Enable comparisons between nil and ipMatch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ipMatch value, NilType nil) => value.Equals(default(ipMatch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ipMatch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ipMatch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ipMatch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ipMatch(NilType nil) => default(ipMatch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ipMatch ipMatch_cast(dynamic value)
        {
            return new ipMatch(value.ip, value.port);
        }
    }
}}}}}}