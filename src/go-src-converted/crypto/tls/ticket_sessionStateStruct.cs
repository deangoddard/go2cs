//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:36:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using hmac = go.crypto.hmac_package;
using sha256 = go.crypto.sha256_package;
using subtle = go.crypto.subtle_package;
using errors = go.errors_package;
using io = go.io_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct sessionState
        {
            // Constructors
            public sessionState(NilType _)
            {
                this.vers = default;
                this.cipherSuite = default;
                this.createdAt = default;
                this.masterSecret = default;
                this.certificates = default;
                this.usedOldKey = default;
            }

            public sessionState(ushort vers = default, ushort cipherSuite = default, ulong createdAt = default, slice<byte> masterSecret = default, slice<slice<byte>> certificates = default, bool usedOldKey = default)
            {
                this.vers = vers;
                this.cipherSuite = cipherSuite;
                this.createdAt = createdAt;
                this.masterSecret = masterSecret;
                this.certificates = certificates;
                this.usedOldKey = usedOldKey;
            }

            // Enable comparisons between nil and sessionState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sessionState value, NilType nil) => value.Equals(default(sessionState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sessionState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sessionState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sessionState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sessionState(NilType nil) => default(sessionState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static sessionState sessionState_cast(dynamic value)
        {
            return new sessionState(value.vers, value.cipherSuite, value.createdAt, value.masterSecret, value.certificates, value.usedOldKey);
        }
    }
}}