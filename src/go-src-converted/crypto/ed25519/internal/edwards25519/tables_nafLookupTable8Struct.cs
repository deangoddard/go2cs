//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:17:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using subtle = go.crypto.subtle_package;
using go;

#nullable enable

namespace go {
namespace crypto {
namespace ed25519 {
namespace @internal
{
    public static partial class edwards25519_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nafLookupTable8
        {
            // Constructors
            public nafLookupTable8(NilType _)
            {
                this.points = default;
            }

            public nafLookupTable8(array<affineCached> points = default)
            {
                this.points = points;
            }

            // Enable comparisons between nil and nafLookupTable8 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nafLookupTable8 value, NilType nil) => value.Equals(default(nafLookupTable8));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nafLookupTable8 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nafLookupTable8 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nafLookupTable8 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nafLookupTable8(NilType nil) => default(nafLookupTable8);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nafLookupTable8 nafLookupTable8_cast(dynamic value)
        {
            return new nafLookupTable8(value.points);
        }
    }
}}}}