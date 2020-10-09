//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        private partial struct schedt
        {
            // Constructors
            public schedt(NilType _)
            {
                this.goidgen = default;
                this.lastpoll = default;
                this.pollUntil = default;
                this.@lock = default;
                this.midle = default;
                this.nmidle = default;
                this.nmidlelocked = default;
                this.mnext = default;
                this.maxmcount = default;
                this.nmsys = default;
                this.nmfreed = default;
                this.ngsys = default;
                this.pidle = default;
                this.npidle = default;
                this.nmspinning = default;
                this.runq = default;
                this.runqsize = default;
                this.sudoglock = default;
                this.sudogcache = default;
                this.deferlock = default;
                this.deferpool = default;
                this.freem = default;
                this.gcwaiting = default;
                this.stopwait = default;
                this.stopnote = default;
                this.sysmonwait = default;
                this.sysmonnote = default;
                this.safePointFn = default;
                this.safePointWait = default;
                this.safePointNote = default;
                this.profilehz = default;
                this.procresizetime = default;
                this.totaltime = default;
                this.sysmonlock = default;
            }

            public schedt(ulong goidgen = default, ulong lastpoll = default, ulong pollUntil = default, mutex @lock = default, muintptr midle = default, int nmidle = default, int nmidlelocked = default, long mnext = default, int maxmcount = default, int nmsys = default, long nmfreed = default, uint ngsys = default, puintptr pidle = default, uint npidle = default, uint nmspinning = default, gQueue runq = default, int runqsize = default, mutex sudoglock = default, ref ptr<sudog> sudogcache = default, mutex deferlock = default, array<ptr<_defer>> deferpool = default, ref ptr<m> freem = default, uint gcwaiting = default, int stopwait = default, note stopnote = default, uint sysmonwait = default, note sysmonnote = default, Action<ptr<p>> safePointFn = default, int safePointWait = default, note safePointNote = default, int profilehz = default, long procresizetime = default, long totaltime = default, mutex sysmonlock = default)
            {
                this.goidgen = goidgen;
                this.lastpoll = lastpoll;
                this.pollUntil = pollUntil;
                this.@lock = @lock;
                this.midle = midle;
                this.nmidle = nmidle;
                this.nmidlelocked = nmidlelocked;
                this.mnext = mnext;
                this.maxmcount = maxmcount;
                this.nmsys = nmsys;
                this.nmfreed = nmfreed;
                this.ngsys = ngsys;
                this.pidle = pidle;
                this.npidle = npidle;
                this.nmspinning = nmspinning;
                this.runq = runq;
                this.runqsize = runqsize;
                this.sudoglock = sudoglock;
                this.sudogcache = sudogcache;
                this.deferlock = deferlock;
                this.deferpool = deferpool;
                this.freem = freem;
                this.gcwaiting = gcwaiting;
                this.stopwait = stopwait;
                this.stopnote = stopnote;
                this.sysmonwait = sysmonwait;
                this.sysmonnote = sysmonnote;
                this.safePointFn = safePointFn;
                this.safePointWait = safePointWait;
                this.safePointNote = safePointNote;
                this.profilehz = profilehz;
                this.procresizetime = procresizetime;
                this.totaltime = totaltime;
                this.sysmonlock = sysmonlock;
            }

            // Enable comparisons between nil and schedt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(schedt value, NilType nil) => value.Equals(default(schedt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(schedt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, schedt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, schedt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator schedt(NilType nil) => default(schedt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static schedt schedt_cast(dynamic value)
        {
            return new schedt(value.goidgen, value.lastpoll, value.pollUntil, value.@lock, value.midle, value.nmidle, value.nmidlelocked, value.mnext, value.maxmcount, value.nmsys, value.nmfreed, value.ngsys, value.pidle, value.npidle, value.nmspinning, value.runq, value.runqsize, value.sudoglock, ref value.sudogcache, value.deferlock, value.deferpool, ref value.freem, value.gcwaiting, value.stopwait, value.stopnote, value.sysmonwait, value.sysmonnote, value.safePointFn, value.safePointWait, value.safePointNote, value.profilehz, value.procresizetime, value.totaltime, value.sysmonlock);
        }
    }
}