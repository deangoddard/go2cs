//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:51:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using ir = go.cmd.compile.@internal.ir_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
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
        private partial struct liveInfo
        {
            // Constructors
            public liveInfo(NilType _)
            {
                this.ID = default;
                this.dist = default;
                this.pos = default;
            }

            public liveInfo(ID ID = default, int dist = default, src.XPos pos = default)
            {
                this.ID = ID;
                this.dist = dist;
                this.pos = pos;
            }

            // Enable comparisons between nil and liveInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(liveInfo value, NilType nil) => value.Equals(default(liveInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(liveInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, liveInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, liveInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator liveInfo(NilType nil) => default(liveInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static liveInfo liveInfo_cast(dynamic value)
        {
            return new liveInfo(value.ID, value.dist, value.pos);
        }
    }
}}}}