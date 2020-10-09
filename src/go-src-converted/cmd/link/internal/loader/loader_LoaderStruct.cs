//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:48:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using goobj2 = go.cmd.@internal.goobj2_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.link.@internal.sym_package;
using elf = go.debug.elf_package;
using fmt = go.fmt_package;
using log = go.log_package;
using bits = go.math.bits_package;
using os = go.os_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Loader
        {
            // Constructors
            public Loader(NilType _)
            {
                this.start = default;
                this.objs = default;
                this.extStart = default;
                this.builtinSyms = default;
                this.objSyms = default;
                this.symsByName = default;
                this.extStaticSyms = default;
                this.extReader = default;
                this.payloadBatch = default;
                this.payloads = default;
                this.values = default;
                this.sects = default;
                this.symSects = default;
                this.align = default;
                this.outdata = default;
                this.extRelocs = default;
                this.deferReturnTramp = default;
                this.objByPkg = default;
                this.Syms = default;
                this.symBatch = default;
                this.anonVersion = default;
                this.attrReachable = default;
                this.attrOnList = default;
                this.attrLocal = default;
                this.attrNotInSymbolTable = default;
                this.attrVisibilityHidden = default;
                this.attrDuplicateOK = default;
                this.attrShared = default;
                this.attrExternal = default;
                this.attrReadOnly = default;
                this.outer = default;
                this.sub = default;
                this.dynimplib = default;
                this.dynimpvers = default;
                this.localentry = default;
                this.extname = default;
                this.elfType = default;
                this.elfSym = default;
                this.localElfSym = default;
                this.symPkg = default;
                this.plt = default;
                this.got = default;
                this.dynid = default;
                this.relocVariant = default;
                this.Reachparent = default;
                this.relocBatch = default;
                this.relocExtBatch = default;
                this.flags = default;
                this.strictDupMsgs = default;
                this.elfsetstring = default;
                this.errorReporter = default;
                this.SymLookup = default;
            }

            public Loader(map<ptr<oReader>, Sym> start = default, slice<objIdx> objs = default, Sym extStart = default, slice<Sym> builtinSyms = default, slice<objSym> objSyms = default, array<map<@string, Sym>> symsByName = default, map<nameVer, Sym> extStaticSyms = default, ref ptr<oReader> extReader = default, slice<extSymPayload> payloadBatch = default, slice<ptr<extSymPayload>> payloads = default, slice<long> values = default, slice<ptr<sym.Section>> sects = default, slice<ushort> symSects = default, slice<byte> align = default, slice<slice<byte>> outdata = default, slice<slice<ExtReloc>> extRelocs = default, map<Sym, bool> deferReturnTramp = default, map<@string, ptr<oReader>> objByPkg = default, slice<ptr<sym.Symbol>> Syms = default, slice<sym.Symbol> symBatch = default, long anonVersion = default, Bitmap attrReachable = default, Bitmap attrOnList = default, Bitmap attrLocal = default, Bitmap attrNotInSymbolTable = default, Bitmap attrVisibilityHidden = default, Bitmap attrDuplicateOK = default, Bitmap attrShared = default, Bitmap attrExternal = default, map<Sym, bool> attrReadOnly = default, map<Sym, Sym> outer = default, map<Sym, Sym> sub = default, map<Sym, @string> dynimplib = default, map<Sym, @string> dynimpvers = default, map<Sym, byte> localentry = default, map<Sym, @string> extname = default, map<Sym, elf.SymType> elfType = default, map<Sym, int> elfSym = default, map<Sym, int> localElfSym = default, map<Sym, @string> symPkg = default, map<Sym, int> plt = default, map<Sym, int> got = default, map<Sym, int> dynid = default, map<relocId, sym.RelocVariant> relocVariant = default, slice<Sym> Reachparent = default, slice<sym.Reloc> relocBatch = default, slice<sym.RelocExt> relocExtBatch = default, uint flags = default, long strictDupMsgs = default, elfsetstringFunc elfsetstring = default, ref ptr<ErrorReporter> errorReporter = default, Func<@string, long, ptr<sym.Symbol>> SymLookup = default)
            {
                this.start = start;
                this.objs = objs;
                this.extStart = extStart;
                this.builtinSyms = builtinSyms;
                this.objSyms = objSyms;
                this.symsByName = symsByName;
                this.extStaticSyms = extStaticSyms;
                this.extReader = extReader;
                this.payloadBatch = payloadBatch;
                this.payloads = payloads;
                this.values = values;
                this.sects = sects;
                this.symSects = symSects;
                this.align = align;
                this.outdata = outdata;
                this.extRelocs = extRelocs;
                this.deferReturnTramp = deferReturnTramp;
                this.objByPkg = objByPkg;
                this.Syms = Syms;
                this.symBatch = symBatch;
                this.anonVersion = anonVersion;
                this.attrReachable = attrReachable;
                this.attrOnList = attrOnList;
                this.attrLocal = attrLocal;
                this.attrNotInSymbolTable = attrNotInSymbolTable;
                this.attrVisibilityHidden = attrVisibilityHidden;
                this.attrDuplicateOK = attrDuplicateOK;
                this.attrShared = attrShared;
                this.attrExternal = attrExternal;
                this.attrReadOnly = attrReadOnly;
                this.outer = outer;
                this.sub = sub;
                this.dynimplib = dynimplib;
                this.dynimpvers = dynimpvers;
                this.localentry = localentry;
                this.extname = extname;
                this.elfType = elfType;
                this.elfSym = elfSym;
                this.localElfSym = localElfSym;
                this.symPkg = symPkg;
                this.plt = plt;
                this.got = got;
                this.dynid = dynid;
                this.relocVariant = relocVariant;
                this.Reachparent = Reachparent;
                this.relocBatch = relocBatch;
                this.relocExtBatch = relocExtBatch;
                this.flags = flags;
                this.strictDupMsgs = strictDupMsgs;
                this.elfsetstring = elfsetstring;
                this.errorReporter = errorReporter;
                this.SymLookup = SymLookup;
            }

            // Enable comparisons between nil and Loader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Loader value, NilType nil) => value.Equals(default(Loader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Loader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Loader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Loader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Loader(NilType nil) => default(Loader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Loader Loader_cast(dynamic value)
        {
            return new Loader(value.start, value.objs, value.extStart, value.builtinSyms, value.objSyms, value.symsByName, value.extStaticSyms, ref value.extReader, value.payloadBatch, value.payloads, value.values, value.sects, value.symSects, value.align, value.outdata, value.extRelocs, value.deferReturnTramp, value.objByPkg, value.Syms, value.symBatch, value.anonVersion, value.attrReachable, value.attrOnList, value.attrLocal, value.attrNotInSymbolTable, value.attrVisibilityHidden, value.attrDuplicateOK, value.attrShared, value.attrExternal, value.attrReadOnly, value.outer, value.sub, value.dynimplib, value.dynimpvers, value.localentry, value.extname, value.elfType, value.elfSym, value.localElfSym, value.symPkg, value.plt, value.got, value.dynid, value.relocVariant, value.Reachparent, value.relocBatch, value.relocExtBatch, value.flags, value.strictDupMsgs, value.elfsetstring, ref value.errorReporter, value.SymLookup);
        }
    }
}}}}