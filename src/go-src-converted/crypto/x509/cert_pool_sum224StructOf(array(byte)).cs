//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sum224 : IArray
        {
            // Value of the sum224 struct
            private readonly array<byte> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref byte this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public sum224(array<byte> value) => m_value = value;

            // Enable implicit conversions between array<byte> and sum224 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sum224(array<byte> value) => new sum224(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<byte>(sum224 value) => value.m_value;
            
            // Enable comparisons between nil and sum224 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sum224 value, NilType nil) => value.Equals(default(sum224));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sum224 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sum224 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sum224 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sum224(NilType nil) => default(sum224);
        }
    }
}}
