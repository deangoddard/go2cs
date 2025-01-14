//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:32:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using crypto = go.crypto_package;
using errors = go.errors_package;
using hash = go.hash_package;
using io = go.io_package;
using big = go.math.big_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class rsa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct PSSOptions
        {
            // Constructors
            public PSSOptions(NilType _)
            {
                this.SaltLength = default;
                this.Hash = default;
            }

            public PSSOptions(nint SaltLength = default, crypto.Hash Hash = default)
            {
                this.SaltLength = SaltLength;
                this.Hash = Hash;
            }

            // Enable comparisons between nil and PSSOptions struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PSSOptions value, NilType nil) => value.Equals(default(PSSOptions));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PSSOptions value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PSSOptions value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PSSOptions value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PSSOptions(NilType nil) => default(PSSOptions);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static PSSOptions PSSOptions_cast(dynamic value)
        {
            return new PSSOptions(value.SaltLength, value.Hash);
        }
    }
}}