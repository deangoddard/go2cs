//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strings = go.strings_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct S2
        {
            // Constructors
            public S2(NilType _)
            {
                this.f = default;
            }

            public S2(Func<long> f = default)
            {
                this.f = f;
            }

            // Enable comparisons between nil and S2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S2 value, NilType nil) => value.Equals(default(S2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S2(NilType nil) => default(S2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static S2 S2_cast(dynamic value)
        {
            return new S2(value.f);
        }
    }
}