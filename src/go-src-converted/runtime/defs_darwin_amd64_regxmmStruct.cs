//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct regxmm
        {
            // Constructors
            public regxmm(NilType _)
            {
                this.xmm_reg = default;
            }

            public regxmm(array<sbyte> xmm_reg = default)
            {
                this.xmm_reg = xmm_reg;
            }

            // Enable comparisons between nil and regxmm struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(regxmm value, NilType nil) => value.Equals(default(regxmm));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(regxmm value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, regxmm value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, regxmm value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator regxmm(NilType nil) => default(regxmm);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static regxmm regxmm_cast(dynamic value)
        {
            return new regxmm(value.xmm_reg);
        }
    }
}