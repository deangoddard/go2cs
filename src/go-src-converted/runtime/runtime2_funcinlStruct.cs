//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:11:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct funcinl
        {
            // Constructors
            public funcinl(NilType _)
            {
                this.zero = default;
                this.entry = default;
                this.name = default;
                this.file = default;
                this.line = default;
            }

            public funcinl(System.UIntPtr zero = default, System.UIntPtr entry = default, @string name = default, @string file = default, nint line = default)
            {
                this.zero = zero;
                this.entry = entry;
                this.name = name;
                this.file = file;
                this.line = line;
            }

            // Enable comparisons between nil and funcinl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(funcinl value, NilType nil) => value.Equals(default(funcinl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(funcinl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, funcinl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, funcinl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator funcinl(NilType nil) => default(funcinl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static funcinl funcinl_cast(dynamic value)
        {
            return new funcinl(value.zero, value.entry, value.name, value.file, value.line);
        }
    }
}