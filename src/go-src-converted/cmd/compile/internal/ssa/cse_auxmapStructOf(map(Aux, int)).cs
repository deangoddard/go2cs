//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:33 UTC
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
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct auxmap : IMap
        {
            // Value of the auxmap struct
            private readonly map<Aux, int> m_value;
            
            public nint Length => ((IMap)m_value).Length;

            object? IMap.this[object key]
            {
                get => ((IMap)m_value)[key];
                set => ((IMap)m_value)[key] = value;
            }

            public int this[Aux key]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value[key];
            
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set => m_value[key] = value;
            }

            public (int, bool) this[Aux key, bool _]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value.TryGetValue(key, out int value) ? (value!, true) : (default!, false);
            }

            public auxmap(map<Aux, int> value) => m_value = value;

            // Enable implicit conversions between map<Aux, int> and auxmap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator auxmap(map<Aux, int> value) => new auxmap(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<Aux, int>(auxmap value) => value.m_value;
            
            // Enable comparisons between nil and auxmap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(auxmap value, NilType nil) => value.Equals(default(auxmap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(auxmap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, auxmap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, auxmap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator auxmap(NilType nil) => default(auxmap);
        }
    }
}}}}