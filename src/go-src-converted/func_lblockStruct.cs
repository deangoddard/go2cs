//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lblock
        {
            // Constructors
            public lblock(NilType _)
            {
                this._goto = default;
                this._break = default;
                this._continue = default;
            }

            public lblock(ref ptr<BasicBlock> _goto = default, ref ptr<BasicBlock> _break = default, ref ptr<BasicBlock> _continue = default)
            {
                this._goto = _goto;
                this._break = _break;
                this._continue = _continue;
            }

            // Enable comparisons between nil and lblock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lblock value, NilType nil) => value.Equals(default(lblock));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lblock value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lblock value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lblock value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lblock(NilType nil) => default(lblock);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lblock lblock_cast(dynamic value)
        {
            return new lblock(ref value._goto, ref value._break, ref value._continue);
        }
    }
}}}}}