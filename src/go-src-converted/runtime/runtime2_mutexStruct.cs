//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:08 UTC
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
        private partial struct mutex
        {
            // Constructors
            public mutex(NilType _)
            {
                this.lockRankStruct = default;
                this.key = default;
            }

            public mutex(lockRankStruct lockRankStruct = default, System.UIntPtr key = default)
            {
                this.lockRankStruct = lockRankStruct;
                this.key = key;
            }

            // Enable comparisons between nil and mutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mutex value, NilType nil) => value.Equals(default(mutex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mutex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mutex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mutex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mutex(NilType nil) => default(mutex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mutex mutex_cast(dynamic value)
        {
            return new mutex(value.lockRankStruct, value.key);
        }
    }
}