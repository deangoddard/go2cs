//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:25:00 UTC
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
    public static partial class walk_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct initContext
        {
            // Value of the initContext struct
            private readonly byte m_value;
            
            public initContext(byte value) => m_value = value;

            // Enable implicit conversions between byte and initContext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator initContext(byte value) => new initContext(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(initContext value) => value.m_value;
            
            // Enable comparisons between nil and initContext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(initContext value, NilType nil) => value.Equals(default(initContext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(initContext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, initContext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, initContext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator initContext(NilType nil) => default(initContext);
        }
    }
}}}}
