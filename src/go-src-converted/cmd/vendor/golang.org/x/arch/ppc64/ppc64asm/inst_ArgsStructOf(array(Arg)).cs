//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:25:06 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace ppc64
{
    public static partial class ppc64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Args : IArray
        {
            // Value of the Args struct
            private readonly array<Arg> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref Arg this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public Args(array<Arg> value) => m_value = value;

            // Enable implicit conversions between array<Arg> and Args struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Args(array<Arg> value) => new Args(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<Arg>(Args value) => value.m_value;
            
            // Enable comparisons between nil and Args struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Args value, NilType nil) => value.Equals(default(Args));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Args value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Args value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Args value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Args(NilType nil) => default(Args);
        }
    }
}}}}}}}
