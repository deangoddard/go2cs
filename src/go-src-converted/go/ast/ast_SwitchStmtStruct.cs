//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:18:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        public partial struct SwitchStmt
        {
            // Constructors
            public SwitchStmt(NilType _)
            {
                this.Switch = default;
                this.Init = default;
                this.Tag = default;
                this.Body = default;
            }

            public SwitchStmt(token.Pos Switch = default, Stmt Init = default, Expr Tag = default, ref ptr<BlockStmt> Body = default)
            {
                this.Switch = Switch;
                this.Init = Init;
                this.Tag = Tag;
                this.Body = Body;
            }

            // Enable comparisons between nil and SwitchStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SwitchStmt value, NilType nil) => value.Equals(default(SwitchStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SwitchStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SwitchStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SwitchStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SwitchStmt(NilType nil) => default(SwitchStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SwitchStmt SwitchStmt_cast(dynamic value)
        {
            return new SwitchStmt(value.Switch, value.Init, value.Tag, ref value.Body);
        }
    }
}}