//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using token = go.go.token_package;
using sort = go.sort_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct commentListReader
        {
            // Constructors
            public commentListReader(NilType _)
            {
                this.fset = default;
                this.list = default;
                this.index = default;
                this.comment = default;
                this.pos = default;
                this.end = default;
            }

            public commentListReader(ref ptr<token.FileSet> fset = default, slice<ref CommentGroup> list = default, long index = default, ref ptr<CommentGroup> comment = default, token.Position pos = default, token.Position end = default)
            {
                this.fset = fset;
                this.list = list;
                this.index = index;
                this.comment = comment;
                this.pos = pos;
                this.end = end;
            }

            // Enable comparisons between nil and commentListReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(commentListReader value, NilType nil) => value.Equals(default(commentListReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(commentListReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, commentListReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, commentListReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator commentListReader(NilType nil) => default(commentListReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static commentListReader commentListReader_cast(dynamic value)
        {
            return new commentListReader(ref value.fset, value.list, value.index, ref value.comment, value.pos, value.end);
        }
    }
}}