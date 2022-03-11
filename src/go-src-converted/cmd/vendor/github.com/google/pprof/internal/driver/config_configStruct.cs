//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:23:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using url = go.net.url_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
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
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct config
        {
            // Constructors
            public config(NilType _)
            {
                this.Output = default;
                this.CallTree = default;
                this.RelativePercentages = default;
                this.Unit = default;
                this.CompactLabels = default;
                this.SourcePath = default;
                this.TrimPath = default;
                this.IntelSyntax = default;
                this.Mean = default;
                this.SampleIndex = default;
                this.DivideBy = default;
                this.Normalize = default;
                this.Sort = default;
                this.DropNegative = default;
                this.NodeCount = default;
                this.NodeFraction = default;
                this.EdgeFraction = default;
                this.Trim = default;
                this.Focus = default;
                this.Ignore = default;
                this.PruneFrom = default;
                this.Hide = default;
                this.Show = default;
                this.ShowFrom = default;
                this.TagFocus = default;
                this.TagIgnore = default;
                this.TagShow = default;
                this.TagHide = default;
                this.NoInlines = default;
                this.Granularity = default;
            }

            public config(@string Output = default, bool CallTree = default, bool RelativePercentages = default, @string Unit = default, bool CompactLabels = default, @string SourcePath = default, @string TrimPath = default, bool IntelSyntax = default, bool Mean = default, @string SampleIndex = default, double DivideBy = default, bool Normalize = default, @string Sort = default, bool DropNegative = default, nint NodeCount = default, double NodeFraction = default, double EdgeFraction = default, bool Trim = default, @string Focus = default, @string Ignore = default, @string PruneFrom = default, @string Hide = default, @string Show = default, @string ShowFrom = default, @string TagFocus = default, @string TagIgnore = default, @string TagShow = default, @string TagHide = default, bool NoInlines = default, @string Granularity = default)
            {
                this.Output = Output;
                this.CallTree = CallTree;
                this.RelativePercentages = RelativePercentages;
                this.Unit = Unit;
                this.CompactLabels = CompactLabels;
                this.SourcePath = SourcePath;
                this.TrimPath = TrimPath;
                this.IntelSyntax = IntelSyntax;
                this.Mean = Mean;
                this.SampleIndex = SampleIndex;
                this.DivideBy = DivideBy;
                this.Normalize = Normalize;
                this.Sort = Sort;
                this.DropNegative = DropNegative;
                this.NodeCount = NodeCount;
                this.NodeFraction = NodeFraction;
                this.EdgeFraction = EdgeFraction;
                this.Trim = Trim;
                this.Focus = Focus;
                this.Ignore = Ignore;
                this.PruneFrom = PruneFrom;
                this.Hide = Hide;
                this.Show = Show;
                this.ShowFrom = ShowFrom;
                this.TagFocus = TagFocus;
                this.TagIgnore = TagIgnore;
                this.TagShow = TagShow;
                this.TagHide = TagHide;
                this.NoInlines = NoInlines;
                this.Granularity = Granularity;
            }

            // Enable comparisons between nil and config struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(config value, NilType nil) => value.Equals(default(config));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(config value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, config value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, config value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator config(NilType nil) => default(config);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static config config_cast(dynamic value)
        {
            return new config(value.Output, value.CallTree, value.RelativePercentages, value.Unit, value.CompactLabels, value.SourcePath, value.TrimPath, value.IntelSyntax, value.Mean, value.SampleIndex, value.DivideBy, value.Normalize, value.Sort, value.DropNegative, value.NodeCount, value.NodeFraction, value.EdgeFraction, value.Trim, value.Focus, value.Ignore, value.PruneFrom, value.Hide, value.Show, value.ShowFrom, value.TagFocus, value.TagIgnore, value.TagShow, value.TagHide, value.NoInlines, value.Granularity);
        }
    }
}}}}}}}