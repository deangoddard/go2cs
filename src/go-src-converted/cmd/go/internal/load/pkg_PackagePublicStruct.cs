//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:01:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using build = go.go.build_package;
using token = go.go.token_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using pathpkg = go.path_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using str = go.cmd.go.@internal.str_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PackagePublic
        {
            // Constructors
            public PackagePublic(NilType _)
            {
                this.Dir = default;
                this.ImportPath = default;
                this.ImportComment = default;
                this.Name = default;
                this.Doc = default;
                this.Target = default;
                this.Shlib = default;
                this.Goroot = default;
                this.Standard = default;
                this.Root = default;
                this.ConflictDir = default;
                this.BinaryOnly = default;
                this.Stale = default;
                this.StaleReason = default;
                this.GoFiles = default;
                this.CgoFiles = default;
                this.IgnoredGoFiles = default;
                this.CFiles = default;
                this.CXXFiles = default;
                this.MFiles = default;
                this.HFiles = default;
                this.FFiles = default;
                this.SFiles = default;
                this.SwigFiles = default;
                this.SwigCXXFiles = default;
                this.SysoFiles = default;
                this.CgoCFLAGS = default;
                this.CgoCPPFLAGS = default;
                this.CgoCXXFLAGS = default;
                this.CgoFFLAGS = default;
                this.CgoLDFLAGS = default;
                this.CgoPkgConfig = default;
                this.Imports = default;
                this.Deps = default;
                this.Incomplete = default;
                this.Error = default;
                this.DepsErrors = default;
                this.TestGoFiles = default;
                this.TestImports = default;
                this.XTestGoFiles = default;
                this.XTestImports = default;
            }

            public PackagePublic(@string Dir = default, @string ImportPath = default, @string ImportComment = default, @string Name = default, @string Doc = default, @string Target = default, @string Shlib = default, bool Goroot = default, bool Standard = default, @string Root = default, @string ConflictDir = default, bool BinaryOnly = default, bool Stale = default, @string StaleReason = default, slice<@string> GoFiles = default, slice<@string> CgoFiles = default, slice<@string> IgnoredGoFiles = default, slice<@string> CFiles = default, slice<@string> CXXFiles = default, slice<@string> MFiles = default, slice<@string> HFiles = default, slice<@string> FFiles = default, slice<@string> SFiles = default, slice<@string> SwigFiles = default, slice<@string> SwigCXXFiles = default, slice<@string> SysoFiles = default, slice<@string> CgoCFLAGS = default, slice<@string> CgoCPPFLAGS = default, slice<@string> CgoCXXFLAGS = default, slice<@string> CgoFFLAGS = default, slice<@string> CgoLDFLAGS = default, slice<@string> CgoPkgConfig = default, slice<@string> Imports = default, slice<@string> Deps = default, bool Incomplete = default, ref ptr<PackageError> Error = default, slice<ref PackageError> DepsErrors = default, slice<@string> TestGoFiles = default, slice<@string> TestImports = default, slice<@string> XTestGoFiles = default, slice<@string> XTestImports = default)
            {
                this.Dir = Dir;
                this.ImportPath = ImportPath;
                this.ImportComment = ImportComment;
                this.Name = Name;
                this.Doc = Doc;
                this.Target = Target;
                this.Shlib = Shlib;
                this.Goroot = Goroot;
                this.Standard = Standard;
                this.Root = Root;
                this.ConflictDir = ConflictDir;
                this.BinaryOnly = BinaryOnly;
                this.Stale = Stale;
                this.StaleReason = StaleReason;
                this.GoFiles = GoFiles;
                this.CgoFiles = CgoFiles;
                this.IgnoredGoFiles = IgnoredGoFiles;
                this.CFiles = CFiles;
                this.CXXFiles = CXXFiles;
                this.MFiles = MFiles;
                this.HFiles = HFiles;
                this.FFiles = FFiles;
                this.SFiles = SFiles;
                this.SwigFiles = SwigFiles;
                this.SwigCXXFiles = SwigCXXFiles;
                this.SysoFiles = SysoFiles;
                this.CgoCFLAGS = CgoCFLAGS;
                this.CgoCPPFLAGS = CgoCPPFLAGS;
                this.CgoCXXFLAGS = CgoCXXFLAGS;
                this.CgoFFLAGS = CgoFFLAGS;
                this.CgoLDFLAGS = CgoLDFLAGS;
                this.CgoPkgConfig = CgoPkgConfig;
                this.Imports = Imports;
                this.Deps = Deps;
                this.Incomplete = Incomplete;
                this.Error = Error;
                this.DepsErrors = DepsErrors;
                this.TestGoFiles = TestGoFiles;
                this.TestImports = TestImports;
                this.XTestGoFiles = XTestGoFiles;
                this.XTestImports = XTestImports;
            }

            // Enable comparisons between nil and PackagePublic struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PackagePublic value, NilType nil) => value.Equals(default(PackagePublic));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PackagePublic value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PackagePublic value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PackagePublic value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PackagePublic(NilType nil) => default(PackagePublic);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PackagePublic PackagePublic_cast(dynamic value)
        {
            return new PackagePublic(value.Dir, value.ImportPath, value.ImportComment, value.Name, value.Doc, value.Target, value.Shlib, value.Goroot, value.Standard, value.Root, value.ConflictDir, value.BinaryOnly, value.Stale, value.StaleReason, value.GoFiles, value.CgoFiles, value.IgnoredGoFiles, value.CFiles, value.CXXFiles, value.MFiles, value.HFiles, value.FFiles, value.SFiles, value.SwigFiles, value.SwigCXXFiles, value.SysoFiles, value.CgoCFLAGS, value.CgoCPPFLAGS, value.CgoCXXFLAGS, value.CgoFFLAGS, value.CgoLDFLAGS, value.CgoPkgConfig, value.Imports, value.Deps, value.Incomplete, ref value.Error, value.DepsErrors, value.TestGoFiles, value.TestImports, value.XTestGoFiles, value.XTestImports);
        }
    }
}}}}