//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:30:25 UTC
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
    public static partial class url_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Values : IMap
        {
            // Value of the Values struct
            private readonly map<@string, slice<@string>> m_value;
            
            public nint Length => ((IMap)m_value).Length;

            object? IMap.this[object key]
            {
                get => ((IMap)m_value)[key];
                set => ((IMap)m_value)[key] = value;
            }

            public slice<@string> this[@string key]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value[key];
            
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set => m_value[key] = value;
            }

            public (slice<@string>, bool) this[@string key, bool _]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value.TryGetValue(key, out slice<@string> value) ? (value!, true) : (default!, false);
            }

            public Values(map<@string, slice<@string>> value) => m_value = value;

            // Enable implicit conversions between map<@string, slice<@string>> and Values struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Values(map<@string, slice<@string>> value) => new Values(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<@string, slice<@string>>(Values value) => value.m_value;
            
            // Enable comparisons between nil and Values struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Values value, NilType nil) => value.Equals(default(Values));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Values value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Values value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Values value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Values(NilType nil) => default(Values);
        }
    }
}}
