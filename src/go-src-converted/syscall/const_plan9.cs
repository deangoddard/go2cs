// package syscall -- go2cs converted at 2022 March 06 22:08:08 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Program Files\Go\src\syscall\const_plan9.go


namespace go;

public static partial class syscall_package {

    // Plan 9 Constants

    // Open modes
public static readonly nint O_RDONLY = 0;
public static readonly nint O_WRONLY = 1;
public static readonly nint O_RDWR = 2;
public static readonly nint O_TRUNC = 16;
public static readonly nint O_CLOEXEC = 32;
public static readonly nuint O_EXCL = 0x1000;


// Bind flags
public static readonly nuint MORDER = 0x0003; // mask for bits defining order of mounting
public static readonly nuint MREPL = 0x0000; // mount replaces object
public static readonly nuint MBEFORE = 0x0001; // mount goes before others in union directory
public static readonly nuint MAFTER = 0x0002; // mount goes after others in union directory
public static readonly nuint MCREATE = 0x0004; // permit creation in mounted directory
public static readonly nuint MCACHE = 0x0010; // cache some data
public static readonly nuint MMASK = 0x0017; // all bits on

// Rfork flags
public static readonly nint RFNAMEG = 1 << 0;
public static readonly nint RFENVG = 1 << 1;
public static readonly nint RFFDG = 1 << 2;
public static readonly nint RFNOTEG = 1 << 3;
public static readonly nint RFPROC = 1 << 4;
public static readonly nint RFMEM = 1 << 5;
public static readonly nint RFNOWAIT = 1 << 6;
public static readonly nint RFCNAMEG = 1 << 10;
public static readonly nint RFCENVG = 1 << 11;
public static readonly nint RFCFDG = 1 << 12;
public static readonly nint RFREND = 1 << 13;
public static readonly nint RFNOMNT = 1 << 14;


// Qid.Type bits
public static readonly nuint QTDIR = 0x80;
public static readonly nuint QTAPPEND = 0x40;
public static readonly nuint QTEXCL = 0x20;
public static readonly nuint QTMOUNT = 0x10;
public static readonly nuint QTAUTH = 0x08;
public static readonly nuint QTTMP = 0x04;
public static readonly nuint QTFILE = 0x00;


// Dir.Mode bits
public static readonly nuint DMDIR = 0x80000000;
public static readonly nuint DMAPPEND = 0x40000000;
public static readonly nuint DMEXCL = 0x20000000;
public static readonly nuint DMMOUNT = 0x10000000;
public static readonly nuint DMAUTH = 0x08000000;
public static readonly nuint DMTMP = 0x04000000;
public static readonly nuint DMREAD = 0x4;
public static readonly nuint DMWRITE = 0x2;
public static readonly nuint DMEXEC = 0x1;


public static readonly nint STATMAX = 65535;
public static readonly nint ERRMAX = 128;
public static readonly nint STATFIXLEN = 49;


} // end syscall_package
