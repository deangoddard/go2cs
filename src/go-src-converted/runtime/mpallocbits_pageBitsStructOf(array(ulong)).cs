//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:10:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pageBits : IArray
        {
            // Value of the pageBits struct
            private readonly array<ulong> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref ulong this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public pageBits(array<ulong> value) => m_value = value;

            // Enable implicit conversions between array<ulong> and pageBits struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pageBits(array<ulong> value) => new pageBits(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<ulong>(pageBits value) => value.m_value;
            
            // Enable comparisons between nil and pageBits struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pageBits value, NilType nil) => value.Equals(default(pageBits));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pageBits value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pageBits value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pageBits value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pageBits(NilType nil) => default(pageBits);
        }
    }
}
