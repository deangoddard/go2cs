//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct intarr : IArray
        {
            // Value of the intarr struct
            private readonly array<nint> m_value;
            
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

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public intarr(array<nint> value) => m_value = value;

            // Enable implicit conversions between array<nint> and intarr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator intarr(array<nint> value) => new intarr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<nint>(intarr value) => value.m_value;
            
            // Enable comparisons between nil and intarr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(intarr value, NilType nil) => value.Equals(default(intarr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(intarr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, intarr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, intarr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator intarr(NilType nil) => default(intarr);
        }
    }
}