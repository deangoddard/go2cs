//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:59:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace text {
namespace template
{
    public static partial class parse_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ChainNode
        {
            // Constructors
            public ChainNode(NilType _)
            {
                this.NodeType = default;
                this.Pos = default;
                this.tr = default;
                this.Node = default;
                this.Field = default;
            }

            public ChainNode(NodeType NodeType = default, Pos Pos = default, ref ptr<Tree> tr = default, Node Node = default, slice<@string> Field = default)
            {
                this.NodeType = NodeType;
                this.Pos = Pos;
                this.tr = tr;
                this.Node = Node;
                this.Field = Field;
            }

            // Enable comparisons between nil and ChainNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ChainNode value, NilType nil) => value.Equals(default(ChainNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ChainNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ChainNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ChainNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ChainNode(NilType nil) => default(ChainNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ChainNode ChainNode_cast(dynamic value)
        {
            return new ChainNode(value.NodeType, value.Pos, ref value.tr, value.Node, value.Field);
        }
    }
}}}