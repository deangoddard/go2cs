//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:23:45 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TextItem
        {
            // Constructors
            public TextItem(NilType _)
            {
                this.Name = default;
                this.InlineLabel = default;
                this.Flat = default;
                this.Cum = default;
                this.FlatFormat = default;
                this.CumFormat = default;
            }

            public TextItem(@string Name = default, @string InlineLabel = default, long Flat = default, long Cum = default, @string FlatFormat = default, @string CumFormat = default)
            {
                this.Name = Name;
                this.InlineLabel = InlineLabel;
                this.Flat = Flat;
                this.Cum = Cum;
                this.FlatFormat = FlatFormat;
                this.CumFormat = CumFormat;
            }

            // Enable comparisons between nil and TextItem struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TextItem value, NilType nil) => value.Equals(default(TextItem));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TextItem value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TextItem value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TextItem value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TextItem(NilType nil) => default(TextItem);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TextItem TextItem_cast(dynamic value)
        {
            return new TextItem(value.Name, value.InlineLabel, value.Flat, value.Cum, value.FlatFormat, value.CumFormat);
        }
    }
}}}}}}}