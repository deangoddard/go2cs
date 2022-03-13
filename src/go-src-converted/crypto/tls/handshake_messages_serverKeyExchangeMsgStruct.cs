//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:35:55 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct serverKeyExchangeMsg
        {
            // Constructors
            public serverKeyExchangeMsg(NilType _)
            {
                this.raw = default;
                this.key = default;
            }

            public serverKeyExchangeMsg(slice<byte> raw = default, slice<byte> key = default)
            {
                this.raw = raw;
                this.key = key;
            }

            // Enable comparisons between nil and serverKeyExchangeMsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(serverKeyExchangeMsg value, NilType nil) => value.Equals(default(serverKeyExchangeMsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(serverKeyExchangeMsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, serverKeyExchangeMsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, serverKeyExchangeMsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator serverKeyExchangeMsg(NilType nil) => default(serverKeyExchangeMsg);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static serverKeyExchangeMsg serverKeyExchangeMsg_cast(dynamic value)
        {
            return new serverKeyExchangeMsg(value.raw, value.key);
        }
    }
}}