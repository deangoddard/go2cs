//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:36:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using elliptic = go.crypto.elliptic_package;
using hmac = go.crypto.hmac_package;
using errors = go.errors_package;
using hash = go.hash_package;
using io = go.io_package;
using big = go.math.big_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using curve25519 = go.golang.org.x.crypto.curve25519_package;
using hkdf = go.golang.org.x.crypto.hkdf_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct nistParameters
        {
            // Constructors
            public nistParameters(NilType _)
            {
                this.privateKey = default;
                this.x = default;
                this.y = default;
                this.curveID = default;
            }

            public nistParameters(slice<byte> privateKey = default, ref ptr<big.Int> x = default, ref ptr<big.Int> y = default, CurveID curveID = default)
            {
                this.privateKey = privateKey;
                this.x = x;
                this.y = y;
                this.curveID = curveID;
            }

            // Enable comparisons between nil and nistParameters struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nistParameters value, NilType nil) => value.Equals(default(nistParameters));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nistParameters value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nistParameters value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nistParameters value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nistParameters(NilType nil) => default(nistParameters);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static nistParameters nistParameters_cast(dynamic value)
        {
            return new nistParameters(value.privateKey, ref value.x, ref value.y, value.curveID);
        }
    }
}}