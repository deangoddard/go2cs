//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:30:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct itd32
        {
            // Constructors
            public itd32(NilType _)
            {
                this.a = default;
                this.b = default;
                this.add = default;
                this.sub = default;
                this.mul = default;
                this.div = default;
                this.mod = default;
            }

            public itd32(int a = default, int b = default, int add = default, int sub = default, int mul = default, int div = default, int mod = default)
            {
                this.a = a;
                this.b = b;
                this.add = add;
                this.sub = sub;
                this.mul = mul;
                this.div = div;
                this.mod = mod;
            }

            // Enable comparisons between nil and itd32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(itd32 value, NilType nil) => value.Equals(default(itd32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(itd32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, itd32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, itd32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator itd32(NilType nil) => default(itd32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static itd32 itd32_cast(dynamic value)
        {
            return new itd32(value.a, value.b, value.add, value.sub, value.mul, value.div, value.mod);
        }
    }
}