//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:48 UTC
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
    public static partial class mail_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Header : IMap
        {
            // Value of the Header struct
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

            public Header(map<@string, slice<@string>> value) => m_value = value;

            // Enable implicit conversions between map<@string, slice<@string>> and Header struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Header(map<@string, slice<@string>> value) => new Header(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<@string, slice<@string>>(Header value) => value.m_value;
            
            // Enable comparisons between nil and Header struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Header value, NilType nil) => value.Equals(default(Header));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Header value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Header value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Header value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Header(NilType nil) => default(Header);
        }
    }
}}
