//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:56 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct stringerarray : IArray
        {
            // Value of the stringerarray struct
            private readonly array<double> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref double this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public stringerarray(array<double> value) => m_value = value;

            // Enable implicit conversions between array<double> and stringerarray struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringerarray(array<double> value) => new stringerarray(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<double>(stringerarray value) => value.m_value;
            
            // Enable comparisons between nil and stringerarray struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringerarray value, NilType nil) => value.Equals(default(stringerarray));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringerarray value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringerarray value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringerarray value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringerarray(NilType nil) => default(stringerarray);
        }
    }
}}}}
