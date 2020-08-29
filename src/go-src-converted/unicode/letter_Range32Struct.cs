//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class unicode_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Range32
        {
            // Constructors
            public Range32(NilType _)
            {
                this.Lo = default;
                this.Hi = default;
                this.Stride = default;
            }

            public Range32(uint Lo = default, uint Hi = default, uint Stride = default)
            {
                this.Lo = Lo;
                this.Hi = Hi;
                this.Stride = Stride;
            }

            // Enable comparisons between nil and Range32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Range32 value, NilType nil) => value.Equals(default(Range32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Range32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Range32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Range32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Range32(NilType nil) => default(Range32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Range32 Range32_cast(dynamic value)
        {
            return new Range32(value.Lo, value.Hi, value.Stride);
        }
    }
}