//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:26:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct g
        {
            // Constructors
            public g(NilType _)
            {
                this.stack = default;
                this.stackguard0 = default;
                this.stackguard1 = default;
                this._panic = default;
                this._defer = default;
                this.m = default;
                this.sched = default;
                this.syscallsp = default;
                this.syscallpc = default;
                this.stktopsp = default;
                this.param = default;
                this.atomicstatus = default;
                this.stackLock = default;
                this.goid = default;
                this.schedlink = default;
                this.waitsince = default;
                this.waitreason = default;
                this.preempt = default;
                this.preemptStop = default;
                this.preemptShrink = default;
                this.asyncSafePoint = default;
                this.paniconfault = default;
                this.gcscandone = default;
                this.throwsplit = default;
                this.activeStackChans = default;
                this.parkingOnChan = default;
                this.raceignore = default;
                this.sysblocktraced = default;
                this.tracking = default;
                this.trackingSeq = default;
                this.runnableStamp = default;
                this.runnableTime = default;
                this.sysexitticks = default;
                this.traceseq = default;
                this.tracelastp = default;
                this.lockedm = default;
                this.sig = default;
                this.writebuf = default;
                this.sigcode0 = default;
                this.sigcode1 = default;
                this.sigpc = default;
                this.gopc = default;
                this.ancestors = default;
                this.startpc = default;
                this.racectx = default;
                this.waiting = default;
                this.cgoCtxt = default;
                this.labels = default;
                this.timer = default;
                this.selectDone = default;
                this.gcAssistBytes = default;
            }

            public g(stack stack = default, System.UIntPtr stackguard0 = default, System.UIntPtr stackguard1 = default, ref ptr<_panic> _panic = default, ref ptr<_defer> _defer = default, ref ptr<m> m = default, gobuf sched = default, System.UIntPtr syscallsp = default, System.UIntPtr syscallpc = default, System.UIntPtr stktopsp = default, unsafe.Pointer param = default, uint atomicstatus = default, uint stackLock = default, long goid = default, guintptr schedlink = default, long waitsince = default, waitReason waitreason = default, bool preempt = default, bool preemptStop = default, bool preemptShrink = default, bool asyncSafePoint = default, bool paniconfault = default, bool gcscandone = default, bool throwsplit = default, bool activeStackChans = default, byte parkingOnChan = default, sbyte raceignore = default, bool sysblocktraced = default, bool tracking = default, byte trackingSeq = default, long runnableStamp = default, long runnableTime = default, long sysexitticks = default, ulong traceseq = default, puintptr tracelastp = default, muintptr lockedm = default, uint sig = default, slice<byte> writebuf = default, System.UIntPtr sigcode0 = default, System.UIntPtr sigcode1 = default, System.UIntPtr sigpc = default, System.UIntPtr gopc = default, ref ptr<slice<ancestorInfo>> ancestors = default, System.UIntPtr startpc = default, System.UIntPtr racectx = default, ref ptr<sudog> waiting = default, slice<System.UIntPtr> cgoCtxt = default, unsafe.Pointer labels = default, ref ptr<timer> timer = default, uint selectDone = default, long gcAssistBytes = default)
            {
                this.stack = stack;
                this.stackguard0 = stackguard0;
                this.stackguard1 = stackguard1;
                this._panic = _panic;
                this._defer = _defer;
                this.m = m;
                this.sched = sched;
                this.syscallsp = syscallsp;
                this.syscallpc = syscallpc;
                this.stktopsp = stktopsp;
                this.param = param;
                this.atomicstatus = atomicstatus;
                this.stackLock = stackLock;
                this.goid = goid;
                this.schedlink = schedlink;
                this.waitsince = waitsince;
                this.waitreason = waitreason;
                this.preempt = preempt;
                this.preemptStop = preemptStop;
                this.preemptShrink = preemptShrink;
                this.asyncSafePoint = asyncSafePoint;
                this.paniconfault = paniconfault;
                this.gcscandone = gcscandone;
                this.throwsplit = throwsplit;
                this.activeStackChans = activeStackChans;
                this.parkingOnChan = parkingOnChan;
                this.raceignore = raceignore;
                this.sysblocktraced = sysblocktraced;
                this.tracking = tracking;
                this.trackingSeq = trackingSeq;
                this.runnableStamp = runnableStamp;
                this.runnableTime = runnableTime;
                this.sysexitticks = sysexitticks;
                this.traceseq = traceseq;
                this.tracelastp = tracelastp;
                this.lockedm = lockedm;
                this.sig = sig;
                this.writebuf = writebuf;
                this.sigcode0 = sigcode0;
                this.sigcode1 = sigcode1;
                this.sigpc = sigpc;
                this.gopc = gopc;
                this.ancestors = ancestors;
                this.startpc = startpc;
                this.racectx = racectx;
                this.waiting = waiting;
                this.cgoCtxt = cgoCtxt;
                this.labels = labels;
                this.timer = timer;
                this.selectDone = selectDone;
                this.gcAssistBytes = gcAssistBytes;
            }

            // Enable comparisons between nil and g struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(g value, NilType nil) => value.Equals(default(g));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(g value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, g value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, g value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator g(NilType nil) => default(g);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static g g_cast(dynamic value)
        {
            return new g(value.stack, value.stackguard0, value.stackguard1, ref value._panic, ref value._defer, ref value.m, value.sched, value.syscallsp, value.syscallpc, value.stktopsp, value.param, value.atomicstatus, value.stackLock, value.goid, value.schedlink, value.waitsince, value.waitreason, value.preempt, value.preemptStop, value.preemptShrink, value.asyncSafePoint, value.paniconfault, value.gcscandone, value.throwsplit, value.activeStackChans, value.parkingOnChan, value.raceignore, value.sysblocktraced, value.tracking, value.trackingSeq, value.runnableStamp, value.runnableTime, value.sysexitticks, value.traceseq, value.tracelastp, value.lockedm, value.sig, value.writebuf, value.sigcode0, value.sigcode1, value.sigpc, value.gopc, ref value.ancestors, value.startpc, value.racectx, ref value.waiting, value.cgoCtxt, value.labels, ref value.timer, value.selectDone, value.gcAssistBytes);
        }
    }
}