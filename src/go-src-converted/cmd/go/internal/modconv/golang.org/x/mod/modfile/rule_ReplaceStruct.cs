//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:46:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using lazyregexp = go.golang.org.x.mod.@internal.lazyregexp_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Replace
        {
            // Constructors
            public Replace(NilType _)
            {
                this.Old = default;
                this.New = default;
                this.Syntax = default;
            }

            public Replace(module.Version Old = default, module.Version New = default, ref ptr<Line> Syntax = default)
            {
                this.Old = Old;
                this.New = New;
                this.Syntax = Syntax;
            }

            // Enable comparisons between nil and Replace struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Replace value, NilType nil) => value.Equals(default(Replace));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Replace value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Replace value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Replace value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Replace(NilType nil) => default(Replace);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Replace Replace_cast(dynamic value)
        {
            return new Replace(value.Old, value.New, ref value.Syntax);
        }
    }
}}}}