//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class hex_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InvalidByteError
        {
            // Value of the InvalidByteError struct
            private readonly byte m_value;
            
            public InvalidByteError(byte value) => m_value = value;

            // Enable implicit conversions between byte and InvalidByteError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidByteError(byte value) => new InvalidByteError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(InvalidByteError value) => value.m_value;
            
            // Enable comparisons between nil and InvalidByteError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InvalidByteError value, NilType nil) => value.Equals(default(InvalidByteError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InvalidByteError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InvalidByteError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InvalidByteError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidByteError(NilType nil) => default(InvalidByteError);
        }
    }
}}
