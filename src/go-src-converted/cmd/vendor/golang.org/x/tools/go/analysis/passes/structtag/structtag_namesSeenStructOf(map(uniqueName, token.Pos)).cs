//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:34:48 UTC
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
namespace tools {
namespace go {
namespace analysis {
namespace passes
{
    public static partial class structtag_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct namesSeen : IMap
        {
            // Value of the namesSeen struct
            private readonly map<uniqueName, token.Pos> m_value;
            
            public nint Length => ((IMap)m_value).Length;

            object? IMap.this[object key]
            {
                get => ((IMap)m_value)[key];
                set => ((IMap)m_value)[key] = value;
            }

            public token.Pos this[uniqueName key]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value[key];
            
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set => m_value[key] = value;
            }

            public (token.Pos, bool) this[uniqueName key, bool _]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => m_value.TryGetValue(key, out token.Pos value) ? (value!, true) : (default!, false);
            }

            public namesSeen(map<uniqueName, token.Pos> value) => m_value = value;

            // Enable implicit conversions between map<uniqueName, token.Pos> and namesSeen struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator namesSeen(map<uniqueName, token.Pos> value) => new namesSeen(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<uniqueName, token.Pos>(namesSeen value) => value.m_value;
            
            // Enable comparisons between nil and namesSeen struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(namesSeen value, NilType nil) => value.Equals(default(namesSeen));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(namesSeen value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, namesSeen value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, namesSeen value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator namesSeen(NilType nil) => default(namesSeen);
        }
    }
}}}}}}}}}
