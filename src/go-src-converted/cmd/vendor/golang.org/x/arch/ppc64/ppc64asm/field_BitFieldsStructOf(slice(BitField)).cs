//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:38:18 UTC
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
namespace arch {
namespace ppc64
{
    public static partial class ppc64asm_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct BitFields : ISlice
        {
            // Value of the BitFields struct
            private readonly slice<BitField> m_value;
            
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
            
            public ref BitField this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public BitFields(slice<BitField> value) => m_value = value;

            // Enable implicit conversions between slice<BitField> and BitFields struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BitFields(slice<BitField> value) => new BitFields(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<BitField>(BitFields value) => value.m_value;
            
            // Enable comparisons between nil and BitFields struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BitFields value, NilType nil) => value.Equals(default(BitFields));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BitFields value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BitFields value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BitFields value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BitFields(NilType nil) => default(BitFields);
        }
    }
}}}}}}}
