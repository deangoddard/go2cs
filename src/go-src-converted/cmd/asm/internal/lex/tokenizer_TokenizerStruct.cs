//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:23:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using scanner = go.text.scanner_package;
using unicode = go.unicode_package;
using flags = go.cmd.asm.@internal.flags_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace asm {
namespace @internal
{
    public static partial class lex_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Tokenizer
        {
            // Constructors
            public Tokenizer(NilType _)
            {
                this.tok = default;
                this.s = default;
                this.@base = default;
                this.line = default;
                this.file = default;
            }

            public Tokenizer(ScanToken tok = default, ref ptr<scanner.Scanner> s = default, ref ptr<src.PosBase> @base = default, long line = default, ref ptr<os.File> file = default)
            {
                this.tok = tok;
                this.s = s;
                this.@base = @base;
                this.line = line;
                this.file = file;
            }

            // Enable comparisons between nil and Tokenizer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tokenizer value, NilType nil) => value.Equals(default(Tokenizer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tokenizer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tokenizer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tokenizer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tokenizer(NilType nil) => default(Tokenizer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tokenizer Tokenizer_cast(dynamic value)
        {
            return new Tokenizer(value.tok, ref value.s, ref value.@base, value.line, ref value.file);
        }
    }
}}}}