//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:42 UTC
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
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BlockStmt
        {
            // Constructors
            public BlockStmt(NilType _)
            {
                this.Lbrace = default;
                this.List = default;
                this.Rbrace = default;
            }

            public BlockStmt(token.Pos Lbrace = default, slice<Stmt> List = default, token.Pos Rbrace = default)
            {
                this.Lbrace = Lbrace;
                this.List = List;
                this.Rbrace = Rbrace;
            }

            // Enable comparisons between nil and BlockStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BlockStmt value, NilType nil) => value.Equals(default(BlockStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BlockStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BlockStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BlockStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BlockStmt(NilType nil) => default(BlockStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BlockStmt BlockStmt_cast(dynamic value)
        {
            return new BlockStmt(value.Lbrace, value.List, value.Rbrace);
        }
    }
}}