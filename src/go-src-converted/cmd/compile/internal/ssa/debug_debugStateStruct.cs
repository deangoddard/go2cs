//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.cmd.compile.@internal.abi_package;
using ir = go.cmd.compile.@internal.ir_package;
using types = go.cmd.compile.@internal.types_package;
using dwarf = go.cmd.@internal.dwarf_package;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using hex = go.encoding.hex_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using bits = go.math.bits_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct debugState
        {
            // Constructors
            public debugState(NilType _)
            {
                this.slots = default;
                this.vars = default;
                this.varSlots = default;
                this.lists = default;
                this.slotVars = default;
                this.f = default;
                this.loggingEnabled = default;
                this.registers = default;
                this.stackOffset = default;
                this.ctxt = default;
                this.valueNames = default;
                this.currentState = default;
                this.liveCount = default;
                this.changedVars = default;
                this.pendingEntries = default;
                this.varParts = default;
                this.blockDebug = default;
                this.pendingSlotLocs = default;
                this.liveSlots = default;
                this.liveSlotSliceBegin = default;
                this.partsByVarOffset = default;
            }

            public debugState(slice<LocalSlot> slots = default, slice<ptr<ir.Name>> vars = default, slice<slice<SlotID>> varSlots = default, slice<slice<byte>> lists = default, slice<VarID> slotVars = default, ref ptr<Func> f = default, bool loggingEnabled = default, slice<Register> registers = default, Func<LocalSlot, int> stackOffset = default, ref ptr<obj.Link> ctxt = default, slice<slice<SlotID>> valueNames = default, stateAtPC currentState = default, slice<nint> liveCount = default, ref ptr<sparseSet> changedVars = default, slice<pendingEntry> pendingEntries = default, map<ptr<ir.Name>, slice<SlotID>> varParts = default, slice<BlockDebug> blockDebug = default, slice<VarLoc> pendingSlotLocs = default, slice<liveSlot> liveSlots = default, nint liveSlotSliceBegin = default, sort.Interface partsByVarOffset = default)
            {
                this.slots = slots;
                this.vars = vars;
                this.varSlots = varSlots;
                this.lists = lists;
                this.slotVars = slotVars;
                this.f = f;
                this.loggingEnabled = loggingEnabled;
                this.registers = registers;
                this.stackOffset = stackOffset;
                this.ctxt = ctxt;
                this.valueNames = valueNames;
                this.currentState = currentState;
                this.liveCount = liveCount;
                this.changedVars = changedVars;
                this.pendingEntries = pendingEntries;
                this.varParts = varParts;
                this.blockDebug = blockDebug;
                this.pendingSlotLocs = pendingSlotLocs;
                this.liveSlots = liveSlots;
                this.liveSlotSliceBegin = liveSlotSliceBegin;
                this.partsByVarOffset = partsByVarOffset;
            }

            // Enable comparisons between nil and debugState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(debugState value, NilType nil) => value.Equals(default(debugState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(debugState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, debugState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, debugState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugState(NilType nil) => default(debugState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static debugState debugState_cast(dynamic value)
        {
            return new debugState(value.slots, value.vars, value.varSlots, value.lists, value.slotVars, ref value.f, value.loggingEnabled, value.registers, value.stackOffset, ref value.ctxt, value.valueNames, value.currentState, value.liveCount, ref value.changedVars, value.pendingEntries, value.varParts, value.blockDebug, value.pendingSlotLocs, value.liveSlots, value.liveSlotSliceBegin, value.partsByVarOffset);
        }
    }
}}}}