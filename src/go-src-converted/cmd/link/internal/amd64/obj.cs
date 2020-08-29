// Inferno utils/6l/obj.c
// https://bitbucket.org/inferno-os/inferno-os/src/default/utils/6l/obj.c
//
//    Copyright © 1994-1999 Lucent Technologies Inc.  All rights reserved.
//    Portions Copyright © 1995-1997 C H Forsyth (forsyth@terzarima.net)
//    Portions Copyright © 1997-1999 Vita Nuova Limited
//    Portions Copyright © 2000-2007 Vita Nuova Holdings Limited (www.vitanuova.com)
//    Portions Copyright © 2004,2006 Bruce Ellis
//    Portions Copyright © 2005-2007 C H Forsyth (forsyth@terzarima.net)
//    Revisions Copyright © 2000-2007 Lucent Technologies Inc. and others
//    Portions Copyright © 2009 The Go Authors. All rights reserved.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

// package amd64 -- go2cs converted at 2020 August 29 10:04:43 UTC
// import "cmd/link/internal/amd64" ==> using amd64 = go.cmd.link.@internal.amd64_package
// Original source: C:\Go\src\cmd\link\internal\amd64\obj.go
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using ld = go.cmd.link.@internal.ld_package;
using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class amd64_package
    {
        public static (ref sys.Arch, ld.Arch) Init()
        {
            var arch = sys.ArchAMD64;
            if (objabi.GOARCH == "amd64p32")
            {
                arch = sys.ArchAMD64P32;
            }
            ld.Arch theArch = new ld.Arch(Funcalign:funcAlign,Maxalign:maxAlign,Minalign:minAlign,Dwarfregsp:dwarfRegSP,Dwarfreglr:dwarfRegLR,Adddynrel:adddynrel,Archinit:archinit,Archreloc:archreloc,Archrelocvariant:archrelocvariant,Asmb:asmb,Elfreloc1:elfreloc1,Elfsetupplt:elfsetupplt,Gentext:gentext,Machoreloc1:machoreloc1,PEreloc1:pereloc1,TLSIEtoLE:tlsIEtoLE,Linuxdynld:"/lib64/ld-linux-x86-64.so.2",Freebsddynld:"/libexec/ld-elf.so.1",Openbsddynld:"/usr/libexec/ld.so",Netbsddynld:"/libexec/ld.elf_so",Dragonflydynld:"/usr/libexec/ld-elf.so.2",Solarisdynld:"/lib/amd64/ld.so.1",);

            return (arch, theArch);
        }

        private static void archinit(ref ld.Link ctxt)
        {

            if (ctxt.HeadType == objabi.Hplan9) /* plan 9 */
                ld.HEADR = 32L + 8L;

                if (ld.FlagTextAddr == -1L.Value)
                {
                    ld.FlagTextAddr.Value = 0x200000UL + int64(ld.HEADR);
                }
                if (ld.FlagDataAddr == -1L.Value)
                {
                    ld.FlagDataAddr.Value = 0L;
                }
                if (ld.FlagRound == -1L.Value)
                {
                    ld.FlagRound.Value = 0x200000UL;
                }
            else if (ctxt.HeadType == objabi.Hdarwin) /* apple MACH */
                ld.HEADR = ld.INITIAL_MACHO_HEADR;
                if (ld.FlagRound == -1L.Value)
                {
                    ld.FlagRound.Value = 4096L;
                }
                if (ld.FlagTextAddr == -1L.Value)
                {
                    ld.FlagTextAddr.Value = 0x1000000UL + int64(ld.HEADR);
                }
                if (ld.FlagDataAddr == -1L.Value)
                {
                    ld.FlagDataAddr.Value = 0L;
                }
            else if (ctxt.HeadType == objabi.Hlinux || ctxt.HeadType == objabi.Hfreebsd || ctxt.HeadType == objabi.Hnetbsd || ctxt.HeadType == objabi.Hopenbsd || ctxt.HeadType == objabi.Hdragonfly || ctxt.HeadType == objabi.Hsolaris) /* solaris */
                ld.Elfinit(ctxt);

                ld.HEADR = ld.ELFRESERVE;
                if (ld.FlagTextAddr == -1L.Value)
                {
                    ld.FlagTextAddr.Value = (1L << (int)(22L)) + int64(ld.HEADR);
                }
                if (ld.FlagDataAddr == -1L.Value)
                {
                    ld.FlagDataAddr.Value = 0L;
                }
                if (ld.FlagRound == -1L.Value)
                {
                    ld.FlagRound.Value = 4096L;
                }
            else if (ctxt.HeadType == objabi.Hnacl) 
                ld.Elfinit(ctxt);
                ld.FlagW.Value = true; // disable dwarf, which gets confused and is useless anyway
                ld.HEADR = 0x10000UL;
                ld.Funcalign = 32L;
                if (ld.FlagTextAddr == -1L.Value)
                {
                    ld.FlagTextAddr.Value = 0x20000UL;
                }
                if (ld.FlagDataAddr == -1L.Value)
                {
                    ld.FlagDataAddr.Value = 0L;
                }
                if (ld.FlagRound == -1L.Value)
                {
                    ld.FlagRound.Value = 0x10000UL;
                }
            else if (ctxt.HeadType == objabi.Hwindows) /* PE executable */
                // ld.HEADR, ld.FlagTextAddr, ld.FlagDataAddr and ld.FlagRound are set in ld.Peinit
                return;
            else 
                ld.Exitf("unknown -H option: %v", ctxt.HeadType);
                        if (ld.FlagDataAddr != 0L && ld.FlagRound != 0L.Value.Value)
            {
                fmt.Printf("warning: -D0x%x is ignored because of -R0x%x\n", uint64(ld.FlagDataAddr.Value), uint32(ld.FlagRound.Value));
            }
        }
    }
}}}}
