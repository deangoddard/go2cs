//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:13 UTC
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
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byDomPreorder : ISlice
        {
            // Value of the byDomPreorder struct
            private readonly slice<ptr<BasicBlock>> m_value;
            
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
            
            public ref ptr<BasicBlock> this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public byDomPreorder(slice<ptr<BasicBlock>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<BasicBlock>> and byDomPreorder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byDomPreorder(slice<ptr<BasicBlock>> value) => new byDomPreorder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<BasicBlock>>(byDomPreorder value) => value.m_value;
            
            // Enable comparisons between nil and byDomPreorder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byDomPreorder value, NilType nil) => value.Equals(default(byDomPreorder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byDomPreorder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byDomPreorder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byDomPreorder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byDomPreorder(NilType nil) => default(byDomPreorder);
        }
    }
}}}}}
