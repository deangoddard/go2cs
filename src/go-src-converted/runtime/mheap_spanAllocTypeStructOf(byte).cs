//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct spanAllocType
        {
            // Value of the spanAllocType struct
            private readonly byte m_value;
            
            public spanAllocType(byte value) => m_value = value;

            // Enable implicit conversions between byte and spanAllocType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator spanAllocType(byte value) => new spanAllocType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(spanAllocType value) => value.m_value;
            
            // Enable comparisons between nil and spanAllocType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(spanAllocType value, NilType nil) => value.Equals(default(spanAllocType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(spanAllocType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, spanAllocType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, spanAllocType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator spanAllocType(NilType nil) => default(spanAllocType);
        }
    }
}
