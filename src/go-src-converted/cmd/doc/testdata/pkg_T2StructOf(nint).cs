//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:15:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd
{
    public static partial class pkg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T2
        {
            // Value of the T2 struct
            private readonly nint m_value;
            
            public T2(nint value) => m_value = value;

            // Enable implicit conversions between nint and T2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T2(nint value) => new T2(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(T2 value) => value.m_value;
            
            // Enable comparisons between nil and T2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T2 value, NilType nil) => value.Equals(default(T2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T2(NilType nil) => default(T2);
        }
    }
}}
