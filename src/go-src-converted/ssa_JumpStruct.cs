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
        public partial struct Jump
        {
            // anInstruction structure promotion - sourced from value copy
            private readonly ptr<anInstruction> m_anInstructionRef;

            private ref anInstruction anInstruction_val => ref m_anInstructionRef.Value;

            public ref ptr<BasicBlock> block => ref m_anInstructionRef.Value.block;

            // Constructors
            public Jump(NilType _)
            {
                this.m_anInstructionRef = new ptr<anInstruction>(new anInstruction(nil));
            }

            public Jump(anInstruction anInstruction = default)
            {
                this.m_anInstructionRef = new ptr<anInstruction>(anInstruction);
            }

            // Enable comparisons between nil and Jump struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Jump value, NilType nil) => value.Equals(default(Jump));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Jump value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Jump value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Jump value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Jump(NilType nil) => default(Jump);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Jump Jump_cast(dynamic value)
        {
            return new Jump(value.anInstruction);
        }
    }
}}}}}