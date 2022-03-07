//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:22:33 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct XcoffAoutHdr64
        {
            // Constructors
            public XcoffAoutHdr64(NilType _)
            {
                this.Omagic = default;
                this.Ovstamp = default;
                this.Odebugger = default;
                this.Otextstart = default;
                this.Odatastart = default;
                this.Otoc = default;
                this.Osnentry = default;
                this.Osntext = default;
                this.Osndata = default;
                this.Osntoc = default;
                this.Osnloader = default;
                this.Osnbss = default;
                this.Oalgntext = default;
                this.Oalgndata = default;
                this.Omodtype = default;
                this.Ocpuflag = default;
                this.Ocputype = default;
                this.Otextpsize = default;
                this.Odatapsize = default;
                this.Ostackpsize = default;
                this.Oflags = default;
                this.Otsize = default;
                this.Odsize = default;
                this.Obsize = default;
                this.Oentry = default;
                this.Omaxstack = default;
                this.Omaxdata = default;
                this.Osntdata = default;
                this.Osntbss = default;
                this.Ox64flags = default;
                this.Oresv3a = default;
                this.Oresv3 = default;
            }

            public XcoffAoutHdr64(short Omagic = default, short Ovstamp = default, uint Odebugger = default, ulong Otextstart = default, ulong Odatastart = default, ulong Otoc = default, short Osnentry = default, short Osntext = default, short Osndata = default, short Osntoc = default, short Osnloader = default, short Osnbss = default, short Oalgntext = default, short Oalgndata = default, array<byte> Omodtype = default, byte Ocpuflag = default, byte Ocputype = default, byte Otextpsize = default, byte Odatapsize = default, byte Ostackpsize = default, byte Oflags = default, ulong Otsize = default, ulong Odsize = default, ulong Obsize = default, ulong Oentry = default, ulong Omaxstack = default, ulong Omaxdata = default, short Osntdata = default, short Osntbss = default, ushort Ox64flags = default, short Oresv3a = default, array<int> Oresv3 = default)
            {
                this.Omagic = Omagic;
                this.Ovstamp = Ovstamp;
                this.Odebugger = Odebugger;
                this.Otextstart = Otextstart;
                this.Odatastart = Odatastart;
                this.Otoc = Otoc;
                this.Osnentry = Osnentry;
                this.Osntext = Osntext;
                this.Osndata = Osndata;
                this.Osntoc = Osntoc;
                this.Osnloader = Osnloader;
                this.Osnbss = Osnbss;
                this.Oalgntext = Oalgntext;
                this.Oalgndata = Oalgndata;
                this.Omodtype = Omodtype;
                this.Ocpuflag = Ocpuflag;
                this.Ocputype = Ocputype;
                this.Otextpsize = Otextpsize;
                this.Odatapsize = Odatapsize;
                this.Ostackpsize = Ostackpsize;
                this.Oflags = Oflags;
                this.Otsize = Otsize;
                this.Odsize = Odsize;
                this.Obsize = Obsize;
                this.Oentry = Oentry;
                this.Omaxstack = Omaxstack;
                this.Omaxdata = Omaxdata;
                this.Osntdata = Osntdata;
                this.Osntbss = Osntbss;
                this.Ox64flags = Ox64flags;
                this.Oresv3a = Oresv3a;
                this.Oresv3 = Oresv3;
            }

            // Enable comparisons between nil and XcoffAoutHdr64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XcoffAoutHdr64 value, NilType nil) => value.Equals(default(XcoffAoutHdr64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XcoffAoutHdr64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XcoffAoutHdr64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XcoffAoutHdr64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XcoffAoutHdr64(NilType nil) => default(XcoffAoutHdr64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XcoffAoutHdr64 XcoffAoutHdr64_cast(dynamic value)
        {
            return new XcoffAoutHdr64(value.Omagic, value.Ovstamp, value.Odebugger, value.Otextstart, value.Odatastart, value.Otoc, value.Osnentry, value.Osntext, value.Osndata, value.Osntoc, value.Osnloader, value.Osnbss, value.Oalgntext, value.Oalgndata, value.Omodtype, value.Ocpuflag, value.Ocputype, value.Otextpsize, value.Odatapsize, value.Ostackpsize, value.Oflags, value.Otsize, value.Odsize, value.Obsize, value.Oentry, value.Omaxstack, value.Omaxdata, value.Osntdata, value.Osntbss, value.Ox64flags, value.Oresv3a, value.Oresv3);
        }
    }
}}}}