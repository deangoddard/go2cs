//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:22:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using goobj = go.cmd.@internal.goobj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
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
        private partial struct pclntab
        {
            // Constructors
            public pclntab(NilType _)
            {
                this.funcSize = default;
                this.firstFunc = default;
                this.lastFunc = default;
                this.size = default;
                this.carrier = default;
                this.pclntab = default;
                this.pcheader = default;
                this.funcnametab = default;
                this.findfunctab = default;
                this.cutab = default;
                this.filetab = default;
                this.pctab = default;
                this.nfunc = default;
                this.nfiles = default;
            }

            public pclntab(uint funcSize = default, loader.Sym firstFunc = default, loader.Sym lastFunc = default, long size = default, loader.Sym carrier = default, loader.Sym pclntab = default, loader.Sym pcheader = default, loader.Sym funcnametab = default, loader.Sym findfunctab = default, loader.Sym cutab = default, loader.Sym filetab = default, loader.Sym pctab = default, int nfunc = default, uint nfiles = default)
            {
                this.funcSize = funcSize;
                this.firstFunc = firstFunc;
                this.lastFunc = lastFunc;
                this.size = size;
                this.carrier = carrier;
                this.pclntab = pclntab;
                this.pcheader = pcheader;
                this.funcnametab = funcnametab;
                this.findfunctab = findfunctab;
                this.cutab = cutab;
                this.filetab = filetab;
                this.pctab = pctab;
                this.nfunc = nfunc;
                this.nfiles = nfiles;
            }

            // Enable comparisons between nil and pclntab struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pclntab value, NilType nil) => value.Equals(default(pclntab));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pclntab value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pclntab value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pclntab value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pclntab(NilType nil) => default(pclntab);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pclntab pclntab_cast(dynamic value)
        {
            return new pclntab(value.funcSize, value.firstFunc, value.lastFunc, value.size, value.carrier, value.pclntab, value.pcheader, value.funcnametab, value.findfunctab, value.cutab, value.filetab, value.pctab, value.nfunc, value.nfiles);
        }
    }
}}}}