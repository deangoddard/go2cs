//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:29:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using buildcfg = go.@internal.buildcfg_package;
using cfg = go.@internal.cfg_package;
using io = go.io_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using sync = go.sync_package;
using fsys = go.cmd.go.@internal.fsys_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class cfg_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct EnvVar
        {
            // Constructors
            public EnvVar(NilType _)
            {
                this.Name = default;
                this.Value = default;
            }

            public EnvVar(@string Name = default, @string Value = default)
            {
                this.Name = Name;
                this.Value = Value;
            }

            // Enable comparisons between nil and EnvVar struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EnvVar value, NilType nil) => value.Equals(default(EnvVar));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EnvVar value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EnvVar value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EnvVar value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EnvVar(NilType nil) => default(EnvVar);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static EnvVar EnvVar_cast(dynamic value)
        {
            return new EnvVar(value.Name, value.Value);
        }
    }
}}}}