//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:58:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constraint = go.go.build.constraint_package;
using token = go.go.token_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using unicode = go.unicode_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class printer_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct commentInfo
        {
            // Constructors
            public commentInfo(NilType _)
            {
                this.cindex = default;
                this.comment = default;
                this.commentOffset = default;
                this.commentNewline = default;
            }

            public commentInfo(nint cindex = default, ref ptr<ast.CommentGroup> comment = default, nint commentOffset = default, bool commentNewline = default)
            {
                this.cindex = cindex;
                this.comment = comment;
                this.commentOffset = commentOffset;
                this.commentNewline = commentNewline;
            }

            // Enable comparisons between nil and commentInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(commentInfo value, NilType nil) => value.Equals(default(commentInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(commentInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, commentInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, commentInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator commentInfo(NilType nil) => default(commentInfo);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static commentInfo commentInfo_cast(dynamic value)
        {
            return new commentInfo(value.cindex, ref value.comment, value.commentOffset, value.commentNewline);
        }
    }
}}