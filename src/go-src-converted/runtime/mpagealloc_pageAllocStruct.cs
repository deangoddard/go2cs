//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:47:02 UTC
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
        private partial struct pageAlloc
        {
            // Constructors
            public pageAlloc(NilType _)
            {
                this.summary = default;
                this.chunks = default;
                this.searchAddr = default;
                this.start = default;
                this.end = default;
                this.inUse = default;
                this.mheapLock = default;
                this.sysStat = default;
                this.test = default;
            }

            public pageAlloc(array<slice<pallocSum>> summary = default, array<ptr<array<pallocData>>> chunks = default, offAddr searchAddr = default, chunkIdx start = default, chunkIdx end = default, addrRanges inUse = default, ref ptr<mutex> mheapLock = default, ref ptr<ulong> sysStat = default, bool test = default)
            {
                this.summary = summary;
                this.chunks = chunks;
                this.searchAddr = searchAddr;
                this.start = start;
                this.end = end;
                this.inUse = inUse;
                this.mheapLock = mheapLock;
                this.sysStat = sysStat;
                this.test = test;
            }

            // Enable comparisons between nil and pageAlloc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pageAlloc value, NilType nil) => value.Equals(default(pageAlloc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pageAlloc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pageAlloc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pageAlloc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pageAlloc(NilType nil) => default(pageAlloc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pageAlloc pageAlloc_cast(dynamic value)
        {
            return new pageAlloc(value.summary, value.chunks, value.searchAddr, value.start, value.end, value.inUse, ref value.mheapLock, ref value.sysStat, value.test);
        }
    }
}