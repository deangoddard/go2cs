//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:47:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(StackRecord))]
        public partial struct BlockProfileRecord
        {
            // StackRecord structure promotion - sourced from value copy
            private readonly ptr<StackRecord> m_StackRecordRef;

            private ref StackRecord StackRecord_val => ref m_StackRecordRef.Value;

            public ref array<System.UIntPtr> Stack0 => ref m_StackRecordRef.Value.Stack0;

            // Constructors
            public BlockProfileRecord(NilType _)
            {
                this.Count = default;
                this.Cycles = default;
                this.m_StackRecordRef = new ptr<StackRecord>(new StackRecord(nil));
            }

            public BlockProfileRecord(long Count = default, long Cycles = default, StackRecord StackRecord = default)
            {
                this.Count = Count;
                this.Cycles = Cycles;
                this.m_StackRecordRef = new ptr<StackRecord>(StackRecord);
            }

            // Enable comparisons between nil and BlockProfileRecord struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BlockProfileRecord value, NilType nil) => value.Equals(default(BlockProfileRecord));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BlockProfileRecord value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BlockProfileRecord value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BlockProfileRecord value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BlockProfileRecord(NilType nil) => default(BlockProfileRecord);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BlockProfileRecord BlockProfileRecord_cast(dynamic value)
        {
            return new BlockProfileRecord(value.Count, value.Cycles, value.StackRecord);
        }
    }
}