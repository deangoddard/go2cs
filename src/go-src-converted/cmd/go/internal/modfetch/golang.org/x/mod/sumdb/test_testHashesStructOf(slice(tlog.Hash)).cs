//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:10 UTC
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
namespace mod
{
    public static partial class sumdb_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct testHashes : ISlice
        {
            // Value of the testHashes struct
            private readonly slice<tlog.Hash> m_value;
            
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
            
            public ref tlog.Hash this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public testHashes(slice<tlog.Hash> value) => m_value = value;

            // Enable implicit conversions between slice<tlog.Hash> and testHashes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testHashes(slice<tlog.Hash> value) => new testHashes(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<tlog.Hash>(testHashes value) => value.m_value;
            
            // Enable comparisons between nil and testHashes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(testHashes value, NilType nil) => value.Equals(default(testHashes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(testHashes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, testHashes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, testHashes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testHashes(NilType nil) => default(testHashes);
        }
    }
}}}}
