//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class tlog_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RecordProof : ISlice
        {
            // Value of the RecordProof struct
            private readonly slice<Hash> m_value;
            
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
            
            public ref Hash this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public RecordProof(slice<Hash> value) => m_value = value;

            // Enable implicit conversions between slice<Hash> and RecordProof struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecordProof(slice<Hash> value) => new RecordProof(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<Hash>(RecordProof value) => value.m_value;
            
            // Enable comparisons between nil and RecordProof struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RecordProof value, NilType nil) => value.Equals(default(RecordProof));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RecordProof value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RecordProof value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RecordProof value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecordProof(NilType nil) => default(RecordProof);
        }
    }
}}}}}
