//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using color = go.image.color_package;

namespace go
{
    public static partial class image_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Uniform
        {
            // Constructors
            public Uniform(NilType _)
            {
                this.C = default;
            }

            public Uniform(color.Color C = default)
            {
                this.C = C;
            }

            // Enable comparisons between nil and Uniform struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Uniform value, NilType nil) => value.Equals(default(Uniform));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Uniform value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Uniform value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Uniform value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Uniform(NilType nil) => default(Uniform);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Uniform Uniform_cast(dynamic value)
        {
            return new Uniform(value.C);
        }
    }
}