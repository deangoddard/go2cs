//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:55:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        private partial struct newSessionTicketMsgTLS13
        {
            // Constructors
            public newSessionTicketMsgTLS13(NilType _)
            {
                this.raw = default;
                this.lifetime = default;
                this.ageAdd = default;
                this.nonce = default;
                this.label = default;
                this.maxEarlyData = default;
            }

            public newSessionTicketMsgTLS13(slice<byte> raw = default, uint lifetime = default, uint ageAdd = default, slice<byte> nonce = default, slice<byte> label = default, uint maxEarlyData = default)
            {
                this.raw = raw;
                this.lifetime = lifetime;
                this.ageAdd = ageAdd;
                this.nonce = nonce;
                this.label = label;
                this.maxEarlyData = maxEarlyData;
            }

            // Enable comparisons between nil and newSessionTicketMsgTLS13 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(newSessionTicketMsgTLS13 value, NilType nil) => value.Equals(default(newSessionTicketMsgTLS13));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(newSessionTicketMsgTLS13 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, newSessionTicketMsgTLS13 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, newSessionTicketMsgTLS13 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator newSessionTicketMsgTLS13(NilType nil) => default(newSessionTicketMsgTLS13);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static newSessionTicketMsgTLS13 newSessionTicketMsgTLS13_cast(dynamic value)
        {
            return new newSessionTicketMsgTLS13(value.raw, value.lifetime, value.ageAdd, value.nonce, value.label, value.maxEarlyData);
        }
    }
}}