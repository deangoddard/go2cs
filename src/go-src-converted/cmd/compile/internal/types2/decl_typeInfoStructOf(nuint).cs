//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:25:53 UTC
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
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct typeInfo
        {
            // Value of the typeInfo struct
            private readonly nuint m_value;
            
            public typeInfo(nuint value) => m_value = value;

            // Enable implicit conversions between nuint and typeInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeInfo(nuint value) => new typeInfo(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nuint(typeInfo value) => value.m_value;
            
            // Enable comparisons between nil and typeInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeInfo value, NilType nil) => value.Equals(default(typeInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeInfo(NilType nil) => default(typeInfo);
        }
    }
}}}}
