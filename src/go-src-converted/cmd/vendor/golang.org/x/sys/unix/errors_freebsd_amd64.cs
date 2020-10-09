// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Constants that were deprecated or moved to enums in the FreeBSD headers. Keep
// them here for backwards compatibility.

// package unix -- go2cs converted at 2020 October 09 05:56:14 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\errors_freebsd_amd64.go

using static go.builtin;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        public static readonly ulong DLT_HHDLC = (ulong)0x79UL;
        public static readonly ulong IFF_SMART = (ulong)0x20UL;
        public static readonly ulong IFT_1822 = (ulong)0x2UL;
        public static readonly ulong IFT_A12MPPSWITCH = (ulong)0x82UL;
        public static readonly ulong IFT_AAL2 = (ulong)0xbbUL;
        public static readonly ulong IFT_AAL5 = (ulong)0x31UL;
        public static readonly ulong IFT_ADSL = (ulong)0x5eUL;
        public static readonly ulong IFT_AFLANE8023 = (ulong)0x3bUL;
        public static readonly ulong IFT_AFLANE8025 = (ulong)0x3cUL;
        public static readonly ulong IFT_ARAP = (ulong)0x58UL;
        public static readonly ulong IFT_ARCNET = (ulong)0x23UL;
        public static readonly ulong IFT_ARCNETPLUS = (ulong)0x24UL;
        public static readonly ulong IFT_ASYNC = (ulong)0x54UL;
        public static readonly ulong IFT_ATM = (ulong)0x25UL;
        public static readonly ulong IFT_ATMDXI = (ulong)0x69UL;
        public static readonly ulong IFT_ATMFUNI = (ulong)0x6aUL;
        public static readonly ulong IFT_ATMIMA = (ulong)0x6bUL;
        public static readonly ulong IFT_ATMLOGICAL = (ulong)0x50UL;
        public static readonly ulong IFT_ATMRADIO = (ulong)0xbdUL;
        public static readonly ulong IFT_ATMSUBINTERFACE = (ulong)0x86UL;
        public static readonly ulong IFT_ATMVCIENDPT = (ulong)0xc2UL;
        public static readonly ulong IFT_ATMVIRTUAL = (ulong)0x95UL;
        public static readonly ulong IFT_BGPPOLICYACCOUNTING = (ulong)0xa2UL;
        public static readonly ulong IFT_BSC = (ulong)0x53UL;
        public static readonly ulong IFT_CCTEMUL = (ulong)0x3dUL;
        public static readonly ulong IFT_CEPT = (ulong)0x13UL;
        public static readonly ulong IFT_CES = (ulong)0x85UL;
        public static readonly ulong IFT_CHANNEL = (ulong)0x46UL;
        public static readonly ulong IFT_CNR = (ulong)0x55UL;
        public static readonly ulong IFT_COFFEE = (ulong)0x84UL;
        public static readonly ulong IFT_COMPOSITELINK = (ulong)0x9bUL;
        public static readonly ulong IFT_DCN = (ulong)0x8dUL;
        public static readonly ulong IFT_DIGITALPOWERLINE = (ulong)0x8aUL;
        public static readonly ulong IFT_DIGITALWRAPPEROVERHEADCHANNEL = (ulong)0xbaUL;
        public static readonly ulong IFT_DLSW = (ulong)0x4aUL;
        public static readonly ulong IFT_DOCSCABLEDOWNSTREAM = (ulong)0x80UL;
        public static readonly ulong IFT_DOCSCABLEMACLAYER = (ulong)0x7fUL;
        public static readonly ulong IFT_DOCSCABLEUPSTREAM = (ulong)0x81UL;
        public static readonly ulong IFT_DS0 = (ulong)0x51UL;
        public static readonly ulong IFT_DS0BUNDLE = (ulong)0x52UL;
        public static readonly ulong IFT_DS1FDL = (ulong)0xaaUL;
        public static readonly ulong IFT_DS3 = (ulong)0x1eUL;
        public static readonly ulong IFT_DTM = (ulong)0x8cUL;
        public static readonly ulong IFT_DVBASILN = (ulong)0xacUL;
        public static readonly ulong IFT_DVBASIOUT = (ulong)0xadUL;
        public static readonly ulong IFT_DVBRCCDOWNSTREAM = (ulong)0x93UL;
        public static readonly ulong IFT_DVBRCCMACLAYER = (ulong)0x92UL;
        public static readonly ulong IFT_DVBRCCUPSTREAM = (ulong)0x94UL;
        public static readonly ulong IFT_ENC = (ulong)0xf4UL;
        public static readonly ulong IFT_EON = (ulong)0x19UL;
        public static readonly ulong IFT_EPLRS = (ulong)0x57UL;
        public static readonly ulong IFT_ESCON = (ulong)0x49UL;
        public static readonly ulong IFT_ETHER = (ulong)0x6UL;
        public static readonly ulong IFT_FAITH = (ulong)0xf2UL;
        public static readonly ulong IFT_FAST = (ulong)0x7dUL;
        public static readonly ulong IFT_FASTETHER = (ulong)0x3eUL;
        public static readonly ulong IFT_FASTETHERFX = (ulong)0x45UL;
        public static readonly ulong IFT_FDDI = (ulong)0xfUL;
        public static readonly ulong IFT_FIBRECHANNEL = (ulong)0x38UL;
        public static readonly ulong IFT_FRAMERELAYINTERCONNECT = (ulong)0x3aUL;
        public static readonly ulong IFT_FRAMERELAYMPI = (ulong)0x5cUL;
        public static readonly ulong IFT_FRDLCIENDPT = (ulong)0xc1UL;
        public static readonly ulong IFT_FRELAY = (ulong)0x20UL;
        public static readonly ulong IFT_FRELAYDCE = (ulong)0x2cUL;
        public static readonly ulong IFT_FRF16MFRBUNDLE = (ulong)0xa3UL;
        public static readonly ulong IFT_FRFORWARD = (ulong)0x9eUL;
        public static readonly ulong IFT_G703AT2MB = (ulong)0x43UL;
        public static readonly ulong IFT_G703AT64K = (ulong)0x42UL;
        public static readonly ulong IFT_GIF = (ulong)0xf0UL;
        public static readonly ulong IFT_GIGABITETHERNET = (ulong)0x75UL;
        public static readonly ulong IFT_GR303IDT = (ulong)0xb2UL;
        public static readonly ulong IFT_GR303RDT = (ulong)0xb1UL;
        public static readonly ulong IFT_H323GATEKEEPER = (ulong)0xa4UL;
        public static readonly ulong IFT_H323PROXY = (ulong)0xa5UL;
        public static readonly ulong IFT_HDH1822 = (ulong)0x3UL;
        public static readonly ulong IFT_HDLC = (ulong)0x76UL;
        public static readonly ulong IFT_HDSL2 = (ulong)0xa8UL;
        public static readonly ulong IFT_HIPERLAN2 = (ulong)0xb7UL;
        public static readonly ulong IFT_HIPPI = (ulong)0x2fUL;
        public static readonly ulong IFT_HIPPIINTERFACE = (ulong)0x39UL;
        public static readonly ulong IFT_HOSTPAD = (ulong)0x5aUL;
        public static readonly ulong IFT_HSSI = (ulong)0x2eUL;
        public static readonly ulong IFT_HY = (ulong)0xeUL;
        public static readonly ulong IFT_IBM370PARCHAN = (ulong)0x48UL;
        public static readonly ulong IFT_IDSL = (ulong)0x9aUL;
        public static readonly ulong IFT_IEEE80211 = (ulong)0x47UL;
        public static readonly ulong IFT_IEEE80212 = (ulong)0x37UL;
        public static readonly ulong IFT_IEEE8023ADLAG = (ulong)0xa1UL;
        public static readonly ulong IFT_IFGSN = (ulong)0x91UL;
        public static readonly ulong IFT_IMT = (ulong)0xbeUL;
        public static readonly ulong IFT_INTERLEAVE = (ulong)0x7cUL;
        public static readonly ulong IFT_IP = (ulong)0x7eUL;
        public static readonly ulong IFT_IPFORWARD = (ulong)0x8eUL;
        public static readonly ulong IFT_IPOVERATM = (ulong)0x72UL;
        public static readonly ulong IFT_IPOVERCDLC = (ulong)0x6dUL;
        public static readonly ulong IFT_IPOVERCLAW = (ulong)0x6eUL;
        public static readonly ulong IFT_IPSWITCH = (ulong)0x4eUL;
        public static readonly ulong IFT_IPXIP = (ulong)0xf9UL;
        public static readonly ulong IFT_ISDN = (ulong)0x3fUL;
        public static readonly ulong IFT_ISDNBASIC = (ulong)0x14UL;
        public static readonly ulong IFT_ISDNPRIMARY = (ulong)0x15UL;
        public static readonly ulong IFT_ISDNS = (ulong)0x4bUL;
        public static readonly ulong IFT_ISDNU = (ulong)0x4cUL;
        public static readonly ulong IFT_ISO88022LLC = (ulong)0x29UL;
        public static readonly ulong IFT_ISO88023 = (ulong)0x7UL;
        public static readonly ulong IFT_ISO88024 = (ulong)0x8UL;
        public static readonly ulong IFT_ISO88025 = (ulong)0x9UL;
        public static readonly ulong IFT_ISO88025CRFPINT = (ulong)0x62UL;
        public static readonly ulong IFT_ISO88025DTR = (ulong)0x56UL;
        public static readonly ulong IFT_ISO88025FIBER = (ulong)0x73UL;
        public static readonly ulong IFT_ISO88026 = (ulong)0xaUL;
        public static readonly ulong IFT_ISUP = (ulong)0xb3UL;
        public static readonly ulong IFT_L3IPXVLAN = (ulong)0x89UL;
        public static readonly ulong IFT_LAPB = (ulong)0x10UL;
        public static readonly ulong IFT_LAPD = (ulong)0x4dUL;
        public static readonly ulong IFT_LAPF = (ulong)0x77UL;
        public static readonly ulong IFT_LOCALTALK = (ulong)0x2aUL;
        public static readonly ulong IFT_LOOP = (ulong)0x18UL;
        public static readonly ulong IFT_MEDIAMAILOVERIP = (ulong)0x8bUL;
        public static readonly ulong IFT_MFSIGLINK = (ulong)0xa7UL;
        public static readonly ulong IFT_MIOX25 = (ulong)0x26UL;
        public static readonly ulong IFT_MODEM = (ulong)0x30UL;
        public static readonly ulong IFT_MPC = (ulong)0x71UL;
        public static readonly ulong IFT_MPLS = (ulong)0xa6UL;
        public static readonly ulong IFT_MPLSTUNNEL = (ulong)0x96UL;
        public static readonly ulong IFT_MSDSL = (ulong)0x8fUL;
        public static readonly ulong IFT_MVL = (ulong)0xbfUL;
        public static readonly ulong IFT_MYRINET = (ulong)0x63UL;
        public static readonly ulong IFT_NFAS = (ulong)0xafUL;
        public static readonly ulong IFT_NSIP = (ulong)0x1bUL;
        public static readonly ulong IFT_OPTICALCHANNEL = (ulong)0xc3UL;
        public static readonly ulong IFT_OPTICALTRANSPORT = (ulong)0xc4UL;
        public static readonly ulong IFT_OTHER = (ulong)0x1UL;
        public static readonly ulong IFT_P10 = (ulong)0xcUL;
        public static readonly ulong IFT_P80 = (ulong)0xdUL;
        public static readonly ulong IFT_PARA = (ulong)0x22UL;
        public static readonly ulong IFT_PFLOG = (ulong)0xf6UL;
        public static readonly ulong IFT_PFSYNC = (ulong)0xf7UL;
        public static readonly ulong IFT_PLC = (ulong)0xaeUL;
        public static readonly ulong IFT_POS = (ulong)0xabUL;
        public static readonly ulong IFT_PPPMULTILINKBUNDLE = (ulong)0x6cUL;
        public static readonly ulong IFT_PROPBWAP2MP = (ulong)0xb8UL;
        public static readonly ulong IFT_PROPCNLS = (ulong)0x59UL;
        public static readonly ulong IFT_PROPDOCSWIRELESSDOWNSTREAM = (ulong)0xb5UL;
        public static readonly ulong IFT_PROPDOCSWIRELESSMACLAYER = (ulong)0xb4UL;
        public static readonly ulong IFT_PROPDOCSWIRELESSUPSTREAM = (ulong)0xb6UL;
        public static readonly ulong IFT_PROPMUX = (ulong)0x36UL;
        public static readonly ulong IFT_PROPWIRELESSP2P = (ulong)0x9dUL;
        public static readonly ulong IFT_PTPSERIAL = (ulong)0x16UL;
        public static readonly ulong IFT_PVC = (ulong)0xf1UL;
        public static readonly ulong IFT_QLLC = (ulong)0x44UL;
        public static readonly ulong IFT_RADIOMAC = (ulong)0xbcUL;
        public static readonly ulong IFT_RADSL = (ulong)0x5fUL;
        public static readonly ulong IFT_REACHDSL = (ulong)0xc0UL;
        public static readonly ulong IFT_RFC1483 = (ulong)0x9fUL;
        public static readonly ulong IFT_RS232 = (ulong)0x21UL;
        public static readonly ulong IFT_RSRB = (ulong)0x4fUL;
        public static readonly ulong IFT_SDLC = (ulong)0x11UL;
        public static readonly ulong IFT_SDSL = (ulong)0x60UL;
        public static readonly ulong IFT_SHDSL = (ulong)0xa9UL;
        public static readonly ulong IFT_SIP = (ulong)0x1fUL;
        public static readonly ulong IFT_SLIP = (ulong)0x1cUL;
        public static readonly ulong IFT_SMDSDXI = (ulong)0x2bUL;
        public static readonly ulong IFT_SMDSICIP = (ulong)0x34UL;
        public static readonly ulong IFT_SONET = (ulong)0x27UL;
        public static readonly ulong IFT_SONETOVERHEADCHANNEL = (ulong)0xb9UL;
        public static readonly ulong IFT_SONETPATH = (ulong)0x32UL;
        public static readonly ulong IFT_SONETVT = (ulong)0x33UL;
        public static readonly ulong IFT_SRP = (ulong)0x97UL;
        public static readonly ulong IFT_SS7SIGLINK = (ulong)0x9cUL;
        public static readonly ulong IFT_STACKTOSTACK = (ulong)0x6fUL;
        public static readonly ulong IFT_STARLAN = (ulong)0xbUL;
        public static readonly ulong IFT_STF = (ulong)0xd7UL;
        public static readonly ulong IFT_T1 = (ulong)0x12UL;
        public static readonly ulong IFT_TDLC = (ulong)0x74UL;
        public static readonly ulong IFT_TERMPAD = (ulong)0x5bUL;
        public static readonly ulong IFT_TR008 = (ulong)0xb0UL;
        public static readonly ulong IFT_TRANSPHDLC = (ulong)0x7bUL;
        public static readonly ulong IFT_TUNNEL = (ulong)0x83UL;
        public static readonly ulong IFT_ULTRA = (ulong)0x1dUL;
        public static readonly ulong IFT_USB = (ulong)0xa0UL;
        public static readonly ulong IFT_V11 = (ulong)0x40UL;
        public static readonly ulong IFT_V35 = (ulong)0x2dUL;
        public static readonly ulong IFT_V36 = (ulong)0x41UL;
        public static readonly ulong IFT_V37 = (ulong)0x78UL;
        public static readonly ulong IFT_VDSL = (ulong)0x61UL;
        public static readonly ulong IFT_VIRTUALIPADDRESS = (ulong)0x70UL;
        public static readonly ulong IFT_VOICEEM = (ulong)0x64UL;
        public static readonly ulong IFT_VOICEENCAP = (ulong)0x67UL;
        public static readonly ulong IFT_VOICEFXO = (ulong)0x65UL;
        public static readonly ulong IFT_VOICEFXS = (ulong)0x66UL;
        public static readonly ulong IFT_VOICEOVERATM = (ulong)0x98UL;
        public static readonly ulong IFT_VOICEOVERFRAMERELAY = (ulong)0x99UL;
        public static readonly ulong IFT_VOICEOVERIP = (ulong)0x68UL;
        public static readonly ulong IFT_X213 = (ulong)0x5dUL;
        public static readonly ulong IFT_X25 = (ulong)0x5UL;
        public static readonly ulong IFT_X25DDN = (ulong)0x4UL;
        public static readonly ulong IFT_X25HUNTGROUP = (ulong)0x7aUL;
        public static readonly ulong IFT_X25MLP = (ulong)0x79UL;
        public static readonly ulong IFT_X25PLE = (ulong)0x28UL;
        public static readonly ulong IFT_XETHER = (ulong)0x1aUL;
        public static readonly ulong IPPROTO_MAXID = (ulong)0x34UL;
        public static readonly ulong IPV6_FAITH = (ulong)0x1dUL;
        public static readonly ulong IPV6_MIN_MEMBERSHIPS = (ulong)0x1fUL;
        public static readonly ulong IP_FAITH = (ulong)0x16UL;
        public static readonly ulong IP_MAX_SOURCE_FILTER = (ulong)0x400UL;
        public static readonly ulong IP_MIN_MEMBERSHIPS = (ulong)0x1fUL;
        public static readonly ulong MAP_NORESERVE = (ulong)0x40UL;
        public static readonly ulong MAP_RENAME = (ulong)0x20UL;
        public static readonly ulong NET_RT_MAXID = (ulong)0x6UL;
        public static readonly ulong RTF_PRCLONING = (ulong)0x10000UL;
        public static readonly ulong RTM_OLDADD = (ulong)0x9UL;
        public static readonly ulong RTM_OLDDEL = (ulong)0xaUL;
        public static readonly ulong RT_CACHING_CONTEXT = (ulong)0x1UL;
        public static readonly ulong RT_NORTREF = (ulong)0x2UL;
        public static readonly ulong SIOCADDRT = (ulong)0x8040720aUL;
        public static readonly ulong SIOCALIFADDR = (ulong)0x8118691bUL;
        public static readonly ulong SIOCDELRT = (ulong)0x8040720bUL;
        public static readonly ulong SIOCDLIFADDR = (ulong)0x8118691dUL;
        public static readonly ulong SIOCGLIFADDR = (ulong)0xc118691cUL;
        public static readonly ulong SIOCGLIFPHYADDR = (ulong)0xc118694bUL;
        public static readonly ulong SIOCSLIFPHYADDR = (ulong)0x8118694aUL;

    }
}}}}}}
