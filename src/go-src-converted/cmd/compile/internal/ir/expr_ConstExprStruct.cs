//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using @base = go.cmd.compile.@internal.@base_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
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
        [PromotedStruct(typeof(miniExpr))]
        public partial struct ConstExpr
        {
            // miniExpr structure promotion - sourced from value copy
            private readonly ptr<miniExpr> m_miniExprRef;

            private ref miniExpr miniExpr_val => ref m_miniExprRef.Value;

            public ref ptr<types.Type> typ => ref m_miniExprRef.Value.typ;

            public ref Nodes init => ref m_miniExprRef.Value.init;

            public ref bitset8 flags => ref m_miniExprRef.Value.flags;

            // Constructors
            public ConstExpr(NilType _)
            {
                this.m_miniExprRef = new ptr<miniExpr>(new miniExpr(nil));
                this.origNode = default;
                this.val = default;
            }

            public ConstExpr(miniExpr miniExpr = default, origNode origNode = default, constant.Value val = default)
            {
                this.m_miniExprRef = new ptr<miniExpr>(miniExpr);
                this.origNode = origNode;
                this.val = val;
            }

            // Enable comparisons between nil and ConstExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ConstExpr value, NilType nil) => value.Equals(default(ConstExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ConstExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ConstExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ConstExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ConstExpr(NilType nil) => default(ConstExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ConstExpr ConstExpr_cast(dynamic value)
        {
            return new ConstExpr(value.miniExpr, value.origNode, value.val);
        }
    }
}}}}