//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct defaultConverter
        {
            // Constructors
            public defaultConverter(NilType _)
            {
            }
            // Enable comparisons between nil and defaultConverter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(defaultConverter value, NilType nil) => value.Equals(default(defaultConverter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(defaultConverter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, defaultConverter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, defaultConverter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator defaultConverter(NilType nil) => default(defaultConverter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static defaultConverter defaultConverter_cast(dynamic value)
        {
            return new defaultConverter();
        }
    }
}}}