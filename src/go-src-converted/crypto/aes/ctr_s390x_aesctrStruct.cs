//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:53:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cipher = go.crypto.cipher_package;
using subtle = go.crypto.@internal.subtle_package;
using binary = go.encoding.binary_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class aes_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct aesctr
        {
            // Constructors
            public aesctr(NilType _)
            {
                this.block = default;
                this.ctr = default;
                this.buffer = default;
                this.storage = default;
            }

            public aesctr(ref ptr<aesCipherAsm> block = default, array<ulong> ctr = default, slice<byte> buffer = default, array<byte> storage = default)
            {
                this.block = block;
                this.ctr = ctr;
                this.buffer = buffer;
                this.storage = storage;
            }

            // Enable comparisons between nil and aesctr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(aesctr value, NilType nil) => value.Equals(default(aesctr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(aesctr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, aesctr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, aesctr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator aesctr(NilType nil) => default(aesctr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static aesctr aesctr_cast(dynamic value)
        {
            return new aesctr(ref value.block, value.ctr, value.buffer, value.storage);
        }
    }
}}