//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;

namespace go
{
    public static partial class strings_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Replacer
        {
            // Constructors
            public Replacer(NilType _)
            {
                this.r = default;
            }

            public Replacer(replacer r = default)
            {
                this.r = r;
            }

            // Enable comparisons between nil and Replacer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Replacer value, NilType nil) => value.Equals(default(Replacer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Replacer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Replacer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Replacer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Replacer(NilType nil) => default(Replacer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Replacer Replacer_cast(dynamic value)
        {
            return new Replacer(value.r);
        }
    }
}