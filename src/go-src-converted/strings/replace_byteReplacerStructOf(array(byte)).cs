//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class strings_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byteReplacer
        {
            // Value of the byteReplacer struct
            private readonly array<byte> m_value;

            public byteReplacer(array<byte> value) => m_value = value;

            // Enable implicit conversions between array<byte> and byteReplacer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byteReplacer(array<byte> value) => new byteReplacer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<byte>(byteReplacer value) => value.m_value;
            
            // Enable comparisons between nil and byteReplacer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byteReplacer value, NilType nil) => value.Equals(default(byteReplacer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byteReplacer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byteReplacer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byteReplacer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byteReplacer(NilType nil) => default(byteReplacer);
        }
    }
}
