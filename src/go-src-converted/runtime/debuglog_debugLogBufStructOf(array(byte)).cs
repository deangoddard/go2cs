//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:24:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct debugLogBuf : IArray
        {
            // Value of the debugLogBuf struct
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

            public debugLogBuf(array<byte> value) => m_value = value;

            // Enable implicit conversions between array<byte> and debugLogBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugLogBuf(array<byte> value) => new debugLogBuf(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<byte>(debugLogBuf value) => value.m_value;
            
            // Enable comparisons between nil and debugLogBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(debugLogBuf value, NilType nil) => value.Equals(default(debugLogBuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(debugLogBuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, debugLogBuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, debugLogBuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugLogBuf(NilType nil) => default(debugLogBuf);
        }
    }
}
