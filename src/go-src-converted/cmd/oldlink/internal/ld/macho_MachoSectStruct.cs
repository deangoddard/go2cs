//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using macho = go.debug.macho_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MachoSect
        {
            // Constructors
            public MachoSect(NilType _)
            {
                this.name = default;
                this.segname = default;
                this.addr = default;
                this.size = default;
                this.off = default;
                this.align = default;
                this.reloc = default;
                this.nreloc = default;
                this.flag = default;
                this.res1 = default;
                this.res2 = default;
            }

            public MachoSect(@string name = default, @string segname = default, ulong addr = default, ulong size = default, uint off = default, uint align = default, uint reloc = default, uint nreloc = default, uint flag = default, uint res1 = default, uint res2 = default)
            {
                this.name = name;
                this.segname = segname;
                this.addr = addr;
                this.size = size;
                this.off = off;
                this.align = align;
                this.reloc = reloc;
                this.nreloc = nreloc;
                this.flag = flag;
                this.res1 = res1;
                this.res2 = res2;
            }

            // Enable comparisons between nil and MachoSect struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MachoSect value, NilType nil) => value.Equals(default(MachoSect));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MachoSect value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MachoSect value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MachoSect value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MachoSect(NilType nil) => default(MachoSect);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MachoSect MachoSect_cast(dynamic value)
        {
            return new MachoSect(value.name, value.segname, value.addr, value.size, value.off, value.align, value.reloc, value.nreloc, value.flag, value.res1, value.res2);
        }
    }
}}}}