//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct context
        {
            // Constructors
            public context(NilType _)
            {
                this.decl = default;
                this.scope = default;
                this.pos = default;
                this.iota = default;
                this.sig = default;
                this.isPanic = default;
                this.hasLabel = default;
                this.hasCallOrRecv = default;
            }

            public context(ref ptr<declInfo> decl = default, ref ptr<Scope> scope = default, token.Pos pos = default, constant.Value iota = default, ref ptr<Signature> sig = default, map<ptr<ast.CallExpr>, bool> isPanic = default, bool hasLabel = default, bool hasCallOrRecv = default)
            {
                this.decl = decl;
                this.scope = scope;
                this.pos = pos;
                this.iota = iota;
                this.sig = sig;
                this.isPanic = isPanic;
                this.hasLabel = hasLabel;
                this.hasCallOrRecv = hasCallOrRecv;
            }

            // Enable comparisons between nil and context struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(context value, NilType nil) => value.Equals(default(context));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(context value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, context value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, context value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator context(NilType nil) => default(context);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static context context_cast(dynamic value)
        {
            return new context(ref value.decl, ref value.scope, value.pos, value.iota, ref value.sig, value.isPanic, value.hasLabel, value.hasCallOrRecv);
        }
    }
}}