//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:43 UTC
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
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct StackOffset
        {
            // Value of the StackOffset struct
            private readonly int m_value;
            
            public StackOffset(int value) => m_value = value;

            // Enable implicit conversions between int and StackOffset struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StackOffset(int value) => new StackOffset(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(StackOffset value) => value.m_value;
            
            // Enable comparisons between nil and StackOffset struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StackOffset value, NilType nil) => value.Equals(default(StackOffset));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StackOffset value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StackOffset value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StackOffset value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StackOffset(NilType nil) => default(StackOffset);
        }
    }
}}}}
