//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using flag = go.flag_package;
using fmt = go.fmt_package;
using race = go.@internal.race_package;
using os = go.os_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PB
        {
            // Constructors
            public PB(NilType _)
            {
                this.globalN = default;
                this.grain = default;
                this.cache = default;
                this.bN = default;
            }

            public PB(ref ptr<ulong> globalN = default, ulong grain = default, ulong cache = default, ulong bN = default)
            {
                this.globalN = globalN;
                this.grain = grain;
                this.cache = cache;
                this.bN = bN;
            }

            // Enable comparisons between nil and PB struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PB value, NilType nil) => value.Equals(default(PB));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PB value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PB value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PB value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PB(NilType nil) => default(PB);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PB PB_cast(dynamic value)
        {
            return new PB(ref value.globalN, value.grain, value.cache, value.bN);
        }
    }
}