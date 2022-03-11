//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:17:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bits = go.math.bits_package;
using go;

#nullable enable

namespace go {
namespace crypto {
namespace ed25519 {
namespace @internal {
namespace edwards25519
{
    public static partial class field_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct uint128
        {
            // Constructors
            public uint128(NilType _)
            {
                this.lo = default;
                this.hi = default;
            }

            public uint128(ulong lo = default, ulong hi = default)
            {
                this.lo = lo;
                this.hi = hi;
            }

            // Enable comparisons between nil and uint128 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uint128 value, NilType nil) => value.Equals(default(uint128));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uint128 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uint128 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uint128 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint128(NilType nil) => default(uint128);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static uint128 uint128_cast(dynamic value)
        {
            return new uint128(value.lo, value.hi);
        }
    }
}}}}}