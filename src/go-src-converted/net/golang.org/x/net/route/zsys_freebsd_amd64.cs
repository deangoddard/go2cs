// Code generated by cmd/cgo -godefs; DO NOT EDIT.
// cgo -godefs defs_freebsd.go

// package route -- go2cs converted at 2020 October 09 04:51:43 UTC
// import "golang.org/x/net/route" ==> using route = go.golang.org.x.net.route_package
// Original source: C:\Users\ritchie\go\src\golang.org\x\net\route\zsys_freebsd_amd64.go

using static go.builtin;

namespace go {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        private static readonly ulong sysAF_UNSPEC = (ulong)0x0UL;
        private static readonly ulong sysAF_INET = (ulong)0x2UL;
        private static readonly ulong sysAF_ROUTE = (ulong)0x11UL;
        private static readonly ulong sysAF_LINK = (ulong)0x12UL;
        private static readonly ulong sysAF_INET6 = (ulong)0x1cUL;

        private static readonly ulong sysSOCK_RAW = (ulong)0x3UL;

        private static readonly ulong sysNET_RT_DUMP = (ulong)0x1UL;
        private static readonly ulong sysNET_RT_FLAGS = (ulong)0x2UL;
        private static readonly ulong sysNET_RT_IFLIST = (ulong)0x3UL;
        private static readonly ulong sysNET_RT_IFMALIST = (ulong)0x4UL;
        private static readonly ulong sysNET_RT_IFLISTL = (ulong)0x5UL;


        private static readonly ulong sysCTL_MAXNAME = (ulong)0x18UL;

        private static readonly ulong sysCTL_UNSPEC = (ulong)0x0UL;
        private static readonly ulong sysCTL_KERN = (ulong)0x1UL;
        private static readonly ulong sysCTL_VM = (ulong)0x2UL;
        private static readonly ulong sysCTL_VFS = (ulong)0x3UL;
        private static readonly ulong sysCTL_NET = (ulong)0x4UL;
        private static readonly ulong sysCTL_DEBUG = (ulong)0x5UL;
        private static readonly ulong sysCTL_HW = (ulong)0x6UL;
        private static readonly ulong sysCTL_MACHDEP = (ulong)0x7UL;
        private static readonly ulong sysCTL_USER = (ulong)0x8UL;
        private static readonly ulong sysCTL_P1003_1B = (ulong)0x9UL;


        private static readonly ulong sysRTM_VERSION = (ulong)0x5UL;

        private static readonly ulong sysRTM_ADD = (ulong)0x1UL;
        private static readonly ulong sysRTM_DELETE = (ulong)0x2UL;
        private static readonly ulong sysRTM_CHANGE = (ulong)0x3UL;
        private static readonly ulong sysRTM_GET = (ulong)0x4UL;
        private static readonly ulong sysRTM_LOSING = (ulong)0x5UL;
        private static readonly ulong sysRTM_REDIRECT = (ulong)0x6UL;
        private static readonly ulong sysRTM_MISS = (ulong)0x7UL;
        private static readonly ulong sysRTM_LOCK = (ulong)0x8UL;
        private static readonly ulong sysRTM_RESOLVE = (ulong)0xbUL;
        private static readonly ulong sysRTM_NEWADDR = (ulong)0xcUL;
        private static readonly ulong sysRTM_DELADDR = (ulong)0xdUL;
        private static readonly ulong sysRTM_IFINFO = (ulong)0xeUL;
        private static readonly ulong sysRTM_NEWMADDR = (ulong)0xfUL;
        private static readonly ulong sysRTM_DELMADDR = (ulong)0x10UL;
        private static readonly ulong sysRTM_IFANNOUNCE = (ulong)0x11UL;
        private static readonly ulong sysRTM_IEEE80211 = (ulong)0x12UL;

