//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:22:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct SparseTreeNode
        {
            // Constructors
            public SparseTreeNode(NilType _)
            {
                this.child = default;
                this.sibling = default;
                this.parent = default;
                this.entry = default;
                this.exit = default;
            }

            public SparseTreeNode(ref ptr<Block> child = default, ref ptr<Block> sibling = default, ref ptr<Block> parent = default, int entry = default, int exit = default)
            {
                this.child = child;
                this.sibling = sibling;
                this.parent = parent;
                this.entry = entry;
                this.exit = exit;
            }

            // Enable comparisons between nil and SparseTreeNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SparseTreeNode value, NilType nil) => value.Equals(default(SparseTreeNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SparseTreeNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SparseTreeNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SparseTreeNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SparseTreeNode(NilType nil) => default(SparseTreeNode);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static SparseTreeNode SparseTreeNode_cast(dynamic value)
        {
            return new SparseTreeNode(ref value.child, ref value.sibling, ref value.parent, value.entry, value.exit);
        }
    }
}}}}