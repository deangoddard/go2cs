//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:42:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using heap = go.container.heap_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct phiState
        {
            // Constructors
            public phiState(NilType _)
            {
                this.s = default;
                this.f = default;
                this.defvars = default;
                this.varnum = default;
                this.idom = default;
                this.tree = default;
                this.level = default;
                this.priq = default;
                this.q = default;
                this.queued = default;
                this.hasPhi = default;
                this.hasDef = default;
                this.placeholder = default;
            }

            public phiState(ref ptr<state> s = default, ref ptr<ssa.Func> f = default, slice<map<ptr<Node>, ptr<ssa.Value>>> defvars = default, map<ptr<Node>, int> varnum = default, slice<ptr<ssa.Block>> idom = default, slice<domBlock> tree = default, slice<int> level = default, blockHeap priq = default, slice<ptr<ssa.Block>> q = default, ref ptr<sparseSet> queued = default, ref ptr<sparseSet> hasPhi = default, ref ptr<sparseSet> hasDef = default, ref ptr<ssa.Value> placeholder = default)
            {
                this.s = s;
                this.f = f;
                this.defvars = defvars;
                this.varnum = varnum;
                this.idom = idom;
                this.tree = tree;
                this.level = level;
                this.priq = priq;
                this.q = q;
                this.queued = queued;
                this.hasPhi = hasPhi;
                this.hasDef = hasDef;
                this.placeholder = placeholder;
            }

            // Enable comparisons between nil and phiState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(phiState value, NilType nil) => value.Equals(default(phiState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(phiState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, phiState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, phiState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator phiState(NilType nil) => default(phiState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static phiState phiState_cast(dynamic value)
        {
            return new phiState(ref value.s, ref value.f, value.defvars, value.varnum, value.idom, value.tree, value.level, value.priq, value.q, ref value.queued, ref value.hasPhi, ref value.hasDef, ref value.placeholder);
        }
    }
}}}}