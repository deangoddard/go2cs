//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:09:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mspan
        {
            // Constructors
            public mspan(NilType _)
            {
                this.next = default;
                this.prev = default;
                this.list = default;
                this.startAddr = default;
                this.npages = default;
                this.manualFreeList = default;
                this.freeindex = default;
                this.nelems = default;
                this.allocCache = default;
                this.allocBits = default;
                this.gcmarkBits = default;
                this.sweepgen = default;
                this.divMul = default;
                this.allocCount = default;
                this.spanclass = default;
                this.state = default;
                this.needzero = default;
                this.elemsize = default;
                this.limit = default;
                this.speciallock = default;
                this.specials = default;
            }

            public mspan(ref ptr<mspan> next = default, ref ptr<mspan> prev = default, ref ptr<mSpanList> list = default, System.UIntPtr startAddr = default, System.UIntPtr npages = default, gclinkptr manualFreeList = default, System.UIntPtr freeindex = default, System.UIntPtr nelems = default, ulong allocCache = default, ref ptr<gcBits> allocBits = default, ref ptr<gcBits> gcmarkBits = default, uint sweepgen = default, uint divMul = default, ushort allocCount = default, spanClass spanclass = default, mSpanStateBox state = default, byte needzero = default, System.UIntPtr elemsize = default, System.UIntPtr limit = default, mutex speciallock = default, ref ptr<special> specials = default)
            {
                this.next = next;
                this.prev = prev;
                this.list = list;
                this.startAddr = startAddr;
                this.npages = npages;
                this.manualFreeList = manualFreeList;
                this.freeindex = freeindex;
                this.nelems = nelems;
                this.allocCache = allocCache;
                this.allocBits = allocBits;
                this.gcmarkBits = gcmarkBits;
                this.sweepgen = sweepgen;
                this.divMul = divMul;
                this.allocCount = allocCount;
                this.spanclass = spanclass;
                this.state = state;
                this.needzero = needzero;
                this.elemsize = elemsize;
                this.limit = limit;
                this.speciallock = speciallock;
                this.specials = specials;
            }

            // Enable comparisons between nil and mspan struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mspan value, NilType nil) => value.Equals(default(mspan));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mspan value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mspan value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mspan value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mspan(NilType nil) => default(mspan);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mspan mspan_cast(dynamic value)
        {
            return new mspan(ref value.next, ref value.prev, ref value.list, value.startAddr, value.npages, value.manualFreeList, value.freeindex, value.nelems, value.allocCache, ref value.allocBits, ref value.gcmarkBits, value.sweepgen, value.divMul, value.allocCount, value.spanclass, value.state, value.needzero, value.elemsize, value.limit, value.speciallock, ref value.specials);
        }
    }
}