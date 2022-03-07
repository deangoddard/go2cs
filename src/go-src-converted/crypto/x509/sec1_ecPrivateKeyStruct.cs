//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ecdsa = go.crypto.ecdsa_package;
using elliptic = go.crypto.elliptic_package;
using asn1 = go.encoding.asn1_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using big = go.math.big_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ecPrivateKey
        {
            // Constructors
            public ecPrivateKey(NilType _)
            {
                this.Version = default;
                this.PrivateKey = default;
                this.NamedCurveOID = default;
                this.PublicKey = default;
            }

            public ecPrivateKey(nint Version = default, slice<byte> PrivateKey = default, asn1.ObjectIdentifier NamedCurveOID = default, asn1.BitString PublicKey = default)
            {
                this.Version = Version;
                this.PrivateKey = PrivateKey;
                this.NamedCurveOID = NamedCurveOID;
                this.PublicKey = PublicKey;
            }

            // Enable comparisons between nil and ecPrivateKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ecPrivateKey value, NilType nil) => value.Equals(default(ecPrivateKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ecPrivateKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ecPrivateKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ecPrivateKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ecPrivateKey(NilType nil) => default(ecPrivateKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ecPrivateKey ecPrivateKey_cast(dynamic value)
        {
            return new ecPrivateKey(value.Version, value.PrivateKey, value.NamedCurveOID, value.PublicKey);
        }
    }
}}