//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:00:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ir_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct typeNode
        {
            // Constructors
            public typeNode(NilType _)
            {
                this.miniNode = default;
                this.typ = default;
            }

            public typeNode(miniNode miniNode = default, ref ptr<types.Type> typ = default)
            {
                this.miniNode = miniNode;
                this.typ = typ;
            }

            // Enable comparisons between nil and typeNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeNode value, NilType nil) => value.Equals(default(typeNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeNode(NilType nil) => default(typeNode);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static typeNode typeNode_cast(dynamic value)
        {
            return new typeNode(value.miniNode, ref value.typ);
        }
    }
}}}}