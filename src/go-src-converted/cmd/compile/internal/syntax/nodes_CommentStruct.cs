//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Comment
        {
            // Constructors
            public Comment(NilType _)
            {
                this.Kind = default;
                this.Text = default;
                this.Next = default;
            }

            public Comment(CommentKind Kind = default, @string Text = default, ref ptr<Comment> Next = default)
            {
                this.Kind = Kind;
                this.Text = Text;
                this.Next = Next;
            }

            // Enable comparisons between nil and Comment struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Comment value, NilType nil) => value.Equals(default(Comment));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Comment value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Comment value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Comment value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Comment(NilType nil) => default(Comment);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Comment Comment_cast(dynamic value)
        {
            return new Comment(value.Kind, value.Text, ref value.Next);
        }
    }
}}}}