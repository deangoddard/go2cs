//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:14:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace hash
{
    public static partial class crc32_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Table : IArray
        {
            // Value of the Table struct
            private readonly array<uint> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref uint this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public Table(array<uint> value) => m_value = value;

            // Enable implicit conversions between array<uint> and Table struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Table(array<uint> value) => new Table(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<uint>(Table value) => value.m_value;
            
            // Enable comparisons between nil and Table struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Table value, NilType nil) => value.Equals(default(Table));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Table value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Table value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Table value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Table(NilType nil) => default(Table);
        }
    }
}}
