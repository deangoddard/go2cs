//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:40:44 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct BadExpr
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public BadExpr(NilType _)
            {
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public BadExpr(expr expr = default)
            {
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and BadExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BadExpr value, NilType nil) => value.Equals(default(BadExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BadExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BadExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BadExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BadExpr(NilType nil) => default(BadExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BadExpr BadExpr_cast(dynamic value)
        {
            return new BadExpr(value.expr);
        }
    }
}}}}