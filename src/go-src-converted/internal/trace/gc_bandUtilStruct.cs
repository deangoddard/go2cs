//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:35:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using heap = go.container.heap_package;
using math = go.math_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct bandUtil
        {
            // Constructors
            public bandUtil(NilType _)
            {
                this.series = default;
                this.i = default;
                this.utilBound = default;
            }

            public bandUtil(nint series = default, nint i = default, double utilBound = default)
            {
                this.series = series;
                this.i = i;
                this.utilBound = utilBound;
            }

            // Enable comparisons between nil and bandUtil struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bandUtil value, NilType nil) => value.Equals(default(bandUtil));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bandUtil value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bandUtil value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bandUtil value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bandUtil(NilType nil) => default(bandUtil);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static bandUtil bandUtil_cast(dynamic value)
        {
            return new bandUtil(value.series, value.i, value.utilBound);
        }
    }
}}