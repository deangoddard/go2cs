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
        private partial struct regAllocState
        {
            // Constructors
            public regAllocState(NilType _)
            {
                this.f = default;
                this.sdom = default;
                this.registers = default;
                this.numRegs = default;
                this.SPReg = default;
                this.SBReg = default;
                this.GReg = default;
                this.allocatable = default;
                this.live = default;
                this.desired = default;
                this.values = default;
                this.sp = default;
                this.sb = default;
                this.orig = default;
                this.regs = default;
                this.nospill = default;
                this.used = default;
                this.tmpused = default;
                this.curBlock = default;
                this.freeUseRecords = default;
                this.endRegs = default;
                this.startRegs = default;
                this.spillLive = default;
                this.copies = default;
                this.loopnest = default;
                this.visitOrder = default;
                this.blockOrder = default;
                this.doClobber = default;
            }

            public regAllocState(ref ptr<Func> f = default, SparseTree sdom = default, slice<Register> registers = default, register numRegs = default, register SPReg = default, register SBReg = default, register GReg = default, regMask allocatable = default, slice<slice<liveInfo>> live = default, slice<desiredState> desired = default, slice<valState> values = default, ID sp = default, ID sb = default, slice<ptr<Value>> orig = default, slice<regState> regs = default, regMask nospill = default, regMask used = default, regMask tmpused = default, ref ptr<Block> curBlock = default, ref ptr<use> freeUseRecords = default, slice<slice<endReg>> endRegs = default, slice<slice<startReg>> startRegs = default, slice<slice<ID>> spillLive = default, map<ptr<Value>, bool> copies = default, ref ptr<loopnest> loopnest = default, slice<ptr<Block>> visitOrder = default, slice<int> blockOrder = default, bool doClobber = default)
            {
                this.f = f;
                this.sdom = sdom;
                this.registers = registers;
                this.numRegs = numRegs;
                this.SPReg = SPReg;
                this.SBReg = SBReg;
                this.GReg = GReg;
                this.allocatable = allocatable;
                this.live = live;
                this.desired = desired;
                this.values = values;
                this.sp = sp;
                this.sb = sb;
                this.orig = orig;
                this.regs = regs;
                this.nospill = nospill;
                this.used = used;
                this.tmpused = tmpused;
                this.curBlock = curBlock;
                this.freeUseRecords = freeUseRecords;
                this.endRegs = endRegs;
                this.startRegs = startRegs;
                this.spillLive = spillLive;
                this.copies = copies;
                this.loopnest = loopnest;
                this.visitOrder = visitOrder;
                this.blockOrder = blockOrder;
                this.doClobber = doClobber;
            }

            // Enable comparisons between nil and regAllocState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(regAllocState value, NilType nil) => value.Equals(default(regAllocState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(regAllocState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, regAllocState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, regAllocState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator regAllocState(NilType nil) => default(regAllocState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static regAllocState regAllocState_cast(dynamic value)
        {
            return new regAllocState(ref value.f, value.sdom, value.registers, value.numRegs, value.SPReg, value.SBReg, value.GReg, value.allocatable, value.live, value.desired, value.values, value.sp, value.sb, value.orig, value.regs, value.nospill, value.used, value.tmpused, ref value.curBlock, ref value.freeUseRecords, value.endRegs, value.startRegs, value.spillLive, value.copies, ref value.loopnest, value.visitOrder, value.blockOrder, value.doClobber);
        }
    }
}}}}