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
        private partial struct neonstate64
        {
            // Constructors
            public neonstate64(NilType _)
            {
                this.v = default;
                this.fpsr = default;
                this.fpcr = default;
            }

            public neonstate64(array<ulong> v = default, uint fpsr = default, uint fpcr = default)
            {
                this.v = v;
                this.fpsr = fpsr;
                this.fpcr = fpcr;
            }

            // Enable comparisons between nil and neonstate64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(neonstate64 value, NilType nil) => value.Equals(default(neonstate64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(neonstate64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, neonstate64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, neonstate64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator neonstate64(NilType nil) => default(neonstate64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static neonstate64 neonstate64_cast(dynamic value)
        {
            return new neonstate64(value.v, value.fpsr, value.fpcr);
        }
    }
}