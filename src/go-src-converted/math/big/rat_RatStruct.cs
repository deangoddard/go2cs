//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:18:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using math = go.math_package;
using go;

#nullable enable

namespace go {
namespace math
{
    public static partial class big_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Rat
        {
            // Constructors
            public Rat(NilType _)
            {
                this.a = default;
                this.b = default;
            }

            public Rat(Int a = default, Int b = default)
            {
                this.a = a;
                this.b = b;
            }

            // Enable comparisons between nil and Rat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Rat value, NilType nil) => value.Equals(default(Rat));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Rat value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Rat value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Rat value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Rat(NilType nil) => default(Rat);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Rat Rat_cast(dynamic value)
        {
            return new Rat(value.a, value.b);
        }
    }
}}