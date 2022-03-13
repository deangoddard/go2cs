//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using list = go.container.list_package;
using context = go.context_package;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct ClientSessionState
        {
            // Constructors
            public ClientSessionState(NilType _)
            {
                this.sessionTicket = default;
                this.vers = default;
                this.cipherSuite = default;
                this.masterSecret = default;
                this.serverCertificates = default;
                this.verifiedChains = default;
                this.receivedAt = default;
                this.ocspResponse = default;
                this.scts = default;
                this.nonce = default;
                this.useBy = default;
                this.ageAdd = default;
            }

            public ClientSessionState(slice<byte> sessionTicket = default, ushort vers = default, ushort cipherSuite = default, slice<byte> masterSecret = default, slice<ptr<x509.Certificate>> serverCertificates = default, slice<slice<ptr<x509.Certificate>>> verifiedChains = default, time.Time receivedAt = default, slice<byte> ocspResponse = default, slice<slice<byte>> scts = default, slice<byte> nonce = default, time.Time useBy = default, uint ageAdd = default)
            {
                this.sessionTicket = sessionTicket;
                this.vers = vers;
                this.cipherSuite = cipherSuite;
                this.masterSecret = masterSecret;
                this.serverCertificates = serverCertificates;
                this.verifiedChains = verifiedChains;
                this.receivedAt = receivedAt;
                this.ocspResponse = ocspResponse;
                this.scts = scts;
                this.nonce = nonce;
                this.useBy = useBy;
                this.ageAdd = ageAdd;
            }

            // Enable comparisons between nil and ClientSessionState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ClientSessionState value, NilType nil) => value.Equals(default(ClientSessionState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ClientSessionState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ClientSessionState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ClientSessionState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ClientSessionState(NilType nil) => default(ClientSessionState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static ClientSessionState ClientSessionState_cast(dynamic value)
        {
            return new ClientSessionState(value.sessionTicket, value.vers, value.cipherSuite, value.masterSecret, value.serverCertificates, value.verifiedChains, value.receivedAt, value.ocspResponse, value.scts, value.nonce, value.useBy, value.ageAdd);
        }
    }
}}