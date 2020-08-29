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
        public partial struct BoolNode
        {
            // Constructors
            public BoolNode(NilType _)
            {
                this.NodeType = default;
                this.Pos = default;
                this.tr = default;
                this.True = default;
            }

            public BoolNode(NodeType NodeType = default, Pos Pos = default, ref ptr<Tree> tr = default, bool True = default)
            {
                this.NodeType = NodeType;
                this.Pos = Pos;
                this.tr = tr;
                this.True = True;
            }

            // Enable comparisons between nil and BoolNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BoolNode value, NilType nil) => value.Equals(default(BoolNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BoolNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BoolNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BoolNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BoolNode(NilType nil) => default(BoolNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BoolNode BoolNode_cast(dynamic value)
        {
            return new BoolNode(value.NodeType, value.Pos, ref value.tr, value.True);
        }
    }
}}}