//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:32:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using fs = go.io.fs_package;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct zipFile
        {
            // Constructors
            public zipFile(NilType _)
            {
                this.name = default;
                this.f = default;
            }

            public zipFile(@string name = default, ref ptr<zip.File> f = default)
            {
                this.name = name;
                this.f = f;
            }

            // Enable comparisons between nil and zipFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(zipFile value, NilType nil) => value.Equals(default(zipFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(zipFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, zipFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, zipFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator zipFile(NilType nil) => default(zipFile);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static zipFile zipFile_cast(dynamic value)
        {
            return new zipFile(value.name, ref value.f);
        }
    }
}}}}