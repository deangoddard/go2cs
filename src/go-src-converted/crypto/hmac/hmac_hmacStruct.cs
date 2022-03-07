//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using subtle = go.crypto.subtle_package;
using hash = go.hash_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class hmac_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct hmac
        {
            // Constructors
            public hmac(NilType _)
            {
                this.opad = default;
                this.ipad = default;
                this.outer = default;
                this.inner = default;
                this.marshaled = default;
            }

            public hmac(slice<byte> opad = default, slice<byte> ipad = default, hash.Hash outer = default, hash.Hash inner = default, bool marshaled = default)
            {
                this.opad = opad;
                this.ipad = ipad;
                this.outer = outer;
                this.inner = inner;
                this.marshaled = marshaled;
            }

            // Enable comparisons between nil and hmac struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hmac value, NilType nil) => value.Equals(default(hmac));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hmac value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hmac value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hmac value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hmac(NilType nil) => default(hmac);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static hmac hmac_cast(dynamic value)
        {
            return new hmac(value.opad, value.ipad, value.outer, value.inner, value.marshaled);
        }
    }
}}