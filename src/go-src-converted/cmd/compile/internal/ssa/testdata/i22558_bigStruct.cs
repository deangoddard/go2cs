//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:39:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using os = go.os_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct big
        {
            // Constructors
            public big(NilType _)
            {
                this.pile = default;
            }

            public big(array<sbyte> pile = default)
            {
                this.pile = pile;
            }

            // Enable comparisons between nil and big struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(big value, NilType nil) => value.Equals(default(big));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(big value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, big value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, big value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator big(NilType nil) => default(big);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static big big_cast(dynamic value)
        {
            return new big(value.pile);
        }
    }
}