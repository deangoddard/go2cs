//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:55:08 UTC
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
using ed25519 = go.crypto.ed25519_package;
using elliptic = go.crypto.elliptic_package;
using rsa = go.crypto.rsa_package;
using sha1 = go.crypto.sha1_package;
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
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using cryptobyte_asn1 = go.golang.org.x.crypto.cryptobyte.asn1_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct authorityInfoAccess
        {
            // Constructors
            public authorityInfoAccess(NilType _)
            {
                this.Method = default;
                this.Location = default;
            }

            public authorityInfoAccess(asn1.ObjectIdentifier Method = default, asn1.RawValue Location = default)
            {
                this.Method = Method;
                this.Location = Location;
            }

            // Enable comparisons between nil and authorityInfoAccess struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(authorityInfoAccess value, NilType nil) => value.Equals(default(authorityInfoAccess));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(authorityInfoAccess value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, authorityInfoAccess value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, authorityInfoAccess value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator authorityInfoAccess(NilType nil) => default(authorityInfoAccess);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static authorityInfoAccess authorityInfoAccess_cast(dynamic value)
        {
            return new authorityInfoAccess(value.Method, value.Location);
        }
    }
}}