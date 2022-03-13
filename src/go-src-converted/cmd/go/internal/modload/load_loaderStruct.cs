//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:31:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using fs = go.io.fs_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using fsys = go.cmd.go.@internal.fsys_package;
using imports = go.cmd.go.@internal.imports_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using mvs = go.cmd.go.@internal.mvs_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using str = go.cmd.go.@internal.str_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modload_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(loaderParams))]
        private partial struct loader
        {
            // loaderParams structure promotion - sourced from value copy
            private readonly ptr<loaderParams> m_loaderParamsRef;

            private ref loaderParams loaderParams_val => ref m_loaderParamsRef.Value;

            public ref ptr<Requirements> requirements => ref m_loaderParamsRef.Value.requirements;

            public ref bool allPatternIsRoot => ref m_loaderParamsRef.Value.allPatternIsRoot;

            public ref Func<ptr<Requirements>, slice<@string>> listRoots => ref m_loaderParamsRef.Value.listRoots;

            // Constructors
            public loader(NilType _)
            {
                this.m_loaderParamsRef = new ptr<loaderParams>(new loaderParams(nil));
                this.allClosesOverTests = default;
                this.work = default;
                this.roots = default;
                this.pkgCache = default;
                this.pkgs = default;
            }

            public loader(loaderParams loaderParams = default, bool allClosesOverTests = default, ref ptr<par.Queue> work = default, slice<ptr<loadPkg>> roots = default, ref ptr<par.Cache> pkgCache = default, slice<ptr<loadPkg>> pkgs = default)
            {
                this.m_loaderParamsRef = new ptr<loaderParams>(loaderParams);
                this.allClosesOverTests = allClosesOverTests;
                this.work = work;
                this.roots = roots;
                this.pkgCache = pkgCache;
                this.pkgs = pkgs;
            }

            // Enable comparisons between nil and loader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(loader value, NilType nil) => value.Equals(default(loader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(loader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, loader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, loader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator loader(NilType nil) => default(loader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static loader loader_cast(dynamic value)
        {
            return new loader(value.loaderParams, value.allClosesOverTests, ref value.work, value.roots, ref value.pkgCache, value.pkgs);
        }
    }
}}}}