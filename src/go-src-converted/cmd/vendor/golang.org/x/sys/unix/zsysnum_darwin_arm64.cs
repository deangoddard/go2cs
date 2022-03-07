// go run mksysnum.go /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS11.1.sdk/usr/include/sys/syscall.h
// Code generated by the command above; see README.md. DO NOT EDIT.

//go:build arm64 && darwin
// +build arm64,darwin

// package unix -- go2cs converted at 2022 March 06 23:30:27 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Program Files\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_darwin_arm64.go


namespace go.cmd.vendor.golang.org.x.sys;

public static partial class unix_package {

    // Deprecated: Use libSystem wrappers instead of direct syscalls.
public static readonly nint SYS_SYSCALL = 0;
public static readonly nint SYS_EXIT = 1;
public static readonly nint SYS_FORK = 2;
public static readonly nint SYS_READ = 3;
public static readonly nint SYS_WRITE = 4;
public static readonly nint SYS_OPEN = 5;
public static readonly nint SYS_CLOSE = 6;
public static readonly nint SYS_WAIT4 = 7;
public static readonly nint SYS_LINK = 9;
public static readonly nint SYS_UNLINK = 10;
public static readonly nint SYS_CHDIR = 12;
public static readonly nint SYS_FCHDIR = 13;
public static readonly nint SYS_MKNOD = 14;
public static readonly nint SYS_CHMOD = 15;
public static readonly nint SYS_CHOWN = 16;
public static readonly nint SYS_GETFSSTAT = 18;
public static readonly nint SYS_GETPID = 20;
public static readonly nint SYS_SETUID = 23;
public static readonly nint SYS_GETUID = 24;
public static readonly nint SYS_GETEUID = 25;
public static readonly nint SYS_PTRACE = 26;
public static readonly nint SYS_RECVMSG = 27;
public static readonly nint SYS_SENDMSG = 28;
public static readonly nint SYS_RECVFROM = 29;
public static readonly nint SYS_ACCEPT = 30;
public static readonly nint SYS_GETPEERNAME = 31;
public static readonly nint SYS_GETSOCKNAME = 32;
public static readonly nint SYS_ACCESS = 33;
public static readonly nint SYS_CHFLAGS = 34;
public static readonly nint SYS_FCHFLAGS = 35;
public static readonly nint SYS_SYNC = 36;
public static readonly nint SYS_KILL = 37;
public static readonly nint SYS_GETPPID = 39;
public static readonly nint SYS_DUP = 41;
public static readonly nint SYS_PIPE = 42;
public static readonly nint SYS_GETEGID = 43;
public static readonly nint SYS_SIGACTION = 46;
public static readonly nint SYS_GETGID = 47;
public static readonly nint SYS_SIGPROCMASK = 48;
public static readonly nint SYS_GETLOGIN = 49;
public static readonly nint SYS_SETLOGIN = 50;
public static readonly nint SYS_ACCT = 51;
public static readonly nint SYS_SIGPENDING = 52;
public static readonly nint SYS_SIGALTSTACK = 53;
public static readonly nint SYS_IOCTL = 54;
public static readonly nint SYS_REBOOT = 55;
public static readonly nint SYS_REVOKE = 56;
public static readonly nint SYS_SYMLINK = 57;
public static readonly nint SYS_READLINK = 58;
public static readonly nint SYS_EXECVE = 59;
public static readonly nint SYS_UMASK = 60;
public static readonly nint SYS_CHROOT = 61;
public static readonly nint SYS_MSYNC = 65;
public static readonly nint SYS_VFORK = 66;
public static readonly nint SYS_MUNMAP = 73;
public static readonly nint SYS_MPROTECT = 74;
public static readonly nint SYS_MADVISE = 75;
public static readonly nint SYS_MINCORE = 78;
public static readonly nint SYS_GETGROUPS = 79;
public static readonly nint SYS_SETGROUPS = 80;
public static readonly nint SYS_GETPGRP = 81;
public static readonly nint SYS_SETPGID = 82;
public static readonly nint SYS_SETITIMER = 83;
public static readonly nint SYS_SWAPON = 85;
public static readonly nint SYS_GETITIMER = 86;
public static readonly nint SYS_GETDTABLESIZE = 89;
public static readonly nint SYS_DUP2 = 90;
public static readonly nint SYS_FCNTL = 92;
public static readonly nint SYS_SELECT = 93;
public static readonly nint SYS_FSYNC = 95;
public static readonly nint SYS_SETPRIORITY = 96;
public static readonly nint SYS_SOCKET = 97;
public static readonly nint SYS_CONNECT = 98;
public static readonly nint SYS_GETPRIORITY = 100;
public static readonly nint SYS_BIND = 104;
public static readonly nint SYS_SETSOCKOPT = 105;
public static readonly nint SYS_LISTEN = 106;
public static readonly nint SYS_SIGSUSPEND = 111;
public static readonly nint SYS_GETTIMEOFDAY = 116;
public static readonly nint SYS_GETRUSAGE = 117;
public static readonly nint SYS_GETSOCKOPT = 118;
public static readonly nint SYS_READV = 120;
public static readonly nint SYS_WRITEV = 121;
public static readonly nint SYS_SETTIMEOFDAY = 122;
public static readonly nint SYS_FCHOWN = 123;
public static readonly nint SYS_FCHMOD = 124;
public static readonly nint SYS_SETREUID = 126;
public static readonly nint SYS_SETREGID = 127;
public static readonly nint SYS_RENAME = 128;
public static readonly nint SYS_FLOCK = 131;
public static readonly nint SYS_MKFIFO = 132;
public static readonly nint SYS_SENDTO = 133;
public static readonly nint SYS_SHUTDOWN = 134;
public static readonly nint SYS_SOCKETPAIR = 135;
public static readonly nint SYS_MKDIR = 136;
public static readonly nint SYS_RMDIR = 137;
public static readonly nint SYS_UTIMES = 138;
public static readonly nint SYS_FUTIMES = 139;
public static readonly nint SYS_ADJTIME = 140;
public static readonly nint SYS_GETHOSTUUID = 142;
public static readonly nint SYS_SETSID = 147;
public static readonly nint SYS_GETPGID = 151;
public static readonly nint SYS_SETPRIVEXEC = 152;
public static readonly nint SYS_PREAD = 153;
public static readonly nint SYS_PWRITE = 154;
public static readonly nint SYS_NFSSVC = 155;
public static readonly nint SYS_STATFS = 157;
public static readonly nint SYS_FSTATFS = 158;
public static readonly nint SYS_UNMOUNT = 159;
public static readonly nint SYS_GETFH = 161;
public static readonly nint SYS_QUOTACTL = 165;
public static readonly nint SYS_MOUNT = 167;
public static readonly nint SYS_CSOPS = 169;
public static readonly nint SYS_CSOPS_AUDITTOKEN = 170;
public static readonly nint SYS_WAITID = 173;
public static readonly nint SYS_KDEBUG_TYPEFILTER = 177;
public static readonly nint SYS_KDEBUG_TRACE_STRING = 178;
public static readonly nint SYS_KDEBUG_TRACE64 = 179;
public static readonly nint SYS_KDEBUG_TRACE = 180;
public static readonly nint SYS_SETGID = 181;
public static readonly nint SYS_SETEGID = 182;
public static readonly nint SYS_SETEUID = 183;
public static readonly nint SYS_SIGRETURN = 184;
public static readonly nint SYS_THREAD_SELFCOUNTS = 186;
public static readonly nint SYS_FDATASYNC = 187;
public static readonly nint SYS_STAT = 188;
public static readonly nint SYS_FSTAT = 189;
public static readonly nint SYS_LSTAT = 190;
public static readonly nint SYS_PATHCONF = 191;
public static readonly nint SYS_FPATHCONF = 192;
public static readonly nint SYS_GETRLIMIT = 194;
public static readonly nint SYS_SETRLIMIT = 195;
public static readonly nint SYS_GETDIRENTRIES = 196;
public static readonly nint SYS_MMAP = 197;
public static readonly nint SYS_LSEEK = 199;
public static readonly nint SYS_TRUNCATE = 200;
public static readonly nint SYS_FTRUNCATE = 201;
public static readonly nint SYS_SYSCTL = 202;
public static readonly nint SYS_MLOCK = 203;
public static readonly nint SYS_MUNLOCK = 204;
public static readonly nint SYS_UNDELETE = 205;
public static readonly nint SYS_OPEN_DPROTECTED_NP = 216;
public static readonly nint SYS_GETATTRLIST = 220;
public static readonly nint SYS_SETATTRLIST = 221;
public static readonly nint SYS_GETDIRENTRIESATTR = 222;
public static readonly nint SYS_EXCHANGEDATA = 223;
public static readonly nint SYS_SEARCHFS = 225;
public static readonly nint SYS_DELETE = 226;
public static readonly nint SYS_COPYFILE = 227;
public static readonly nint SYS_FGETATTRLIST = 228;
public static readonly nint SYS_FSETATTRLIST = 229;
public static readonly nint SYS_POLL = 230;
public static readonly nint SYS_WATCHEVENT = 231;
public static readonly nint SYS_WAITEVENT = 232;
public static readonly nint SYS_MODWATCH = 233;
public static readonly nint SYS_GETXATTR = 234;
public static readonly nint SYS_FGETXATTR = 235;
public static readonly nint SYS_SETXATTR = 236;
public static readonly nint SYS_FSETXATTR = 237;
public static readonly nint SYS_REMOVEXATTR = 238;
public static readonly nint SYS_FREMOVEXATTR = 239;
public static readonly nint SYS_LISTXATTR = 240;
public static readonly nint SYS_FLISTXATTR = 241;
public static readonly nint SYS_FSCTL = 242;
public static readonly nint SYS_INITGROUPS = 243;
public static readonly nint SYS_POSIX_SPAWN = 244;
public static readonly nint SYS_FFSCTL = 245;
public static readonly nint SYS_NFSCLNT = 247;
public static readonly nint SYS_FHOPEN = 248;
public static readonly nint SYS_MINHERIT = 250;
public static readonly nint SYS_SEMSYS = 251;
public static readonly nint SYS_MSGSYS = 252;
public static readonly nint SYS_SHMSYS = 253;
public static readonly nint SYS_SEMCTL = 254;
public static readonly nint SYS_SEMGET = 255;
public static readonly nint SYS_SEMOP = 256;
public static readonly nint SYS_MSGCTL = 258;
public static readonly nint SYS_MSGGET = 259;
public static readonly nint SYS_MSGSND = 260;
public static readonly nint SYS_MSGRCV = 261;
public static readonly nint SYS_SHMAT = 262;
public static readonly nint SYS_SHMCTL = 263;
public static readonly nint SYS_SHMDT = 264;
public static readonly nint SYS_SHMGET = 265;
public static readonly nint SYS_SHM_OPEN = 266;
public static readonly nint SYS_SHM_UNLINK = 267;
public static readonly nint SYS_SEM_OPEN = 268;
public static readonly nint SYS_SEM_CLOSE = 269;
public static readonly nint SYS_SEM_UNLINK = 270;
public static readonly nint SYS_SEM_WAIT = 271;
public static readonly nint SYS_SEM_TRYWAIT = 272;
public static readonly nint SYS_SEM_POST = 273;
public static readonly nint SYS_SYSCTLBYNAME = 274;
public static readonly nint SYS_OPEN_EXTENDED = 277;
public static readonly nint SYS_UMASK_EXTENDED = 278;
public static readonly nint SYS_STAT_EXTENDED = 279;
public static readonly nint SYS_LSTAT_EXTENDED = 280;
public static readonly nint SYS_FSTAT_EXTENDED = 281;
public static readonly nint SYS_CHMOD_EXTENDED = 282;
public static readonly nint SYS_FCHMOD_EXTENDED = 283;
public static readonly nint SYS_ACCESS_EXTENDED = 284;
public static readonly nint SYS_SETTID = 285;
public static readonly nint SYS_GETTID = 286;
public static readonly nint SYS_SETSGROUPS = 287;
public static readonly nint SYS_GETSGROUPS = 288;
public static readonly nint SYS_SETWGROUPS = 289;
public static readonly nint SYS_GETWGROUPS = 290;
public static readonly nint SYS_MKFIFO_EXTENDED = 291;
public static readonly nint SYS_MKDIR_EXTENDED = 292;
public static readonly nint SYS_IDENTITYSVC = 293;
public static readonly nint SYS_SHARED_REGION_CHECK_NP = 294;
public static readonly nint SYS_VM_PRESSURE_MONITOR = 296;
public static readonly nint SYS_PSYNCH_RW_LONGRDLOCK = 297;
public static readonly nint SYS_PSYNCH_RW_YIELDWRLOCK = 298;
public static readonly nint SYS_PSYNCH_RW_DOWNGRADE = 299;
public static readonly nint SYS_PSYNCH_RW_UPGRADE = 300;
public static readonly nint SYS_PSYNCH_MUTEXWAIT = 301;
public static readonly nint SYS_PSYNCH_MUTEXDROP = 302;
public static readonly nint SYS_PSYNCH_CVBROAD = 303;
public static readonly nint SYS_PSYNCH_CVSIGNAL = 304;
public static readonly nint SYS_PSYNCH_CVWAIT = 305;
public static readonly nint SYS_PSYNCH_RW_RDLOCK = 306;
public static readonly nint SYS_PSYNCH_RW_WRLOCK = 307;
public static readonly nint SYS_PSYNCH_RW_UNLOCK = 308;
public static readonly nint SYS_PSYNCH_RW_UNLOCK2 = 309;
public static readonly nint SYS_GETSID = 310;
public static readonly nint SYS_SETTID_WITH_PID = 311;
public static readonly nint SYS_PSYNCH_CVCLRPREPOST = 312;
public static readonly nint SYS_AIO_FSYNC = 313;
public static readonly nint SYS_AIO_RETURN = 314;
public static readonly nint SYS_AIO_SUSPEND = 315;
public static readonly nint SYS_AIO_CANCEL = 316;
public static readonly nint SYS_AIO_ERROR = 317;
public static readonly nint SYS_AIO_READ = 318;
public static readonly nint SYS_AIO_WRITE = 319;
public static readonly nint SYS_LIO_LISTIO = 320;
public static readonly nint SYS_IOPOLICYSYS = 322;
public static readonly nint SYS_PROCESS_POLICY = 323;
public static readonly nint SYS_MLOCKALL = 324;
public static readonly nint SYS_MUNLOCKALL = 325;
public static readonly nint SYS_ISSETUGID = 327;
public static readonly nint SYS___PTHREAD_KILL = 328;
public static readonly nint SYS___PTHREAD_SIGMASK = 329;
public static readonly nint SYS___SIGWAIT = 330;
public static readonly nint SYS___DISABLE_THREADSIGNAL = 331;
public static readonly nint SYS___PTHREAD_MARKCANCEL = 332;
public static readonly nint SYS___PTHREAD_CANCELED = 333;
public static readonly nint SYS___SEMWAIT_SIGNAL = 334;
public static readonly nint SYS_PROC_INFO = 336;
public static readonly nint SYS_SENDFILE = 337;
public static readonly nint SYS_STAT64 = 338;
public static readonly nint SYS_FSTAT64 = 339;
public static readonly nint SYS_LSTAT64 = 340;
public static readonly nint SYS_STAT64_EXTENDED = 341;
public static readonly nint SYS_LSTAT64_EXTENDED = 342;
public static readonly nint SYS_FSTAT64_EXTENDED = 343;
public static readonly nint SYS_GETDIRENTRIES64 = 344;
public static readonly nint SYS_STATFS64 = 345;
public static readonly nint SYS_FSTATFS64 = 346;
public static readonly nint SYS_GETFSSTAT64 = 347;
public static readonly nint SYS___PTHREAD_CHDIR = 348;
public static readonly nint SYS___PTHREAD_FCHDIR = 349;
public static readonly nint SYS_AUDIT = 350;
public static readonly nint SYS_AUDITON = 351;
public static readonly nint SYS_GETAUID = 353;
public static readonly nint SYS_SETAUID = 354;
public static readonly nint SYS_GETAUDIT_ADDR = 357;
public static readonly nint SYS_SETAUDIT_ADDR = 358;
public static readonly nint SYS_AUDITCTL = 359;
public static readonly nint SYS_BSDTHREAD_CREATE = 360;
public static readonly nint SYS_BSDTHREAD_TERMINATE = 361;
public static readonly nint SYS_KQUEUE = 362;
public static readonly nint SYS_KEVENT = 363;
public static readonly nint SYS_LCHOWN = 364;
public static readonly nint SYS_BSDTHREAD_REGISTER = 366;
public static readonly nint SYS_WORKQ_OPEN = 367;
public static readonly nint SYS_WORKQ_KERNRETURN = 368;
public static readonly nint SYS_KEVENT64 = 369;
public static readonly nint SYS___OLD_SEMWAIT_SIGNAL = 370;
public static readonly nint SYS___OLD_SEMWAIT_SIGNAL_NOCANCEL = 371;
public static readonly nint SYS_THREAD_SELFID = 372;
public static readonly nint SYS_LEDGER = 373;
public static readonly nint SYS_KEVENT_QOS = 374;
public static readonly nint SYS_KEVENT_ID = 375;
public static readonly nint SYS___MAC_EXECVE = 380;
public static readonly nint SYS___MAC_SYSCALL = 381;
public static readonly nint SYS___MAC_GET_FILE = 382;
public static readonly nint SYS___MAC_SET_FILE = 383;
public static readonly nint SYS___MAC_GET_LINK = 384;
public static readonly nint SYS___MAC_SET_LINK = 385;
public static readonly nint SYS___MAC_GET_PROC = 386;
public static readonly nint SYS___MAC_SET_PROC = 387;
public static readonly nint SYS___MAC_GET_FD = 388;
public static readonly nint SYS___MAC_SET_FD = 389;
public static readonly nint SYS___MAC_GET_PID = 390;
public static readonly nint SYS_PSELECT = 394;
public static readonly nint SYS_PSELECT_NOCANCEL = 395;
public static readonly nint SYS_READ_NOCANCEL = 396;
public static readonly nint SYS_WRITE_NOCANCEL = 397;
public static readonly nint SYS_OPEN_NOCANCEL = 398;
public static readonly nint SYS_CLOSE_NOCANCEL = 399;
public static readonly nint SYS_WAIT4_NOCANCEL = 400;
public static readonly nint SYS_RECVMSG_NOCANCEL = 401;
public static readonly nint SYS_SENDMSG_NOCANCEL = 402;
public static readonly nint SYS_RECVFROM_NOCANCEL = 403;
public static readonly nint SYS_ACCEPT_NOCANCEL = 404;
public static readonly nint SYS_MSYNC_NOCANCEL = 405;
public static readonly nint SYS_FCNTL_NOCANCEL = 406;
public static readonly nint SYS_SELECT_NOCANCEL = 407;
public static readonly nint SYS_FSYNC_NOCANCEL = 408;
public static readonly nint SYS_CONNECT_NOCANCEL = 409;
public static readonly nint SYS_SIGSUSPEND_NOCANCEL = 410;
public static readonly nint SYS_READV_NOCANCEL = 411;
public static readonly nint SYS_WRITEV_NOCANCEL = 412;
public static readonly nint SYS_SENDTO_NOCANCEL = 413;
public static readonly nint SYS_PREAD_NOCANCEL = 414;
public static readonly nint SYS_PWRITE_NOCANCEL = 415;
public static readonly nint SYS_WAITID_NOCANCEL = 416;
public static readonly nint SYS_POLL_NOCANCEL = 417;
public static readonly nint SYS_MSGSND_NOCANCEL = 418;
public static readonly nint SYS_MSGRCV_NOCANCEL = 419;
public static readonly nint SYS_SEM_WAIT_NOCANCEL = 420;
public static readonly nint SYS_AIO_SUSPEND_NOCANCEL = 421;
public static readonly nint SYS___SIGWAIT_NOCANCEL = 422;
public static readonly nint SYS___SEMWAIT_SIGNAL_NOCANCEL = 423;
public static readonly nint SYS___MAC_MOUNT = 424;
public static readonly nint SYS___MAC_GET_MOUNT = 425;
public static readonly nint SYS___MAC_GETFSSTAT = 426;
public static readonly nint SYS_FSGETPATH = 427;
public static readonly nint SYS_AUDIT_SESSION_SELF = 428;
public static readonly nint SYS_AUDIT_SESSION_JOIN = 429;
public static readonly nint SYS_FILEPORT_MAKEPORT = 430;
public static readonly nint SYS_FILEPORT_MAKEFD = 431;
public static readonly nint SYS_AUDIT_SESSION_PORT = 432;
public static readonly nint SYS_PID_SUSPEND = 433;
public static readonly nint SYS_PID_RESUME = 434;
public static readonly nint SYS_PID_HIBERNATE = 435;
public static readonly nint SYS_PID_SHUTDOWN_SOCKETS = 436;
public static readonly nint SYS_SHARED_REGION_MAP_AND_SLIDE_NP = 438;
public static readonly nint SYS_KAS_INFO = 439;
public static readonly nint SYS_MEMORYSTATUS_CONTROL = 440;
public static readonly nint SYS_GUARDED_OPEN_NP = 441;
public static readonly nint SYS_GUARDED_CLOSE_NP = 442;
public static readonly nint SYS_GUARDED_KQUEUE_NP = 443;
public static readonly nint SYS_CHANGE_FDGUARD_NP = 444;
public static readonly nint SYS_USRCTL = 445;
public static readonly nint SYS_PROC_RLIMIT_CONTROL = 446;
public static readonly nint SYS_CONNECTX = 447;
public static readonly nint SYS_DISCONNECTX = 448;
public static readonly nint SYS_PEELOFF = 449;
public static readonly nint SYS_SOCKET_DELEGATE = 450;
public static readonly nint SYS_TELEMETRY = 451;
public static readonly nint SYS_PROC_UUID_POLICY = 452;
public static readonly nint SYS_MEMORYSTATUS_GET_LEVEL = 453;
public static readonly nint SYS_SYSTEM_OVERRIDE = 454;
public static readonly nint SYS_VFS_PURGE = 455;
public static readonly nint SYS_SFI_CTL = 456;
public static readonly nint SYS_SFI_PIDCTL = 457;
public static readonly nint SYS_COALITION = 458;
public static readonly nint SYS_COALITION_INFO = 459;
public static readonly nint SYS_NECP_MATCH_POLICY = 460;
public static readonly nint SYS_GETATTRLISTBULK = 461;
public static readonly nint SYS_CLONEFILEAT = 462;
public static readonly nint SYS_OPENAT = 463;
public static readonly nint SYS_OPENAT_NOCANCEL = 464;
public static readonly nint SYS_RENAMEAT = 465;
public static readonly nint SYS_FACCESSAT = 466;
public static readonly nint SYS_FCHMODAT = 467;
public static readonly nint SYS_FCHOWNAT = 468;
public static readonly nint SYS_FSTATAT = 469;
public static readonly nint SYS_FSTATAT64 = 470;
public static readonly nint SYS_LINKAT = 471;
public static readonly nint SYS_UNLINKAT = 472;
public static readonly nint SYS_READLINKAT = 473;
public static readonly nint SYS_SYMLINKAT = 474;
public static readonly nint SYS_MKDIRAT = 475;
public static readonly nint SYS_GETATTRLISTAT = 476;
public static readonly nint SYS_PROC_TRACE_LOG = 477;
public static readonly nint SYS_BSDTHREAD_CTL = 478;
public static readonly nint SYS_OPENBYID_NP = 479;
public static readonly nint SYS_RECVMSG_X = 480;
public static readonly nint SYS_SENDMSG_X = 481;
public static readonly nint SYS_THREAD_SELFUSAGE = 482;
public static readonly nint SYS_CSRCTL = 483;
public static readonly nint SYS_GUARDED_OPEN_DPROTECTED_NP = 484;
public static readonly nint SYS_GUARDED_WRITE_NP = 485;
public static readonly nint SYS_GUARDED_PWRITE_NP = 486;
public static readonly nint SYS_GUARDED_WRITEV_NP = 487;
public static readonly nint SYS_RENAMEATX_NP = 488;
public static readonly nint SYS_MREMAP_ENCRYPTED = 489;
public static readonly nint SYS_NETAGENT_TRIGGER = 490;
public static readonly nint SYS_STACK_SNAPSHOT_WITH_CONFIG = 491;
public static readonly nint SYS_MICROSTACKSHOT = 492;
public static readonly nint SYS_GRAB_PGO_DATA = 493;
public static readonly nint SYS_PERSONA = 494;
public static readonly nint SYS_WORK_INTERVAL_CTL = 499;
public static readonly nint SYS_GETENTROPY = 500;
public static readonly nint SYS_NECP_OPEN = 501;
public static readonly nint SYS_NECP_CLIENT_ACTION = 502;
public static readonly nint SYS___NEXUS_OPEN = 503;
public static readonly nint SYS___NEXUS_REGISTER = 504;
public static readonly nint SYS___NEXUS_DEREGISTER = 505;
public static readonly nint SYS___NEXUS_CREATE = 506;
public static readonly nint SYS___NEXUS_DESTROY = 507;
public static readonly nint SYS___NEXUS_GET_OPT = 508;
public static readonly nint SYS___NEXUS_SET_OPT = 509;
public static readonly nint SYS___CHANNEL_OPEN = 510;
public static readonly nint SYS___CHANNEL_GET_INFO = 511;
public static readonly nint SYS___CHANNEL_SYNC = 512;
public static readonly nint SYS___CHANNEL_GET_OPT = 513;
public static readonly nint SYS___CHANNEL_SET_OPT = 514;
public static readonly nint SYS_ULOCK_WAIT = 515;
public static readonly nint SYS_ULOCK_WAKE = 516;
public static readonly nint SYS_FCLONEFILEAT = 517;
public static readonly nint SYS_FS_SNAPSHOT = 518;
public static readonly nint SYS_TERMINATE_WITH_PAYLOAD = 520;
public static readonly nint SYS_ABORT_WITH_PAYLOAD = 521;
public static readonly nint SYS_NECP_SESSION_OPEN = 522;
public static readonly nint SYS_NECP_SESSION_ACTION = 523;
public static readonly nint SYS_SETATTRLISTAT = 524;
public static readonly nint SYS_NET_QOS_GUIDELINE = 525;
public static readonly nint SYS_FMOUNT = 526;
public static readonly nint SYS_NTP_ADJTIME = 527;
public static readonly nint SYS_NTP_GETTIME = 528;
public static readonly nint SYS_OS_FAULT_WITH_PAYLOAD = 529;
public static readonly nint SYS_MAXSYSCALL = 530;
public static readonly nint SYS_INVALID = 63;


} // end unix_package
