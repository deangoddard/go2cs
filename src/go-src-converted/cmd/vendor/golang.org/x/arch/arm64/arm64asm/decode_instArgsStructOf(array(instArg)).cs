//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:24:56 UTC
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
namespace arm64
{
    public static partial class arm64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct instArgs : IArray
        {
            // Value of the instArgs struct
            private readonly array<instArg> m_value;
            
            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }

            public ref instArg this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();

            public instArgs(array<instArg> value) => m_value = value;

            // Enable implicit conversions between array<instArg> and instArgs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instArgs(array<instArg> value) => new instArgs(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<instArg>(instArgs value) => value.m_value;
            
            // Enable comparisons between nil and instArgs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(instArgs value, NilType nil) => value.Equals(default(instArgs));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(instArgs value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, instArgs value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, instArgs value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instArgs(NilType nil) => default(instArgs);
        }
    }
}}}}}}}
