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
        private partial struct simpleStmt
        {
            // stmt structure promotion - sourced from value copy
            private readonly ptr<stmt> m_stmtRef;

            private ref stmt stmt_val => ref m_stmtRef.Value;

            // Constructors
            public simpleStmt(NilType _)
            {
                this.m_stmtRef = new ptr<stmt>(new stmt(nil));
            }

            public simpleStmt(stmt stmt = default)
            {
                this.m_stmtRef = new ptr<stmt>(stmt);
            }

            // Enable comparisons between nil and simpleStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(simpleStmt value, NilType nil) => value.Equals(default(simpleStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(simpleStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, simpleStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, simpleStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator simpleStmt(NilType nil) => default(simpleStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static simpleStmt simpleStmt_cast(dynamic value)
        {
            return new simpleStmt(value.stmt);
        }
    }
}}}}