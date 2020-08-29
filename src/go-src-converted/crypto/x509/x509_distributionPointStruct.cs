//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using crypto = go.crypto_package;
using dsa = go.crypto.dsa_package;
using ecdsa = go.crypto.ecdsa_package;
using elliptic = go.crypto.elliptic_package;
using rsa = go.crypto.rsa_package;
using _sha1_ = go.crypto.sha1_package;
using _sha256_ = go.crypto.sha256_package;
using _sha512_ = go.crypto.sha512_package;
using pkix = go.crypto.x509.pkix_package;
using asn1 = go.encoding.asn1_package;
using pem = go.encoding.pem_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using big = go.math.big_package;
using net = go.net_package;
using url = go.net.url_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;
using cryptobyte = go.golang_org.x.crypto.cryptobyte_package;
using cryptobyte_asn1 = go.golang_org.x.crypto.cryptobyte.asn1_package;
using go;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct distributionPoint
        {
            // Constructors
            public distributionPoint(NilType _)
            {
                this.DistributionPoint = default;
                this.Reason = default;
                this.CRLIssuer = default;
            }

            public distributionPoint(distributionPointName DistributionPoint = default, asn1.BitString Reason = default, asn1.RawValue CRLIssuer = default)
            {
                this.DistributionPoint = DistributionPoint;
                this.Reason = Reason;
                this.CRLIssuer = CRLIssuer;
            }

            // Enable comparisons between nil and distributionPoint struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(distributionPoint value, NilType nil) => value.Equals(default(distributionPoint));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(distributionPoint value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, distributionPoint value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, distributionPoint value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator distributionPoint(NilType nil) => default(distributionPoint);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static distributionPoint distributionPoint_cast(dynamic value)
        {
            return new distributionPoint(value.DistributionPoint, value.Reason, value.CRLIssuer);
        }
    }
}}