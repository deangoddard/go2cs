//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:41:03 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Weekday
        {
            // Value of the Weekday struct
            private readonly nint m_value;
            
            public Weekday(nint value) => m_value = value;

            // Enable implicit conversions between nint and Weekday struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Weekday(nint value) => new Weekday(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(Weekday value) => value.m_value;
            
            // Enable comparisons between nil and Weekday struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Weekday value, NilType nil) => value.Equals(default(Weekday));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Weekday value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Weekday value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Weekday value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Weekday(NilType nil) => default(Weekday);
        }
    }
}
