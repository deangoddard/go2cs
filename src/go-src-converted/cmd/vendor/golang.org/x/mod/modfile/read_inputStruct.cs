//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:26:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct input
        {
            // Constructors
            public input(NilType _)
            {
                this.filename = default;
                this.complete = default;
                this.remaining = default;
                this.tokenStart = default;
                this.token = default;
                this.pos = default;
                this.comments = default;
                this.file = default;
                this.parseErrors = default;
                this.pre = default;
                this.post = default;
            }

            public input(@string filename = default, slice<byte> complete = default, slice<byte> remaining = default, slice<byte> tokenStart = default, token token = default, Position pos = default, slice<Comment> comments = default, ref ptr<FileSyntax> file = default, ErrorList parseErrors = default, slice<Expr> pre = default, slice<Expr> post = default)
            {
                this.filename = filename;
                this.complete = complete;
                this.remaining = remaining;
                this.tokenStart = tokenStart;
                this.token = token;
                this.pos = pos;
                this.comments = comments;
                this.file = file;
                this.parseErrors = parseErrors;
                this.pre = pre;
                this.post = post;
            }

            // Enable comparisons between nil and input struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(input value, NilType nil) => value.Equals(default(input));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(input value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, input value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, input value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator input(NilType nil) => default(input);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static input input_cast(dynamic value)
        {
            return new input(value.filename, value.complete, value.remaining, value.tokenStart, value.token, value.pos, value.comments, ref value.file, value.parseErrors, value.pre, value.post);
        }
    }
}}}}}}