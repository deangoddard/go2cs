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
        private partial struct dwctxt2
        {
            // Constructors
            public dwctxt2(NilType _)
            {
                this.linkctxt = default;
                this.ldr = default;
                this.arch = default;
                this.tmap = default;
                this.rtmap = default;
                this.tdmap = default;
                this.typeRuntimeEface = default;
                this.typeRuntimeIface = default;
                this.uintptrInfoSym = default;
            }

            public dwctxt2(ref ptr<Link> linkctxt = default, ref ptr<loader.Loader> ldr = default, ref ptr<sys.Arch> arch = default, map<@string, loader.Sym> tmap = default, map<loader.Sym, loader.Sym> rtmap = default, map<loader.Sym, loader.Sym> tdmap = default, loader.Sym typeRuntimeEface = default, loader.Sym typeRuntimeIface = default, loader.Sym uintptrInfoSym = default)
            {
                this.linkctxt = linkctxt;
                this.ldr = ldr;
                this.arch = arch;
                this.tmap = tmap;
                this.rtmap = rtmap;
                this.tdmap = tdmap;
                this.typeRuntimeEface = typeRuntimeEface;
                this.typeRuntimeIface = typeRuntimeIface;
                this.uintptrInfoSym = uintptrInfoSym;
            }

            // Enable comparisons between nil and dwctxt2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dwctxt2 value, NilType nil) => value.Equals(default(dwctxt2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dwctxt2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dwctxt2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dwctxt2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dwctxt2(NilType nil) => default(dwctxt2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dwctxt2 dwctxt2_cast(dynamic value)
        {
            return new dwctxt2(ref value.linkctxt, ref value.ldr, ref value.arch, value.tmap, value.rtmap, value.tdmap, value.typeRuntimeEface, value.typeRuntimeIface, value.uintptrInfoSym);
        }
    }
}}}}