//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:23:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using math = go.math_package;
using strings = go.strings_package;
using time = go.time_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class measurement_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct unit
        {
            // Constructors
            public unit(NilType _)
            {
                this.canonicalName = default;
                this.aliases = default;
                this.factor = default;
            }

            public unit(@string canonicalName = default, slice<@string> aliases = default, double factor = default)
            {
                this.canonicalName = canonicalName;
                this.aliases = aliases;
                this.factor = factor;
            }

            // Enable comparisons between nil and unit struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(unit value, NilType nil) => value.Equals(default(unit));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(unit value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, unit value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, unit value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator unit(NilType nil) => default(unit);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static unit unit_cast(dynamic value)
        {
            return new unit(value.canonicalName, value.aliases, value.factor);
        }
    }
}}}}}}}