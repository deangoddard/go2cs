//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:09:49 UTC
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
        private partial struct sweepClass
        {
            // Value of the sweepClass struct
            private readonly uint m_value;
            
            public sweepClass(uint value) => m_value = value;

            // Enable implicit conversions between uint and sweepClass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sweepClass(uint value) => new sweepClass(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(sweepClass value) => value.m_value;
            
            // Enable comparisons between nil and sweepClass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sweepClass value, NilType nil) => value.Equals(default(sweepClass));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sweepClass value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sweepClass value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sweepClass value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sweepClass(NilType nil) => default(sweepClass);
        }
    }
}
