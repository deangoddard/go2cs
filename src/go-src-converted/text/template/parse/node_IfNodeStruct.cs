//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace text {
namespace template
{
    public static partial class parse_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(BranchNode))]
        public partial struct IfNode
        {
            // BranchNode structure promotion - sourced from value copy
            private readonly ptr<BranchNode> m_BranchNodeRef;

            private ref BranchNode BranchNode_val => ref m_BranchNodeRef.Value;

            public ref ptr<Tree> tr => ref m_BranchNodeRef.Value.tr;

            public ref long Line => ref m_BranchNodeRef.Value.Line;

            public ref ptr<PipeNode> Pipe => ref m_BranchNodeRef.Value.Pipe;

            public ref ptr<ListNode> List => ref m_BranchNodeRef.Value.List;

            public ref ptr<ListNode> ElseList => ref m_BranchNodeRef.Value.ElseList;

            // Constructors
            public IfNode(NilType _)
            {
                this.m_BranchNodeRef = new ptr<BranchNode>(new BranchNode(nil));
            }

            public IfNode(BranchNode BranchNode = default)
            {
                this.m_BranchNodeRef = new ptr<BranchNode>(BranchNode);
            }

            // Enable comparisons between nil and IfNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfNode value, NilType nil) => value.Equals(default(IfNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfNode(NilType nil) => default(IfNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfNode IfNode_cast(dynamic value)
        {
            return new IfNode(value.BranchNode);
        }
    }
}}}