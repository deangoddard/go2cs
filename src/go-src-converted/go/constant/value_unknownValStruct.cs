//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using math = go.math_package;
using big = go.math.big_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class constant_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct unknownVal
        {
            // Constructors
            public unknownVal(NilType _)
            {
            }
            // Enable comparisons between nil and unknownVal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(unknownVal value, NilType nil) => value.Equals(default(unknownVal));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(unknownVal value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, unknownVal value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, unknownVal value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator unknownVal(NilType nil) => default(unknownVal);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static unknownVal unknownVal_cast(dynamic value)
        {
            return new unknownVal();
        }
    }
}}