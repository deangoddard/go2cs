//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MMUCurve
        {
            // Constructors
            public MMUCurve(NilType _)
            {
                this.series = default;
            }

            public MMUCurve(slice<mmuSeries> series = default)
            {
                this.series = series;
            }

            // Enable comparisons between nil and MMUCurve struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MMUCurve value, NilType nil) => value.Equals(default(MMUCurve));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MMUCurve value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MMUCurve value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MMUCurve value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MMUCurve(NilType nil) => default(MMUCurve);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MMUCurve MMUCurve_cast(dynamic value)
        {
            return new MMUCurve(value.series);
        }
    }
}}