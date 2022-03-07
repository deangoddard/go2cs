// Created by cgo -godefs - DO NOT EDIT
// cgo -godefs types_darwin.go

//go:build arm64 && darwin
// +build arm64,darwin

// package syscall -- go2cs converted at 2022 March 06 22:29:49 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Program Files\Go\src\syscall\ztypes_darwin_arm64.go


namespace go;

public static partial class syscall_package {

private static readonly nuint sizeofPtr = 0x8;
private static readonly nuint sizeofShort = 0x2;
private static readonly nuint sizeofInt = 0x4;
private static readonly nuint sizeofLong = 0x8;
private static readonly nuint sizeofLongLong = 0x8;


private partial struct _C_short { // : short
}
private partial struct _C_int { // : int
}
private partial struct _C_long { // : long
}
private partial struct _C_long_long { // : long
}
public partial struct Timespec {
    public long Sec;
    public long Nsec;
}

public partial struct Timeval {
    public long Sec;
    public int Usec;
    public array<byte> Pad_cgo_0;
}

public partial struct Timeval32 {
    public int Sec;
    public int Usec;
}

public partial struct Rusage {
    public Timeval Utime;
    public Timeval Stime;
    public long Maxrss;
    public long Ixrss;
    public long Idrss;
    public long Isrss;
    public long Minflt;
    public long Majflt;
    public long Nswap;
    public long Inblock;
    public long Oublock;
    public long Msgsnd;
    public long Msgrcv;
    public long Nsignals;
    public long Nvcsw;
    public long Nivcsw;
}

public partial struct Rlimit {
    public ulong Cur;
    public ulong Max;
}

private partial struct _Gid_t { // : uint
}

public partial struct Stat_t {
    public int Dev;
    public ushort Mode;
    public ushort Nlink;
    public ulong Ino;
    public uint Uid;
    public uint Gid;
    public int Rdev;
    public array<byte> Pad_cgo_0;
    public Timespec Atimespec;
    public Timespec Mtimespec;
    public Timespec Ctimespec;
    public Timespec Birthtimespec;
    public long Size;
    public long Blocks;
    public int Blksize;
    public uint Flags;
    public uint Gen;
    public int Lspare;
    public array<long> Qspare;
}

public partial struct Statfs_t {
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

public partial struct Flock_t {
    public long Start;
    public long Len;
    public int Pid;
    public short Type;
    public short Whence;
}

public partial struct Fstore_t {
    public uint Flags;
    public int Posmode;
    public long Offset;
    public long Length;
    public long Bytesalloc;
}

public partial struct Radvisory_t {
    public long Offset;
    public int Count;
    public array<byte> Pad_cgo_0;
}

public partial struct Fbootstraptransfer_t {
    public long Offset;
    public ulong Length;
    public ptr<byte> Buffer;
}

public partial struct Log2phys_t {
    public uint Flags;
    public long Contigbytes;
    public long Devoffset;
}

public partial struct Fsid {
    public array<int> Val;
}

public partial struct Dirent {
    public ulong Ino;
    public ulong Seekoff;
    public ushort Reclen;
    public ushort Namlen;
    public byte Type;
    public array<sbyte> Name;
    public array<byte> Pad_cgo_0;
}

private static readonly nuint pathMax = 0x400;


public partial struct RawSockaddrInet4 {
    public byte Len;
    public byte Family;
    public ushort Port;
    public array<byte> Addr; /* in_addr */
    public array<sbyte> Zero;
}

public partial struct RawSockaddrInet6 {
    public byte Len;
    public byte Family;
    public ushort Port;
    public uint Flowinfo;
    public array<byte> Addr; /* in6_addr */
    public uint Scope_id;
}

public partial struct RawSockaddrUnix {
    public byte Len;
    public byte Family;
    public array<sbyte> Path;
}

public partial struct RawSockaddrDatalink {
    public byte Len;
    public byte Family;
    public ushort Index;
    public byte Type;
    public byte Nlen;
    public byte Alen;
    public byte Slen;
    public array<sbyte> Data;
}

public partial struct RawSockaddr {
    public byte Len;
    public byte Family;
    public array<sbyte> Data;
}

public partial struct RawSockaddrAny {
    public RawSockaddr Addr;
    public array<sbyte> Pad;
}

private partial struct _Socklen { // : uint
}

public partial struct Linger {
    public int Onoff;
    public int Linger;
}

public partial struct Iovec {
    public ptr<byte> Base;
    public ulong Len;
}

public partial struct IPMreq {
    public array<byte> Multiaddr; /* in_addr */
    public array<byte> Interface; /* in_addr */
}

public partial struct IPv6Mreq {
    public array<byte> Multiaddr; /* in6_addr */
    public uint Interface;
}

public partial struct Msghdr {
    public ptr<byte> Name;
    public uint Namelen;
    public array<byte> Pad_cgo_0;
    public ptr<Iovec> Iov;
    public int Iovlen;
    public array<byte> Pad_cgo_1;
    public ptr<byte> Control;
    public uint Controllen;
    public int Flags;
}

public partial struct Cmsghdr {
    public uint Len;
    public int Level;
    public int Type;
}

public partial struct Inet4Pktinfo {
    public uint Ifindex;
    public array<byte> Spec_dst; /* in_addr */
    public array<byte> Addr; /* in_addr */
}

public partial struct Inet6Pktinfo {
    public array<byte> Addr; /* in6_addr */
    public uint Ifindex;
}

public partial struct IPv6MTUInfo {
    public RawSockaddrInet6 Addr;
    public uint Mtu;
}

public partial struct ICMPv6Filter {
    public array<uint> Filt;
}

public static readonly nuint SizeofSockaddrInet4 = 0x10;
public static readonly nuint SizeofSockaddrInet6 = 0x1c;
public static readonly nuint SizeofSockaddrAny = 0x6c;
public static readonly nuint SizeofSockaddrUnix = 0x6a;
public static readonly nuint SizeofSockaddrDatalink = 0x14;
public static readonly nuint SizeofLinger = 0x8;
public static readonly nuint SizeofIPMreq = 0x8;
public static readonly nuint SizeofIPv6Mreq = 0x14;
public static readonly nuint SizeofMsghdr = 0x30;
public static readonly nuint SizeofCmsghdr = 0xc;
public static readonly nuint SizeofInet4Pktinfo = 0xc;
public static readonly nuint SizeofInet6Pktinfo = 0x14;
public static readonly nuint SizeofIPv6MTUInfo = 0x20;
public static readonly nuint SizeofICMPv6Filter = 0x20;


public static readonly nuint PTRACE_TRACEME = 0x0;
public static readonly nuint PTRACE_CONT = 0x7;
public static readonly nuint PTRACE_KILL = 0x8;


public partial struct Kevent_t {
    public ulong Ident;
    public short Filter;
    public ushort Flags;
    public uint Fflags;
    public long Data;
    public ptr<byte> Udata;
}

public partial struct FdSet {
    public array<int> Bits;
}

public static readonly nuint SizeofIfMsghdr = 0x70;
public static readonly nuint SizeofIfData = 0x60;
public static readonly nuint SizeofIfaMsghdr = 0x14;
public static readonly nuint SizeofIfmaMsghdr = 0x10;
public static readonly nuint SizeofIfmaMsghdr2 = 0x14;
public static readonly nuint SizeofRtMsghdr = 0x5c;
public static readonly nuint SizeofRtMetrics = 0x38;


public partial struct IfMsghdr {
    public ushort Msglen;
    public byte Version;
    public byte Type;
    public int Addrs;
    public int Flags;
    public ushort Index;
    public array<byte> Pad_cgo_0;
    public IfData Data;
}

public partial struct IfData {
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
    public Timeval32 Lastchange;
    public uint Unused2;
    public uint Hwassist;
    public uint Reserved1;
    public uint Reserved2;
}

public partial struct IfaMsghdr {
    public ushort Msglen;
    public byte Version;
    public byte Type;
    public int Addrs;
    public int Flags;
    public ushort Index;
    public array<byte> Pad_cgo_0;
    public int Metric;
}

public partial struct IfmaMsghdr {
    public ushort Msglen;
    public byte Version;
    public byte Type;
    public int Addrs;
    public int Flags;
    public ushort Index;
    public array<byte> Pad_cgo_0;
}

public partial struct IfmaMsghdr2 {
    public ushort Msglen;
    public byte Version;
    public byte Type;
    public int Addrs;
    public int Flags;
    public ushort Index;
    public array<byte> Pad_cgo_0;
    public int Refcount;
}

public partial struct RtMsghdr {
    public ushort Msglen;
    public byte Version;
    public byte Type;
    public ushort Index;
    public array<byte> Pad_cgo_0;
    public int Flags;
    public int Addrs;
    public int Pid;
    public int Seq;
    public int Errno;
    public int Use;
    public uint Inits;
    public RtMetrics Rmx;
}

public partial struct RtMetrics {
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

public static readonly nuint SizeofBpfVersion = 0x4;
public static readonly nuint SizeofBpfStat = 0x8;
public static readonly nuint SizeofBpfProgram = 0x10;
public static readonly nuint SizeofBpfInsn = 0x8;
public static readonly nuint SizeofBpfHdr = 0x14;


public partial struct BpfVersion {
    public ushort Major;
    public ushort Minor;
}

public partial struct BpfStat {
    public uint Recv;
    public uint Drop;
}

public partial struct BpfProgram {
    public uint Len;
    public array<byte> Pad_cgo_0;
    public ptr<BpfInsn> Insns;
}

public partial struct BpfInsn {
    public ushort Code;
    public byte Jt;
    public byte Jf;
    public uint K;
}

public partial struct BpfHdr {
    public Timeval32 Tstamp;
    public uint Caplen;
    public uint Datalen;
    public ushort Hdrlen;
    public array<byte> Pad_cgo_0;
}

private static readonly nuint _AT_FDCWD = -0x2;


public partial struct Termios {
    public ulong Iflag;
    public ulong Oflag;
    public ulong Cflag;
    public ulong Lflag;
    public array<byte> Cc;
    public array<byte> Pad_cgo_0;
    public ulong Ispeed;
    public ulong Ospeed;
}

} // end syscall_package
