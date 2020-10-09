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
        private partial struct p
        {
            // Constructors
            public p(NilType _)
            {
                this.id = default;
                this.status = default;
                this.link = default;
                this.schedtick = default;
                this.syscalltick = default;
                this.sysmontick = default;
                this.m = default;
                this.mcache = default;
                this.pcache = default;
                this.raceprocctx = default;
                this.deferpool = default;
                this.deferpoolbuf = default;
                this.goidcache = default;
                this.goidcacheend = default;
                this.runqhead = default;
                this.runqtail = default;
                this.runq = default;
                this.runnext = default;
                this.sudogcache = default;
                this.sudogbuf = default;
                this.tracebuf = default;
                this.traceSweep = default;
                this.traceSwept = default;
                this.traceReclaimed = default;
                this.palloc = default;
                this._ = default;
                this.timer0When = default;
                this.gcAssistTime = default;
                this.gcFractionalMarkTime = default;
                this.gcBgMarkWorker = default;
                this.gcMarkWorkerMode = default;
                this.gcMarkWorkerStartTime = default;
                this.gcw = default;
                this.wbBuf = default;
                this.runSafePointFn = default;
                this.timersLock = default;
                this.timers = default;
                this.numTimers = default;
                this.adjustTimers = default;
                this.deletedTimers = default;
                this.timerRaceCtx = default;
                this.preempt = default;
                this.pad = default;
            }

            public p(int id = default, uint status = default, puintptr link = default, uint schedtick = default, uint syscalltick = default, sysmontick sysmontick = default, muintptr m = default, ref ptr<mcache> mcache = default, pageCache pcache = default, System.UIntPtr raceprocctx = default, array<slice<ptr<_defer>>> deferpool = default, array<array<ptr<_defer>>> deferpoolbuf = default, ulong goidcache = default, ulong goidcacheend = default, uint runqhead = default, uint runqtail = default, array<guintptr> runq = default, guintptr runnext = default, slice<ptr<sudog>> sudogcache = default, array<ptr<sudog>> sudogbuf = default, traceBufPtr tracebuf = default, bool traceSweep = default, System.UIntPtr traceSwept = default, System.UIntPtr traceReclaimed = default, persistentAlloc palloc = default, uint _ = default, ulong timer0When = default, long gcAssistTime = default, long gcFractionalMarkTime = default, guintptr gcBgMarkWorker = default, gcMarkWorkerMode gcMarkWorkerMode = default, long gcMarkWorkerStartTime = default, gcWork gcw = default, wbBuf wbBuf = default, uint runSafePointFn = default, mutex timersLock = default, slice<ptr<timer>> timers = default, uint numTimers = default, uint adjustTimers = default, uint deletedTimers = default, System.UIntPtr timerRaceCtx = default, bool preempt = default, cpu.CacheLinePad pad = default)
            {
                this.id = id;
                this.status = status;
                this.link = link;
                this.schedtick = schedtick;
                this.syscalltick = syscalltick;
                this.sysmontick = sysmontick;
                this.m = m;
                this.mcache = mcache;
                this.pcache = pcache;
                this.raceprocctx = raceprocctx;
                this.deferpool = deferpool;
                this.deferpoolbuf = deferpoolbuf;
                this.goidcache = goidcache;
                this.goidcacheend = goidcacheend;
                this.runqhead = runqhead;
                this.runqtail = runqtail;
                this.runq = runq;
                this.runnext = runnext;
                this.sudogcache = sudogcache;
                this.sudogbuf = sudogbuf;
                this.tracebuf = tracebuf;
                this.traceSweep = traceSweep;
                this.traceSwept = traceSwept;
                this.traceReclaimed = traceReclaimed;
                this.palloc = palloc;
                this._ = _;
                this.timer0When = timer0When;
                this.gcAssistTime = gcAssistTime;
                this.gcFractionalMarkTime = gcFractionalMarkTime;
                this.gcBgMarkWorker = gcBgMarkWorker;
                this.gcMarkWorkerMode = gcMarkWorkerMode;
                this.gcMarkWorkerStartTime = gcMarkWorkerStartTime;
                this.gcw = gcw;
                this.wbBuf = wbBuf;
                this.runSafePointFn = runSafePointFn;
                this.timersLock = timersLock;
                this.timers = timers;
                this.numTimers = numTimers;
                this.adjustTimers = adjustTimers;
                this.deletedTimers = deletedTimers;
                this.timerRaceCtx = timerRaceCtx;
                this.preempt = preempt;
                this.pad = pad;
            }

            // Enable comparisons between nil and p struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(p value, NilType nil) => value.Equals(default(p));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(p value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, p value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, p value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator p(NilType nil) => default(p);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static p p_cast(dynamic value)
        {
            return new p(value.id, value.status, value.link, value.schedtick, value.syscalltick, value.sysmontick, value.m, ref value.mcache, value.pcache, value.raceprocctx, value.deferpool, value.deferpoolbuf, value.goidcache, value.goidcacheend, value.runqhead, value.runqtail, value.runq, value.runnext, value.sudogcache, value.sudogbuf, value.tracebuf, value.traceSweep, value.traceSwept, value.traceReclaimed, value.palloc, value._, value.timer0When, value.gcAssistTime, value.gcFractionalMarkTime, value.gcBgMarkWorker, value.gcMarkWorkerMode, value.gcMarkWorkerStartTime, value.gcw, value.wbBuf, value.runSafePointFn, value.timersLock, value.timers, value.numTimers, value.adjustTimers, value.deletedTimers, value.timerRaceCtx, value.preempt, value.pad);
        }
    }
}