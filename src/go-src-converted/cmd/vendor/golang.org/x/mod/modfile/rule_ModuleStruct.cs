//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:26:05 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Module
        {
            // Constructors
            public Module(NilType _)
            {
                this.Mod = default;
                this.Deprecated = default;
                this.Syntax = default;
            }

            public Module(module.Version Mod = default, @string Deprecated = default, ref ptr<Line> Syntax = default)
            {
                this.Mod = Mod;
                this.Deprecated = Deprecated;
                this.Syntax = Syntax;
            }

            // Enable comparisons between nil and Module struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Module value, NilType nil) => value.Equals(default(Module));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Module value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Module value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Module value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Module(NilType nil) => default(Module);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Module Module_cast(dynamic value)
        {
            return new Module(value.Mod, value.Deprecated, ref value.Syntax);
        }
    }
}}}}}}