//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:50:18 UTC
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
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ValAndOff
        {
            // Value of the ValAndOff struct
            private readonly long m_value;
            
            public ValAndOff(long value) => m_value = value;

            // Enable implicit conversions between long and ValAndOff struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ValAndOff(long value) => new ValAndOff(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(ValAndOff value) => value.m_value;
            
            // Enable comparisons between nil and ValAndOff struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ValAndOff value, NilType nil) => value.Equals(default(ValAndOff));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ValAndOff value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ValAndOff value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ValAndOff value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ValAndOff(NilType nil) => default(ValAndOff);
        }
    }
}}}}
