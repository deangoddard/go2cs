//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:51:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using dwarf = go.cmd.@internal.dwarf_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CompilationUnit
        {
            // Constructors
            public CompilationUnit(NilType _)
            {
                this.Pkg = default;
                this.Lib = default;
                this.Consts = default;
                this.PCs = default;
                this.DWInfo = default;
                this.FuncDIEs = default;
                this.AbsFnDIEs = default;
                this.RangeSyms = default;
                this.Textp = default;
                this.DWARFFileTable = default;
            }

            public CompilationUnit(@string Pkg = default, ref ptr<Library> Lib = default, ref ptr<Symbol> Consts = default, slice<dwarf.Range> PCs = default, ref ptr<dwarf.DWDie> DWInfo = default, slice<ptr<Symbol>> FuncDIEs = default, slice<ptr<Symbol>> AbsFnDIEs = default, slice<ptr<Symbol>> RangeSyms = default, slice<ptr<Symbol>> Textp = default, slice<@string> DWARFFileTable = default)
            {
                this.Pkg = Pkg;
                this.Lib = Lib;
                this.Consts = Consts;
                this.PCs = PCs;
                this.DWInfo = DWInfo;
                this.FuncDIEs = FuncDIEs;
                this.AbsFnDIEs = AbsFnDIEs;
                this.RangeSyms = RangeSyms;
                this.Textp = Textp;
                this.DWARFFileTable = DWARFFileTable;
            }

            // Enable comparisons between nil and CompilationUnit struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CompilationUnit value, NilType nil) => value.Equals(default(CompilationUnit));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CompilationUnit value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CompilationUnit value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CompilationUnit value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CompilationUnit(NilType nil) => default(CompilationUnit);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CompilationUnit CompilationUnit_cast(dynamic value)
        {
            return new CompilationUnit(value.Pkg, ref value.Lib, ref value.Consts, value.PCs, ref value.DWInfo, value.FuncDIEs, value.AbsFnDIEs, value.RangeSyms, value.Textp, value.DWARFFileTable);
        }
    }
}}}}