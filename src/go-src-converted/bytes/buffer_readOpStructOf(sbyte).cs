//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:14:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class bytes_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct readOp
        {
            // Value of the readOp struct
            private readonly sbyte m_value;
            
            public readOp(sbyte value) => m_value = value;

            // Enable implicit conversions between sbyte and readOp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readOp(sbyte value) => new readOp(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sbyte(readOp value) => value.m_value;
            
            // Enable comparisons between nil and readOp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(readOp value, NilType nil) => value.Equals(default(readOp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(readOp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, readOp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, readOp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readOp(NilType nil) => default(readOp);
        }
    }
}
