//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct contextKey
        {
            // Constructors
            public contextKey(NilType _)
            {
                this.name = default;
            }

            public contextKey(@string name = default)
            {
                this.name = name;
            }

            // Enable comparisons between nil and contextKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(contextKey value, NilType nil) => value.Equals(default(contextKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(contextKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, contextKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, contextKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator contextKey(NilType nil) => default(contextKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static contextKey contextKey_cast(dynamic value)
        {
            return new contextKey(value.name);
        }
    }
}}