//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:50:36 UTC
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
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
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
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct XcoffLdImportFile64
        {
            // Constructors
            public XcoffLdImportFile64(NilType _)
            {
                this.Limpidpath = default;
                this.Limpidbase = default;
                this.Limpidmem = default;
            }

            public XcoffLdImportFile64(@string Limpidpath = default, @string Limpidbase = default, @string Limpidmem = default)
            {
                this.Limpidpath = Limpidpath;
                this.Limpidbase = Limpidbase;
                this.Limpidmem = Limpidmem;
            }

            // Enable comparisons between nil and XcoffLdImportFile64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XcoffLdImportFile64 value, NilType nil) => value.Equals(default(XcoffLdImportFile64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XcoffLdImportFile64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XcoffLdImportFile64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XcoffLdImportFile64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XcoffLdImportFile64(NilType nil) => default(XcoffLdImportFile64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XcoffLdImportFile64 XcoffLdImportFile64_cast(dynamic value)
        {
            return new XcoffLdImportFile64(value.Limpidpath, value.Limpidbase, value.Limpidmem);
        }
    }
}}}}