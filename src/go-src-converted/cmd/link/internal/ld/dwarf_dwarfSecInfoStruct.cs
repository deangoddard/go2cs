//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:49:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using dwarf = go.cmd.@internal.dwarf_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using fmt = go.fmt_package;
using log = go.log_package;
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
        private partial struct dwarfSecInfo
        {
            // Constructors
            public dwarfSecInfo(NilType _)
            {
                this.syms = default;
            }

            public dwarfSecInfo(slice<loader.Sym> syms = default)
            {
                this.syms = syms;
            }

            // Enable comparisons between nil and dwarfSecInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dwarfSecInfo value, NilType nil) => value.Equals(default(dwarfSecInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dwarfSecInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dwarfSecInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dwarfSecInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dwarfSecInfo(NilType nil) => default(dwarfSecInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dwarfSecInfo dwarfSecInfo_cast(dynamic value)
        {
            return new dwarfSecInfo(value.syms);
        }
    }
}}}}