//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using crypto = go.crypto_package;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using des = go.crypto.des_package;
using hmac = go.crypto.hmac_package;
using rc4 = go.crypto.rc4_package;
using sha1 = go.crypto.sha1_package;
using sha256 = go.crypto.sha256_package;
using fmt = go.fmt_package;
using hash = go.hash_package;
using cpu = go.@internal.cpu_package;
using runtime = go.runtime_package;
using chacha20poly1305 = go.golang.org.x.crypto.chacha20poly1305_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct prefixNonceAEAD
        {
            // Constructors
            public prefixNonceAEAD(NilType _)
            {
                this.nonce = default;
                this.aead = default;
            }

            public prefixNonceAEAD(array<byte> nonce = default, cipher.AEAD aead = default)
            {
                this.nonce = nonce;
                this.aead = aead;
            }

            // Enable comparisons between nil and prefixNonceAEAD struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(prefixNonceAEAD value, NilType nil) => value.Equals(default(prefixNonceAEAD));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(prefixNonceAEAD value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, prefixNonceAEAD value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, prefixNonceAEAD value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator prefixNonceAEAD(NilType nil) => default(prefixNonceAEAD);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static prefixNonceAEAD prefixNonceAEAD_cast(dynamic value)
        {
            return new prefixNonceAEAD(value.nonce, value.aead);
        }
    }
}}