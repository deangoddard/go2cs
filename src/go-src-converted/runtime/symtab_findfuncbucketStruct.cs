//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct findfuncbucket
        {
            // Constructors
            public findfuncbucket(NilType _)
            {
                this.idx = default;
                this.subbuckets = default;
            }

            public findfuncbucket(uint idx = default, array<byte> subbuckets = default)
            {
                this.idx = idx;
                this.subbuckets = subbuckets;
            }

            // Enable comparisons between nil and findfuncbucket struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(findfuncbucket value, NilType nil) => value.Equals(default(findfuncbucket));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(findfuncbucket value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, findfuncbucket value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, findfuncbucket value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator findfuncbucket(NilType nil) => default(findfuncbucket);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static findfuncbucket findfuncbucket_cast(dynamic value)
        {
            return new findfuncbucket(value.idx, value.subbuckets);
        }
    }
}