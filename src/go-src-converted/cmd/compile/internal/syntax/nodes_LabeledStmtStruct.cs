//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:40:45 UTC
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
        public partial struct LabeledStmt
        {
            // stmt structure promotion - sourced from value copy
            private readonly ptr<stmt> m_stmtRef;

            private ref stmt stmt_val => ref m_stmtRef.Value;

            // Constructors
            public LabeledStmt(NilType _)
            {
                this.Label = default;
                this.Stmt = default;
                this.m_stmtRef = new ptr<stmt>(new stmt(nil));
            }

            public LabeledStmt(ref ptr<Name> Label = default, Stmt Stmt = default, stmt stmt = default)
            {
                this.Label = Label;
                this.Stmt = Stmt;
                this.m_stmtRef = new ptr<stmt>(stmt);
            }

            // Enable comparisons between nil and LabeledStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LabeledStmt value, NilType nil) => value.Equals(default(LabeledStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LabeledStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LabeledStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LabeledStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LabeledStmt(NilType nil) => default(LabeledStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LabeledStmt LabeledStmt_cast(dynamic value)
        {
            return new LabeledStmt(ref value.Label, value.Stmt, value.stmt);
        }
    }
}}}}