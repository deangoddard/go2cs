//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using binary = go.encoding.binary_package;
using ioutil = go.io.ioutil_package;
using bits = go.math.bits_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
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
        private partial struct xcoffLoaderSymbol
        {
            // Constructors
            public xcoffLoaderSymbol(NilType _)
            {
                this.sym = default;
                this.smtype = default;
                this.smclas = default;
            }

            public xcoffLoaderSymbol(ref ptr<sym.Symbol> sym = default, sbyte smtype = default, sbyte smclas = default)
            {
                this.sym = sym;
                this.smtype = smtype;
                this.smclas = smclas;
            }

            // Enable comparisons between nil and xcoffLoaderSymbol struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(xcoffLoaderSymbol value, NilType nil) => value.Equals(default(xcoffLoaderSymbol));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(xcoffLoaderSymbol value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, xcoffLoaderSymbol value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, xcoffLoaderSymbol value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator xcoffLoaderSymbol(NilType nil) => default(xcoffLoaderSymbol);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static xcoffLoaderSymbol xcoffLoaderSymbol_cast(dynamic value)
        {
            return new xcoffLoaderSymbol(ref value.sym, value.smtype, value.smclas);
        }
    }
}}}}