//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:26:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct SliceExpr
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public SliceExpr(NilType _)
            {
                this.X = default;
                this.Index = default;
                this.Full = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public SliceExpr(Expr X = default, array<Expr> Index = default, bool Full = default, expr expr = default)
            {
                this.X = X;
                this.Index = Index;
                this.Full = Full;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and SliceExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SliceExpr value, NilType nil) => value.Equals(default(SliceExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SliceExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SliceExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SliceExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SliceExpr(NilType nil) => default(SliceExpr);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static SliceExpr SliceExpr_cast(dynamic value)
        {
            return new SliceExpr(value.X, value.Index, value.Full, value.expr);
        }
    }
}}}}