//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using token = go.go.token_package;
using go;

namespace go {
namespace go
{
    public static partial class doc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Value
        {
            // Constructors
            public Value(NilType _)
            {
                this.Doc = default;
                this.Names = default;
                this.Decl = default;
                this.order = default;
            }

            public Value(@string Doc = default, slice<@string> Names = default, ref ptr<ast.GenDecl> Decl = default, long order = default)
            {
                this.Doc = Doc;
                this.Names = Names;
                this.Decl = Decl;
                this.order = order;
            }

            // Enable comparisons between nil and Value struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Value value, NilType nil) => value.Equals(default(Value));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Value value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Value value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Value value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Value(NilType nil) => default(Value);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Value Value_cast(dynamic value)
        {
            return new Value(value.Doc, value.Names, ref value.Decl, value.order);
        }
    }
}}