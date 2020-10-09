//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using syntax = go.regexp.syntax_package;
using sync = go.sync_package;

#nullable enable

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct machine
        {
            // Constructors
            public machine(NilType _)
            {
                this.re = default;
                this.p = default;
                this.q0 = default;
                this.q1 = default;
                this.pool = default;
                this.matched = default;
                this.matchcap = default;
                this.inputs = default;
            }

            public machine(ref ptr<Regexp> re = default, ref ptr<syntax.Prog> p = default, queue q0 = default, queue q1 = default, slice<ptr<thread>> pool = default, bool matched = default, slice<long> matchcap = default, inputs inputs = default)
            {
                this.re = re;
                this.p = p;
                this.q0 = q0;
                this.q1 = q1;
                this.pool = pool;
                this.matched = matched;
                this.matchcap = matchcap;
                this.inputs = inputs;
            }

            // Enable comparisons between nil and machine struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(machine value, NilType nil) => value.Equals(default(machine));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(machine value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, machine value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, machine value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator machine(NilType nil) => default(machine);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static machine machine_cast(dynamic value)
        {
            return new machine(ref value.re, ref value.p, value.q0, value.q1, value.pool, value.matched, value.matchcap, value.inputs);
        }
    }
}