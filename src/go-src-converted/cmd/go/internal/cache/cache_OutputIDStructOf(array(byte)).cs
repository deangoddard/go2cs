//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:30:04 UTC
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
namespace go {
namespace @internal
{
    public static partial class cache_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct OutputID : IArray
        {
            // Value of the OutputID struct
            private readonly array<byte> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref byte this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public OutputID(array<byte> value) => m_value = value;

            // Enable implicit conversions between array<byte> and OutputID struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator OutputID(array<byte> value) => new OutputID(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<byte>(OutputID value) => value.m_value;
            
            // Enable comparisons between nil and OutputID struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OutputID value, NilType nil) => value.Equals(default(OutputID));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OutputID value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OutputID value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OutputID value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator OutputID(NilType nil) => default(OutputID);
        }
    }
}}}}
