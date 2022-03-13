//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:35:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using crypto = go.crypto_package;
using ecdsa = go.crypto.ecdsa_package;
using ed25519 = go.crypto.ed25519_package;
using rsa = go.crypto.rsa_package;
using subtle = go.crypto.subtle_package;
using x509 = go.crypto.x509_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using hash = go.hash_package;
using io = go.io_package;
using net = go.net_package;
using strings = go.strings_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct clientHandshakeState
        {
            // Constructors
            public clientHandshakeState(NilType _)
            {
                this.c = default;
                this.ctx = default;
                this.serverHello = default;
                this.hello = default;
                this.suite = default;
                this.finishedHash = default;
                this.masterSecret = default;
                this.session = default;
            }

            public clientHandshakeState(ref ptr<Conn> c = default, context.Context ctx = default, ref ptr<serverHelloMsg> serverHello = default, ref ptr<clientHelloMsg> hello = default, ref ptr<cipherSuite> suite = default, finishedHash finishedHash = default, slice<byte> masterSecret = default, ref ptr<ClientSessionState> session = default)
            {
                this.c = c;
                this.ctx = ctx;
                this.serverHello = serverHello;
                this.hello = hello;
                this.suite = suite;
                this.finishedHash = finishedHash;
                this.masterSecret = masterSecret;
                this.session = session;
            }

            // Enable comparisons between nil and clientHandshakeState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(clientHandshakeState value, NilType nil) => value.Equals(default(clientHandshakeState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(clientHandshakeState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, clientHandshakeState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, clientHandshakeState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator clientHandshakeState(NilType nil) => default(clientHandshakeState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static clientHandshakeState clientHandshakeState_cast(dynamic value)
        {
            return new clientHandshakeState(ref value.c, value.ctx, ref value.serverHello, ref value.hello, ref value.suite, value.finishedHash, value.masterSecret, ref value.session);
        }
    }
}}