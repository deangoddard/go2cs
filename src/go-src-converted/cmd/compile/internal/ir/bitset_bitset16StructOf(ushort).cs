//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:58:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ir_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct bitset16
        {
            // Value of the bitset16 struct
            private readonly ushort m_value;
            
            public bitset16(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and bitset16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitset16(ushort value) => new bitset16(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(bitset16 value) => value.m_value;
            
            // Enable comparisons between nil and bitset16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bitset16 value, NilType nil) => value.Equals(default(bitset16));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bitset16 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bitset16 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bitset16 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitset16(NilType nil) => default(bitset16);
        }
    }
}}}}
