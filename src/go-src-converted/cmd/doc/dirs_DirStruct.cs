//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:29:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using exec = go.@internal.execabs_package;
using log = go.log_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using strings = go.strings_package;
using sync = go.sync_package;
using semver = go.golang.org.x.mod.semver_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Dir
        {
            // Constructors
            public Dir(NilType _)
            {
                this.importPath = default;
                this.dir = default;
                this.inModule = default;
            }

            public Dir(@string importPath = default, @string dir = default, bool inModule = default)
            {
                this.importPath = importPath;
                this.dir = dir;
                this.inModule = inModule;
            }

            // Enable comparisons between nil and Dir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dir value, NilType nil) => value.Equals(default(Dir));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dir value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dir value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dir value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dir(NilType nil) => default(Dir);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Dir Dir_cast(dynamic value)
        {
            return new Dir(value.importPath, value.dir, value.inModule);
        }
    }
}