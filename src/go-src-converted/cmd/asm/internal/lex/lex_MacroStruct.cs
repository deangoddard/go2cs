//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:57:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using log = go.log_package;
using os = go.os_package;
using strings = go.strings_package;
using scanner = go.text.scanner_package;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Macro
        {
            // Constructors
            public Macro(NilType _)
            {
                this.name = default;
                this.args = default;
                this.tokens = default;
            }

            public Macro(@string name = default, slice<@string> args = default, slice<Token> tokens = default)
            {
                this.name = name;
                this.args = args;
                this.tokens = tokens;
            }

            // Enable comparisons between nil and Macro struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Macro value, NilType nil) => value.Equals(default(Macro));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Macro value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Macro value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Macro value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Macro(NilType nil) => default(Macro);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Macro Macro_cast(dynamic value)
        {
            return new Macro(value.name, value.args, value.tokens);
        }
    }
}}}}