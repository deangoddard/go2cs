//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class flag_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct int64Value
        {
            // Value of the int64Value struct
            private readonly long m_value;
            
            public int64Value(long value) => m_value = value;

            // Enable implicit conversions between long and int64Value struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int64Value(long value) => new int64Value(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(int64Value value) => value.m_value;
            
            // Enable comparisons between nil and int64Value struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(int64Value value, NilType nil) => value.Equals(default(int64Value));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(int64Value value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, int64Value value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, int64Value value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int64Value(NilType nil) => default(int64Value);
        }
    }
}
