//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:21 UTC
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
namespace vet {
namespace testdata
{
    public static partial class print_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RecursiveSlice : ISlice
        {
            // Value of the RecursiveSlice struct
            private readonly slice<RecursiveSlice> m_value;
            
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
            
            public ref RecursiveSlice this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public RecursiveSlice(slice<RecursiveSlice> value) => m_value = value;

            // Enable implicit conversions between slice<RecursiveSlice> and RecursiveSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecursiveSlice(slice<RecursiveSlice> value) => new RecursiveSlice(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<RecursiveSlice>(RecursiveSlice value) => value.m_value;
            
            // Enable comparisons between nil and RecursiveSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RecursiveSlice value, NilType nil) => value.Equals(default(RecursiveSlice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RecursiveSlice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RecursiveSlice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RecursiveSlice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecursiveSlice(NilType nil) => default(RecursiveSlice);
        }
    }
}}}}
