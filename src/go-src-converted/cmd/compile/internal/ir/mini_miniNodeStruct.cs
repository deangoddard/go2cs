//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ir_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct miniNode
        {
            // Constructors
            public miniNode(NilType _)
            {
                this.pos = default;
                this.op = default;
                this.bits = default;
                this.esc = default;
            }

            public miniNode(src.XPos pos = default, Op op = default, bitset8 bits = default, ushort esc = default)
            {
                this.pos = pos;
                this.op = op;
                this.bits = bits;
                this.esc = esc;
            }

            // Enable comparisons between nil and miniNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(miniNode value, NilType nil) => value.Equals(default(miniNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(miniNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, miniNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, miniNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator miniNode(NilType nil) => default(miniNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static miniNode miniNode_cast(dynamic value)
        {
            return new miniNode(value.pos, value.op, value.bits, value.esc);
        }
    }
}}}}