//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:22:26 UTC
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
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byTypeStr : ISlice
        {
            // Value of the byTypeStr struct
            private readonly slice<typelinkSortKey> m_value;
            
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
            
            public ref typelinkSortKey this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public byTypeStr(slice<typelinkSortKey> value) => m_value = value;

            // Enable implicit conversions between slice<typelinkSortKey> and byTypeStr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byTypeStr(slice<typelinkSortKey> value) => new byTypeStr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<typelinkSortKey>(byTypeStr value) => value.m_value;
            
            // Enable comparisons between nil and byTypeStr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byTypeStr value, NilType nil) => value.Equals(default(byTypeStr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byTypeStr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byTypeStr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byTypeStr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byTypeStr(NilType nil) => default(byTypeStr);
        }
    }
}}}}
