//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:00:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @base = go.cmd.go.@internal.@base_package;
using str = go.cmd.go.@internal.str_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PerPackageFlag
        {
            // Constructors
            public PerPackageFlag(NilType _)
            {
                this.present = default;
                this.values = default;
            }

            public PerPackageFlag(bool present = default, slice<ppfValue> values = default)
            {
                this.present = present;
                this.values = values;
            }

            // Enable comparisons between nil and PerPackageFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PerPackageFlag value, NilType nil) => value.Equals(default(PerPackageFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PerPackageFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PerPackageFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PerPackageFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PerPackageFlag(NilType nil) => default(PerPackageFlag);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PerPackageFlag PerPackageFlag_cast(dynamic value)
        {
            return new PerPackageFlag(value.present, value.values);
        }
    }
}}}}