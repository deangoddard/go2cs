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
        public partial struct Field
        {
            // Constructors
            public Field(NilType _)
            {
                this.Doc = default;
                this.Names = default;
                this.Type = default;
                this.Tag = default;
                this.Comment = default;
            }

            public Field(ref ptr<CommentGroup> Doc = default, slice<ptr<Ident>> Names = default, Expr Type = default, ref ptr<BasicLit> Tag = default, ref ptr<CommentGroup> Comment = default)
            {
                this.Doc = Doc;
                this.Names = Names;
                this.Type = Type;
                this.Tag = Tag;
                this.Comment = Comment;
            }

            // Enable comparisons between nil and Field struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Field value, NilType nil) => value.Equals(default(Field));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Field value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Field value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Field value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Field(NilType nil) => default(Field);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Field Field_cast(dynamic value)
        {
            return new Field(ref value.Doc, value.Names, value.Type, ref value.Tag, ref value.Comment);
        }
    }
}}