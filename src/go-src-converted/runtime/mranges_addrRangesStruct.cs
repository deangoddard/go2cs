//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:21:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct addrRanges
        {
            // Constructors
            public addrRanges(NilType _)
            {
                this.ranges = default;
                this.totalBytes = default;
                this.sysStat = default;
            }

            public addrRanges(slice<addrRange> ranges = default, System.UIntPtr totalBytes = default, ref ptr<ulong> sysStat = default)
            {
                this.ranges = ranges;
                this.totalBytes = totalBytes;
                this.sysStat = sysStat;
            }

            // Enable comparisons between nil and addrRanges struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(addrRanges value, NilType nil) => value.Equals(default(addrRanges));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(addrRanges value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, addrRanges value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, addrRanges value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator addrRanges(NilType nil) => default(addrRanges);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static addrRanges addrRanges_cast(dynamic value)
        {
            return new addrRanges(value.ranges, value.totalBytes, ref value.sysStat);
        }
    }
}