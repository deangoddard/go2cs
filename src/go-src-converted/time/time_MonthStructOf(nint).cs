//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:30:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class time_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Month
        {
            // Value of the Month struct
            private readonly nint m_value;
            
            public Month(nint value) => m_value = value;

            // Enable implicit conversions between nint and Month struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Month(nint value) => new Month(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(Month value) => value.m_value;
            
            // Enable comparisons between nil and Month struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Month value, NilType nil) => value.Equals(default(Month));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Month value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Month value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Month value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Month(NilType nil) => default(Month);
        }
    }
}
