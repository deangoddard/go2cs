//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:36 UTC
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
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ACCESS_MASK
        {
            // Value of the ACCESS_MASK struct
            private readonly uint m_value;
            
            public ACCESS_MASK(uint value) => m_value = value;

            // Enable implicit conversions between uint and ACCESS_MASK struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ACCESS_MASK(uint value) => new ACCESS_MASK(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(ACCESS_MASK value) => value.m_value;
            
            // Enable comparisons between nil and ACCESS_MASK struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ACCESS_MASK value, NilType nil) => value.Equals(default(ACCESS_MASK));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ACCESS_MASK value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ACCESS_MASK value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ACCESS_MASK value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ACCESS_MASK(NilType nil) => default(ACCESS_MASK);
        }
    }
}}}}}}
