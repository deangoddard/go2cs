//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct BranchNode
        {
            // Constructors
            public BranchNode(NilType _)
            {
                this.NodeType = default;
                this.Pos = default;
                this.tr = default;
                this.Line = default;
                this.Pipe = default;
                this.List = default;
                this.ElseList = default;
            }

            public BranchNode(NodeType NodeType = default, Pos Pos = default, ref ptr<Tree> tr = default, nint Line = default, ref ptr<PipeNode> Pipe = default, ref ptr<ListNode> List = default, ref ptr<ListNode> ElseList = default)
            {
                this.NodeType = NodeType;
                this.Pos = Pos;
                this.tr = tr;
                this.Line = Line;
                this.Pipe = Pipe;
                this.List = List;
                this.ElseList = ElseList;
            }

            // Enable comparisons between nil and BranchNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BranchNode value, NilType nil) => value.Equals(default(BranchNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BranchNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BranchNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BranchNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BranchNode(NilType nil) => default(BranchNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BranchNode BranchNode_cast(dynamic value)
        {
            return new BranchNode(value.NodeType, value.Pos, ref value.tr, value.Line, ref value.Pipe, ref value.List, ref value.ElseList);
        }
    }
}}}