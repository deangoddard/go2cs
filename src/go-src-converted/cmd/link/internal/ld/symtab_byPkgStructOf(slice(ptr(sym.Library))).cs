//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:35:28 UTC
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
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct byPkg : ISlice
        {
            // Value of the byPkg struct
            private readonly slice<ptr<sym.Library>> m_value;
            
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
            
            public ref ptr<sym.Library> this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public byPkg(slice<ptr<sym.Library>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<sym.Library>> and byPkg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPkg(slice<ptr<sym.Library>> value) => new byPkg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<sym.Library>>(byPkg value) => value.m_value;
            
            // Enable comparisons between nil and byPkg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byPkg value, NilType nil) => value.Equals(default(byPkg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byPkg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byPkg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byPkg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPkg(NilType nil) => default(byPkg);
        }
    }
}}}}
