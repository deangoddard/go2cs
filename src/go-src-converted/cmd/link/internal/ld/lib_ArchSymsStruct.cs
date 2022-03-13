//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:34:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using goobj = go.cmd.@internal.goobj_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loadelf = go.cmd.link.@internal.loadelf_package;
using loader = go.cmd.link.@internal.loader_package;
using loadmacho = go.cmd.link.@internal.loadmacho_package;
using loadpe = go.cmd.link.@internal.loadpe_package;
using loadxcoff = go.cmd.link.@internal.loadxcoff_package;
using sym = go.cmd.link.@internal.sym_package;
using sha1 = go.crypto.sha1_package;
using elf = go.debug.elf_package;
using macho = go.debug.macho_package;
using base64 = go.encoding.base64_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using exec = go.@internal.execabs_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct ArchSyms
        {
            // Constructors
            public ArchSyms(NilType _)
            {
                this.Rel = default;
                this.Rela = default;
                this.RelPLT = default;
                this.RelaPLT = default;
                this.LinkEditGOT = default;
                this.LinkEditPLT = default;
                this.TOC = default;
                this.DotTOC = default;
                this.GOT = default;
                this.PLT = default;
                this.GOTPLT = default;
                this.Tlsg = default;
                this.Tlsoffset = default;
                this.Dynamic = default;
                this.DynSym = default;
                this.DynStr = default;
                this.unreachableMethod = default;
            }

            public ArchSyms(loader.Sym Rel = default, loader.Sym Rela = default, loader.Sym RelPLT = default, loader.Sym RelaPLT = default, loader.Sym LinkEditGOT = default, loader.Sym LinkEditPLT = default, loader.Sym TOC = default, slice<loader.Sym> DotTOC = default, loader.Sym GOT = default, loader.Sym PLT = default, loader.Sym GOTPLT = default, loader.Sym Tlsg = default, nint Tlsoffset = default, loader.Sym Dynamic = default, loader.Sym DynSym = default, loader.Sym DynStr = default, loader.Sym unreachableMethod = default)
            {
                this.Rel = Rel;
                this.Rela = Rela;
                this.RelPLT = RelPLT;
                this.RelaPLT = RelaPLT;
                this.LinkEditGOT = LinkEditGOT;
                this.LinkEditPLT = LinkEditPLT;
                this.TOC = TOC;
                this.DotTOC = DotTOC;
                this.GOT = GOT;
                this.PLT = PLT;
                this.GOTPLT = GOTPLT;
                this.Tlsg = Tlsg;
                this.Tlsoffset = Tlsoffset;
                this.Dynamic = Dynamic;
                this.DynSym = DynSym;
                this.DynStr = DynStr;
                this.unreachableMethod = unreachableMethod;
            }

            // Enable comparisons between nil and ArchSyms struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ArchSyms value, NilType nil) => value.Equals(default(ArchSyms));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ArchSyms value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ArchSyms value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ArchSyms value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ArchSyms(NilType nil) => default(ArchSyms);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static ArchSyms ArchSyms_cast(dynamic value)
        {
            return new ArchSyms(value.Rel, value.Rela, value.RelPLT, value.RelaPLT, value.LinkEditGOT, value.LinkEditPLT, value.TOC, value.DotTOC, value.GOT, value.PLT, value.GOTPLT, value.Tlsg, value.Tlsoffset, value.Dynamic, value.DynSym, value.DynStr, value.unreachableMethod);
        }
    }
}}}}