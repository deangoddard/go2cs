//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:40:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using lazyregexp = go.golang.org.x.mod.@internal.lazyregexp_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct elem
        {
            // Constructors
            public elem(NilType _)
            {
                this.version = default;
                this.indirect = default;
            }

            public elem(@string version = default, bool indirect = default)
            {
                this.version = version;
                this.indirect = indirect;
            }

            // Enable comparisons between nil and elem struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elem value, NilType nil) => value.Equals(default(elem));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elem value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elem value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elem value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elem(NilType nil) => default(elem);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static elem elem_cast(dynamic value)
        {
            return new elem(value.version, value.indirect);
        }
    }
}}}}}}