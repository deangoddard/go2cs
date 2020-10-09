// NOTE: cgo can't generate struct Stat_t and struct Statfs_t yet
// Created by cgo -godefs - DO NOT EDIT
// cgo -godefs types_darwin.go

// +build arm,darwin

// package unix -- go2cs converted at 2020 October 09 06:00:28 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\ztypes_darwin_arm.go

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
        public static readonly ulong SizeofPtr = (ulong)0x4UL;
        public static readonly ulong SizeofShort = (ulong)0x2UL;
        public static readonly ulong SizeofInt = (ulong)0x4UL;
        public static readonly ulong SizeofLong = (ulong)0x4UL;
        public static readonly ulong SizeofLongLong = (ulong)0x8UL;


        private partial struct _C_short // : short
        {
        }
        private partial struct _C_int // : int
        {
        }
        private partial struct _C_long // : int
        {
        }
        private partial struct _C_long_long // : long
        {
        }
        public partial struct Timespec
        {
            public int Sec;
            public int Nsec;
        }

        public partial struct Timeval
        {
            public int Sec;
            public int Usec;
        }

        public partial struct Timeval32 // : array<byte>
        {
        }

        public partial struct Rusage
        {
            public Timeval Utime;
            public Timeval Stime;
            public int Maxrss;
            public int Ixrss;
            public int Idrss;
            public int Isrss;
            public int Minflt;
            public int Majflt;
            public int Nswap;
            public int Inblock;
            public int Oublock;
            public int Msgsnd;
            public int Msgrcv;
            public int Nsignals;
            public int Nvcsw;
            public int Nivcsw;
        }

        public partial struct Rlimit
        {
            public ulong Cur;
            public ulong Max;
        }

        private partial struct _Gid_t // : uint
        {
        }

        public partial struct Stat_t
        {
            public int Dev;
            public ushort Mode;
            public ushort Nlink;
            public ulong Ino;
            public uint Uid;
            public uint Gid;
            public int Rdev;
            public Timespec Atim;
            public Timespec Mtim;
            public Timespec Ctim;
            public Timespec Btim;
            public long Size;
            public long Blocks;
            public int Blksize;
            public uint Flags;
            public uint Gen;
            public int Lspare;
            public array<long> Qspare;
        }

        public partial struct Statfs_t
        {
            public uint Bsize;
            public int Iosize;
            public ulong Blocks;
            public ulong Bfree;
            public ulong Bavail;
            public ulong Files;
            public ulong Ffree;
            public Fsid Fsid;
            public uint Owner;
            public uint Type;
            public uint Flags;
            public uint Fssubtype;
            public array<sbyte> Fstypename;
            public array<sbyte> Mntonname;
            public array<sbyte> Mntfromname;
            public array<uint> Reserved;
        }

        public partial struct Flock_t
        {
            public long Start;
            public long Len;
            public int Pid;
            public short Type;
            public short Whence;
        }

        public partial struct Fstore_t
        {
            public uint Flags;
            public int Posmode;
            public long Offset;
            public long Length;
            public long Bytesalloc;
        }

        public partial struct Radvisory_t
        {
            public long Offset;
            public int Count;
        }

        public partial struct Fbootstraptransfer_t
        {
            public long Offset;
            public uint Length;
            public ptr<byte> Buffer;
        }

        public partial struct Log2phys_t
        {
            public uint Flags;
            public long Contigbytes;
            public long Devoffset;
        }

        public partial struct Fsid
        {
            public array<int> Val;
        }

        public partial struct Dirent
        {
            public ulong Ino;
            public ulong Seekoff;
            public ushort Reclen;
            public ushort Namlen;
            public byte Type;
            public array<sbyte> Name;
            public array<byte> _;
        }

        public partial struct RawSockaddrInet4
        {
            public byte Len;
            public byte Family;
            public ushort Port;
            public array<byte> Addr; /* in_addr */
            public array<sbyte> Zero;
        }

        public partial struct RawSockaddrInet6
        {
            public byte Len;
            public byte Family;
            public ushort Port;
            public uint Flowinfo;
            public array<byte> Addr; /* in6_addr */
            public uint Scope_id;
        }

        public partial struct RawSockaddrUnix
        {
            public byte Len;
            public byte Family;
            public array<sbyte> Path;
        }

        public partial struct RawSockaddrDatalink
        {
            public byte Len;
            public byte Family;
            public ushort Index;
            public byte Type;
            public byte Nlen;
            public byte Alen;
            public byte Slen;
            public array<sbyte> Data;
        }

        public partial struct RawSockaddr
        {
            public byte Len;
            public byte Family;
            public array<sbyte> Data;
        }

        public partial struct RawSockaddrAny
        {
            public RawSockaddr Addr;
            public array<sbyte> Pad;
        }

        private partial struct _Socklen // : uint
        {
        }

        public partial struct Linger
        {
            public int Onoff;
            public int Linger;
        }

        public partial struct Iovec
        {
            public ptr<byte> Base;
            public uint Len;
        }

        public partial struct IPMreq
        {
            public array<byte> Multiaddr; /* in_addr */
            public array<byte> Interface; /* in_addr */
        }

        public partial struct IPv6Mreq
        {
            public array<byte> Multiaddr; /* in6_addr */
            public uint Interface;
        }

        public partial struct Msghdr
        {
            public ptr<byte> Name;
            public uint Namelen;
            public ptr<Iovec> Iov;
            public int Iovlen;
            public ptr<byte> Control;
            public uint Controllen;
            public int Flags;
        }

        public partial struct Cmsghdr
        {
            public uint Len;
            public int Level;
            public int Type;
        }

        public partial struct Inet4Pktinfo
        {
            public uint Ifindex;
            public array<byte> Spec_dst; /* in_addr */
            public array<byte> Addr; /* in_addr */
        }

        public partial struct Inet6Pktinfo
        {
            public array<byte> Addr; /* in6_addr */
            public uint Ifindex;
        }

        public partial struct IPv6MTUInfo
        {
            public RawSockaddrInet6 Addr;
            public uint Mtu;
        }

        public partial struct ICMPv6Filter
        {
            public array<uint> Filt;
        }

        public static readonly ulong SizeofSockaddrInet4 = (ulong)0x10UL;
        public static readonly ulong SizeofSockaddrInet6 = (ulong)0x1cUL;
        public static readonly ulong SizeofSockaddrAny = (ulong)0x6cUL;
        public static readonly ulong SizeofSockaddrUnix = (ulong)0x6aUL;
        public static readonly ulong SizeofSockaddrDatalink = (ulong)0x14UL;
        public static readonly ulong SizeofLinger = (ulong)0x8UL;
        public static readonly ulong SizeofIPMreq = (ulong)0x8UL;
        public static readonly ulong SizeofIPv6Mreq = (ulong)0x14UL;
        public static readonly ulong SizeofMsghdr = (ulong)0x1cUL;
        public static readonly ulong SizeofCmsghdr = (ulong)0xcUL;
        public static readonly ulong SizeofInet4Pktinfo = (ulong)0xcUL;
        public static readonly ulong SizeofInet6Pktinfo = (ulong)0x14UL;
        public static readonly ulong SizeofIPv6MTUInfo = (ulong)0x20UL;
        public static readonly ulong SizeofICMPv6Filter = (ulong)0x20UL;


        public static readonly ulong PTRACE_TRACEME = (ulong)0x0UL;
        public static readonly ulong PTRACE_CONT = (ulong)0x7UL;
        public static readonly ulong PTRACE_KILL = (ulong)0x8UL;


        public partial struct Kevent_t
        {
            public uint Ident;
            public short Filter;
            public ushort Flags;
            public uint Fflags;
            public int Data;
            public ptr<byte> Udata;
        }

        public partial struct FdSet
        {
            public array<int> Bits;
        }

        public static readonly ulong SizeofIfMsghdr = (ulong)0x70UL;
        public static readonly ulong SizeofIfData = (ulong)0x60UL;
        public static readonly ulong SizeofIfaMsghdr = (ulong)0x14UL;
        public static readonly ulong SizeofIfmaMsghdr = (ulong)0x10UL;
        public static readonly ulong SizeofIfmaMsghdr2 = (ulong)0x14UL;
        public static readonly ulong SizeofRtMsghdr = (ulong)0x5cUL;
        public static readonly ulong SizeofRtMetrics = (ulong)0x38UL;


        public partial struct IfMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public array<byte> _;
            public IfData Data;
        }

        public partial struct IfData
        {
            public byte Type;
            public byte Typelen;
            public byte Physical;
            public byte Addrlen;
            public byte Hdrlen;
            public byte Recvquota;
            public byte Xmitquota;
            public byte Unused1;
            public uint Mtu;
            public uint Metric;
            public uint Baudrate;
            public uint Ipackets;
            public uint Ierrors;
            public uint Opackets;
            public uint Oerrors;
            public uint Collisions;
            public uint Ibytes;
            public uint Obytes;
            public uint Imcasts;
            public uint Omcasts;
            public uint Iqdrops;
            public uint Noproto;
            public uint Recvtiming;
            public uint Xmittiming;
            public Timeval Lastchange;
            public uint Unused2;
            public uint Hwassist;
            public uint Reserved1;
            public uint Reserved2;
        }

        public partial struct IfaMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public array<byte> _;
            public int Metric;
        }

        public partial struct IfmaMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public array<byte> _;
        }

        public partial struct IfmaMsghdr2
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public array<byte> _;
            public int Refcount;
        }

        public partial struct RtMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Index;
            public array<byte> _;
            public int Flags;
            public int Addrs;
            public int Pid;
            public int Seq;
            public int Errno;
            public int Use;
            public uint Inits;
            public RtMetrics Rmx;
        }

        public partial struct RtMetrics
        {
            public uint Locks;
            public uint Mtu;
            public uint Hopcount;
            public int Expire;
            public uint Recvpipe;
            public uint Sendpipe;
            public uint Ssthresh;
            public uint Rtt;
            public uint Rttvar;
            public uint Pksent;
            public array<uint> Filler;
        }

        public static readonly ulong SizeofBpfVersion = (ulong)0x4UL;
        public static readonly ulong SizeofBpfStat = (ulong)0x8UL;
        public static readonly ulong SizeofBpfProgram = (ulong)0x8UL;
        public static readonly ulong SizeofBpfInsn = (ulong)0x8UL;
        public static readonly ulong SizeofBpfHdr = (ulong)0x14UL;


        public partial struct BpfVersion
        {
            public ushort Major;
            public ushort Minor;
        }

        public partial struct BpfStat
        {
            public uint Recv;
            public uint Drop;
        }

        public partial struct BpfProgram
        {
            public uint Len;
            public ptr<BpfInsn> Insns;
        }

        public partial struct BpfInsn
        {
            public ushort Code;
            public byte Jt;
            public byte Jf;
            public uint K;
        }

        public partial struct BpfHdr
        {
            public Timeval Tstamp;
            public uint Caplen;
            public uint Datalen;
            public ushort Hdrlen;
            public array<byte> _;
        }

        public partial struct Termios
        {
            public uint Iflag;
            public uint Oflag;
            public uint Cflag;
            public uint Lflag;
            public array<byte> Cc;
            public uint Ispeed;
            public uint Ospeed;
        }

        public partial struct Winsize
        {
            public ushort Row;
            public ushort Col;
            public ushort Xpixel;
            public ushort Ypixel;
        }

        public static readonly ulong AT_FDCWD = (ulong)-0x2UL;
        public static readonly ulong AT_REMOVEDIR = (ulong)0x80UL;
        public static readonly ulong AT_SYMLINK_FOLLOW = (ulong)0x40UL;
        public static readonly ulong AT_SYMLINK_NOFOLLOW = (ulong)0x20UL;


        public partial struct PollFd
        {
            public int Fd;
            public short Events;
            public short Revents;
        }

        public static readonly ulong POLLERR = (ulong)0x8UL;
        public static readonly ulong POLLHUP = (ulong)0x10UL;
        public static readonly ulong POLLIN = (ulong)0x1UL;
        public static readonly ulong POLLNVAL = (ulong)0x20UL;
        public static readonly ulong POLLOUT = (ulong)0x4UL;
        public static readonly ulong POLLPRI = (ulong)0x2UL;
        public static readonly ulong POLLRDBAND = (ulong)0x80UL;
        public static readonly ulong POLLRDNORM = (ulong)0x40UL;
        public static readonly ulong POLLWRBAND = (ulong)0x100UL;
        public static readonly ulong POLLWRNORM = (ulong)0x4UL;


        public partial struct Utsname
        {
            public array<byte> Sysname;
            public array<byte> Nodename;
            public array<byte> Release;
            public array<byte> Version;
            public array<byte> Machine;
        }

        public static readonly ulong SizeofClockinfo = (ulong)0x14UL;



        public partial struct Clockinfo
        {
            public int Hz;
            public int Tick;
            public int Tickadj;
            public int Stathz;
            public int Profhz;
        }
    }
}}}}}}
