//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dumper
        {
            // Constructors
            public dumper(NilType _)
            {
                this.output = default;
                this.ptrmap = default;
                this.indent = default;
                this.last = default;
                this.line = default;
            }

            public dumper(io.Writer output = default, map<Node, long> ptrmap = default, long indent = default, byte last = default, long line = default)
            {
                this.output = output;
                this.ptrmap = ptrmap;
                this.indent = indent;
                this.last = last;
                this.line = line;
            }

            // Enable comparisons between nil and dumper struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dumper value, NilType nil) => value.Equals(default(dumper));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dumper value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dumper value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dumper value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dumper(NilType nil) => default(dumper);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dumper dumper_cast(dynamic value)
        {
            return new dumper(value.output, value.ptrmap, value.indent, value.last, value.line);
        }
    }
}}}}