//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:22:49 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct noBody
        {
            // Constructors
            public noBody(NilType _)
            {
            }
            // Enable comparisons between nil and noBody struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(noBody value, NilType nil) => value.Equals(default(noBody));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(noBody value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, noBody value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, noBody value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator noBody(NilType nil) => default(noBody);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static noBody noBody_cast(dynamic value)
        {
            return new noBody();
        }
    }
}}