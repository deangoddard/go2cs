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
        public partial struct Require
        {
            // Constructors
            public Require(NilType _)
            {
                this.Mod = default;
                this.Indirect = default;
                this.Syntax = default;
            }

            public Require(module.Version Mod = default, bool Indirect = default, ref ptr<Line> Syntax = default)
            {
                this.Mod = Mod;
                this.Indirect = Indirect;
                this.Syntax = Syntax;
            }

            // Enable comparisons between nil and Require struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Require value, NilType nil) => value.Equals(default(Require));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Require value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Require value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Require value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Require(NilType nil) => default(Require);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Require Require_cast(dynamic value)
        {
            return new Require(value.Mod, value.Indirect, ref value.Syntax);
        }
    }
}}}}}}