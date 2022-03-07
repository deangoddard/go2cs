//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:17:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using scanner = go.go.scanner_package;
using token = go.go.token_package;
using goroot = go.@internal.goroot_package;
using fs = go.io.fs_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using fsys = go.cmd.go.@internal.fsys_package;
using imports = go.cmd.go.@internal.imports_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using modinfo = go.cmd.go.@internal.modinfo_package;
using modload = go.cmd.go.@internal.modload_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using str = go.cmd.go.@internal.str_package;
using trace = go.cmd.go.@internal.trace_package;
using sys = go.cmd.@internal.sys_package;
using modfile = go.golang.org.x.mod.modfile_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(PackagePublic))]
        public partial struct Package
        {
            // PackagePublic structure promotion - sourced from value copy
            private readonly ptr<PackagePublic> m_PackagePublicRef;

            private ref PackagePublic PackagePublic_val => ref m_PackagePublicRef.Value;

            public ref @string Dir => ref m_PackagePublicRef.Value.Dir;

            public ref @string ImportPath => ref m_PackagePublicRef.Value.ImportPath;

            public ref @string ImportComment => ref m_PackagePublicRef.Value.ImportComment;

            public ref @string Name => ref m_PackagePublicRef.Value.Name;

            public ref @string Doc => ref m_PackagePublicRef.Value.Doc;

            public ref @string Target => ref m_PackagePublicRef.Value.Target;

            public ref @string Shlib => ref m_PackagePublicRef.Value.Shlib;

            public ref @string Root => ref m_PackagePublicRef.Value.Root;

            public ref @string ConflictDir => ref m_PackagePublicRef.Value.ConflictDir;

            public ref @string ForTest => ref m_PackagePublicRef.Value.ForTest;

            public ref @string Export => ref m_PackagePublicRef.Value.Export;

            public ref @string BuildID => ref m_PackagePublicRef.Value.BuildID;

            public ref ptr<modinfo.ModulePublic> Module => ref m_PackagePublicRef.Value.Module;

            public ref slice<@string> Match => ref m_PackagePublicRef.Value.Match;

            public ref bool Goroot => ref m_PackagePublicRef.Value.Goroot;

            public ref bool Standard => ref m_PackagePublicRef.Value.Standard;

            public ref bool DepOnly => ref m_PackagePublicRef.Value.DepOnly;

            public ref bool BinaryOnly => ref m_PackagePublicRef.Value.BinaryOnly;

            public ref bool Incomplete => ref m_PackagePublicRef.Value.Incomplete;

            public ref bool Stale => ref m_PackagePublicRef.Value.Stale;

            public ref @string StaleReason => ref m_PackagePublicRef.Value.StaleReason;

            public ref slice<@string> GoFiles => ref m_PackagePublicRef.Value.GoFiles;

            public ref slice<@string> CgoFiles => ref m_PackagePublicRef.Value.CgoFiles;

            public ref slice<@string> CompiledGoFiles => ref m_PackagePublicRef.Value.CompiledGoFiles;

            public ref slice<@string> IgnoredGoFiles => ref m_PackagePublicRef.Value.IgnoredGoFiles;

            public ref slice<@string> InvalidGoFiles => ref m_PackagePublicRef.Value.InvalidGoFiles;

            public ref slice<@string> IgnoredOtherFiles => ref m_PackagePublicRef.Value.IgnoredOtherFiles;

            public ref slice<@string> CFiles => ref m_PackagePublicRef.Value.CFiles;

            public ref slice<@string> CXXFiles => ref m_PackagePublicRef.Value.CXXFiles;

            public ref slice<@string> MFiles => ref m_PackagePublicRef.Value.MFiles;

            public ref slice<@string> HFiles => ref m_PackagePublicRef.Value.HFiles;

            public ref slice<@string> FFiles => ref m_PackagePublicRef.Value.FFiles;

            public ref slice<@string> SFiles => ref m_PackagePublicRef.Value.SFiles;

            public ref slice<@string> SwigFiles => ref m_PackagePublicRef.Value.SwigFiles;

            public ref slice<@string> SwigCXXFiles => ref m_PackagePublicRef.Value.SwigCXXFiles;

            public ref slice<@string> SysoFiles => ref m_PackagePublicRef.Value.SysoFiles;

            public ref slice<@string> EmbedPatterns => ref m_PackagePublicRef.Value.EmbedPatterns;

            public ref slice<@string> EmbedFiles => ref m_PackagePublicRef.Value.EmbedFiles;

            public ref slice<@string> CgoCFLAGS => ref m_PackagePublicRef.Value.CgoCFLAGS;

            public ref slice<@string> CgoCPPFLAGS => ref m_PackagePublicRef.Value.CgoCPPFLAGS;

            public ref slice<@string> CgoCXXFLAGS => ref m_PackagePublicRef.Value.CgoCXXFLAGS;

            public ref slice<@string> CgoFFLAGS => ref m_PackagePublicRef.Value.CgoFFLAGS;

            public ref slice<@string> CgoLDFLAGS => ref m_PackagePublicRef.Value.CgoLDFLAGS;

            public ref slice<@string> CgoPkgConfig => ref m_PackagePublicRef.Value.CgoPkgConfig;

            public ref slice<@string> Imports => ref m_PackagePublicRef.Value.Imports;

            public ref map<@string, @string> ImportMap => ref m_PackagePublicRef.Value.ImportMap;

            public ref slice<@string> Deps => ref m_PackagePublicRef.Value.Deps;

            public ref ptr<PackageError> Error => ref m_PackagePublicRef.Value.Error;

            public ref slice<ptr<PackageError>> DepsErrors => ref m_PackagePublicRef.Value.DepsErrors;

            public ref slice<@string> TestGoFiles => ref m_PackagePublicRef.Value.TestGoFiles;

            public ref slice<@string> TestImports => ref m_PackagePublicRef.Value.TestImports;

            public ref slice<@string> TestEmbedPatterns => ref m_PackagePublicRef.Value.TestEmbedPatterns;

            public ref slice<@string> TestEmbedFiles => ref m_PackagePublicRef.Value.TestEmbedFiles;

            public ref slice<@string> XTestGoFiles => ref m_PackagePublicRef.Value.XTestGoFiles;

            public ref slice<@string> XTestImports => ref m_PackagePublicRef.Value.XTestImports;

            public ref slice<@string> XTestEmbedPatterns => ref m_PackagePublicRef.Value.XTestEmbedPatterns;

            public ref slice<@string> XTestEmbedFiles => ref m_PackagePublicRef.Value.XTestEmbedFiles;

            // Constructors
            public Package(NilType _)
            {
                this.m_PackagePublicRef = new ptr<PackagePublic>(new PackagePublic(nil));
                this.Internal = default;
            }

            public Package(PackagePublic PackagePublic = default, PackageInternal Internal = default)
            {
                this.m_PackagePublicRef = new ptr<PackagePublic>(PackagePublic);
                this.Internal = Internal;
            }

            // Enable comparisons between nil and Package struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Package value, NilType nil) => value.Equals(default(Package));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Package value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Package value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Package value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Package(NilType nil) => default(Package);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Package Package_cast(dynamic value)
        {
            return new Package(value.PackagePublic, value.Internal);
        }
    }
}}}}