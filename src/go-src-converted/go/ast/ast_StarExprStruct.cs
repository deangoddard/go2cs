//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:15 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct StarExpr
        {
            // Constructors
            public StarExpr(NilType _)
            {
                this.Star = default;
                this.X = default;
            }

            public StarExpr(token.Pos Star = default, Expr X = default)
            {
                this.Star = Star;
                this.X = X;
            }

            // Enable comparisons between nil and StarExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StarExpr value, NilType nil) => value.Equals(default(StarExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StarExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StarExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StarExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StarExpr(NilType nil) => default(StarExpr);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static StarExpr StarExpr_cast(dynamic value)
        {
            return new StarExpr(value.Star, value.X);
        }
    }
}}