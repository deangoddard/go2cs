//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:49:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using sha1 = go.crypto.sha1_package;
using binary = go.encoding.binary_package;
using hex = go.encoding.hex_package;
using io = go.io_package;
using filepath = go.path.filepath_package;
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
        public partial struct ElfShdr
        {
            // Constructors
            public ElfShdr(NilType _)
            {
                this.name = default;
                this.type_ = default;
                this.flags = default;
                this.addr = default;
                this.off = default;
                this.size = default;
                this.link = default;
                this.info = default;
                this.addralign = default;
                this.entsize = default;
                this.shnum = default;
            }

            public ElfShdr(uint name = default, uint type_ = default, ulong flags = default, ulong addr = default, ulong off = default, ulong size = default, uint link = default, uint info = default, ulong addralign = default, ulong entsize = default, long shnum = default)
            {
                this.name = name;
                this.type_ = type_;
                this.flags = flags;
                this.addr = addr;
                this.off = off;
                this.size = size;
                this.link = link;
                this.info = info;
                this.addralign = addralign;
                this.entsize = entsize;
                this.shnum = shnum;
            }

            // Enable comparisons between nil and ElfShdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ElfShdr value, NilType nil) => value.Equals(default(ElfShdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ElfShdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ElfShdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ElfShdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ElfShdr(NilType nil) => default(ElfShdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ElfShdr ElfShdr_cast(dynamic value)
        {
            return new ElfShdr(value.name, value.type_, value.flags, value.addr, value.off, value.size, value.link, value.info, value.addralign, value.entsize, value.shnum);
        }
    }
}}}}