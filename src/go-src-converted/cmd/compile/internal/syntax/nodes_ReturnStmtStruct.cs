//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using src = go.cmd.@internal.src_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(stmt))]
        public partial struct ReturnStmt
        {
            // stmt structure promotion - sourced from value copy
            private readonly ptr<stmt> m_stmtRef;

            private ref stmt stmt_val => ref m_stmtRef.Value;

            // Constructors
            public ReturnStmt(NilType _)
            {
                this.Results = default;
                this.m_stmtRef = new ptr<stmt>(new stmt(nil));
            }

            public ReturnStmt(Expr Results = default, stmt stmt = default)
            {
                this.Results = Results;
                this.m_stmtRef = new ptr<stmt>(stmt);
            }

            // Enable comparisons between nil and ReturnStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ReturnStmt value, NilType nil) => value.Equals(default(ReturnStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ReturnStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ReturnStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ReturnStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ReturnStmt(NilType nil) => default(ReturnStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ReturnStmt ReturnStmt_cast(dynamic value)
        {
            return new ReturnStmt(value.Results, value.stmt);
        }
    }
}}}}