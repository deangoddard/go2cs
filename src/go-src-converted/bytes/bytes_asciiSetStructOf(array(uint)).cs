//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class bytes_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct asciiSet : IArray
        {
            // Value of the asciiSet struct
            private readonly array<uint> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref uint this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

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
