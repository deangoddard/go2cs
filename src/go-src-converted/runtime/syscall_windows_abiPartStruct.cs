//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:12:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.@internal.abi_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct abiPart
        {
            // Constructors
            public abiPart(NilType _)
            {
                this.kind = default;
                this.srcStackOffset = default;
                this.dstStackOffset = default;
                this.dstRegister = default;
                this.len = default;
            }

            public abiPart(abiPartKind kind = default, System.UIntPtr srcStackOffset = default, System.UIntPtr dstStackOffset = default, nint dstRegister = default, System.UIntPtr len = default)
            {
                this.kind = kind;
                this.srcStackOffset = srcStackOffset;
                this.dstStackOffset = dstStackOffset;
                this.dstRegister = dstRegister;
                this.len = len;
            }

            // Enable comparisons between nil and abiPart struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(abiPart value, NilType nil) => value.Equals(default(abiPart));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(abiPart value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, abiPart value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, abiPart value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator abiPart(NilType nil) => default(abiPart);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static abiPart abiPart_cast(dynamic value)
        {
            return new abiPart(value.kind, value.srcStackOffset, value.dstStackOffset, value.dstRegister, value.len);
        }
    }
}