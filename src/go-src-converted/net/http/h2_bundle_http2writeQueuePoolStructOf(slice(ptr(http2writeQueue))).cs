//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:22:02 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2writeQueuePool : ISlice
        {
            // Value of the http2writeQueuePool struct
            private readonly slice<ptr<http2writeQueue>> m_value;
            
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
            
            public ref ptr<http2writeQueue> this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public http2writeQueuePool(slice<ptr<http2writeQueue>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<http2writeQueue>> and http2writeQueuePool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2writeQueuePool(slice<ptr<http2writeQueue>> value) => new http2writeQueuePool(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<http2writeQueue>>(http2writeQueuePool value) => value.m_value;
            
            // Enable comparisons between nil and http2writeQueuePool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2writeQueuePool value, NilType nil) => value.Equals(default(http2writeQueuePool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2writeQueuePool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2writeQueuePool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2writeQueuePool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2writeQueuePool(NilType nil) => default(http2writeQueuePool);
        }
    }
}}
