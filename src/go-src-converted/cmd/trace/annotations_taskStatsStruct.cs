//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:35:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using template = go.html.template_package;
using trace = go.@internal.trace_package;
using log = go.log_package;
using math = go.math_package;
using http = go.net.http_package;
using url = go.net.url_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct taskStats
        {
            // Constructors
            public taskStats(NilType _)
            {
                this.Type = default;
                this.Count = default;
                this.Histogram = default;
            }

            public taskStats(@string Type = default, nint Count = default, durationHistogram Histogram = default)
            {
                this.Type = Type;
                this.Count = Count;
                this.Histogram = Histogram;
            }

            // Enable comparisons between nil and taskStats struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(taskStats value, NilType nil) => value.Equals(default(taskStats));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(taskStats value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, taskStats value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, taskStats value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator taskStats(NilType nil) => default(taskStats);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static taskStats taskStats_cast(dynamic value)
        {
            return new taskStats(value.Type, value.Count, value.Histogram);
        }
    }
}