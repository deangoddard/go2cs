//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class bidi_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Direction
        {
            // Value of the Direction struct
            private readonly nint m_value;
            
            public Direction(nint value) => m_value = value;

            // Enable implicit conversions between nint and Direction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Direction(nint value) => new Direction(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(Direction value) => value.m_value;
            
            // Enable comparisons between nil and Direction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Direction value, NilType nil) => value.Equals(default(Direction));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Direction value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Direction value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Direction value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Direction(NilType nil) => default(Direction);
        }
    }
}}}}}}
