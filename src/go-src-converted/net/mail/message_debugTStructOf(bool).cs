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
        private partial struct debugT
        {
            // Value of the debugT struct
            private readonly bool m_value;
            
            public debugT(bool value) => m_value = value;

            // Enable implicit conversions between bool and debugT struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugT(bool value) => new debugT(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bool(debugT value) => value.m_value;
            
            // Enable comparisons between nil and debugT struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(debugT value, NilType nil) => value.Equals(default(debugT));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(debugT value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, debugT value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, debugT value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugT(NilType nil) => default(debugT);
        }
    }
}}
