//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:12:34 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct chanDir
        {
            // Value of the chanDir struct
            private readonly nint m_value;
            
            public chanDir(nint value) => m_value = value;

            // Enable implicit conversions between nint and chanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chanDir(nint value) => new chanDir(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(chanDir value) => value.m_value;
            
            // Enable comparisons between nil and chanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(chanDir value, NilType nil) => value.Equals(default(chanDir));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(chanDir value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, chanDir value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, chanDir value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chanDir(NilType nil) => default(chanDir);
        }
    }
}}
