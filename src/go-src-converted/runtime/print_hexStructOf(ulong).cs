//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:47:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct hex
        {
            // Value of the hex struct
            private readonly ulong m_value;

            public hex(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and hex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hex(ulong value) => new hex(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(hex value) => value.m_value;
            
            // Enable comparisons between nil and hex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hex value, NilType nil) => value.Equals(default(hex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hex(NilType nil) => default(hex);
        }
    }
}
