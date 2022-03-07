//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:42:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nodeSet : IMap
        {
            // Value of the nodeSet struct
            private readonly map<ptr<graphNode>, bool> m_value;
            
            public nint Length => ((IMap)m_value).Length;

            object? IMap.this[object key]
            {
                get => ((IMap)m_value)[key];
                set => ((IMap)m_value)[key] = value;
            }

            public bool this[ptr<graphNode> key]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value[key];
            
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set => m_value[key] = value;
            }

            public (bool, bool) this[ptr<graphNode> key, bool _]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value.TryGetValue(key, out bool value) ? (value!, true) : (default!, false);
            }

            public nodeSet(map<ptr<graphNode>, bool> value) => m_value = value;

            // Enable implicit conversions between map<ptr<graphNode>, bool> and nodeSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nodeSet(map<ptr<graphNode>, bool> value) => new nodeSet(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<ptr<graphNode>, bool>(nodeSet value) => value.m_value;
            
            // Enable comparisons between nil and nodeSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nodeSet value, NilType nil) => value.Equals(default(nodeSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nodeSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nodeSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nodeSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nodeSet(NilType nil) => default(nodeSet);
        }
    }
}}
