//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct Panic
        {
            // anInstruction structure promotion - sourced from value copy
            private readonly ptr<anInstruction> m_anInstructionRef;

            private ref anInstruction anInstruction_val => ref m_anInstructionRef.Value;

            public ref ptr<BasicBlock> block => ref m_anInstructionRef.Value.block;

            // Constructors
            public Panic(NilType _)
            {
                this.m_anInstructionRef = new ptr<anInstruction>(new anInstruction(nil));
                this.X = default;
                this.pos = default;
            }

            public Panic(anInstruction anInstruction = default, Value X = default, token.Pos pos = default)
            {
                this.m_anInstructionRef = new ptr<anInstruction>(anInstruction);
                this.X = X;
                this.pos = pos;
            }

            // Enable comparisons between nil and Panic struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Panic value, NilType nil) => value.Equals(default(Panic));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Panic value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Panic value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Panic value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Panic(NilType nil) => default(Panic);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Panic Panic_cast(dynamic value)
        {
            return new Panic(value.anInstruction, value.X, value.pos);
        }
    }
}}}}}