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
        public partial struct IfStmt
        {
            // miniStmt structure promotion - sourced from value copy
            private readonly ptr<miniStmt> m_miniStmtRef;

            private ref miniStmt miniStmt_val => ref m_miniStmtRef.Value;

            public ref Nodes init => ref m_miniStmtRef.Value.init;

            // Constructors
            public IfStmt(NilType _)
            {
                this.m_miniStmtRef = new ptr<miniStmt>(new miniStmt(nil));
                this.Cond = default;
                this.Body = default;
                this.Else = default;
                this.Likely = default;
            }

            public IfStmt(miniStmt miniStmt = default, Node Cond = default, Nodes Body = default, Nodes Else = default, bool Likely = default)
            {
                this.m_miniStmtRef = new ptr<miniStmt>(miniStmt);
                this.Cond = Cond;
                this.Body = Body;
                this.Else = Else;
                this.Likely = Likely;
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

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static IfStmt IfStmt_cast(dynamic value)
        {
            return new IfStmt(value.miniStmt, value.Cond, value.Body, value.Else, value.Likely);
        }
    }
}}}}