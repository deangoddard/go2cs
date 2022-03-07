//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:10 UTC
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
        [PromotedStruct(typeof(stmt))]
        public partial struct IfStmt
        {
            // stmt structure promotion - sourced from value copy
            private readonly ptr<stmt> m_stmtRef;

            private ref stmt stmt_val => ref m_stmtRef.Value;

            // Constructors
            public IfStmt(NilType _)
            {
                this.Init = default;
                this.Cond = default;
                this.Then = default;
                this.Else = default;
                this.m_stmtRef = new ptr<stmt>(new stmt(nil));
            }

            public IfStmt(SimpleStmt Init = default, Expr Cond = default, ref ptr<BlockStmt> Then = default, Stmt Else = default, stmt stmt = default)
            {
                this.Init = Init;
                this.Cond = Cond;
                this.Then = Then;
                this.Else = Else;
                this.m_stmtRef = new ptr<stmt>(stmt);
            }

            // Enable comparisons between nil and IfStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfStmt value, NilType nil) => value.Equals(default(IfStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfStmt(NilType nil) => default(IfStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfStmt IfStmt_cast(dynamic value)
        {
            return new IfStmt(value.Init, value.Cond, ref value.Then, value.Else, value.stmt);
        }
    }
}}}}