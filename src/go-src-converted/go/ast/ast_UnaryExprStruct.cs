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
        public partial struct UnaryExpr
        {
            // Constructors
            public UnaryExpr(NilType _)
            {
                this.OpPos = default;
                this.Op = default;
                this.X = default;
            }

            public UnaryExpr(token.Pos OpPos = default, token.Token Op = default, Expr X = default)
            {
                this.OpPos = OpPos;
                this.Op = Op;
                this.X = X;
            }

            // Enable comparisons between nil and UnaryExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnaryExpr value, NilType nil) => value.Equals(default(UnaryExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnaryExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnaryExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnaryExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnaryExpr(NilType nil) => default(UnaryExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UnaryExpr UnaryExpr_cast(dynamic value)
        {
            return new UnaryExpr(value.OpPos, value.Op, value.X);
        }
    }
}}