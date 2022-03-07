//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:20:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct certificateVerifyMsg
        {
            // Constructors
            public certificateVerifyMsg(NilType _)
            {
                this.raw = default;
                this.hasSignatureAlgorithm = default;
                this.signatureAlgorithm = default;
                this.signature = default;
            }

            public certificateVerifyMsg(slice<byte> raw = default, bool hasSignatureAlgorithm = default, SignatureScheme signatureAlgorithm = default, slice<byte> signature = default)
            {
                this.raw = raw;
                this.hasSignatureAlgorithm = hasSignatureAlgorithm;
                this.signatureAlgorithm = signatureAlgorithm;
                this.signature = signature;
            }

            // Enable comparisons between nil and certificateVerifyMsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(certificateVerifyMsg value, NilType nil) => value.Equals(default(certificateVerifyMsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(certificateVerifyMsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, certificateVerifyMsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, certificateVerifyMsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator certificateVerifyMsg(NilType nil) => default(certificateVerifyMsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static certificateVerifyMsg certificateVerifyMsg_cast(dynamic value)
        {
            return new certificateVerifyMsg(value.raw, value.hasSignatureAlgorithm, value.signatureAlgorithm, value.signature);
        }
    }
}}