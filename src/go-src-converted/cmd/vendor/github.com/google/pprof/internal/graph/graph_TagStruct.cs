//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using math = go.math_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
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
    public static partial class graph_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Tag
        {
            // Constructors
            public Tag(NilType _)
            {
                this.Name = default;
                this.Unit = default;
                this.Value = default;
                this.Flat = default;
                this.FlatDiv = default;
                this.Cum = default;
                this.CumDiv = default;
            }

            public Tag(@string Name = default, @string Unit = default, long Value = default, long Flat = default, long FlatDiv = default, long Cum = default, long CumDiv = default)
            {
                this.Name = Name;
                this.Unit = Unit;
                this.Value = Value;
                this.Flat = Flat;
                this.FlatDiv = FlatDiv;
                this.Cum = Cum;
                this.CumDiv = CumDiv;
            }

            // Enable comparisons between nil and Tag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tag value, NilType nil) => value.Equals(default(Tag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tag(NilType nil) => default(Tag);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Tag Tag_cast(dynamic value)
        {
            return new Tag(value.Name, value.Unit, value.Value, value.Flat, value.FlatDiv, value.Cum, value.CumDiv);
        }
    }
}}}}}}}