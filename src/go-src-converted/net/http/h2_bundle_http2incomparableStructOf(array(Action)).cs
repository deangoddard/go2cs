//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct http2incomparable : IArray
        {
            // Value of the http2incomparable struct
            private readonly array<Action> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref Action this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public http2incomparable(array<Action> value) => m_value = value;

            // Enable implicit conversions between array<Action> and http2incomparable struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2incomparable(array<Action> value) => new http2incomparable(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<Action>(http2incomparable value) => value.m_value;
            
            // Enable comparisons between nil and http2incomparable struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2incomparable value, NilType nil) => value.Equals(default(http2incomparable));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2incomparable value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2incomparable value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2incomparable value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2incomparable(NilType nil) => default(http2incomparable);
        }
    }
}}
