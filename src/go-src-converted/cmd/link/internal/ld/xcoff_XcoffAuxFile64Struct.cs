//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:35:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using bits = go.math.bits_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
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
        public partial struct XcoffAuxFile64
        {
            // Constructors
            public XcoffAuxFile64(NilType _)
            {
                this.Xzeroes = default;
                this.Xoffset = default;
                this.X_pad1 = default;
                this.Xftype = default;
                this.X_pad2 = default;
                this.Xauxtype = default;
            }

            public XcoffAuxFile64(uint Xzeroes = default, uint Xoffset = default, array<byte> X_pad1 = default, byte Xftype = default, array<byte> X_pad2 = default, byte Xauxtype = default)
            {
                this.Xzeroes = Xzeroes;
                this.Xoffset = Xoffset;
                this.X_pad1 = X_pad1;
                this.Xftype = Xftype;
                this.X_pad2 = X_pad2;
                this.Xauxtype = Xauxtype;
            }

            // Enable comparisons between nil and XcoffAuxFile64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XcoffAuxFile64 value, NilType nil) => value.Equals(default(XcoffAuxFile64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XcoffAuxFile64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XcoffAuxFile64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XcoffAuxFile64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XcoffAuxFile64(NilType nil) => default(XcoffAuxFile64);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static XcoffAuxFile64 XcoffAuxFile64_cast(dynamic value)
        {
            return new XcoffAuxFile64(value.Xzeroes, value.Xoffset, value.X_pad1, value.Xftype, value.X_pad2, value.Xauxtype);
        }
    }
}}}}