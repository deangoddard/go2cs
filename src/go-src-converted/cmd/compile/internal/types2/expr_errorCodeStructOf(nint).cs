//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:12:36 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorCode
        {
            // Value of the errorCode struct
            private readonly nint m_value;
            
            public errorCode(nint value) => m_value = value;

            // Enable implicit conversions between nint and errorCode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorCode(nint value) => new errorCode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(errorCode value) => value.m_value;
            
            // Enable comparisons between nil and errorCode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorCode value, NilType nil) => value.Equals(default(errorCode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorCode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorCode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorCode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorCode(NilType nil) => default(errorCode);
        }
    }
}}}}
