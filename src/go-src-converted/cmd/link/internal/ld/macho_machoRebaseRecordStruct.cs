//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:21:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using codesign = go.cmd.@internal.codesign_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using macho = go.debug.macho_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using io = go.io_package;
using os = go.os_package;
using sort = go.sort_package;
using strings = go.strings_package;
using @unsafe = go.@unsafe_package;
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
        private partial struct machoRebaseRecord
        {
            // Constructors
            public machoRebaseRecord(NilType _)
            {
                this.sym = default;
                this.off = default;
            }

            public machoRebaseRecord(loader.Sym sym = default, long off = default)
            {
                this.sym = sym;
                this.off = off;
            }

            // Enable comparisons between nil and machoRebaseRecord struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(machoRebaseRecord value, NilType nil) => value.Equals(default(machoRebaseRecord));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(machoRebaseRecord value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, machoRebaseRecord value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, machoRebaseRecord value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator machoRebaseRecord(NilType nil) => default(machoRebaseRecord);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static machoRebaseRecord machoRebaseRecord_cast(dynamic value)
        {
            return new machoRebaseRecord(value.sym, value.off);
        }
    }
}}}}