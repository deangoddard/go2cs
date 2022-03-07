// cgo -godefs -- -Wall -Werror -static -I/tmp/include /build/linux/types.go | go run mkpost.go
// Code generated by the command above; see README.md. DO NOT EDIT.

//go:build mips && linux
// +build mips,linux

// package unix -- go2cs converted at 2022 March 06 23:30:30 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Program Files\Go\src\cmd\vendor\golang.org\x\sys\unix\ztypes_linux_mips.go


namespace go.cmd.vendor.golang.org.x.sys;

public static partial class unix_package {

public static readonly nuint SizeofPtr = 0x4;
public static readonly nuint SizeofLong = 0x4;


private partial struct _C_long { // : int
}
public partial struct Timespec {
    public int Sec;
    public int Nsec;
}

public partial struct Timeval {
    public int Sec;
    public int Usec;
}

public partial struct Timex {
    public uint Modes;
    public int Offset;
    public int Freq;
    public int Maxerror;
    public int Esterror;
    public int Status;
    public int Constant;
    public int Precision;
    public int Tolerance;
    public Timeval Time;
    public int Tick;
    public int Ppsfreq;
    public int Jitter;
    public int Shift;
    public int Stabil;
    public int Jitcnt;
    public int Calcnt;
    public int Errcnt;
    public int Stbcnt;
    public int Tai;
    public array<byte> _;
}

public partial struct Time_t { // : int
}

public partial struct Tms {
    public int Utime;
    public int Stime;
    public int Cutime;
    public int Cstime;
}

public partial struct Utimbuf {
    public int Actime;
    public int Modtime;
}

public partial struct Rusage {
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

public partial struct Stat_t {
    public uint Dev;
    public array<int> Pad1;
    public ulong Ino;
    public uint Mode;
    public uint Nlink;
    public uint Uid;
    public uint Gid;
    public uint Rdev;
    public array<int> Pad2;
    public long Size;
    public Timespec Atim;
    public Timespec Mtim;
    public Timespec Ctim;
    public int Blksize;
    public int Pad4;
    public long Blocks;
    public array<int> Pad5;
}

public partial struct Dirent {
    public ulong Ino;
    public long Off;
    public ushort Reclen;
    public byte Type;
    public array<sbyte> Name;
    public array<byte> _;
}

public partial struct Flock_t {
    public short Type;
    public short Whence;
    public array<byte> _;
    public long Start;
    public long Len;
    public int Pid;
    public array<byte> _;
}

public partial struct DmNameList {
    public ulong Dev;
    public uint Next;
    public array<byte> Name;
    public array<byte> _;
}

public static readonly nuint FADV_DONTNEED = 0x4;
public static readonly nuint FADV_NOREUSE = 0x5;


public partial struct RawSockaddr {
    public ushort Family;
    public array<sbyte> Data;
}

public partial struct RawSockaddrAny {
    public RawSockaddr Addr;
    public array<sbyte> Pad;
}

public partial struct Iovec {
    public ptr<byte> Base;
    public uint Len;
}

public partial struct Msghdr {
    public ptr<byte> Name;
    public uint Namelen;
    public ptr<Iovec> Iov;
    public uint Iovlen;
    public ptr<byte> Control;
    public uint Controllen;
    public int Flags;
}

public partial struct Cmsghdr {
    public uint Len;
    public int Level;
    public int Type;
}

public static readonly nuint SizeofIovec = 0x8;
public static readonly nuint SizeofMsghdr = 0x1c;
public static readonly nuint SizeofCmsghdr = 0xc;


public static readonly nuint SizeofSockFprog = 0x8;


public partial struct PtraceRegs {
    public array<ulong> Regs;
    public ulong Lo;
    public ulong Hi;
    public ulong Epc;
    public ulong Badvaddr;
    public ulong Status;
    public ulong Cause;
}

public partial struct FdSet {
    public array<int> Bits;
}

public partial struct Sysinfo_t {
    public int Uptime;
    public array<uint> Loads;
    public uint Totalram;
    public uint Freeram;
    public uint Sharedram;
    public uint Bufferram;
    public uint Totalswap;
    public uint Freeswap;
    public ushort Procs;
    public ushort Pad;
    public uint Totalhigh;
    public uint Freehigh;
    public uint Unit;
    public array<sbyte> _;
}

public partial struct Ustat_t {
    public int Tfree;
    public uint Tinode;
    public array<sbyte> Fname;
    public array<sbyte> Fpack;
}

public partial struct EpollEvent {
    public uint Events;
    public int PadFd;
    public int Fd;
    public int Pad;
}

public static readonly nuint POLLRDHUP = 0x2000;


public partial struct Sigset_t {
    public array<uint> Val;
}

private static readonly nuint _C__NSIG = 0x80;



public partial struct Termios {
    public uint Iflag;
    public uint Oflag;
    public uint Cflag;
    public uint Lflag;
    public byte Line;
    public array<byte> Cc;
    public uint Ispeed;
    public uint Ospeed;
}

public partial struct Taskstats {
    public ushort Version;
    public uint Ac_exitcode;
    public byte Ac_flag;
    public byte Ac_nice;
    public array<byte> _;
    public ulong Cpu_count;
    public ulong Cpu_delay_total;
    public ulong Blkio_count;
    public ulong Blkio_delay_total;
    public ulong Swapin_count;
    public ulong Swapin_delay_total;
    public ulong Cpu_run_real_total;
    public ulong Cpu_run_virtual_total;
    public array<sbyte> Ac_comm;
    public byte Ac_sched;
    public array<byte> Ac_pad;
    public array<byte> _;
    public uint Ac_uid;
    public uint Ac_gid;
    public uint Ac_pid;
    public uint Ac_ppid;
    public uint Ac_btime;
    public array<byte> _;
    public ulong Ac_etime;
    public ulong Ac_utime;
    public ulong Ac_stime;
    public ulong Ac_minflt;
    public ulong Ac_majflt;
    public ulong Coremem;
    public ulong Virtmem;
    public ulong Hiwater_rss;
    public ulong Hiwater_vm;
    public ulong Read_char;
    public ulong Write_char;
    public ulong Read_syscalls;
    public ulong Write_syscalls;
    public ulong Read_bytes;
    public ulong Write_bytes;
    public ulong Cancelled_write_bytes;
    public ulong Nvcsw;
    public ulong Nivcsw;
    public ulong Ac_utimescaled;
    public ulong Ac_stimescaled;
    public ulong Cpu_scaled_run_real_total;
    public ulong Freepages_count;
    public ulong Freepages_delay_total;
    public ulong Thrashing_count;
    public ulong Thrashing_delay_total;
    public ulong Ac_btime64;
}

private partial struct cpuMask { // : uint
}

private static readonly nuint _NCPUBITS = 0x20;


public static readonly nuint CBitFieldMaskBit0 = 0x8000000000000000;
public static readonly nuint CBitFieldMaskBit1 = 0x4000000000000000;
public static readonly nuint CBitFieldMaskBit2 = 0x2000000000000000;
public static readonly nuint CBitFieldMaskBit3 = 0x1000000000000000;
public static readonly nuint CBitFieldMaskBit4 = 0x800000000000000;
public static readonly nuint CBitFieldMaskBit5 = 0x400000000000000;
public static readonly nuint CBitFieldMaskBit6 = 0x200000000000000;
public static readonly nuint CBitFieldMaskBit7 = 0x100000000000000;
public static readonly nuint CBitFieldMaskBit8 = 0x80000000000000;
public static readonly nuint CBitFieldMaskBit9 = 0x40000000000000;
public static readonly nuint CBitFieldMaskBit10 = 0x20000000000000;
public static readonly nuint CBitFieldMaskBit11 = 0x10000000000000;
public static readonly nuint CBitFieldMaskBit12 = 0x8000000000000;
public static readonly nuint CBitFieldMaskBit13 = 0x4000000000000;
public static readonly nuint CBitFieldMaskBit14 = 0x2000000000000;
public static readonly nuint CBitFieldMaskBit15 = 0x1000000000000;
public static readonly nuint CBitFieldMaskBit16 = 0x800000000000;
public static readonly nuint CBitFieldMaskBit17 = 0x400000000000;
public static readonly nuint CBitFieldMaskBit18 = 0x200000000000;
public static readonly nuint CBitFieldMaskBit19 = 0x100000000000;
public static readonly nuint CBitFieldMaskBit20 = 0x80000000000;
public static readonly nuint CBitFieldMaskBit21 = 0x40000000000;
public static readonly nuint CBitFieldMaskBit22 = 0x20000000000;
public static readonly nuint CBitFieldMaskBit23 = 0x10000000000;
public static readonly nuint CBitFieldMaskBit24 = 0x8000000000;
public static readonly nuint CBitFieldMaskBit25 = 0x4000000000;
public static readonly nuint CBitFieldMaskBit26 = 0x2000000000;
public static readonly nuint CBitFieldMaskBit27 = 0x1000000000;
public static readonly nuint CBitFieldMaskBit28 = 0x800000000;
public static readonly nuint CBitFieldMaskBit29 = 0x400000000;
public static readonly nuint CBitFieldMaskBit30 = 0x200000000;
public static readonly nuint CBitFieldMaskBit31 = 0x100000000;
public static readonly nuint CBitFieldMaskBit32 = 0x80000000;
public static readonly nuint CBitFieldMaskBit33 = 0x40000000;
public static readonly nuint CBitFieldMaskBit34 = 0x20000000;
public static readonly nuint CBitFieldMaskBit35 = 0x10000000;
public static readonly nuint CBitFieldMaskBit36 = 0x8000000;
public static readonly nuint CBitFieldMaskBit37 = 0x4000000;
public static readonly nuint CBitFieldMaskBit38 = 0x2000000;
public static readonly nuint CBitFieldMaskBit39 = 0x1000000;
public static readonly nuint CBitFieldMaskBit40 = 0x800000;
public static readonly nuint CBitFieldMaskBit41 = 0x400000;
public static readonly nuint CBitFieldMaskBit42 = 0x200000;
public static readonly nuint CBitFieldMaskBit43 = 0x100000;
public static readonly nuint CBitFieldMaskBit44 = 0x80000;
public static readonly nuint CBitFieldMaskBit45 = 0x40000;
public static readonly nuint CBitFieldMaskBit46 = 0x20000;
public static readonly nuint CBitFieldMaskBit47 = 0x10000;
public static readonly nuint CBitFieldMaskBit48 = 0x8000;
public static readonly nuint CBitFieldMaskBit49 = 0x4000;
public static readonly nuint CBitFieldMaskBit50 = 0x2000;
public static readonly nuint CBitFieldMaskBit51 = 0x1000;
public static readonly nuint CBitFieldMaskBit52 = 0x800;
public static readonly nuint CBitFieldMaskBit53 = 0x400;
public static readonly nuint CBitFieldMaskBit54 = 0x200;
public static readonly nuint CBitFieldMaskBit55 = 0x100;
public static readonly nuint CBitFieldMaskBit56 = 0x80;
public static readonly nuint CBitFieldMaskBit57 = 0x40;
public static readonly nuint CBitFieldMaskBit58 = 0x20;
public static readonly nuint CBitFieldMaskBit59 = 0x10;
public static readonly nuint CBitFieldMaskBit60 = 0x8;
public static readonly nuint CBitFieldMaskBit61 = 0x4;
public static readonly nuint CBitFieldMaskBit62 = 0x2;
public static readonly nuint CBitFieldMaskBit63 = 0x1;


public partial struct SockaddrStorage {
    public ushort Family;
    public array<sbyte> _;
    public uint _;
}

public partial struct HDGeometry {
    public byte Heads;
    public byte Sectors;
    public ushort Cylinders;
    public uint Start;
}

public partial struct Statfs_t {
    public int Type;
    public int Bsize;
    public int Frsize;
    public array<byte> _;
    public ulong Blocks;
    public ulong Bfree;
    public ulong Files;
    public ulong Ffree;
    public ulong Bavail;
    public Fsid Fsid;
    public int Namelen;
    public int Flags;
    public array<int> Spare;
    public array<byte> _;
}

public partial struct TpacketHdr {
    public uint Status;
    public uint Len;
    public uint Snaplen;
    public ushort Mac;
    public ushort Net;
    public uint Sec;
    public uint Usec;
}

public static readonly nuint SizeofTpacketHdr = 0x18;


public partial struct RTCPLLInfo {
    public int Ctrl;
    public int Value;
    public int Max;
    public int Min;
    public int Posmult;
    public int Negmult;
    public int Clock;
}

public partial struct BlkpgPartition {
    public long Start;
    public long Length;
    public int Pno;
    public array<byte> Devname;
    public array<byte> Volname;
    public array<byte> _;
}

public static readonly nuint BLKPG = 0x20001269;


public partial struct XDPUmemReg {
    public ulong Addr;
    public ulong Len;
    public uint Size;
    public uint Headroom;
    public uint Flags;
    public array<byte> _;
}

public partial struct CryptoUserAlg {
    public array<sbyte> Name;
    public array<sbyte> Driver_name;
    public array<sbyte> Module_name;
    public uint Type;
    public uint Mask;
    public uint Refcnt;
    public uint Flags;
}

public partial struct CryptoStatAEAD {
    public array<sbyte> Type;
    public ulong Encrypt_cnt;
    public ulong Encrypt_tlen;
    public ulong Decrypt_cnt;
    public ulong Decrypt_tlen;
    public ulong Err_cnt;
}

public partial struct CryptoStatAKCipher {
    public array<sbyte> Type;
    public ulong Encrypt_cnt;
    public ulong Encrypt_tlen;
    public ulong Decrypt_cnt;
    public ulong Decrypt_tlen;
    public ulong Verify_cnt;
    public ulong Sign_cnt;
    public ulong Err_cnt;
}

public partial struct CryptoStatCipher {
    public array<sbyte> Type;
    public ulong Encrypt_cnt;
    public ulong Encrypt_tlen;
    public ulong Decrypt_cnt;
    public ulong Decrypt_tlen;
    public ulong Err_cnt;
}

public partial struct CryptoStatCompress {
    public array<sbyte> Type;
    public ulong Compress_cnt;
    public ulong Compress_tlen;
    public ulong Decompress_cnt;
    public ulong Decompress_tlen;
    public ulong Err_cnt;
}

public partial struct CryptoStatHash {
    public array<sbyte> Type;
    public ulong Hash_cnt;
    public ulong Hash_tlen;
    public ulong Err_cnt;
}

public partial struct CryptoStatKPP {
    public array<sbyte> Type;
    public ulong Setsecret_cnt;
    public ulong Generate_public_key_cnt;
    public ulong Compute_shared_secret_cnt;
    public ulong Err_cnt;
}

public partial struct CryptoStatRNG {
    public array<sbyte> Type;
    public ulong Generate_cnt;
    public ulong Generate_tlen;
    public ulong Seed_cnt;
    public ulong Err_cnt;
}

public partial struct CryptoStatLarval {
    public array<sbyte> Type;
}

public partial struct CryptoReportLarval {
    public array<sbyte> Type;
}

public partial struct CryptoReportHash {
    public array<sbyte> Type;
    public uint Blocksize;
    public uint Digestsize;
}

public partial struct CryptoReportCipher {
    public array<sbyte> Type;
    public uint Blocksize;
    public uint Min_keysize;
    public uint Max_keysize;
}

public partial struct CryptoReportBlkCipher {
    public array<sbyte> Type;
    public array<sbyte> Geniv;
    public uint Blocksize;
    public uint Min_keysize;
    public uint Max_keysize;
    public uint Ivsize;
}

public partial struct CryptoReportAEAD {
    public array<sbyte> Type;
    public array<sbyte> Geniv;
    public uint Blocksize;
    public uint Maxauthsize;
    public uint Ivsize;
}

public partial struct CryptoReportComp {
    public array<sbyte> Type;
}

public partial struct CryptoReportRNG {
    public array<sbyte> Type;
    public uint Seedsize;
}

public partial struct CryptoReportAKCipher {
    public array<sbyte> Type;
}

public partial struct CryptoReportKPP {
    public array<sbyte> Type;
}

public partial struct CryptoReportAcomp {
    public array<sbyte> Type;
}

public partial struct LoopInfo {
    public int Number;
    public uint Device;
    public uint Inode;
    public uint Rdevice;
    public int Offset;
    public int Encrypt_type;
    public int Encrypt_key_size;
    public int Flags;
    public array<sbyte> Name;
    public array<byte> Encrypt_key;
    public array<uint> Init;
    public array<sbyte> Reserved;
}

public partial struct TIPCSubscr {
    public TIPCServiceRange Seq;
    public uint Timeout;
    public uint Filter;
    public array<sbyte> Handle;
}

public partial struct TIPCSIOCLNReq {
    public uint Peer;
    public uint Id;
    public array<sbyte> Linkname;
}

public partial struct TIPCSIOCNodeIDReq {
    public uint Peer;
    public array<sbyte> Id;
}

public partial struct PPSKInfo {
    public uint Assert_sequence;
    public uint Clear_sequence;
    public PPSKTime Assert_tu;
    public PPSKTime Clear_tu;
    public int Current_mode;
    public array<byte> _;
}

public static readonly nuint PPS_GETPARAMS = 0x400470a1;
public static readonly nuint PPS_SETPARAMS = 0x800470a2;
public static readonly nuint PPS_GETCAP = 0x400470a3;
public static readonly nuint PPS_FETCH = 0xc00470a4;


} // end unix_package
