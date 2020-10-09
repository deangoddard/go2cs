//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sync = go.sync_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(anInstruction))]
        private partial struct register
        {
            // anInstruction structure promotion - sourced from value copy
            private readonly ptr<anInstruction> m_anInstructionRef;

            private ref anInstruction anInstruction_val => ref m_anInstructionRef.Value;

            public ref ptr<BasicBlock> block => ref m_anInstructionRef.Value.block;

            // Constructors
            public register(NilType _)
            {
                this.m_anInstructionRef = new ptr<anInstruction>(new anInstruction(nil));
                this.num = default;
                this.typ = default;
                this.pos = default;
                this.referrers = default;
            }

            public register(anInstruction anInstruction = default, long num = default, types.Type typ = default, token.Pos pos = default, slice<Instruction> referrers = default)
            {
                this.m_anInstructionRef = new ptr<anInstruction>(anInstruction);
                this.num = num;
                this.typ = typ;
                this.pos = pos;
                this.referrers = referrers;
            }

            // Enable comparisons between nil and register struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(register value, NilType nil) => value.Equals(default(register));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(register value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, register value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, register value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator register(NilType nil) => default(register);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static register register_cast(dynamic value)
        {
            return new register(value.anInstruction, value.num, value.typ, value.pos, value.referrers);
        }
    }
}}}}}