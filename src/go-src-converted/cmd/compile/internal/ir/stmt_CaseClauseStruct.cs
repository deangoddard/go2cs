//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:00:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ir_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(miniStmt))]
        public partial struct CaseClause
        {
            // miniStmt structure promotion - sourced from value copy
            private readonly ptr<miniStmt> m_miniStmtRef;

            private ref miniStmt miniStmt_val => ref m_miniStmtRef.Value;

            public ref Nodes init => ref m_miniStmtRef.Value.init;

            // Constructors
            public CaseClause(NilType _)
            {
                this.m_miniStmtRef = new ptr<miniStmt>(new miniStmt(nil));
                this.Var = default;
                this.List = default;
                this.Body = default;
            }

            public CaseClause(miniStmt miniStmt = default, ref ptr<Name> Var = default, Nodes List = default, Nodes Body = default)
            {
                this.m_miniStmtRef = new ptr<miniStmt>(miniStmt);
                this.Var = Var;
                this.List = List;
                this.Body = Body;
            }

            // Enable comparisons between nil and CaseClause struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CaseClause value, NilType nil) => value.Equals(default(CaseClause));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CaseClause value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CaseClause value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CaseClause value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CaseClause(NilType nil) => default(CaseClause);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static CaseClause CaseClause_cast(dynamic value)
        {
            return new CaseClause(value.miniStmt, ref value.Var, value.List, value.Body);
        }
    }
}}}}