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
        public partial struct NilExpr
        {
            // miniExpr structure promotion - sourced from value copy
            private readonly ptr<miniExpr> m_miniExprRef;

            private ref miniExpr miniExpr_val => ref m_miniExprRef.Value;

            public ref ptr<types.Type> typ => ref m_miniExprRef.Value.typ;

            public ref Nodes init => ref m_miniExprRef.Value.init;

            public ref bitset8 flags => ref m_miniExprRef.Value.flags;

            // Constructors
            public NilExpr(NilType _)
            {
                this.m_miniExprRef = new ptr<miniExpr>(new miniExpr(nil));
                this.Sym_ = default;
            }

            public NilExpr(miniExpr miniExpr = default, ref ptr<types.Sym> Sym_ = default)
            {
                this.m_miniExprRef = new ptr<miniExpr>(miniExpr);
                this.Sym_ = Sym_;
            }

            // Enable comparisons between nil and NilExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilExpr value, NilType nil) => value.Equals(default(NilExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NilExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NilExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NilExpr(NilType nil) => default(NilExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NilExpr NilExpr_cast(dynamic value)
        {
            return new NilExpr(value.miniExpr, ref value.Sym_);
        }
    }
}}}}