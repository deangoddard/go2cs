//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:42:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct operandMode
        {
            // Value of the operandMode struct
            private readonly byte m_value;
            
            public operandMode(byte value) => m_value = value;

            // Enable implicit conversions between byte and operandMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator operandMode(byte value) => new operandMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(operandMode value) => value.m_value;
            
            // Enable comparisons between nil and operandMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(operandMode value, NilType nil) => value.Equals(default(operandMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(operandMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, operandMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, operandMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator operandMode(NilType nil) => default(operandMode);
        }
    }
}}
