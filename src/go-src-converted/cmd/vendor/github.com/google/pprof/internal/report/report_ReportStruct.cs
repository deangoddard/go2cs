//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:06:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using time = go.time_package;
using graph = go.github.com.google.pprof.@internal.graph_package;
using measurement = go.github.com.google.pprof.@internal.measurement_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class report_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Report
        {
            // Constructors
            public Report(NilType _)
            {
                this.prof = default;
                this.total = default;
                this.options = default;
                this.formatValue = default;
            }

            public Report(ref ptr<profile.Profile> prof = default, long total = default, ref ptr<Options> options = default, Func<long, @string> formatValue = default)
            {
                this.prof = prof;
                this.total = total;
                this.options = options;
                this.formatValue = formatValue;
            }

            // Enable comparisons between nil and Report struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Report value, NilType nil) => value.Equals(default(Report));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Report value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Report value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Report value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Report(NilType nil) => default(Report);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Report Report_cast(dynamic value)
        {
            return new Report(ref value.prof, value.total, ref value.options, value.formatValue);
        }
    }
}}}}}}}