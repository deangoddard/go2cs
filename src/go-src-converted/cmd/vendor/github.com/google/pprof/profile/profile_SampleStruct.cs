//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:06:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Sample
        {
            // Constructors
            public Sample(NilType _)
            {
                this.Location = default;
                this.Value = default;
                this.Label = default;
                this.NumLabel = default;
                this.NumUnit = default;
                this.locationIDX = default;
                this.labelX = default;
            }

            public Sample(slice<ref Location> Location = default, slice<long> Value = default, map<@string, slice<@string>> Label = default, map<@string, slice<long>> NumLabel = default, map<@string, slice<@string>> NumUnit = default, slice<ulong> locationIDX = default, slice<label> labelX = default)
            {
                this.Location = Location;
                this.Value = Value;
                this.Label = Label;
                this.NumLabel = NumLabel;
                this.NumUnit = NumUnit;
                this.locationIDX = locationIDX;
                this.labelX = labelX;
            }

            // Enable comparisons between nil and Sample struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sample value, NilType nil) => value.Equals(default(Sample));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sample value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sample value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sample value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sample(NilType nil) => default(Sample);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Sample Sample_cast(dynamic value)
        {
            return new Sample(value.Location, value.Value, value.Label, value.NumLabel, value.NumUnit, value.locationIDX, value.labelX);
        }
    }
}}}}}}