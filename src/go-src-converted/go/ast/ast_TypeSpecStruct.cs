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
        public partial struct TypeSpec
        {
            // Constructors
            public TypeSpec(NilType _)
            {
                this.Doc = default;
                this.Name = default;
                this.Assign = default;
                this.Type = default;
                this.Comment = default;
            }

            public TypeSpec(ref ptr<CommentGroup> Doc = default, ref ptr<Ident> Name = default, token.Pos Assign = default, Expr Type = default, ref ptr<CommentGroup> Comment = default)
            {
                this.Doc = Doc;
                this.Name = Name;
                this.Assign = Assign;
                this.Type = Type;
                this.Comment = Comment;
            }

            // Enable comparisons between nil and TypeSpec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TypeSpec value, NilType nil) => value.Equals(default(TypeSpec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TypeSpec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TypeSpec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TypeSpec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TypeSpec(NilType nil) => default(TypeSpec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TypeSpec TypeSpec_cast(dynamic value)
        {
            return new TypeSpec(ref value.Doc, ref value.Name, value.Assign, value.Type, ref value.Comment);
        }
    }
}}