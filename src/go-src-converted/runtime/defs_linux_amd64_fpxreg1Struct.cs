//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fpxreg1
        {
            // Constructors
            public fpxreg1(NilType _)
            {
                this.significand = default;
                this.exponent = default;
                this.padding = default;
            }

            public fpxreg1(array<ushort> significand = default, ushort exponent = default, array<ushort> padding = default)
            {
                this.significand = significand;
                this.exponent = exponent;
                this.padding = padding;
            }

            // Enable comparisons between nil and fpxreg1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fpxreg1 value, NilType nil) => value.Equals(default(fpxreg1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fpxreg1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fpxreg1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fpxreg1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fpxreg1(NilType nil) => default(fpxreg1);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fpxreg1 fpxreg1_cast(dynamic value)
        {
            return new fpxreg1(value.significand, value.exponent, value.padding);
        }
    }
}