//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:44:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct moduleJSON
        {
            // Constructors
            public moduleJSON(NilType _)
            {
                this.Path = default;
                this.Dir = default;
                this.GoVersion = default;
            }

            public moduleJSON(@string Path = default, @string Dir = default, @string GoVersion = default)
            {
                this.Path = Path;
                this.Dir = Dir;
                this.GoVersion = GoVersion;
            }

            // Enable comparisons between nil and moduleJSON struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(moduleJSON value, NilType nil) => value.Equals(default(moduleJSON));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(moduleJSON value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, moduleJSON value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, moduleJSON value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator moduleJSON(NilType nil) => default(moduleJSON);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static moduleJSON moduleJSON_cast(dynamic value)
        {
            return new moduleJSON(value.Path, value.Dir, value.GoVersion);
        }
    }
}