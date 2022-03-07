//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:36:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto
{
    public static partial class cryptobyte_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct String : ISlice
        {
            // Value of the String struct
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

            public String(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and String struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator String(slice<byte> value) => new String(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(String value) => value.m_value;
            
            // Enable comparisons between nil and String struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(String value, NilType nil) => value.Equals(default(String));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(String value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, String value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, String value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator String(NilType nil) => default(String);
        }
    }
}}}}}
