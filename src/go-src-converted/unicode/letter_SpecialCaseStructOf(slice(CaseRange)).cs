//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class unicode_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct SpecialCase : ISlice
        {
            // Value of the SpecialCase struct
            private readonly slice<CaseRange> m_value;
            
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
            
            public ref CaseRange this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public SpecialCase(slice<CaseRange> value) => m_value = value;

            // Enable implicit conversions between slice<CaseRange> and SpecialCase struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SpecialCase(slice<CaseRange> value) => new SpecialCase(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<CaseRange>(SpecialCase value) => value.m_value;
            
            // Enable comparisons between nil and SpecialCase struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SpecialCase value, NilType nil) => value.Equals(default(SpecialCase));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SpecialCase value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SpecialCase value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SpecialCase value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SpecialCase(NilType nil) => default(SpecialCase);
        }
    }
}
