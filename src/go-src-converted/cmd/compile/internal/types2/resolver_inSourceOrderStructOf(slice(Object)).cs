//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:12:49 UTC
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
namespace compile {
namespace @internal
{
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct inSourceOrder : ISlice
        {
            // Value of the inSourceOrder struct
            private readonly slice<Object> m_value;
            
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
            
            public ref Object this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public inSourceOrder(slice<Object> value) => m_value = value;

            // Enable implicit conversions between slice<Object> and inSourceOrder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator inSourceOrder(slice<Object> value) => new inSourceOrder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<Object>(inSourceOrder value) => value.m_value;
            
            // Enable comparisons between nil and inSourceOrder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(inSourceOrder value, NilType nil) => value.Equals(default(inSourceOrder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(inSourceOrder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, inSourceOrder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, inSourceOrder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator inSourceOrder(NilType nil) => default(inSourceOrder);
        }
    }
}}}}
