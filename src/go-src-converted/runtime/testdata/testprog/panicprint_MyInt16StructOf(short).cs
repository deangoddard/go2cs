//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:29:25 UTC
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
        public partial struct MyInt16
        {
            // Value of the MyInt16 struct
            private readonly short m_value;
            
            public MyInt16(short value) => m_value = value;

            // Enable implicit conversions between short and MyInt16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyInt16(short value) => new MyInt16(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator short(MyInt16 value) => value.m_value;
            
            // Enable comparisons between nil and MyInt16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyInt16 value, NilType nil) => value.Equals(default(MyInt16));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyInt16 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyInt16 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyInt16 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyInt16(NilType nil) => default(MyInt16);
        }
    }
}
