//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class bytes_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct asciiSet
        {
            // Value of the asciiSet struct
            private readonly array<uint> m_value;

            public asciiSet(array<uint> value) => m_value = value;

            // Enable implicit conversions between array<uint> and asciiSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator asciiSet(array<uint> value) => new asciiSet(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<uint>(asciiSet value) => value.m_value;
            
            // Enable comparisons between nil and asciiSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(asciiSet value, NilType nil) => value.Equals(default(asciiSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(asciiSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, asciiSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, asciiSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator asciiSet(NilType nil) => default(asciiSet);
        }
    }
}
