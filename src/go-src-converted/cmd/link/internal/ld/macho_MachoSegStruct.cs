//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:50:06 UTC
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
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
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
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MachoSeg
        {
            // Constructors
            public MachoSeg(NilType _)
            {
                this.name = default;
                this.vsize = default;
                this.vaddr = default;
                this.fileoffset = default;
                this.filesize = default;
                this.prot1 = default;
                this.prot2 = default;
                this.nsect = default;
                this.msect = default;
                this.sect = default;
                this.flag = default;
            }

            public MachoSeg(@string name = default, ulong vsize = default, ulong vaddr = default, ulong fileoffset = default, ulong filesize = default, uint prot1 = default, uint prot2 = default, uint nsect = default, uint msect = default, slice<MachoSect> sect = default, uint flag = default)
            {
                this.name = name;
                this.vsize = vsize;
                this.vaddr = vaddr;
                this.fileoffset = fileoffset;
                this.filesize = filesize;
                this.prot1 = prot1;
                this.prot2 = prot2;
                this.nsect = nsect;
                this.msect = msect;
                this.sect = sect;
                this.flag = flag;
            }

            // Enable comparisons between nil and MachoSeg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MachoSeg value, NilType nil) => value.Equals(default(MachoSeg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MachoSeg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MachoSeg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MachoSeg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MachoSeg(NilType nil) => default(MachoSeg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MachoSeg MachoSeg_cast(dynamic value)
        {
            return new MachoSeg(value.name, value.vsize, value.vaddr, value.fileoffset, value.filesize, value.prot1, value.prot2, value.nsect, value.msect, value.sect, value.flag);
        }
    }
}}}}