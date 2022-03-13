//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:36:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using crypto = go.crypto_package;
using md5 = go.crypto.md5_package;
using rsa = go.crypto.rsa_package;
using sha1 = go.crypto.sha1_package;
using x509 = go.crypto.x509_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct ecdheKeyAgreement
        {
            // Constructors
            public ecdheKeyAgreement(NilType _)
            {
                this.version = default;
                this.isRSA = default;
                this.@params = default;
                this.ckx = default;
                this.preMasterSecret = default;
            }

            public ecdheKeyAgreement(ushort version = default, bool isRSA = default, ecdheParameters @params = default, ref ptr<clientKeyExchangeMsg> ckx = default, slice<byte> preMasterSecret = default)
            {
                this.version = version;
                this.isRSA = isRSA;
                this.@params = @params;
                this.ckx = ckx;
                this.preMasterSecret = preMasterSecret;
            }

            // Enable comparisons between nil and ecdheKeyAgreement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ecdheKeyAgreement value, NilType nil) => value.Equals(default(ecdheKeyAgreement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ecdheKeyAgreement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ecdheKeyAgreement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ecdheKeyAgreement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ecdheKeyAgreement(NilType nil) => default(ecdheKeyAgreement);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static ecdheKeyAgreement ecdheKeyAgreement_cast(dynamic value)
        {
            return new ecdheKeyAgreement(value.version, value.isRSA, value.@params, ref value.ckx, value.preMasterSecret);
        }
    }
}}