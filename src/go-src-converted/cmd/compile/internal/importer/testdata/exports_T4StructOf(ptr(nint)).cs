//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:55 UTC
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
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T4
        {
            // Value of the T4 struct
            private readonly ptr<nint> m_value;
            
            public T4(ptr<nint> value) => m_value = value;

            // Enable implicit conversions between ptr<nint> and T4 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T4(ptr<nint> value) => new T4(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptr<nint>(T4 value) => value.m_value;
            
            // Enable comparisons between nil and T4 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T4 value, NilType nil) => value.Equals(default(T4));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T4 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T4 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T4 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T4(NilType nil) => default(T4);
        }
    }
}}}}
