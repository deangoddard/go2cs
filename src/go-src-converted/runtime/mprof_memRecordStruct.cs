//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct memRecord
        {
            // Constructors
            public memRecord(NilType _)
            {
                this.active = default;
                this.future = default;
            }

            public memRecord(memRecordCycle active = default, array<memRecordCycle> future = default)
            {
                this.active = active;
                this.future = future;
            }

            // Enable comparisons between nil and memRecord struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(memRecord value, NilType nil) => value.Equals(default(memRecord));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(memRecord value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, memRecord value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, memRecord value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator memRecord(NilType nil) => default(memRecord);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static memRecord memRecord_cast(dynamic value)
        {
            return new memRecord(value.active, value.future);
        }
    }
}