//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using io = go.io_package;
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

#nullable enable

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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Options
        {
            // Constructors
            public Options(NilType _)
            {
                this.OutputFormat = default;
                this.CumSort = default;
                this.CallTree = default;
                this.DropNegative = default;
                this.CompactLabels = default;
                this.Ratio = default;
                this.Title = default;
                this.ProfileLabels = default;
                this.ActiveFilters = default;
                this.NumLabelUnits = default;
                this.NodeCount = default;
                this.NodeFraction = default;
                this.EdgeFraction = default;
                this.SampleValue = default;
                this.SampleMeanDivisor = default;
                this.SampleType = default;
                this.SampleUnit = default;
                this.OutputUnit = default;
                this.Symbol = default;
                this.SourcePath = default;
                this.TrimPath = default;
                this.IntelSyntax = default;
            }

            public Options(nint OutputFormat = default, bool CumSort = default, bool CallTree = default, bool DropNegative = default, bool CompactLabels = default, double Ratio = default, @string Title = default, slice<@string> ProfileLabels = default, slice<@string> ActiveFilters = default, map<@string, @string> NumLabelUnits = default, nint NodeCount = default, double NodeFraction = default, double EdgeFraction = default, Func<slice<long>, long> SampleValue = default, Func<slice<long>, long> SampleMeanDivisor = default, @string SampleType = default, @string SampleUnit = default, @string OutputUnit = default, ref ptr<regexp.Regexp> Symbol = default, @string SourcePath = default, @string TrimPath = default, bool IntelSyntax = default)
            {
                this.OutputFormat = OutputFormat;
                this.CumSort = CumSort;
                this.CallTree = CallTree;
                this.DropNegative = DropNegative;
                this.CompactLabels = CompactLabels;
                this.Ratio = Ratio;
                this.Title = Title;
                this.ProfileLabels = ProfileLabels;
                this.ActiveFilters = ActiveFilters;
                this.NumLabelUnits = NumLabelUnits;
                this.NodeCount = NodeCount;
                this.NodeFraction = NodeFraction;
                this.EdgeFraction = EdgeFraction;
                this.SampleValue = SampleValue;
                this.SampleMeanDivisor = SampleMeanDivisor;
                this.SampleType = SampleType;
                this.SampleUnit = SampleUnit;
                this.OutputUnit = OutputUnit;
                this.Symbol = Symbol;
                this.SourcePath = SourcePath;
                this.TrimPath = TrimPath;
                this.IntelSyntax = IntelSyntax;
            }

            // Enable comparisons between nil and Options struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Options value, NilType nil) => value.Equals(default(Options));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Options value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Options value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Options value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Options(NilType nil) => default(Options);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Options Options_cast(dynamic value)
        {
            return new Options(value.OutputFormat, value.CumSort, value.CallTree, value.DropNegative, value.CompactLabels, value.Ratio, value.Title, value.ProfileLabels, value.ActiveFilters, value.NumLabelUnits, value.NodeCount, value.NodeFraction, value.EdgeFraction, value.SampleValue, value.SampleMeanDivisor, value.SampleType, value.SampleUnit, value.OutputUnit, ref value.Symbol, value.SourcePath, value.TrimPath, value.IntelSyntax);
        }
    }
}}}}}}}