//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:03 UTC
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
        [PromotedStruct(typeof(simpleStmt))]
        public partial struct SendStmt
        {
            // simpleStmt structure promotion - sourced from value copy
            private readonly ptr<simpleStmt> m_simpleStmtRef;

            private ref simpleStmt simpleStmt_val => ref m_simpleStmtRef.Value;

            // Constructors
            public SendStmt(NilType _)
            {
                this.Chan = default;
                this.Value = default;
                this.m_simpleStmtRef = new ptr<simpleStmt>(new simpleStmt(nil));
            }

            public SendStmt(Expr Chan = default, Expr Value = default, simpleStmt simpleStmt = default)
            {
                this.Chan = Chan;
                this.Value = Value;
                this.m_simpleStmtRef = new ptr<simpleStmt>(simpleStmt);
            }

            // Enable comparisons between nil and SendStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SendStmt value, NilType nil) => value.Equals(default(SendStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SendStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SendStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SendStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SendStmt(NilType nil) => default(SendStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SendStmt SendStmt_cast(dynamic value)
        {
            return new SendStmt(value.Chan, value.Value, value.simpleStmt);
        }
    }
}}}}