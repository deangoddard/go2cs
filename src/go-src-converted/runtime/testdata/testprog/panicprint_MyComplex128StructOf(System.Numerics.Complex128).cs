//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:26:05 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MyComplex128
        {
            // Value of the MyComplex128 struct
            private readonly System.Numerics.Complex128 m_value;
            
            public MyComplex128(System.Numerics.Complex128 value) => m_value = value;

            // Enable implicit conversions between System.Numerics.Complex128 and MyComplex128 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyComplex128(System.Numerics.Complex128 value) => new MyComplex128(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.Numerics.Complex128(MyComplex128 value) => value.m_value;
            
            // Enable comparisons between nil and MyComplex128 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyComplex128 value, NilType nil) => value.Equals(default(MyComplex128));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyComplex128 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyComplex128 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyComplex128 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyComplex128(NilType nil) => default(MyComplex128);
        }
    }
}
