//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:25:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using fmt = go.fmt_package;
using bits = go.math.bits_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct use
        {
            // Constructors
            public use(NilType _)
            {
                this.dist = default;
                this.pos = default;
                this.next = default;
            }

            public use(int dist = default, src.XPos pos = default, ref ptr<use> next = default)
            {
                this.dist = dist;
                this.pos = pos;
                this.next = next;
            }

            // Enable comparisons between nil and use struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(use value, NilType nil) => value.Equals(default(use));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(use value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, use value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, use value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator use(NilType nil) => default(use);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static use use_cast(dynamic value)
        {
            return new use(value.dist, value.pos, ref value.next);
        }
    }
}}}}