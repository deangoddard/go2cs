//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:55:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rsaKeyAgreement
        {
            // Constructors
            public rsaKeyAgreement(NilType _)
            {
            }
            // Enable comparisons between nil and rsaKeyAgreement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rsaKeyAgreement value, NilType nil) => value.Equals(default(rsaKeyAgreement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rsaKeyAgreement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rsaKeyAgreement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rsaKeyAgreement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rsaKeyAgreement(NilType nil) => default(rsaKeyAgreement);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rsaKeyAgreement rsaKeyAgreement_cast(dynamic value)
        {
            return new rsaKeyAgreement();
        }
    }
}}