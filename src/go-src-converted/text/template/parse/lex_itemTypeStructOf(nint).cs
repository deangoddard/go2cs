//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace text {
namespace template
{
    public static partial class parse_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct itemType
        {
            // Value of the itemType struct
            private readonly nint m_value;
            
            public itemType(nint value) => m_value = value;

            // Enable implicit conversions between nint and itemType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator itemType(nint value) => new itemType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(itemType value) => value.m_value;
            
            // Enable comparisons between nil and itemType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(itemType value, NilType nil) => value.Equals(default(itemType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(itemType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, itemType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, itemType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator itemType(NilType nil) => default(itemType);
        }
    }
}}}
