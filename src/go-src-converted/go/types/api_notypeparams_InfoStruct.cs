//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ast = go.go.ast_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Info
        {
            // Constructors
            public Info(NilType _)
            {
                this.Types = default;
                this.Defs = default;
                this.Uses = default;
                this.Implicits = default;
                this.Selections = default;
                this.Scopes = default;
                this.InitOrder = default;
            }

            public Info(map<ast.Expr, TypeAndValue> Types = default, map<ptr<ast.Ident>, Object> Defs = default, map<ptr<ast.Ident>, Object> Uses = default, map<ast.Node, Object> Implicits = default, map<ptr<ast.SelectorExpr>, ptr<Selection>> Selections = default, map<ast.Node, ptr<Scope>> Scopes = default, slice<ptr<Initializer>> InitOrder = default)
            {
                this.Types = Types;
                this.Defs = Defs;
                this.Uses = Uses;
                this.Implicits = Implicits;
                this.Selections = Selections;
                this.Scopes = Scopes;
                this.InitOrder = InitOrder;
            }

            // Enable comparisons between nil and Info struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Info value, NilType nil) => value.Equals(default(Info));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Info value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Info value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Info value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Info(NilType nil) => default(Info);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Info Info_cast(dynamic value)
        {
            return new Info(value.Types, value.Defs, value.Uses, value.Implicits, value.Selections, value.Scopes, value.InitOrder);
        }
    }
}}