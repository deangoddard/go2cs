//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using token = go.go.token_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IfStmt
        {
            // Constructors
            public IfStmt(NilType _)
            {
                this.If = default;
                this.Init = default;
                this.Cond = default;
                this.Body = default;
                this.Else = default;
            }

            public IfStmt(token.Pos If = default, Stmt Init = default, Expr Cond = default, ref ptr<BlockStmt> Body = default, Stmt Else = default)
            {
                this.If = If;
                this.Init = Init;
                this.Cond = Cond;
                this.Body = Body;
                this.Else = Else;
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
            return new IfStmt(value.If, value.Init, value.Cond, ref value.Body, value.Else);
        }
    }
}}