//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using src = go.cmd.@internal.src_package;
using list = go.container.list_package;
using gosym = go.debug.gosym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using armasm = go.golang.org.x.arch.arm.armasm_package;
using arm64asm = go.golang.org.x.arch.arm64.arm64asm_package;
using ppc64asm = go.golang.org.x.arch.ppc64.ppc64asm_package;
using x86asm = go.golang.org.x.arch.x86.x86asm_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class objfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct textReader
        {
            // Constructors
            public textReader(NilType _)
            {
                this.code = default;
                this.pc = default;
            }

            public textReader(slice<byte> code = default, ulong pc = default)
            {
                this.code = code;
                this.pc = pc;
            }

            // Enable comparisons between nil and textReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(textReader value, NilType nil) => value.Equals(default(textReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(textReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, textReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, textReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator textReader(NilType nil) => default(textReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static textReader textReader_cast(dynamic value)
        {
            return new textReader(value.code, value.pc);
        }
    }
}}}