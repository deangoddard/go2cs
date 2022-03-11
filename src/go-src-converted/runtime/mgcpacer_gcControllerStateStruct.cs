//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:09:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gcControllerState
        {
            // Constructors
            public gcControllerState(NilType _)
            {
                this.gcPercent = default;
                this._ = default;
                this.heapMinimum = default;
                this.triggerRatio = default;
                this.trigger = default;
                this.heapGoal = default;
                this.lastHeapGoal = default;
                this.heapLive = default;
                this.heapScan = default;
                this.heapMarked = default;
                this.scanWork = default;
                this.bgScanCredit = default;
                this.assistTime = default;
                this.dedicatedMarkTime = default;
                this.fractionalMarkTime = default;
                this.idleMarkTime = default;
                this.markStartTime = default;
                this.dedicatedMarkWorkersNeeded = default;
                this.assistWorkPerByte = default;
                this.assistBytesPerWork = default;
                this.fractionalUtilizationGoal = default;
                this._ = default;
            }

            public gcControllerState(int gcPercent = default, uint _ = default, ulong heapMinimum = default, double triggerRatio = default, ulong trigger = default, ulong heapGoal = default, ulong lastHeapGoal = default, ulong heapLive = default, ulong heapScan = default, ulong heapMarked = default, long scanWork = default, long bgScanCredit = default, long assistTime = default, long dedicatedMarkTime = default, long fractionalMarkTime = default, long idleMarkTime = default, long markStartTime = default, long dedicatedMarkWorkersNeeded = default, ulong assistWorkPerByte = default, ulong assistBytesPerWork = default, double fractionalUtilizationGoal = default, cpu.CacheLinePad _ = default)
            {
                this.gcPercent = gcPercent;
                this._ = _;
                this.heapMinimum = heapMinimum;
                this.triggerRatio = triggerRatio;
                this.trigger = trigger;
                this.heapGoal = heapGoal;
                this.lastHeapGoal = lastHeapGoal;
                this.heapLive = heapLive;
                this.heapScan = heapScan;
                this.heapMarked = heapMarked;
                this.scanWork = scanWork;
                this.bgScanCredit = bgScanCredit;
                this.assistTime = assistTime;
                this.dedicatedMarkTime = dedicatedMarkTime;
                this.fractionalMarkTime = fractionalMarkTime;
                this.idleMarkTime = idleMarkTime;
                this.markStartTime = markStartTime;
                this.dedicatedMarkWorkersNeeded = dedicatedMarkWorkersNeeded;
                this.assistWorkPerByte = assistWorkPerByte;
                this.assistBytesPerWork = assistBytesPerWork;
                this.fractionalUtilizationGoal = fractionalUtilizationGoal;
                this._ = _;
            }

            // Enable comparisons between nil and gcControllerState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcControllerState value, NilType nil) => value.Equals(default(gcControllerState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcControllerState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcControllerState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcControllerState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcControllerState(NilType nil) => default(gcControllerState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gcControllerState gcControllerState_cast(dynamic value)
        {
            return new gcControllerState(value.gcPercent, value._, value.heapMinimum, value.triggerRatio, value.trigger, value.heapGoal, value.lastHeapGoal, value.heapLive, value.heapScan, value.heapMarked, value.scanWork, value.bgScanCredit, value.assistTime, value.dedicatedMarkTime, value.fractionalMarkTime, value.idleMarkTime, value.markStartTime, value.dedicatedMarkWorkersNeeded, value.assistWorkPerByte, value.assistBytesPerWork, value.fractionalUtilizationGoal, value._);
        }
    }
}