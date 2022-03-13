//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:02:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using ir = go.cmd.compile.@internal.ir_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using bits = go.math.bits_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct valState
        {
            // Constructors
            public valState(NilType _)
            {
                this.regs = default;
                this.uses = default;
                this.spill = default;
                this.restoreMin = default;
                this.restoreMax = default;
                this.needReg = default;
                this.rematerializeable = default;
            }

            public valState(regMask regs = default, ref ptr<use> uses = default, ref ptr<Value> spill = default, int restoreMin = default, int restoreMax = default, bool needReg = default, bool rematerializeable = default)
            {
                this.regs = regs;
                this.uses = uses;
                this.spill = spill;
                this.restoreMin = restoreMin;
                this.restoreMax = restoreMax;
                this.needReg = needReg;
                this.rematerializeable = rematerializeable;
            }

            // Enable comparisons between nil and valState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(valState value, NilType nil) => value.Equals(default(valState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(valState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, valState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, valState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator valState(NilType nil) => default(valState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static valState valState_cast(dynamic value)
        {
            return new valState(value.regs, ref value.uses, ref value.spill, value.restoreMin, value.restoreMax, value.needReg, value.rematerializeable);
        }
    }
}}}}