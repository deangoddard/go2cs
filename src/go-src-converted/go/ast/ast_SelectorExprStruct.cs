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
        public partial struct SelectorExpr
        {
            // Constructors
            public SelectorExpr(NilType _)
            {
                this.X = default;
                this.Sel = default;
            }

            public SelectorExpr(Expr X = default, ref ptr<Ident> Sel = default)
            {
                this.X = X;
                this.Sel = Sel;
            }

            // Enable comparisons between nil and SelectorExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SelectorExpr value, NilType nil) => value.Equals(default(SelectorExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SelectorExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SelectorExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SelectorExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SelectorExpr(NilType nil) => default(SelectorExpr);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static SelectorExpr SelectorExpr_cast(dynamic value)
        {
            return new SelectorExpr(value.X, ref value.Sel);
        }
    }
}}