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
        private partial struct anInstruction
        {
            // Constructors
            public anInstruction(NilType _)
            {
                this.block = default;
            }

            public anInstruction(ref ptr<BasicBlock> block = default)
            {
                this.block = block;
            }

            // Enable comparisons between nil and anInstruction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(anInstruction value, NilType nil) => value.Equals(default(anInstruction));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(anInstruction value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, anInstruction value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, anInstruction value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator anInstruction(NilType nil) => default(anInstruction);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static anInstruction anInstruction_cast(dynamic value)
        {
            return new anInstruction(ref value.block);
        }
    }
}}}}}