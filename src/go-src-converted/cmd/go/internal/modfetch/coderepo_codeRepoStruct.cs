//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using path = go.path_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using codehost = go.cmd.go.@internal.modfetch.codehost_package;
using modfile = go.golang.org.x.mod.modfile_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using modzip = go.golang.org.x.mod.zip_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modfetch_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct codeRepo
        {
            // Constructors
            public codeRepo(NilType _)
            {
                this.modPath = default;
                this.code = default;
                this.codeRoot = default;
                this.codeDir = default;
                this.pathMajor = default;
                this.pathPrefix = default;
                this.pseudoMajor = default;
            }

            public codeRepo(@string modPath = default, codehost.Repo code = default, @string codeRoot = default, @string codeDir = default, @string pathMajor = default, @string pathPrefix = default, @string pseudoMajor = default)
            {
                this.modPath = modPath;
                this.code = code;
                this.codeRoot = codeRoot;
                this.codeDir = codeDir;
                this.pathMajor = pathMajor;
                this.pathPrefix = pathPrefix;
                this.pseudoMajor = pseudoMajor;
            }

            // Enable comparisons between nil and codeRepo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(codeRepo value, NilType nil) => value.Equals(default(codeRepo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(codeRepo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, codeRepo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, codeRepo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator codeRepo(NilType nil) => default(codeRepo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static codeRepo codeRepo_cast(dynamic value)
        {
            return new codeRepo(value.modPath, value.code, value.codeRoot, value.codeDir, value.pathMajor, value.pathPrefix, value.pseudoMajor);
        }
    }
}}}}