//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct int8
        {
            // Value of the int8 struct
            private readonly sbyte m_value;

            public int8(sbyte value) => m_value = value;

            // Enable implicit conversions between sbyte and int8 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int8(sbyte value) => new int8(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sbyte(int8 value) => value.m_value;
            
            // Enable comparisons between nil and int8 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(int8 value, NilType nil) => value.Equals(default(int8));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(int8 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, int8 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, int8 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int8(NilType nil) => default(int8);
        }
    }
}
