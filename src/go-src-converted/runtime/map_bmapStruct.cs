//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using math = go.runtime.@internal.math_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bmap
        {
            // Constructors
            public bmap(NilType _)
            {
                this.tophash = default;
            }

            public bmap(array<byte> tophash = default)
            {
                this.tophash = tophash;
            }

            // Enable comparisons between nil and bmap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bmap value, NilType nil) => value.Equals(default(bmap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bmap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bmap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bmap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bmap(NilType nil) => default(bmap);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bmap bmap_cast(dynamic value)
        {
            return new bmap(value.tophash);
        }
    }
}