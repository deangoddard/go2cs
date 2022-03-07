// mksysnum_linux.pl
// Code generated by the command above; DO NOT EDIT.

//go:build arm && linux
// +build arm,linux

// package syscall -- go2cs converted at 2022 March 06 22:29:48 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Program Files\Go\src\syscall\zsysnum_linux_arm.go


namespace go;

public static partial class syscall_package {

public static readonly nint SYS_OABI_SYSCALL_BASE = 0;
public static readonly nint SYS_SYSCALL_BASE = 0;
public static readonly nint SYS_RESTART_SYSCALL = 0;
public static readonly nint SYS_EXIT = 1;
public static readonly nint SYS_FORK = 2;
public static readonly nint SYS_READ = 3;
public static readonly nint SYS_WRITE = 4;
public static readonly nint SYS_OPEN = 5;
public static readonly nint SYS_CLOSE = 6;
public static readonly nint SYS_CREAT = 8;
public static readonly nint SYS_LINK = 9;
public static readonly nint SYS_UNLINK = 10;
public static readonly nint SYS_EXECVE = 11;
public static readonly nint SYS_CHDIR = 12;
public static readonly nint SYS_TIME = 13;
public static readonly nint SYS_MKNOD = 14;
public static readonly nint SYS_CHMOD = 15;
public static readonly nint SYS_LCHOWN = 16;
public static readonly nint SYS_LSEEK = 19;
public static readonly nint SYS_GETPID = 20;
public static readonly nint SYS_MOUNT = 21;
public static readonly nint SYS_UMOUNT = 22;
public static readonly nint SYS_SETUID = 23;
public static readonly nint SYS_GETUID = 24;
public static readonly nint SYS_STIME = 25;
public static readonly nint SYS_PTRACE = 26;
public static readonly nint SYS_ALARM = 27;
public static readonly nint SYS_PAUSE = 29;
public static readonly nint SYS_UTIME = 30;
public static readonly nint SYS_ACCESS = 33;
public static readonly nint SYS_NICE = 34;
public static readonly nint SYS_SYNC = 36;
public static readonly nint SYS_KILL = 37;
public static readonly nint SYS_RENAME = 38;
public static readonly nint SYS_MKDIR = 39;
public static readonly nint SYS_RMDIR = 40;
public static readonly nint SYS_DUP = 41;
public static readonly nint SYS_PIPE = 42;
public static readonly nint SYS_TIMES = 43;
public static readonly nint SYS_BRK = 45;
public static readonly nint SYS_SETGID = 46;
public static readonly nint SYS_GETGID = 47;
public static readonly nint SYS_GETEUID = 49;
public static readonly nint SYS_GETEGID = 50;
public static readonly nint SYS_ACCT = 51;
public static readonly nint SYS_UMOUNT2 = 52;
public static readonly nint SYS_IOCTL = 54;
public static readonly nint SYS_FCNTL = 55;
public static readonly nint SYS_SETPGID = 57;
public static readonly nint SYS_UMASK = 60;
public static readonly nint SYS_CHROOT = 61;
public static readonly nint SYS_USTAT = 62;
public static readonly nint SYS_DUP2 = 63;
public static readonly nint SYS_GETPPID = 64;
public static readonly nint SYS_GETPGRP = 65;
public static readonly nint SYS_SETSID = 66;
public static readonly nint SYS_SIGACTION = 67;
public static readonly nint SYS_SETREUID = 70;
public static readonly nint SYS_SETREGID = 71;
public static readonly nint SYS_SIGSUSPEND = 72;
public static readonly nint SYS_SIGPENDING = 73;
public static readonly nint SYS_SETHOSTNAME = 74;
public static readonly nint SYS_SETRLIMIT = 75;
public static readonly nint SYS_GETRLIMIT = 76;
public static readonly nint SYS_GETRUSAGE = 77;
public static readonly nint SYS_GETTIMEOFDAY = 78;
public static readonly nint SYS_SETTIMEOFDAY = 79;
public static readonly nint SYS_GETGROUPS = 80;
public static readonly nint SYS_SETGROUPS = 81;
public static readonly nint SYS_SELECT = 82;
public static readonly nint SYS_SYMLINK = 83;
public static readonly nint SYS_READLINK = 85;
public static readonly nint SYS_USELIB = 86;
public static readonly nint SYS_SWAPON = 87;
public static readonly nint SYS_REBOOT = 88;
public static readonly nint SYS_READDIR = 89;
public static readonly nint SYS_MMAP = 90;
public static readonly nint SYS_MUNMAP = 91;
public static readonly nint SYS_TRUNCATE = 92;
public static readonly nint SYS_FTRUNCATE = 93;
public static readonly nint SYS_FCHMOD = 94;
public static readonly nint SYS_FCHOWN = 95;
public static readonly nint SYS_GETPRIORITY = 96;
public static readonly nint SYS_SETPRIORITY = 97;
public static readonly nint SYS_STATFS = 99;
public static readonly nint SYS_FSTATFS = 100;
public static readonly nint SYS_SOCKETCALL = 102;
public static readonly nint SYS_SYSLOG = 103;
public static readonly nint SYS_SETITIMER = 104;
public static readonly nint SYS_GETITIMER = 105;
public static readonly nint SYS_STAT = 106;
public static readonly nint SYS_LSTAT = 107;
public static readonly nint SYS_FSTAT = 108;
public static readonly nint SYS_VHANGUP = 111;
public static readonly nint SYS_SYSCALL = 113;
public static readonly nint SYS_WAIT4 = 114;
public static readonly nint SYS_SWAPOFF = 115;
public static readonly nint SYS_SYSINFO = 116;
public static readonly nint SYS_IPC = 117;
public static readonly nint SYS_FSYNC = 118;
public static readonly nint SYS_SIGRETURN = 119;
public static readonly nint SYS_CLONE = 120;
public static readonly nint SYS_SETDOMAINNAME = 121;
public static readonly nint SYS_UNAME = 122;
public static readonly nint SYS_ADJTIMEX = 124;
public static readonly nint SYS_MPROTECT = 125;
public static readonly nint SYS_SIGPROCMASK = 126;
public static readonly nint SYS_INIT_MODULE = 128;
public static readonly nint SYS_DELETE_MODULE = 129;
public static readonly nint SYS_QUOTACTL = 131;
public static readonly nint SYS_GETPGID = 132;
public static readonly nint SYS_FCHDIR = 133;
public static readonly nint SYS_BDFLUSH = 134;
public static readonly nint SYS_SYSFS = 135;
public static readonly nint SYS_PERSONALITY = 136;
public static readonly nint SYS_SETFSUID = 138;
public static readonly nint SYS_SETFSGID = 139;
public static readonly nint SYS__LLSEEK = 140;
public static readonly nint SYS_GETDENTS = 141;
public static readonly nint SYS__NEWSELECT = 142;
public static readonly nint SYS_FLOCK = 143;
public static readonly nint SYS_MSYNC = 144;
public static readonly nint SYS_READV = 145;
public static readonly nint SYS_WRITEV = 146;
public static readonly nint SYS_GETSID = 147;
public static readonly nint SYS_FDATASYNC = 148;
public static readonly nint SYS__SYSCTL = 149;
public static readonly nint SYS_MLOCK = 150;
public static readonly nint SYS_MUNLOCK = 151;
public static readonly nint SYS_MLOCKALL = 152;
public static readonly nint SYS_MUNLOCKALL = 153;
public static readonly nint SYS_SCHED_SETPARAM = 154;
public static readonly nint SYS_SCHED_GETPARAM = 155;
public static readonly nint SYS_SCHED_SETSCHEDULER = 156;
public static readonly nint SYS_SCHED_GETSCHEDULER = 157;
public static readonly nint SYS_SCHED_YIELD = 158;
public static readonly nint SYS_SCHED_GET_PRIORITY_MAX = 159;
public static readonly nint SYS_SCHED_GET_PRIORITY_MIN = 160;
public static readonly nint SYS_SCHED_RR_GET_INTERVAL = 161;
public static readonly nint SYS_NANOSLEEP = 162;
public static readonly nint SYS_MREMAP = 163;
public static readonly nint SYS_SETRESUID = 164;
public static readonly nint SYS_GETRESUID = 165;
public static readonly nint SYS_POLL = 168;
public static readonly nint SYS_NFSSERVCTL = 169;
public static readonly nint SYS_SETRESGID = 170;
public static readonly nint SYS_GETRESGID = 171;
public static readonly nint SYS_PRCTL = 172;
public static readonly nint SYS_RT_SIGRETURN = 173;
public static readonly nint SYS_RT_SIGACTION = 174;
public static readonly nint SYS_RT_SIGPROCMASK = 175;
public static readonly nint SYS_RT_SIGPENDING = 176;
public static readonly nint SYS_RT_SIGTIMEDWAIT = 177;
public static readonly nint SYS_RT_SIGQUEUEINFO = 178;
public static readonly nint SYS_RT_SIGSUSPEND = 179;
public static readonly nint SYS_PREAD64 = 180;
public static readonly nint SYS_PWRITE64 = 181;
public static readonly nint SYS_CHOWN = 182;
public static readonly nint SYS_GETCWD = 183;
public static readonly nint SYS_CAPGET = 184;
public static readonly nint SYS_CAPSET = 185;
public static readonly nint SYS_SIGALTSTACK = 186;
public static readonly nint SYS_SENDFILE = 187;
public static readonly nint SYS_VFORK = 190;
public static readonly nint SYS_UGETRLIMIT = 191;
public static readonly nint SYS_MMAP2 = 192;
public static readonly nint SYS_TRUNCATE64 = 193;
public static readonly nint SYS_FTRUNCATE64 = 194;
public static readonly nint SYS_STAT64 = 195;
public static readonly nint SYS_LSTAT64 = 196;
public static readonly nint SYS_FSTAT64 = 197;
public static readonly nint SYS_LCHOWN32 = 198;
public static readonly nint SYS_GETUID32 = 199;
public static readonly nint SYS_GETGID32 = 200;
public static readonly nint SYS_GETEUID32 = 201;
public static readonly nint SYS_GETEGID32 = 202;
public static readonly nint SYS_SETREUID32 = 203;
public static readonly nint SYS_SETREGID32 = 204;
public static readonly nint SYS_GETGROUPS32 = 205;
public static readonly nint SYS_SETGROUPS32 = 206;
public static readonly nint SYS_FCHOWN32 = 207;
public static readonly nint SYS_SETRESUID32 = 208;
public static readonly nint SYS_GETRESUID32 = 209;
public static readonly nint SYS_SETRESGID32 = 210;
public static readonly nint SYS_GETRESGID32 = 211;
public static readonly nint SYS_CHOWN32 = 212;
public static readonly nint SYS_SETUID32 = 213;
public static readonly nint SYS_SETGID32 = 214;
public static readonly nint SYS_SETFSUID32 = 215;
public static readonly nint SYS_SETFSGID32 = 216;
public static readonly nint SYS_GETDENTS64 = 217;
public static readonly nint SYS_PIVOT_ROOT = 218;
public static readonly nint SYS_MINCORE = 219;
public static readonly nint SYS_MADVISE = 220;
public static readonly nint SYS_FCNTL64 = 221;
public static readonly nint SYS_GETTID = 224;
public static readonly nint SYS_READAHEAD = 225;
public static readonly nint SYS_SETXATTR = 226;
public static readonly nint SYS_LSETXATTR = 227;
public static readonly nint SYS_FSETXATTR = 228;
public static readonly nint SYS_GETXATTR = 229;
public static readonly nint SYS_LGETXATTR = 230;
public static readonly nint SYS_FGETXATTR = 231;
public static readonly nint SYS_LISTXATTR = 232;
public static readonly nint SYS_LLISTXATTR = 233;
public static readonly nint SYS_FLISTXATTR = 234;
public static readonly nint SYS_REMOVEXATTR = 235;
public static readonly nint SYS_LREMOVEXATTR = 236;
public static readonly nint SYS_FREMOVEXATTR = 237;
public static readonly nint SYS_TKILL = 238;
public static readonly nint SYS_SENDFILE64 = 239;
public static readonly nint SYS_FUTEX = 240;
public static readonly nint SYS_SCHED_SETAFFINITY = 241;
public static readonly nint SYS_SCHED_GETAFFINITY = 242;
public static readonly nint SYS_IO_SETUP = 243;
public static readonly nint SYS_IO_DESTROY = 244;
public static readonly nint SYS_IO_GETEVENTS = 245;
public static readonly nint SYS_IO_SUBMIT = 246;
public static readonly nint SYS_IO_CANCEL = 247;
public static readonly nint SYS_EXIT_GROUP = 248;
public static readonly nint SYS_LOOKUP_DCOOKIE = 249;
public static readonly nint SYS_EPOLL_CREATE = 250;
public static readonly nint SYS_EPOLL_CTL = 251;
public static readonly nint SYS_EPOLL_WAIT = 252;
public static readonly nint SYS_REMAP_FILE_PAGES = 253;
public static readonly nint SYS_SET_TID_ADDRESS = 256;
public static readonly nint SYS_TIMER_CREATE = 257;
public static readonly nint SYS_TIMER_SETTIME = 258;
public static readonly nint SYS_TIMER_GETTIME = 259;
public static readonly nint SYS_TIMER_GETOVERRUN = 260;
public static readonly nint SYS_TIMER_DELETE = 261;
public static readonly nint SYS_CLOCK_SETTIME = 262;
public static readonly nint SYS_CLOCK_GETTIME = 263;
public static readonly nint SYS_CLOCK_GETRES = 264;
public static readonly nint SYS_CLOCK_NANOSLEEP = 265;
public static readonly nint SYS_STATFS64 = 266;
public static readonly nint SYS_FSTATFS64 = 267;
public static readonly nint SYS_TGKILL = 268;
public static readonly nint SYS_UTIMES = 269;
public static readonly nint SYS_ARM_FADVISE64_64 = 270;
public static readonly nint SYS_PCICONFIG_IOBASE = 271;
public static readonly nint SYS_PCICONFIG_READ = 272;
public static readonly nint SYS_PCICONFIG_WRITE = 273;
public static readonly nint SYS_MQ_OPEN = 274;
public static readonly nint SYS_MQ_UNLINK = 275;
public static readonly nint SYS_MQ_TIMEDSEND = 276;
public static readonly nint SYS_MQ_TIMEDRECEIVE = 277;
public static readonly nint SYS_MQ_NOTIFY = 278;
public static readonly nint SYS_MQ_GETSETATTR = 279;
public static readonly nint SYS_WAITID = 280;
public static readonly nint SYS_SOCKET = 281;
public static readonly nint SYS_BIND = 282;
public static readonly nint SYS_CONNECT = 283;
public static readonly nint SYS_LISTEN = 284;
public static readonly nint SYS_ACCEPT = 285;
public static readonly nint SYS_GETSOCKNAME = 286;
public static readonly nint SYS_GETPEERNAME = 287;
public static readonly nint SYS_SOCKETPAIR = 288;
public static readonly nint SYS_SEND = 289;
public static readonly nint SYS_SENDTO = 290;
public static readonly nint SYS_RECV = 291;
public static readonly nint SYS_RECVFROM = 292;
public static readonly nint SYS_SHUTDOWN = 293;
public static readonly nint SYS_SETSOCKOPT = 294;
public static readonly nint SYS_GETSOCKOPT = 295;
public static readonly nint SYS_SENDMSG = 296;
public static readonly nint SYS_RECVMSG = 297;
public static readonly nint SYS_SEMOP = 298;
public static readonly nint SYS_SEMGET = 299;
public static readonly nint SYS_SEMCTL = 300;
public static readonly nint SYS_MSGSND = 301;
public static readonly nint SYS_MSGRCV = 302;
public static readonly nint SYS_MSGGET = 303;
public static readonly nint SYS_MSGCTL = 304;
public static readonly nint SYS_SHMAT = 305;
public static readonly nint SYS_SHMDT = 306;
public static readonly nint SYS_SHMGET = 307;
public static readonly nint SYS_SHMCTL = 308;
public static readonly nint SYS_ADD_KEY = 309;
public static readonly nint SYS_REQUEST_KEY = 310;
public static readonly nint SYS_KEYCTL = 311;
public static readonly nint SYS_SEMTIMEDOP = 312;
public static readonly nint SYS_VSERVER = 313;
public static readonly nint SYS_IOPRIO_SET = 314;
public static readonly nint SYS_IOPRIO_GET = 315;
public static readonly nint SYS_INOTIFY_INIT = 316;
public static readonly nint SYS_INOTIFY_ADD_WATCH = 317;
public static readonly nint SYS_INOTIFY_RM_WATCH = 318;
public static readonly nint SYS_MBIND = 319;
public static readonly nint SYS_GET_MEMPOLICY = 320;
public static readonly nint SYS_SET_MEMPOLICY = 321;
public static readonly nint SYS_OPENAT = 322;
public static readonly nint SYS_MKDIRAT = 323;
public static readonly nint SYS_MKNODAT = 324;
public static readonly nint SYS_FCHOWNAT = 325;
public static readonly nint SYS_FUTIMESAT = 326;
public static readonly nint SYS_FSTATAT64 = 327;
public static readonly nint SYS_UNLINKAT = 328;
public static readonly nint SYS_RENAMEAT = 329;
public static readonly nint SYS_LINKAT = 330;
public static readonly nint SYS_SYMLINKAT = 331;
public static readonly nint SYS_READLINKAT = 332;
public static readonly nint SYS_FCHMODAT = 333;
public static readonly nint SYS_FACCESSAT = 334;
public static readonly nint SYS_PSELECT6 = 335;
public static readonly nint SYS_PPOLL = 336;
public static readonly nint SYS_UNSHARE = 337;
public static readonly nint SYS_SET_ROBUST_LIST = 338;
public static readonly nint SYS_GET_ROBUST_LIST = 339;
public static readonly nint SYS_SPLICE = 340;
public static readonly nint SYS_ARM_SYNC_FILE_RANGE = 341;
public static readonly nint SYS_TEE = 342;
public static readonly nint SYS_VMSPLICE = 343;
public static readonly nint SYS_MOVE_PAGES = 344;
public static readonly nint SYS_GETCPU = 345;
public static readonly nint SYS_EPOLL_PWAIT = 346;
public static readonly nint SYS_KEXEC_LOAD = 347;
public static readonly nint SYS_UTIMENSAT = 348;
public static readonly nint SYS_SIGNALFD = 349;
public static readonly nint SYS_TIMERFD_CREATE = 350;
public static readonly nint SYS_EVENTFD = 351;
public static readonly nint SYS_FALLOCATE = 352;
public static readonly nint SYS_TIMERFD_SETTIME = 353;
public static readonly nint SYS_TIMERFD_GETTIME = 354;
public static readonly nint SYS_SIGNALFD4 = 355;
public static readonly nint SYS_EVENTFD2 = 356;
public static readonly nint SYS_EPOLL_CREATE1 = 357;
public static readonly nint SYS_DUP3 = 358;
public static readonly nint SYS_PIPE2 = 359;
public static readonly nint SYS_INOTIFY_INIT1 = 360;
public static readonly nint SYS_PREADV = 361;
public static readonly nint SYS_PWRITEV = 362;
public static readonly nint SYS_RT_TGSIGQUEUEINFO = 363;
public static readonly nint SYS_PERF_EVENT_OPEN = 364;
public static readonly nint SYS_RECVMMSG = 365;
public static readonly nint SYS_ACCEPT4 = 366;
public static readonly nint SYS_FANOTIFY_INIT = 367;
public static readonly nint SYS_FANOTIFY_MARK = 368;
public static readonly nint SYS_PRLIMIT64 = 369;
public static readonly nint SYS_NAME_TO_HANDLE_AT = 370;
public static readonly nint SYS_OPEN_BY_HANDLE_AT = 371;
public static readonly nint SYS_CLOCK_ADJTIME = 372;
public static readonly nint SYS_SYNCFS = 373;
public static readonly nint SYS_SENDMMSG = 374;
public static readonly nint SYS_SETNS = 375;
public static readonly nint SYS_PROCESS_VM_READV = 376;
public static readonly nint SYS_PROCESS_VM_WRITEV = 377;


} // end syscall_package
