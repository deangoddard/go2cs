//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:21:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class loadmacho_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ldMachoDysymtab
        {
            // Constructors
            public ldMachoDysymtab(NilType _)
            {
                this.ilocalsym = default;
                this.nlocalsym = default;
                this.iextdefsym = default;
                this.nextdefsym = default;
                this.iundefsym = default;
                this.nundefsym = default;
                this.tocoff = default;
                this.ntoc = default;
                this.modtaboff = default;
                this.nmodtab = default;
                this.extrefsymoff = default;
                this.nextrefsyms = default;
                this.indirectsymoff = default;
                this.nindirectsyms = default;
                this.extreloff = default;
                this.nextrel = default;
                this.locreloff = default;
                this.nlocrel = default;
                this.indir = default;
            }

            public ldMachoDysymtab(uint ilocalsym = default, uint nlocalsym = default, uint iextdefsym = default, uint nextdefsym = default, uint iundefsym = default, uint nundefsym = default, uint tocoff = default, uint ntoc = default, uint modtaboff = default, uint nmodtab = default, uint extrefsymoff = default, uint nextrefsyms = default, uint indirectsymoff = default, uint nindirectsyms = default, uint extreloff = default, uint nextrel = default, uint locreloff = default, uint nlocrel = default, slice<uint> indir = default)
            {
                this.ilocalsym = ilocalsym;
                this.nlocalsym = nlocalsym;
                this.iextdefsym = iextdefsym;
                this.nextdefsym = nextdefsym;
                this.iundefsym = iundefsym;
                this.nundefsym = nundefsym;
                this.tocoff = tocoff;
                this.ntoc = ntoc;
                this.modtaboff = modtaboff;
                this.nmodtab = nmodtab;
                this.extrefsymoff = extrefsymoff;
                this.nextrefsyms = nextrefsyms;
                this.indirectsymoff = indirectsymoff;
                this.nindirectsyms = nindirectsyms;
                this.extreloff = extreloff;
                this.nextrel = nextrel;
                this.locreloff = locreloff;
                this.nlocrel = nlocrel;
                this.indir = indir;
            }

            // Enable comparisons between nil and ldMachoDysymtab struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ldMachoDysymtab value, NilType nil) => value.Equals(default(ldMachoDysymtab));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ldMachoDysymtab value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ldMachoDysymtab value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ldMachoDysymtab value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ldMachoDysymtab(NilType nil) => default(ldMachoDysymtab);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ldMachoDysymtab ldMachoDysymtab_cast(dynamic value)
        {
            return new ldMachoDysymtab(value.ilocalsym, value.nlocalsym, value.iextdefsym, value.nextdefsym, value.iundefsym, value.nundefsym, value.tocoff, value.ntoc, value.modtaboff, value.nmodtab, value.extrefsymoff, value.nextrefsyms, value.indirectsymoff, value.nindirectsyms, value.extreloff, value.nextrel, value.locreloff, value.nlocrel, value.indir);
        }
    }
}}}}