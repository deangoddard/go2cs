//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:24:34 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PCRel
        {
            // Value of the PCRel struct
            private readonly int m_value;
            
            public PCRel(int value) => m_value = value;

            // Enable implicit conversions between int and PCRel struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PCRel(int value) => new PCRel(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(PCRel value) => value.m_value;
            
            // Enable comparisons between nil and PCRel struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PCRel value, NilType nil) => value.Equals(default(PCRel));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PCRel value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PCRel value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PCRel value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PCRel(NilType nil) => default(PCRel);
        }
    }
}}}}}}}
