//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:23:55 UTC
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
    public static partial class ssagen_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct instrumentKind
        {
            // Value of the instrumentKind struct
            private readonly byte m_value;
            
            public instrumentKind(byte value) => m_value = value;

            // Enable implicit conversions between byte and instrumentKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instrumentKind(byte value) => new instrumentKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(instrumentKind value) => value.m_value;
            
            // Enable comparisons between nil and instrumentKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(instrumentKind value, NilType nil) => value.Equals(default(instrumentKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(instrumentKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, instrumentKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, instrumentKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instrumentKind(NilType nil) => default(instrumentKind);
        }
    }
}}}}
