//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:18:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using crypto = go.crypto_package;
using rand = go.crypto.rand_package;
using subtle = go.crypto.subtle_package;
using errors = go.errors_package;
using hash = go.hash_package;
using io = go.io_package;
using math = go.math_package;
using big = go.math.big_package;
using randutil = go.crypto.@internal.randutil_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class rsa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PublicKey
        {
            // Constructors
            public PublicKey(NilType _)
            {
                this.N = default;
                this.E = default;
            }

            public PublicKey(ref ptr<big.Int> N = default, nint E = default)
            {
                this.N = N;
                this.E = E;
            }

            // Enable comparisons between nil and PublicKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PublicKey value, NilType nil) => value.Equals(default(PublicKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PublicKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PublicKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PublicKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PublicKey(NilType nil) => default(PublicKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PublicKey PublicKey_cast(dynamic value)
        {
            return new PublicKey(ref value.N, value.E);
        }
    }
}}