//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fpcontrol
        {
            // Constructors
            public fpcontrol(NilType _)
            {
                this.pad_cgo_0 = default;
            }

            public fpcontrol(array<byte> pad_cgo_0 = default)
            {
                this.pad_cgo_0 = pad_cgo_0;
            }

            // Enable comparisons between nil and fpcontrol struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fpcontrol value, NilType nil) => value.Equals(default(fpcontrol));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fpcontrol value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fpcontrol value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fpcontrol value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fpcontrol(NilType nil) => default(fpcontrol);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fpcontrol fpcontrol_cast(dynamic value)
        {
            return new fpcontrol(value.pad_cgo_0);
        }
    }
}