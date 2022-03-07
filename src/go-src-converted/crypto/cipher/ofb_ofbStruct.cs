//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:18:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using subtle = go.crypto.@internal.subtle_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ofb
        {
            // Constructors
            public ofb(NilType _)
            {
                this.b = default;
                this.cipher = default;
                this.@out = default;
                this.outUsed = default;
            }

            public ofb(Block b = default, slice<byte> cipher = default, slice<byte> @out = default, nint outUsed = default)
            {
                this.b = b;
                this.cipher = cipher;
                this.@out = @out;
                this.outUsed = outUsed;
            }

            // Enable comparisons between nil and ofb struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ofb value, NilType nil) => value.Equals(default(ofb));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ofb value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ofb value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ofb value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ofb(NilType nil) => default(ofb);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ofb ofb_cast(dynamic value)
        {
            return new ofb(value.b, value.cipher, value.@out, value.outUsed);
        }
    }
}}