        private static readonly ulong sysRTA_DST = (ulong)0x1UL;
        private static readonly ulong sysRTA_GATEWAY = (ulong)0x2UL;
        private static readonly ulong sysRTA_NETMASK = (ulong)0x4UL;
        private static readonly ulong sysRTA_GENMASK = (ulong)0x8UL;
        private static readonly ulong sysRTA_IFP = (ulong)0x10UL;
        private static readonly ulong sysRTA_IFA = (ulong)0x20UL;
        private static readonly ulong sysRTA_AUTHOR = (ulong)0x40UL;
        private static readonly ulong sysRTA_BRD = (ulong)0x80UL;

        private static readonly ulong sysRTAX_DST = (ulong)0x0UL;
        private static readonly ulong sysRTAX_GATEWAY = (ulong)0x1UL;
        private static readonly ulong sysRTAX_NETMASK = (ulong)0x2UL;
        private static readonly ulong sysRTAX_GENMASK = (ulong)0x3UL;
        private static readonly ulong sysRTAX_IFP = (ulong)0x4UL;
        private static readonly ulong sysRTAX_IFA = (ulong)0x5UL;
        private static readonly ulong sysRTAX_AUTHOR = (ulong)0x6UL;
        private static readonly ulong sysRTAX_BRD = (ulong)0x7UL;
        private static readonly ulong sysRTAX_MAX = (ulong)0x8UL;


        private static readonly ulong sizeofIfMsghdrlFreeBSD10 = (ulong)0xb0UL;
        private static readonly ulong sizeofIfaMsghdrFreeBSD10 = (ulong)0x14UL;
        private static readonly ulong sizeofIfaMsghdrlFreeBSD10 = (ulong)0xb0UL;
        private static readonly ulong sizeofIfmaMsghdrFreeBSD10 = (ulong)0x10UL;
        private static readonly ulong sizeofIfAnnouncemsghdrFreeBSD10 = (ulong)0x18UL;

        private static readonly ulong sizeofRtMsghdrFreeBSD10 = (ulong)0x98UL;
        private static readonly ulong sizeofRtMetricsFreeBSD10 = (ulong)0x70UL;

        private static readonly ulong sizeofIfMsghdrFreeBSD7 = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD8 = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD9 = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD10 = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD11 = (ulong)0xa8UL;

        private static readonly ulong sizeofIfDataFreeBSD7 = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD8 = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD9 = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD10 = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD11 = (ulong)0x98UL;

        private static readonly ulong sizeofIfMsghdrlFreeBSD10Emu = (ulong)0xb0UL;
        private static readonly ulong sizeofIfaMsghdrFreeBSD10Emu = (ulong)0x14UL;
        private static readonly ulong sizeofIfaMsghdrlFreeBSD10Emu = (ulong)0xb0UL;
        private static readonly ulong sizeofIfmaMsghdrFreeBSD10Emu = (ulong)0x10UL;
        private static readonly ulong sizeofIfAnnouncemsghdrFreeBSD10Emu = (ulong)0x18UL;

        private static readonly ulong sizeofRtMsghdrFreeBSD10Emu = (ulong)0x98UL;
        private static readonly ulong sizeofRtMetricsFreeBSD10Emu = (ulong)0x70UL;

        private static readonly ulong sizeofIfMsghdrFreeBSD7Emu = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD8Emu = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD9Emu = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD10Emu = (ulong)0xa8UL;
        private static readonly ulong sizeofIfMsghdrFreeBSD11Emu = (ulong)0xa8UL;

        private static readonly ulong sizeofIfDataFreeBSD7Emu = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD8Emu = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD9Emu = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD10Emu = (ulong)0x98UL;
        private static readonly ulong sizeofIfDataFreeBSD11Emu = (ulong)0x98UL;

        private static readonly ulong sizeofSockaddrStorage = (ulong)0x80UL;
        private static readonly ulong sizeofSockaddrInet = (ulong)0x10UL;
        private static readonly ulong sizeofSockaddrInet6 = (ulong)0x1cUL;

    }
}}}}
