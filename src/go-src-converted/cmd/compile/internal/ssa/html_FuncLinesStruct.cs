//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:50:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using html = go.html_package;
using exec = go.@internal.execabs_package;
using io = go.io_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FuncLines
        {
            // Constructors
            public FuncLines(NilType _)
            {
                this.Filename = default;
                this.StartLineno = default;
                this.Lines = default;
            }

            public FuncLines(@string Filename = default, nuint StartLineno = default, slice<@string> Lines = default)
            {
                this.Filename = Filename;
                this.StartLineno = StartLineno;
                this.Lines = Lines;
            }

            // Enable comparisons between nil and FuncLines struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FuncLines value, NilType nil) => value.Equals(default(FuncLines));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FuncLines value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FuncLines value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FuncLines value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncLines(NilType nil) => default(FuncLines);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FuncLines FuncLines_cast(dynamic value)
        {
            return new FuncLines(value.Filename, value.StartLineno, value.Lines);
        }
    }
}}}}