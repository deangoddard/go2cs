//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:40:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using path = go.path_package;
using sort = go.sort_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using semver = go.golang.org.x.mod.semver_package;
using errors = go.golang.org.x.xerrors_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class module_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct ModuleError
        {
            // Constructors
            public ModuleError(NilType _)
            {
                this.Path = default;
                this.Version = default;
                this.Err = default;
            }

            public ModuleError(@string Path = default, @string Version = default, error Err = default)
            {
                this.Path = Path;
                this.Version = Version;
                this.Err = Err;
            }

            // Enable comparisons between nil and ModuleError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ModuleError value, NilType nil) => value.Equals(default(ModuleError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ModuleError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ModuleError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ModuleError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ModuleError(NilType nil) => default(ModuleError);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static ModuleError ModuleError_cast(dynamic value)
        {
            return new ModuleError(value.Path, value.Version, value.Err);
        }
    }
}}}}}}