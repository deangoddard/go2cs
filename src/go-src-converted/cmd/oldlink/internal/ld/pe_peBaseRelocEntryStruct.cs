//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:33 UTC
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
using sym = go.cmd.oldlink.@internal.sym_package;
using pe = go.debug.pe_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
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
        private partial struct peBaseRelocEntry
        {
            // Constructors
            public peBaseRelocEntry(NilType _)
            {
                this.typeOff = default;
                this.rel = default;
                this.sym = default;
            }

            public peBaseRelocEntry(ushort typeOff = default, ref ptr<sym.Reloc> rel = default, ref ptr<sym.Symbol> sym = default)
            {
                this.typeOff = typeOff;
                this.rel = rel;
                this.sym = sym;
            }

            // Enable comparisons between nil and peBaseRelocEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(peBaseRelocEntry value, NilType nil) => value.Equals(default(peBaseRelocEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(peBaseRelocEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, peBaseRelocEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, peBaseRelocEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator peBaseRelocEntry(NilType nil) => default(peBaseRelocEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static peBaseRelocEntry peBaseRelocEntry_cast(dynamic value)
        {
            return new peBaseRelocEntry(value.typeOff, ref value.rel, ref value.sym);
        }
    }
}}}}