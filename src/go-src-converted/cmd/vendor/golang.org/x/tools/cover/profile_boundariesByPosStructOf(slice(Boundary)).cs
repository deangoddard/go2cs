//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:34 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace tools
{
    public static partial class cover_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct boundariesByPos : ISlice
        {
            // Value of the boundariesByPos struct
            private readonly slice<Boundary> m_value;
            
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
            
            public ref Boundary this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public boundariesByPos(slice<Boundary> value) => m_value = value;

            // Enable implicit conversions between slice<Boundary> and boundariesByPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator boundariesByPos(slice<Boundary> value) => new boundariesByPos(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<Boundary>(boundariesByPos value) => value.m_value;
            
            // Enable comparisons between nil and boundariesByPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(boundariesByPos value, NilType nil) => value.Equals(default(boundariesByPos));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(boundariesByPos value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, boundariesByPos value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, boundariesByPos value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator boundariesByPos(NilType nil) => default(boundariesByPos);
        }
    }
}}}}}}
