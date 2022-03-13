//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class asn1_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct ObjectIdentifier : ISlice
        {
            // Value of the ObjectIdentifier struct
            private readonly slice<nint> m_value;
            
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
            
            public ref nint this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public ObjectIdentifier(slice<nint> value) => m_value = value;

            // Enable implicit conversions between slice<nint> and ObjectIdentifier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ObjectIdentifier(slice<nint> value) => new ObjectIdentifier(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<nint>(ObjectIdentifier value) => value.m_value;
            
            // Enable comparisons between nil and ObjectIdentifier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ObjectIdentifier value, NilType nil) => value.Equals(default(ObjectIdentifier));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ObjectIdentifier value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ObjectIdentifier value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ObjectIdentifier value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ObjectIdentifier(NilType nil) => default(ObjectIdentifier);
        }
    }
}}
