//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:17:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class test2json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct textBytes : ISlice
        {
            // Value of the textBytes struct
            private readonly slice<byte> m_value;
            
            public Array Array => ((ISlice)m_value).Array;

            public nint Low => ((ISlice)m_value).Low;

            public nint High => ((ISlice)m_value).High;

            public nint Capacity => ((ISlice)m_value).Capacity;

            public nint Available => ((ISlice)m_value).Available;

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
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public textBytes(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and textBytes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator textBytes(slice<byte> value) => new textBytes(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(textBytes value) => value.m_value;
            
            // Enable comparisons between nil and textBytes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(textBytes value, NilType nil) => value.Equals(default(textBytes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(textBytes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, textBytes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, textBytes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator textBytes(NilType nil) => default(textBytes);
        }
    }
}}}
