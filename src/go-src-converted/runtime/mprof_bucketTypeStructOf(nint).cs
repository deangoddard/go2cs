//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:10:06 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bucketType
        {
            // Value of the bucketType struct
            private readonly nint m_value;
            
            public bucketType(nint value) => m_value = value;

            // Enable implicit conversions between nint and bucketType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bucketType(nint value) => new bucketType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(bucketType value) => value.m_value;
            
            // Enable comparisons between nil and bucketType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bucketType value, NilType nil) => value.Equals(default(bucketType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bucketType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bucketType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bucketType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bucketType(NilType nil) => default(bucketType);
        }
    }
}
