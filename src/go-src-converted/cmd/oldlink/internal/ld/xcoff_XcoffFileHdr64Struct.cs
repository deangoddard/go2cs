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
        public partial struct XcoffFileHdr64
        {
            // Constructors
            public XcoffFileHdr64(NilType _)
            {
                this.Fmagic = default;
                this.Fnscns = default;
                this.Ftimedat = default;
                this.Fsymptr = default;
                this.Fopthdr = default;
                this.Fflags = default;
                this.Fnsyms = default;
            }

            public XcoffFileHdr64(ushort Fmagic = default, ushort Fnscns = default, int Ftimedat = default, ulong Fsymptr = default, ushort Fopthdr = default, ushort Fflags = default, int Fnsyms = default)
            {
                this.Fmagic = Fmagic;
                this.Fnscns = Fnscns;
                this.Ftimedat = Ftimedat;
                this.Fsymptr = Fsymptr;
                this.Fopthdr = Fopthdr;
                this.Fflags = Fflags;
                this.Fnsyms = Fnsyms;
            }

            // Enable comparisons between nil and XcoffFileHdr64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XcoffFileHdr64 value, NilType nil) => value.Equals(default(XcoffFileHdr64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XcoffFileHdr64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XcoffFileHdr64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XcoffFileHdr64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XcoffFileHdr64(NilType nil) => default(XcoffFileHdr64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XcoffFileHdr64 XcoffFileHdr64_cast(dynamic value)
        {
            return new XcoffFileHdr64(value.Fmagic, value.Fnscns, value.Ftimedat, value.Fsymptr, value.Fopthdr, value.Fflags, value.Fnsyms);
        }
    }
}}}}