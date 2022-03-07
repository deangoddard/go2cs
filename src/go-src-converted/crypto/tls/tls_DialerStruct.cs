//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:21:08 UTC
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
using x509 = go.crypto.x509_package;
using pem = go.encoding.pem_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using net = go.net_package;
using os = go.os_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Dialer
        {
            // Constructors
            public Dialer(NilType _)
            {
                this.NetDialer = default;
                this.Config = default;
            }

            public Dialer(ref ptr<net.Dialer> NetDialer = default, ref ptr<Config> Config = default)
            {
                this.NetDialer = NetDialer;
                this.Config = Config;
            }

            // Enable comparisons between nil and Dialer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dialer value, NilType nil) => value.Equals(default(Dialer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dialer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dialer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dialer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dialer(NilType nil) => default(Dialer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Dialer Dialer_cast(dynamic value)
        {
            return new Dialer(ref value.NetDialer, ref value.Config);
        }
    }
}}