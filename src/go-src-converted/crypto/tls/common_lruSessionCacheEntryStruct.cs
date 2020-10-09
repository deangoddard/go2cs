//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:55:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using list = go.container.list_package;
using crypto = go.crypto_package;
using ecdsa = go.crypto.ecdsa_package;
using ed25519 = go.crypto.ed25519_package;
using elliptic = go.crypto.elliptic_package;
using rand = go.crypto.rand_package;
using rsa = go.crypto.rsa_package;
using sha512 = go.crypto.sha512_package;
using x509 = go.crypto.x509_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using cpu = go.@internal.cpu_package;
using io = go.io_package;
using net = go.net_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lruSessionCacheEntry
        {
            // Constructors
            public lruSessionCacheEntry(NilType _)
            {
                this.sessionKey = default;
                this.state = default;
            }

            public lruSessionCacheEntry(@string sessionKey = default, ref ptr<ClientSessionState> state = default)
            {
                this.sessionKey = sessionKey;
                this.state = state;
            }

            // Enable comparisons between nil and lruSessionCacheEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lruSessionCacheEntry value, NilType nil) => value.Equals(default(lruSessionCacheEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lruSessionCacheEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lruSessionCacheEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lruSessionCacheEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lruSessionCacheEntry(NilType nil) => default(lruSessionCacheEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lruSessionCacheEntry lruSessionCacheEntry_cast(dynamic value)
        {
            return new lruSessionCacheEntry(value.sessionKey, ref value.state);
        }
    }
}}