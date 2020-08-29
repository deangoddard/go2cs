//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ecdsa = go.crypto.ecdsa_package;
using rsa = go.crypto.rsa_package;
using pkix = go.crypto.x509.pkix_package;
using asn1 = go.encoding.asn1_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pkcs8
        {
            // Constructors
            public pkcs8(NilType _)
            {
                this.Version = default;
                this.Algo = default;
                this.PrivateKey = default;
            }

            public pkcs8(long Version = default, pkix.AlgorithmIdentifier Algo = default, slice<byte> PrivateKey = default)
            {
                this.Version = Version;
                this.Algo = Algo;
                this.PrivateKey = PrivateKey;
            }

            // Enable comparisons between nil and pkcs8 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pkcs8 value, NilType nil) => value.Equals(default(pkcs8));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pkcs8 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pkcs8 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pkcs8 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pkcs8(NilType nil) => default(pkcs8);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pkcs8 pkcs8_cast(dynamic value)
        {
            return new pkcs8(value.Version, value.Algo, value.PrivateKey);
        }
    }
}}