//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:28 UTC
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
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _Socklen
        {
            // Value of the _Socklen struct
            private readonly uint m_value;
            
            public _Socklen(uint value) => m_value = value;

            // Enable implicit conversions between uint and _Socklen struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Socklen(uint value) => new _Socklen(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(_Socklen value) => value.m_value;
            
            // Enable comparisons between nil and _Socklen struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_Socklen value, NilType nil) => value.Equals(default(_Socklen));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_Socklen value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _Socklen value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _Socklen value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Socklen(NilType nil) => default(_Socklen);
        }
    }
}}}}}}
