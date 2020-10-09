//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:50:35 UTC
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
        public partial struct XcoffScnHdr64
        {
            // Constructors
            public XcoffScnHdr64(NilType _)
            {
                this.Sname = default;
                this.Spaddr = default;
                this.Svaddr = default;
                this.Ssize = default;
                this.Sscnptr = default;
                this.Srelptr = default;
                this.Slnnoptr = default;
                this.Snreloc = default;
                this.Snlnno = default;
                this.Sflags = default;
            }

            public XcoffScnHdr64(array<byte> Sname = default, ulong Spaddr = default, ulong Svaddr = default, ulong Ssize = default, ulong Sscnptr = default, ulong Srelptr = default, ulong Slnnoptr = default, uint Snreloc = default, uint Snlnno = default, uint Sflags = default)
            {
                this.Sname = Sname;
                this.Spaddr = Spaddr;
                this.Svaddr = Svaddr;
                this.Ssize = Ssize;
                this.Sscnptr = Sscnptr;
                this.Srelptr = Srelptr;
                this.Slnnoptr = Slnnoptr;
                this.Snreloc = Snreloc;
                this.Snlnno = Snlnno;
                this.Sflags = Sflags;
            }

            // Enable comparisons between nil and XcoffScnHdr64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XcoffScnHdr64 value, NilType nil) => value.Equals(default(XcoffScnHdr64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XcoffScnHdr64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XcoffScnHdr64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XcoffScnHdr64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XcoffScnHdr64(NilType nil) => default(XcoffScnHdr64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XcoffScnHdr64 XcoffScnHdr64_cast(dynamic value)
        {
            return new XcoffScnHdr64(value.Sname, value.Spaddr, value.Svaddr, value.Ssize, value.Sscnptr, value.Srelptr, value.Slnnoptr, value.Snreloc, value.Snlnno, value.Sflags);
        }
    }
}}}}