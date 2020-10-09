//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using sort = go.sort_package;
using time = go.time_package;
using keys = go.golang.org.x.tools.@internal.@event.keys_package;
using label = go.golang.org.x.tools.@internal.@event.label_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export
{
    public static partial class metric_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Float64Data
        {
            // Constructors
            public Float64Data(NilType _)
            {
                this.Info = default;
                this.IsGauge = default;
                this.Rows = default;
                this.EndTime = default;
                this.groups = default;
                this.key = default;
            }

            public Float64Data(ref ptr<Scalar> Info = default, bool IsGauge = default, slice<double> Rows = default, time.Time EndTime = default, slice<slice<label.Label>> groups = default, ref ptr<keys.Float64> key = default)
            {
                this.Info = Info;
                this.IsGauge = IsGauge;
                this.Rows = Rows;
                this.EndTime = EndTime;
                this.groups = groups;
                this.key = key;
            }

            // Enable comparisons between nil and Float64Data struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Float64Data value, NilType nil) => value.Equals(default(Float64Data));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Float64Data value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Float64Data value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Float64Data value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Float64Data(NilType nil) => default(Float64Data);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Float64Data Float64Data_cast(dynamic value)
        {
            return new Float64Data(ref value.Info, value.IsGauge, value.Rows, value.EndTime, value.groups, ref value.key);
        }
    }
}}}}}}}