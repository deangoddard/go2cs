// Copyright 2020 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

//go:build zos && s390x
// +build zos,s390x

// Hand edited based on zerrors_linux_s390x.go
// TODO: auto-generate.

// package unix -- go2cs converted at 2022 March 06 23:27:53 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Program Files\Go\src\cmd\vendor\golang.org\x\sys\unix\zerrors_zos_s390x.go


namespace go.cmd.vendor.golang.org.x.sys;

public static partial class unix_package {

public static readonly nuint BRKINT = 0x0001;
public static readonly nuint CLOCK_MONOTONIC = 0x1;
public static readonly nuint CLOCK_PROCESS_CPUTIME_ID = 0x2;
public static readonly nuint CLOCK_REALTIME = 0x0;
public static readonly nuint CLOCK_THREAD_CPUTIME_ID = 0x3;
public static readonly nuint CS8 = 0x0030;
public static readonly nuint CSIZE = 0x0030;
public static readonly nuint ECHO = 0x00000008;
public static readonly nuint ECHONL = 0x00000001;
public static readonly nuint FD_CLOEXEC = 0x01;
public static readonly nuint FD_CLOFORK = 0x02;
public static readonly nuint FNDELAY = 0x04;
public static readonly nint F_CLOSFD = 9;
public static readonly nint F_CONTROL_CVT = 13;
public static readonly nint F_DUPFD = 0;
public static readonly nint F_DUPFD2 = 8;
public static readonly nint F_GETFD = 1;
public static readonly nint F_GETFL = 259;
public static readonly nint F_GETLK = 5;
public static readonly nint F_GETOWN = 10;
public static readonly nuint F_OK = 0x0;
public static readonly nint F_RDLCK = 1;
public static readonly nint F_SETFD = 2;
public static readonly nint F_SETFL = 4;
public static readonly nint F_SETLK = 6;
public static readonly nint F_SETLKW = 7;
public static readonly nint F_SETOWN = 11;
public static readonly nint F_SETTAG = 12;
public static readonly nint F_UNLCK = 3;
public static readonly nint F_WRLCK = 2;
public static readonly nuint FSTYPE_ZFS = 0xe9; //"Z"
public static readonly nuint FSTYPE_HFS = 0xc8; //"H"
public static readonly nuint FSTYPE_NFS = 0xd5; //"N"
public static readonly nuint FSTYPE_TFS = 0xe3; //"T"
public static readonly nuint FSTYPE_AUTOMOUNT = 0xc1; //"A"
public static readonly nuint IP6F_MORE_FRAG = 0x0001;
public static readonly nuint IP6F_OFF_MASK = 0xfff8;
public static readonly nuint IP6F_RESERVED_MASK = 0x0006;
public static readonly nuint IP6OPT_JUMBO = 0xc2;
public static readonly nint IP6OPT_JUMBO_LEN = 6;
public static readonly nuint IP6OPT_MUTABLE = 0x20;
public static readonly nuint IP6OPT_NSAP_ADDR = 0xc3;
public static readonly nuint IP6OPT_PAD1 = 0x00;
public static readonly nuint IP6OPT_PADN = 0x01;
public static readonly nuint IP6OPT_ROUTER_ALERT = 0x05;
public static readonly nuint IP6OPT_TUNNEL_LIMIT = 0x04;
public static readonly nuint IP6OPT_TYPE_DISCARD = 0x40;
public static readonly nuint IP6OPT_TYPE_FORCEICMP = 0x80;
public static readonly nuint IP6OPT_TYPE_ICMP = 0xc0;
public static readonly nuint IP6OPT_TYPE_SKIP = 0x00;
public static readonly nuint IP6_ALERT_AN = 0x0002;
public static readonly nuint IP6_ALERT_MLD = 0x0000;
public static readonly nuint IP6_ALERT_RSVP = 0x0001;
public static readonly nint IPPORT_RESERVED = 1024;
public static readonly nint IPPORT_USERRESERVED = 5000;
public static readonly nint IPPROTO_AH = 51;
public static readonly nint SOL_AH = 51;
public static readonly nint IPPROTO_DSTOPTS = 60;
public static readonly nint SOL_DSTOPTS = 60;
public static readonly nint IPPROTO_EGP = 8;
public static readonly nint SOL_EGP = 8;
public static readonly nint IPPROTO_ESP = 50;
public static readonly nint SOL_ESP = 50;
public static readonly nint IPPROTO_FRAGMENT = 44;
public static readonly nint SOL_FRAGMENT = 44;
public static readonly nint IPPROTO_GGP = 2;
public static readonly nint SOL_GGP = 2;
public static readonly nint IPPROTO_HOPOPTS = 0;
public static readonly nint SOL_HOPOPTS = 0;
public static readonly nint IPPROTO_ICMP = 1;
public static readonly nint SOL_ICMP = 1;
public static readonly nint IPPROTO_ICMPV6 = 58;
public static readonly nint SOL_ICMPV6 = 58;
public static readonly nint IPPROTO_IDP = 22;
public static readonly nint SOL_IDP = 22;
public static readonly nint IPPROTO_IP = 0;
public static readonly nint SOL_IP = 0;
public static readonly nint IPPROTO_IPV6 = 41;
public static readonly nint SOL_IPV6 = 41;
public static readonly nint IPPROTO_MAX = 256;
public static readonly nint SOL_MAX = 256;
public static readonly nint IPPROTO_NONE = 59;
public static readonly nint SOL_NONE = 59;
public static readonly nint IPPROTO_PUP = 12;
public static readonly nint SOL_PUP = 12;
public static readonly nint IPPROTO_RAW = 255;
public static readonly nint SOL_RAW = 255;
public static readonly nint IPPROTO_ROUTING = 43;
public static readonly nint SOL_ROUTING = 43;
public static readonly nint IPPROTO_TCP = 6;
public static readonly nint SOL_TCP = 6;
public static readonly nint IPPROTO_UDP = 17;
public static readonly nint SOL_UDP = 17;
public static readonly nint IPV6_ADDR_PREFERENCES = 32;
public static readonly nint IPV6_CHECKSUM = 19;
public static readonly nint IPV6_DONTFRAG = 29;
public static readonly nint IPV6_DSTOPTS = 23;
public static readonly nint IPV6_HOPLIMIT = 11;
public static readonly nint IPV6_HOPOPTS = 22;
public static readonly nint IPV6_JOIN_GROUP = 5;
public static readonly nint IPV6_LEAVE_GROUP = 6;
public static readonly nint IPV6_MULTICAST_HOPS = 9;
public static readonly nint IPV6_MULTICAST_IF = 7;
public static readonly nint IPV6_MULTICAST_LOOP = 4;
public static readonly nint IPV6_NEXTHOP = 20;
public static readonly nint IPV6_PATHMTU = 12;
public static readonly nint IPV6_PKTINFO = 13;
public static readonly nuint IPV6_PREFER_SRC_CGA = 0x10;
public static readonly nuint IPV6_PREFER_SRC_COA = 0x02;
public static readonly nuint IPV6_PREFER_SRC_HOME = 0x01;
public static readonly nuint IPV6_PREFER_SRC_NONCGA = 0x20;
public static readonly nuint IPV6_PREFER_SRC_PUBLIC = 0x08;
public static readonly nuint IPV6_PREFER_SRC_TMP = 0x04;
public static readonly nint IPV6_RECVDSTOPTS = 28;
public static readonly nint IPV6_RECVHOPLIMIT = 14;
public static readonly nint IPV6_RECVHOPOPTS = 26;
public static readonly nint IPV6_RECVPATHMTU = 16;
public static readonly nint IPV6_RECVPKTINFO = 15;
public static readonly nint IPV6_RECVRTHDR = 25;
public static readonly nint IPV6_RECVTCLASS = 31;
public static readonly nint IPV6_RTHDR = 21;
public static readonly nint IPV6_RTHDRDSTOPTS = 24;
public static readonly nint IPV6_RTHDR_TYPE_0 = 0;
public static readonly nint IPV6_TCLASS = 30;
public static readonly nint IPV6_UNICAST_HOPS = 3;
public static readonly nint IPV6_USE_MIN_MTU = 18;
public static readonly nint IPV6_V6ONLY = 10;
public static readonly nint IP_ADD_MEMBERSHIP = 5;
public static readonly nint IP_ADD_SOURCE_MEMBERSHIP = 12;
public static readonly nint IP_BLOCK_SOURCE = 10;
public static readonly nint IP_DEFAULT_MULTICAST_LOOP = 1;
public static readonly nint IP_DEFAULT_MULTICAST_TTL = 1;
public static readonly nint IP_DROP_MEMBERSHIP = 6;
public static readonly nint IP_DROP_SOURCE_MEMBERSHIP = 13;
public static readonly nint IP_MAX_MEMBERSHIPS = 20;
public static readonly nint IP_MULTICAST_IF = 7;
public static readonly nint IP_MULTICAST_LOOP = 4;
public static readonly nint IP_MULTICAST_TTL = 3;
public static readonly nint IP_OPTIONS = 1;
public static readonly nint IP_PKTINFO = 101;
public static readonly nint IP_RECVPKTINFO = 102;
public static readonly nint IP_TOS = 2;
public static readonly nint IP_TTL = 3;
public static readonly nint IP_UNBLOCK_SOURCE = 11;
public static readonly nuint ICANON = 0x0010;
public static readonly nuint ICMP6_FILTER = 0x26;
public static readonly nuint ICRNL = 0x0002;
public static readonly nuint IEXTEN = 0x0020;
public static readonly nuint IGNBRK = 0x0004;
public static readonly nuint IGNCR = 0x0008;
public static readonly nuint INLCR = 0x0020;
public static readonly nuint ISIG = 0x0040;
public static readonly nuint ISTRIP = 0x0080;
public static readonly nuint IXON = 0x0200;
public static readonly nuint IXOFF = 0x0100;
public static readonly nuint LOCK_SH = 0x1; // Not exist on zOS
public static readonly nuint LOCK_EX = 0x2; // Not exist on zOS
public static readonly nuint LOCK_NB = 0x4; // Not exist on zOS
public static readonly nuint LOCK_UN = 0x8; // Not exist on zOS
public static readonly nuint POLLIN = 0x0003;
public static readonly nuint POLLOUT = 0x0004;
public static readonly nuint POLLPRI = 0x0010;
public static readonly nuint POLLERR = 0x0020;
public static readonly nuint POLLHUP = 0x0040;
public static readonly nuint POLLNVAL = 0x0080;
public static readonly nuint PROT_READ = 0x1; // mmap - page can be read
public static readonly nuint PROT_WRITE = 0x2; // page can be written
public static readonly nuint PROT_NONE = 0x4; // can't be accessed
public static readonly nuint PROT_EXEC = 0x8; // can be executed
public static readonly nuint MAP_PRIVATE = 0x1; // changes are private
public static readonly nuint MAP_SHARED = 0x2; // changes are shared
public static readonly nuint MAP_FIXED = 0x4; // place exactly
public static readonly nint MCAST_JOIN_GROUP = 40;
public static readonly nint MCAST_LEAVE_GROUP = 41;
public static readonly nint MCAST_JOIN_SOURCE_GROUP = 42;
public static readonly nint MCAST_LEAVE_SOURCE_GROUP = 43;
public static readonly nint MCAST_BLOCK_SOURCE = 44;
public static readonly nint MCAST_UNBLOCK_SOURCE = 45;
public static readonly nuint MS_SYNC = 0x1; // msync - synchronous writes
public static readonly nuint MS_ASYNC = 0x2; // asynchronous writes
public static readonly nuint MS_INVALIDATE = 0x4; // invalidate mappings
public static readonly nuint MTM_RDONLY = 0x80000000;
public static readonly nuint MTM_RDWR = 0x40000000;
public static readonly nuint MTM_UMOUNT = 0x10000000;
public static readonly nuint MTM_IMMED = 0x08000000;
public static readonly nuint MTM_FORCE = 0x04000000;
public static readonly nuint MTM_DRAIN = 0x02000000;
public static readonly nuint MTM_RESET = 0x01000000;
public static readonly nuint MTM_SAMEMODE = 0x00100000;
public static readonly nuint MTM_UNQSEFORCE = 0x00040000;
public static readonly nuint MTM_NOSUID = 0x00000400;
public static readonly nuint MTM_SYNCHONLY = 0x00000200;
public static readonly nuint MTM_REMOUNT = 0x00000100;
public static readonly nuint MTM_NOSECURITY = 0x00000080;
public static readonly nuint NFDBITS = 0x20;
public static readonly nuint O_ACCMODE = 0x03;
public static readonly nuint O_APPEND = 0x08;
public static readonly nuint O_ASYNCSIG = 0x0200;
public static readonly nuint O_CREAT = 0x80;
public static readonly nuint O_EXCL = 0x40;
public static readonly nuint O_GETFL = 0x0F;
public static readonly nuint O_LARGEFILE = 0x0400;
public static readonly nuint O_NONBLOCK = 0x04;
public static readonly nuint O_RDONLY = 0x02;
public static readonly nuint O_RDWR = 0x03;
public static readonly nuint O_SYNC = 0x0100;
public static readonly nuint O_TRUNC = 0x10;
public static readonly nuint O_WRONLY = 0x01;
public static readonly nuint O_NOCTTY = 0x20;
public static readonly nuint OPOST = 0x0001;
public static readonly nuint ONLCR = 0x0004;
public static readonly nuint PARENB = 0x0200;
public static readonly nuint PARMRK = 0x0400;
public static readonly nint QUERYCVT = 3;
public static readonly nuint RUSAGE_CHILDREN = -0x1;
public static readonly nuint RUSAGE_SELF = 0x0; // RUSAGE_THREAD unsupported on z/OS
public static readonly nint SEEK_CUR = 1;
public static readonly nint SEEK_END = 2;
public static readonly nint SEEK_SET = 0;
public static readonly nint SETAUTOCVTALL = 5;
public static readonly nint SETAUTOCVTON = 2;
public static readonly nint SETCVTALL = 4;
public static readonly nint SETCVTOFF = 0;
public static readonly nint SETCVTON = 1;
public static readonly nint AF_APPLETALK = 16;
public static readonly nint AF_CCITT = 10;
public static readonly nint AF_CHAOS = 5;
public static readonly nint AF_DATAKIT = 9;
public static readonly nint AF_DLI = 13;
public static readonly nint AF_ECMA = 8;
public static readonly nint AF_HYLINK = 15;
public static readonly nint AF_IMPLINK = 3;
public static readonly nint AF_INET = 2;
public static readonly nint AF_INET6 = 19;
public static readonly nint AF_INTF = 20;
public static readonly nint AF_IUCV = 17;
public static readonly nint AF_LAT = 14;
public static readonly nint AF_LINK = 18;
public static readonly nint AF_MAX = 30;
public static readonly nint AF_NBS = 7;
public static readonly nint AF_NDD = 23;
public static readonly nint AF_NETWARE = 22;
public static readonly nint AF_NS = 6;
public static readonly nint AF_PUP = 4;
public static readonly nint AF_RIF = 21;
public static readonly nint AF_ROUTE = 20;
public static readonly nint AF_SNA = 11;
public static readonly nint AF_UNIX = 1;
public static readonly nint AF_UNSPEC = 0;
public static readonly nint IBMTCP_IMAGE = 1;
public static readonly nuint MSG_ACK_EXPECTED = 0x10;
public static readonly nuint MSG_ACK_GEN = 0x40;
public static readonly nuint MSG_ACK_TIMEOUT = 0x20;
public static readonly nuint MSG_CONNTERM = 0x80;
public static readonly nuint MSG_CTRUNC = 0x20;
public static readonly nuint MSG_DONTROUTE = 0x4;
public static readonly nuint MSG_EOF = 0x8000;
public static readonly nuint MSG_EOR = 0x8;
public static readonly nint MSG_MAXIOVLEN = 16;
public static readonly nuint MSG_NONBLOCK = 0x4000;
public static readonly nuint MSG_OOB = 0x1;
public static readonly nuint MSG_PEEK = 0x2;
public static readonly nuint MSG_TRUNC = 0x10;
public static readonly nuint MSG_WAITALL = 0x40;
public static readonly nint PRIO_PROCESS = 1;
public static readonly nint PRIO_PGRP = 2;
public static readonly nint PRIO_USER = 3;
public static readonly nint RLIMIT_CPU = 0;
public static readonly nint RLIMIT_FSIZE = 1;
public static readonly nint RLIMIT_DATA = 2;
public static readonly nint RLIMIT_STACK = 3;
public static readonly nint RLIMIT_CORE = 4;
public static readonly nint RLIMIT_AS = 5;
public static readonly nint RLIMIT_NOFILE = 6;
public static readonly nint RLIMIT_MEMLIMIT = 7;
public static readonly nint RLIM_INFINITY = 2147483647;
public static readonly nuint SCM_RIGHTS = 0x01;
public static readonly nuint SF_CLOSE = 0x00000002;
public static readonly nuint SF_REUSE = 0x00000001;
public static readonly nint SHUT_RD = 0;
public static readonly nint SHUT_RDWR = 2;
public static readonly nint SHUT_WR = 1;
public static readonly nint SOCK_CONN_DGRAM = 6;
public static readonly nint SOCK_DGRAM = 2;
public static readonly nint SOCK_RAW = 3;
public static readonly nint SOCK_RDM = 4;
public static readonly nint SOCK_SEQPACKET = 5;
public static readonly nint SOCK_STREAM = 1;
public static readonly nuint SOL_SOCKET = 0xffff;
public static readonly nint SOMAXCONN = 10;
public static readonly nuint SO_ACCEPTCONN = 0x0002;
public static readonly nuint SO_ACCEPTECONNABORTED = 0x0006;
public static readonly nuint SO_ACKNOW = 0x7700;
public static readonly nuint SO_BROADCAST = 0x0020;
public static readonly nuint SO_BULKMODE = 0x8000;
public static readonly nuint SO_CKSUMRECV = 0x0800;
public static readonly nuint SO_CLOSE = 0x01;
public static readonly nuint SO_CLUSTERCONNTYPE = 0x00004001;
public static readonly nint SO_CLUSTERCONNTYPE_INTERNAL = 8;
public static readonly nint SO_CLUSTERCONNTYPE_NOCONN = 0;
public static readonly nint SO_CLUSTERCONNTYPE_NONE = 1;
public static readonly nint SO_CLUSTERCONNTYPE_SAME_CLUSTER = 2;
public static readonly nint SO_CLUSTERCONNTYPE_SAME_IMAGE = 4;
public static readonly nuint SO_DEBUG = 0x0001;
public static readonly nuint SO_DONTROUTE = 0x0010;
public static readonly nuint SO_ERROR = 0x1007;
public static readonly nuint SO_IGNOREINCOMINGPUSH = 0x1;
public static readonly nuint SO_IGNORESOURCEVIPA = 0x0002;
public static readonly nuint SO_KEEPALIVE = 0x0008;
public static readonly nuint SO_LINGER = 0x0080;
public static readonly nuint SO_NONBLOCKLOCAL = 0x8001;
public static readonly nuint SO_NOREUSEADDR = 0x1000;
public static readonly nuint SO_OOBINLINE = 0x0100;
public static readonly nuint SO_OPTACK = 0x8004;
public static readonly nuint SO_OPTMSS = 0x8003;
public static readonly nuint SO_RCVBUF = 0x1002;
public static readonly nuint SO_RCVLOWAT = 0x1004;
public static readonly nuint SO_RCVTIMEO = 0x1006;
public static readonly nuint SO_REUSEADDR = 0x0004;
public static readonly nuint SO_REUSEPORT = 0x0200;
public static readonly nuint SO_SECINFO = 0x00004002;
public static readonly nuint SO_SET = 0x0200;
public static readonly nuint SO_SNDBUF = 0x1001;
public static readonly nuint SO_SNDLOWAT = 0x1003;
public static readonly nuint SO_SNDTIMEO = 0x1005;
public static readonly nuint SO_TYPE = 0x1008;
public static readonly nuint SO_UNSET = 0x0400;
public static readonly nuint SO_USELOOPBACK = 0x0040;
public static readonly nuint SO_USE_IFBUFS = 0x0400;
public static readonly nuint S_ISUID = 0x0800;
public static readonly nuint S_ISGID = 0x0400;
public static readonly nuint S_ISVTX = 0x0200;
public static readonly nuint S_IRUSR = 0x0100;
public static readonly nuint S_IWUSR = 0x0080;
public static readonly nuint S_IXUSR = 0x0040;
public static readonly nuint S_IRWXU = 0x01C0;
public static readonly nuint S_IRGRP = 0x0020;
public static readonly nuint S_IWGRP = 0x0010;
public static readonly nuint S_IXGRP = 0x0008;
public static readonly nuint S_IRWXG = 0x0038;
public static readonly nuint S_IROTH = 0x0004;
public static readonly nuint S_IWOTH = 0x0002;
public static readonly nuint S_IXOTH = 0x0001;
public static readonly nuint S_IRWXO = 0x0007;
public static readonly var S_IREAD = S_IRUSR;
public static readonly var S_IWRITE = S_IWUSR;
public static readonly var S_IEXEC = S_IXUSR;
public static readonly nuint S_IFDIR = 0x01000000;
public static readonly nuint S_IFCHR = 0x02000000;
public static readonly nuint S_IFREG = 0x03000000;
public static readonly nuint S_IFFIFO = 0x04000000;
public static readonly nuint S_IFIFO = 0x04000000;
public static readonly nuint S_IFLNK = 0x05000000;
public static readonly nuint S_IFBLK = 0x06000000;
public static readonly nuint S_IFSOCK = 0x07000000;
public static readonly nuint S_IFVMEXTL = 0xFE000000;
public static readonly nuint S_IFVMEXTL_EXEC = 0x00010000;
public static readonly nuint S_IFVMEXTL_DATA = 0x00020000;
public static readonly nuint S_IFVMEXTL_MEL = 0x00030000;
public static readonly nuint S_IFEXTL = 0x00000001;
public static readonly nuint S_IFPROGCTL = 0x00000002;
public static readonly nuint S_IFAPFCTL = 0x00000004;
public static readonly nuint S_IFNOSHARE = 0x00000008;
public static readonly nuint S_IFSHARELIB = 0x00000010;
public static readonly nuint S_IFMT = 0xFF000000;
public static readonly nuint S_IFMST = 0x00FF0000;
public static readonly nuint TCP_KEEPALIVE = 0x8;
public static readonly nuint TCP_NODELAY = 0x1;
public static readonly nuint TCP_INFO = 0xb;
public static readonly nuint TCP_USER_TIMEOUT = 0x1;
public static readonly nuint TIOCGWINSZ = 0x4008a368;
public static readonly nuint TIOCSWINSZ = 0x8008a367;
public static readonly nuint TIOCSBRK = 0x2000a77b;
public static readonly nuint TIOCCBRK = 0x2000a77a;
public static readonly nuint TIOCSTI = 0x8001a772;
public static readonly nuint TIOCGPGRP = 0x4004a777; // _IOR(167, 119, int)
public static readonly nint TCSANOW = 0;
public static readonly nint TCSETS = 0; // equivalent to TCSANOW for tcsetattr
public static readonly nint TCSADRAIN = 1;
public static readonly nint TCSETSW = 1; // equivalent to TCSADRAIN for tcsetattr
public static readonly nint TCSAFLUSH = 2;
public static readonly nint TCSETSF = 2; // equivalent to TCSAFLUSH for tcsetattr
public static readonly nint TCGETS = 3; // not defined in ioctl.h -- zos golang only
public static readonly nint TCIFLUSH = 0;
public static readonly nint TCOFLUSH = 1;
public static readonly nint TCIOFLUSH = 2;
public static readonly nint TCOOFF = 0;
public static readonly nint TCOON = 1;
public static readonly nint TCIOFF = 2;
public static readonly nint TCION = 3;
public static readonly nuint TIOCSPGRP = 0x8004a776;
public static readonly nuint TIOCNOTTY = 0x2000a771;
public static readonly nuint TIOCEXCL = 0x2000a70d;
public static readonly nuint TIOCNXCL = 0x2000a70e;
public static readonly nuint TIOCGETD = 0x4004a700;
public static readonly nuint TIOCSETD = 0x8004a701;
public static readonly nuint TIOCPKT = 0x8004a770;
public static readonly nuint TIOCSTOP = 0x2000a76f;
public static readonly nuint TIOCSTART = 0x2000a76e;
public static readonly nuint TIOCUCNTL = 0x8004a766;
public static readonly nuint TIOCREMOTE = 0x8004a769;
public static readonly nuint TIOCMGET = 0x4004a76a;
public static readonly nuint TIOCMSET = 0x8004a76d;
public static readonly nuint TIOCMBIC = 0x8004a76b;
public static readonly nuint TIOCMBIS = 0x8004a76c;
public static readonly nint VINTR = 0;
public static readonly nint VQUIT = 1;
public static readonly nint VERASE = 2;
public static readonly nint VKILL = 3;
public static readonly nint VEOF = 4;
public static readonly nint VEOL = 5;
public static readonly nint VMIN = 6;
public static readonly nint VSTART = 7;
public static readonly nint VSTOP = 8;
public static readonly nint VSUSP = 9;
public static readonly nint VTIME = 10;
public static readonly nuint WCONTINUED = 0x4;
public static readonly nuint WNOHANG = 0x1;
public static readonly nuint WUNTRACED = 0x2;
private static readonly nint _BPX_SWAP = 1;
private static readonly nint _BPX_NONSWAP = 2;
public static readonly nint MCL_CURRENT = 1; // for Linux compatibility -- no zos semantics
public static readonly nint MCL_FUTURE = 2; // for Linux compatibility -- no zos semantics
public static readonly nint MCL_ONFAULT = 3; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_NORMAL = 0; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_RANDOM = 1; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_SEQUENTIAL = 2; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_WILLNEED = 3; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_REMOVE = 4; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_DONTFORK = 5; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_DOFORK = 6; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_HWPOISON = 7; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_MERGEABLE = 8; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_UNMERGEABLE = 9; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_SOFT_OFFLINE = 10; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_HUGEPAGE = 11; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_NOHUGEPAGE = 12; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_DONTDUMP = 13; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_DODUMP = 14; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_FREE = 15; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_WIPEONFORK = 16; // for Linux compatibility -- no zos semantics
public static readonly nint MADV_KEEPONFORK = 17; // for Linux compatibility -- no zos semantics
public static readonly nint AT_SYMLINK_NOFOLLOW = 1; // for Unix  compatibility -- no zos semantics
public static readonly nint AT_FDCWD = 2; // for Unix  compatibility -- no zos semantics

public static readonly var EDOM = Errno(1);
public static readonly var ERANGE = Errno(2);
public static readonly var EACCES = Errno(111);
public static readonly var EAGAIN = Errno(112);
public static readonly var EBADF = Errno(113);
public static readonly var EBUSY = Errno(114);
public static readonly var ECHILD = Errno(115);
public static readonly var EDEADLK = Errno(116);
public static readonly var EEXIST = Errno(117);
public static readonly var EFAULT = Errno(118);
public static readonly var EFBIG = Errno(119);
public static readonly var EINTR = Errno(120);
public static readonly var EINVAL = Errno(121);
public static readonly var EIO = Errno(122);
public static readonly var EISDIR = Errno(123);
public static readonly var EMFILE = Errno(124);
public static readonly var EMLINK = Errno(125);
public static readonly var ENAMETOOLONG = Errno(126);
public static readonly var ENFILE = Errno(127);
public static readonly var ENODEV = Errno(128);
public static readonly var ENOENT = Errno(129);
public static readonly var ENOEXEC = Errno(130);
public static readonly var ENOLCK = Errno(131);
public static readonly var ENOMEM = Errno(132);
public static readonly var ENOSPC = Errno(133);
public static readonly var ENOSYS = Errno(134);
public static readonly var ENOTDIR = Errno(135);
public static readonly var ENOTEMPTY = Errno(136);
public static readonly var ENOTTY = Errno(137);
public static readonly var ENXIO = Errno(138);
public static readonly var EPERM = Errno(139);
public static readonly var EPIPE = Errno(140);
public static readonly var EROFS = Errno(141);
public static readonly var ESPIPE = Errno(142);
public static readonly var ESRCH = Errno(143);
public static readonly var EXDEV = Errno(144);
public static readonly var E2BIG = Errno(145);
public static readonly var ELOOP = Errno(146);
public static readonly var EILSEQ = Errno(147);
public static readonly var ENODATA = Errno(148);
public static readonly var EOVERFLOW = Errno(149);
public static readonly var EMVSNOTUP = Errno(150);
public static readonly var ECMSSTORAGE = Errno(151);
public static readonly var EMVSDYNALC = Errno(151);
public static readonly var EMVSCVAF = Errno(152);
public static readonly var EMVSCATLG = Errno(153);
public static readonly var ECMSINITIAL = Errno(156);
public static readonly var EMVSINITIAL = Errno(156);
public static readonly var ECMSERR = Errno(157);
public static readonly var EMVSERR = Errno(157);
public static readonly var EMVSPARM = Errno(158);
public static readonly var ECMSPFSFILE = Errno(159);
public static readonly var EMVSPFSFILE = Errno(159);
public static readonly var EMVSBADCHAR = Errno(160);
public static readonly var ECMSPFSPERM = Errno(162);
public static readonly var EMVSPFSPERM = Errno(162);
public static readonly var EMVSSAFEXTRERR = Errno(163);
public static readonly var EMVSSAF2ERR = Errno(164);
public static readonly var EMVSTODNOTSET = Errno(165);
public static readonly var EMVSPATHOPTS = Errno(166);
public static readonly var EMVSNORTL = Errno(167);
public static readonly var EMVSEXPIRE = Errno(168);
public static readonly var EMVSPASSWORD = Errno(169);
public static readonly var EMVSWLMERROR = Errno(170);
public static readonly var EMVSCPLERROR = Errno(171);
public static readonly var EMVSARMERROR = Errno(172);
public static readonly var ELENOFORK = Errno(200);
public static readonly var ELEMSGERR = Errno(201);
public static readonly var EFPMASKINV = Errno(202);
public static readonly var EFPMODEINV = Errno(203);
public static readonly var EBUFLEN = Errno(227);
public static readonly var EEXTLINK = Errno(228);
public static readonly var ENODD = Errno(229);
public static readonly var ECMSESMERR = Errno(230);
public static readonly var ECPERR = Errno(231);
public static readonly var ELEMULTITHREAD = Errno(232);
public static readonly var ELEFENCE = Errno(244);
public static readonly var EBADDATA = Errno(245);
public static readonly var EUNKNOWN = Errno(246);
public static readonly var ENOTSUP = Errno(247);
public static readonly var EBADNAME = Errno(248);
public static readonly var ENOTSAFE = Errno(249);
public static readonly var ELEMULTITHREADFORK = Errno(257);
public static readonly var ECUNNOENV = Errno(258);
public static readonly var ECUNNOCONV = Errno(259);
public static readonly var ECUNNOTALIGNED = Errno(260);
public static readonly var ECUNERR = Errno(262);
public static readonly var EIBMBADCALL = Errno(1000);
public static readonly var EIBMBADPARM = Errno(1001);
public static readonly var EIBMSOCKOUTOFRANGE = Errno(1002);
public static readonly var EIBMSOCKINUSE = Errno(1003);
public static readonly var EIBMIUCVERR = Errno(1004);
public static readonly var EOFFLOADboxERROR = Errno(1005);
public static readonly var EOFFLOADboxRESTART = Errno(1006);
public static readonly var EOFFLOADboxDOWN = Errno(1007);
public static readonly var EIBMCONFLICT = Errno(1008);
public static readonly var EIBMCANCELLED = Errno(1009);
public static readonly var EIBMBADTCPNAME = Errno(1011);
public static readonly var ENOTBLK = Errno(1100);
public static readonly var ETXTBSY = Errno(1101);
public static readonly var EWOULDBLOCK = Errno(1102);
public static readonly var EINPROGRESS = Errno(1103);
public static readonly var EALREADY = Errno(1104);
public static readonly var ENOTSOCK = Errno(1105);
public static readonly var EDESTADDRREQ = Errno(1106);
public static readonly var EMSGSIZE = Errno(1107);
public static readonly var EPROTOTYPE = Errno(1108);
public static readonly var ENOPROTOOPT = Errno(1109);
public static readonly var EPROTONOSUPPORT = Errno(1110);
public static readonly var ESOCKTNOSUPPORT = Errno(1111);
public static readonly var EOPNOTSUPP = Errno(1112);
public static readonly var EPFNOSUPPORT = Errno(1113);
public static readonly var EAFNOSUPPORT = Errno(1114);
public static readonly var EADDRINUSE = Errno(1115);
public static readonly var EADDRNOTAVAIL = Errno(1116);
public static readonly var ENETDOWN = Errno(1117);
public static readonly var ENETUNREACH = Errno(1118);
public static readonly var ENETRESET = Errno(1119);
public static readonly var ECONNABORTED = Errno(1120);
public static readonly var ECONNRESET = Errno(1121);
public static readonly var ENOBUFS = Errno(1122);
public static readonly var EISCONN = Errno(1123);
public static readonly var ENOTCONN = Errno(1124);
public static readonly var ESHUTDOWN = Errno(1125);
public static readonly var ETOOMANYREFS = Errno(1126);
public static readonly var ETIMEDOUT = Errno(1127);
public static readonly var ECONNREFUSED = Errno(1128);
public static readonly var EHOSTDOWN = Errno(1129);
public static readonly var EHOSTUNREACH = Errno(1130);
public static readonly var EPROCLIM = Errno(1131);
public static readonly var EUSERS = Errno(1132);
public static readonly var EDQUOT = Errno(1133);
public static readonly var ESTALE = Errno(1134);
public static readonly var EREMOTE = Errno(1135);
public static readonly var ENOSTR = Errno(1136);
public static readonly var ETIME = Errno(1137);
public static readonly var ENOSR = Errno(1138);
public static readonly var ENOMSG = Errno(1139);
public static readonly var EBADMSG = Errno(1140);
public static readonly var EIDRM = Errno(1141);
public static readonly var ENONET = Errno(1142);
public static readonly var ERREMOTE = Errno(1143);
public static readonly var ENOLINK = Errno(1144);
public static readonly var EADV = Errno(1145);
public static readonly var ESRMNT = Errno(1146);
public static readonly var ECOMM = Errno(1147);
public static readonly var EPROTO = Errno(1148);
public static readonly var EMULTIHOP = Errno(1149);
public static readonly var EDOTDOT = Errno(1150);
public static readonly var EREMCHG = Errno(1151);
public static readonly var ECANCELED = Errno(1152);
public static readonly var EINTRNODATA = Errno(1159);
public static readonly var ENOREUSE = Errno(1160);
public static readonly var ENOMOVE = Errno(1161);


// Signals
public static readonly var SIGHUP = Signal(1);
public static readonly var SIGINT = Signal(2);
public static readonly var SIGABRT = Signal(3);
public static readonly var SIGILL = Signal(4);
public static readonly var SIGPOLL = Signal(5);
public static readonly var SIGURG = Signal(6);
public static readonly var SIGSTOP = Signal(7);
public static readonly var SIGFPE = Signal(8);
public static readonly var SIGKILL = Signal(9);
public static readonly var SIGBUS = Signal(10);
public static readonly var SIGSEGV = Signal(11);
public static readonly var SIGSYS = Signal(12);
public static readonly var SIGPIPE = Signal(13);
public static readonly var SIGALRM = Signal(14);
public static readonly var SIGTERM = Signal(15);
public static readonly var SIGUSR1 = Signal(16);
public static readonly var SIGUSR2 = Signal(17);
public static readonly var SIGABND = Signal(18);
public static readonly var SIGCONT = Signal(19);
public static readonly var SIGCHLD = Signal(20);
public static readonly var SIGTTIN = Signal(21);
public static readonly var SIGTTOU = Signal(22);
public static readonly var SIGIO = Signal(23);
public static readonly var SIGQUIT = Signal(24);
public static readonly var SIGTSTP = Signal(25);
public static readonly var SIGTRAP = Signal(26);
public static readonly var SIGIOERR = Signal(27);
public static readonly var SIGWINCH = Signal(28);
public static readonly var SIGXCPU = Signal(29);
public static readonly var SIGXFSZ = Signal(30);
public static readonly var SIGVTALRM = Signal(31);
public static readonly var SIGPROF = Signal(32);
public static readonly var SIGDANGER = Signal(33);
public static readonly var SIGTHSTOP = Signal(34);
public static readonly var SIGTHCONT = Signal(35);
public static readonly var SIGTRACE = Signal(37);
public static readonly var SIGDCE = Signal(38);
public static readonly var SIGDUMP = Signal(39);


// Error table


// Signal table


} // end unix_package
