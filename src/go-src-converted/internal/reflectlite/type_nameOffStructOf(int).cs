//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class reflectlite_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct nameOff
        {
            // Value of the nameOff struct
            private readonly int m_value;
            
            public nameOff(int value) => m_value = value;

            // Enable implicit conversions between int and nameOff struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nameOff(int value) => new nameOff(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(nameOff value) => value.m_value;
            
            // Enable comparisons between nil and nameOff struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nameOff value, NilType nil) => value.Equals(default(nameOff));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nameOff value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nameOff value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nameOff value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nameOff(NilType nil) => default(nameOff);
        }
    }
}}
