//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:28:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct d
        {
            // Value of the d struct
            private readonly nint m_value;
            
            public d(nint value) => m_value = value;

            // Enable implicit conversions between nint and d struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator d(nint value) => new d(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(d value) => value.m_value;
            
            // Enable comparisons between nil and d struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(d value, NilType nil) => value.Equals(default(d));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(d value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, d value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, d value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator d(NilType nil) => default(d);
        }
    }
}
