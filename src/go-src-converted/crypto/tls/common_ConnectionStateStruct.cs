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
        public partial struct ConnectionState
        {
            // Constructors
            public ConnectionState(NilType _)
            {
                this.Version = default;
                this.HandshakeComplete = default;
                this.DidResume = default;
                this.CipherSuite = default;
                this.NegotiatedProtocol = default;
                this.NegotiatedProtocolIsMutual = default;
                this.ServerName = default;
                this.PeerCertificates = default;
                this.VerifiedChains = default;
                this.SignedCertificateTimestamps = default;
                this.OCSPResponse = default;
                this.TLSUnique = default;
                this.ekm = default;
            }

            public ConnectionState(ushort Version = default, bool HandshakeComplete = default, bool DidResume = default, ushort CipherSuite = default, @string NegotiatedProtocol = default, bool NegotiatedProtocolIsMutual = default, @string ServerName = default, slice<ptr<x509.Certificate>> PeerCertificates = default, slice<slice<ptr<x509.Certificate>>> VerifiedChains = default, slice<slice<byte>> SignedCertificateTimestamps = default, slice<byte> OCSPResponse = default, slice<byte> TLSUnique = default, Func<@string, slice<byte>, long, (slice<byte>, error)> ekm = default)
            {
                this.Version = Version;
                this.HandshakeComplete = HandshakeComplete;
                this.DidResume = DidResume;
                this.CipherSuite = CipherSuite;
                this.NegotiatedProtocol = NegotiatedProtocol;
                this.NegotiatedProtocolIsMutual = NegotiatedProtocolIsMutual;
                this.ServerName = ServerName;
                this.PeerCertificates = PeerCertificates;
                this.VerifiedChains = VerifiedChains;
                this.SignedCertificateTimestamps = SignedCertificateTimestamps;
                this.OCSPResponse = OCSPResponse;
                this.TLSUnique = TLSUnique;
                this.ekm = ekm;
            }

            // Enable comparisons between nil and ConnectionState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ConnectionState value, NilType nil) => value.Equals(default(ConnectionState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ConnectionState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ConnectionState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ConnectionState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ConnectionState(NilType nil) => default(ConnectionState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ConnectionState ConnectionState_cast(dynamic value)
        {
            return new ConnectionState(value.Version, value.HandshakeComplete, value.DidResume, value.CipherSuite, value.NegotiatedProtocol, value.NegotiatedProtocolIsMutual, value.ServerName, value.PeerCertificates, value.VerifiedChains, value.SignedCertificateTimestamps, value.OCSPResponse, value.TLSUnique, value.ekm);
        }
    }
}}