//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using token = go.go.token_package;
using types = go.go.types_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using atomic = go.sync.atomic_package;
using ssa = go.golang.org.x.tools.go.ssa_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace ssa
{
    public static partial class interp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct frame
        {
            // Constructors
            public frame(NilType _)
            {
                this.i = default;
                this.caller = default;
                this.fn = default;
                this.block = default;
                this.prevBlock = default;
                this.env = default;
                this.locals = default;
                this.defers = default;
                this.result = default;
                this.panicking = default;
            }

            public frame(ref ptr<interpreter> i = default, ref ptr<frame> caller = default, ref ptr<ssa.Function> fn = default, ref ptr<ssa.BasicBlock> block = default, ref ptr<ssa.BasicBlock> prevBlock = default, map<ssa.Value, value> env = default, slice<value> locals = default, ref ptr<deferred> defers = default, value result = default, bool panicking = default)
            {
                this.i = i;
                this.caller = caller;
                this.fn = fn;
                this.block = block;
                this.prevBlock = prevBlock;
                this.env = env;
                this.locals = locals;
                this.defers = defers;
                this.result = result;
                this.panicking = panicking;
            }

            // Enable comparisons between nil and frame struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(frame value, NilType nil) => value.Equals(default(frame));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(frame value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, frame value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, frame value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator frame(NilType nil) => default(frame);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static frame frame_cast(dynamic value)
        {
            return new frame(ref value.i, ref value.caller, ref value.fn, ref value.block, ref value.prevBlock, value.env, value.locals, ref value.defers, value.result, value.panicking);
        }
    }
}}}}}}