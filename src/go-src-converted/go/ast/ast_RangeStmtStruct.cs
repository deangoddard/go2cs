//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:43 UTC
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
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RangeStmt
        {
            // Constructors
            public RangeStmt(NilType _)
            {
                this.For = default;
                this.Key = default;
                this.Value = default;
                this.TokPos = default;
                this.Tok = default;
                this.X = default;
                this.Body = default;
            }

            public RangeStmt(token.Pos For = default, Expr Key = default, Expr Value = default, token.Pos TokPos = default, token.Token Tok = default, Expr X = default, ref ptr<BlockStmt> Body = default)
            {
                this.For = For;
                this.Key = Key;
                this.Value = Value;
                this.TokPos = TokPos;
                this.Tok = Tok;
                this.X = X;
                this.Body = Body;
            }

            // Enable comparisons between nil and RangeStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RangeStmt value, NilType nil) => value.Equals(default(RangeStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RangeStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RangeStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RangeStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RangeStmt(NilType nil) => default(RangeStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RangeStmt RangeStmt_cast(dynamic value)
        {
            return new RangeStmt(value.For, value.Key, value.Value, value.TokPos, value.Tok, value.X, ref value.Body);
        }
    }
}}