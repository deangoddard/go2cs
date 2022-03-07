// go run linux/mksysnum.go -Wall -Werror -static -I/tmp/include -m64 /tmp/include/asm/unistd.h
// Code generated by the command above; see README.md. DO NOT EDIT.

//go:build amd64 && linux
// +build amd64,linux

// package unix -- go2cs converted at 2022 March 06 23:30:27 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Program Files\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_linux_amd64.go


namespace go.cmd.vendor.golang.org.x.sys;

public static partial class unix_package {

public static readonly nint SYS_READ = 0;
public static readonly nint SYS_WRITE = 1;
public static readonly nint SYS_OPEN = 2;
public static readonly nint SYS_CLOSE = 3;
public static readonly nint SYS_STAT = 4;
public static readonly nint SYS_FSTAT = 5;
public static readonly nint SYS_LSTAT = 6;
public static readonly nint SYS_POLL = 7;
public static readonly nint SYS_LSEEK = 8;
public static readonly nint SYS_MMAP = 9;
public static readonly nint SYS_MPROTECT = 10;
public static readonly nint SYS_MUNMAP = 11;
public static readonly nint SYS_BRK = 12;
public static readonly nint SYS_RT_SIGACTION = 13;
public static readonly nint SYS_RT_SIGPROCMASK = 14;
public static readonly nint SYS_RT_SIGRETURN = 15;
public static readonly nint SYS_IOCTL = 16;
public static readonly nint SYS_PREAD64 = 17;
public static readonly nint SYS_PWRITE64 = 18;
public static readonly nint SYS_READV = 19;
public static readonly nint SYS_WRITEV = 20;
public static readonly nint SYS_ACCESS = 21;
public static readonly nint SYS_PIPE = 22;
public static readonly nint SYS_SELECT = 23;
public static readonly nint SYS_SCHED_YIELD = 24;
public static readonly nint SYS_MREMAP = 25;
public static readonly nint SYS_MSYNC = 26;
public static readonly nint SYS_MINCORE = 27;
public static readonly nint SYS_MADVISE = 28;
public static readonly nint SYS_SHMGET = 29;
public static readonly nint SYS_SHMAT = 30;
public static readonly nint SYS_SHMCTL = 31;
public static readonly nint SYS_DUP = 32;
public static readonly nint SYS_DUP2 = 33;
public static readonly nint SYS_PAUSE = 34;
public static readonly nint SYS_NANOSLEEP = 35;
public static readonly nint SYS_GETITIMER = 36;
public static readonly nint SYS_ALARM = 37;
public static readonly nint SYS_SETITIMER = 38;
public static readonly nint SYS_GETPID = 39;
public static readonly nint SYS_SENDFILE = 40;
public static readonly nint SYS_SOCKET = 41;
public static readonly nint SYS_CONNECT = 42;
public static readonly nint SYS_ACCEPT = 43;
public static readonly nint SYS_SENDTO = 44;
public static readonly nint SYS_RECVFROM = 45;
public static readonly nint SYS_SENDMSG = 46;
public static readonly nint SYS_RECVMSG = 47;
public static readonly nint SYS_SHUTDOWN = 48;
public static readonly nint SYS_BIND = 49;
public static readonly nint SYS_LISTEN = 50;
public static readonly nint SYS_GETSOCKNAME = 51;
public static readonly nint SYS_GETPEERNAME = 52;
public static readonly nint SYS_SOCKETPAIR = 53;
public static readonly nint SYS_SETSOCKOPT = 54;
public static readonly nint SYS_GETSOCKOPT = 55;
public static readonly nint SYS_CLONE = 56;
public static readonly nint SYS_FORK = 57;
public static readonly nint SYS_VFORK = 58;
public static readonly nint SYS_EXECVE = 59;
public static readonly nint SYS_EXIT = 60;
public static readonly nint SYS_WAIT4 = 61;
public static readonly nint SYS_KILL = 62;
public static readonly nint SYS_UNAME = 63;
public static readonly nint SYS_SEMGET = 64;
public static readonly nint SYS_SEMOP = 65;
public static readonly nint SYS_SEMCTL = 66;
public static readonly nint SYS_SHMDT = 67;
public static readonly nint SYS_MSGGET = 68;
public static readonly nint SYS_MSGSND = 69;
public static readonly nint SYS_MSGRCV = 70;
public static readonly nint SYS_MSGCTL = 71;
public static readonly nint SYS_FCNTL = 72;
public static readonly nint SYS_FLOCK = 73;
public static readonly nint SYS_FSYNC = 74;
public static readonly nint SYS_FDATASYNC = 75;
public static readonly nint SYS_TRUNCATE = 76;
public static readonly nint SYS_FTRUNCATE = 77;
public static readonly nint SYS_GETDENTS = 78;
public static readonly nint SYS_GETCWD = 79;
public static readonly nint SYS_CHDIR = 80;
public static readonly nint SYS_FCHDIR = 81;
public static readonly nint SYS_RENAME = 82;
public static readonly nint SYS_MKDIR = 83;
public static readonly nint SYS_RMDIR = 84;
public static readonly nint SYS_CREAT = 85;
public static readonly nint SYS_LINK = 86;
public static readonly nint SYS_UNLINK = 87;
public static readonly nint SYS_SYMLINK = 88;
public static readonly nint SYS_READLINK = 89;
public static readonly nint SYS_CHMOD = 90;
public static readonly nint SYS_FCHMOD = 91;
public static readonly nint SYS_CHOWN = 92;
public static readonly nint SYS_FCHOWN = 93;
public static readonly nint SYS_LCHOWN = 94;
public static readonly nint SYS_UMASK = 95;
public static readonly nint SYS_GETTIMEOFDAY = 96;
public static readonly nint SYS_GETRLIMIT = 97;
public static readonly nint SYS_GETRUSAGE = 98;
public static readonly nint SYS_SYSINFO = 99;
public static readonly nint SYS_TIMES = 100;
public static readonly nint SYS_PTRACE = 101;
public static readonly nint SYS_GETUID = 102;
public static readonly nint SYS_SYSLOG = 103;
public static readonly nint SYS_GETGID = 104;
public static readonly nint SYS_SETUID = 105;
public static readonly nint SYS_SETGID = 106;
public static readonly nint SYS_GETEUID = 107;
public static readonly nint SYS_GETEGID = 108;
public static readonly nint SYS_SETPGID = 109;
public static readonly nint SYS_GETPPID = 110;
public static readonly nint SYS_GETPGRP = 111;
public static readonly nint SYS_SETSID = 112;
public static readonly nint SYS_SETREUID = 113;
public static readonly nint SYS_SETREGID = 114;
public static readonly nint SYS_GETGROUPS = 115;
public static readonly nint SYS_SETGROUPS = 116;
public static readonly nint SYS_SETRESUID = 117;
public static readonly nint SYS_GETRESUID = 118;
public static readonly nint SYS_SETRESGID = 119;
public static readonly nint SYS_GETRESGID = 120;
public static readonly nint SYS_GETPGID = 121;
public static readonly nint SYS_SETFSUID = 122;
public static readonly nint SYS_SETFSGID = 123;
public static readonly nint SYS_GETSID = 124;
public static readonly nint SYS_CAPGET = 125;
public static readonly nint SYS_CAPSET = 126;
public static readonly nint SYS_RT_SIGPENDING = 127;
public static readonly nint SYS_RT_SIGTIMEDWAIT = 128;
public static readonly nint SYS_RT_SIGQUEUEINFO = 129;
public static readonly nint SYS_RT_SIGSUSPEND = 130;
public static readonly nint SYS_SIGALTSTACK = 131;
public static readonly nint SYS_UTIME = 132;
public static readonly nint SYS_MKNOD = 133;
public static readonly nint SYS_USELIB = 134;
public static readonly nint SYS_PERSONALITY = 135;
public static readonly nint SYS_USTAT = 136;
public static readonly nint SYS_STATFS = 137;
public static readonly nint SYS_FSTATFS = 138;
public static readonly nint SYS_SYSFS = 139;
public static readonly nint SYS_GETPRIORITY = 140;
public static readonly nint SYS_SETPRIORITY = 141;
public static readonly nint SYS_SCHED_SETPARAM = 142;
public static readonly nint SYS_SCHED_GETPARAM = 143;
public static readonly nint SYS_SCHED_SETSCHEDULER = 144;
public static readonly nint SYS_SCHED_GETSCHEDULER = 145;
public static readonly nint SYS_SCHED_GET_PRIORITY_MAX = 146;
public static readonly nint SYS_SCHED_GET_PRIORITY_MIN = 147;
public static readonly nint SYS_SCHED_RR_GET_INTERVAL = 148;
public static readonly nint SYS_MLOCK = 149;
public static readonly nint SYS_MUNLOCK = 150;
public static readonly nint SYS_MLOCKALL = 151;
public static readonly nint SYS_MUNLOCKALL = 152;
public static readonly nint SYS_VHANGUP = 153;
public static readonly nint SYS_MODIFY_LDT = 154;
public static readonly nint SYS_PIVOT_ROOT = 155;
public static readonly nint SYS__SYSCTL = 156;
public static readonly nint SYS_PRCTL = 157;
public static readonly nint SYS_ARCH_PRCTL = 158;
public static readonly nint SYS_ADJTIMEX = 159;
public static readonly nint SYS_SETRLIMIT = 160;
public static readonly nint SYS_CHROOT = 161;
public static readonly nint SYS_SYNC = 162;
public static readonly nint SYS_ACCT = 163;
public static readonly nint SYS_SETTIMEOFDAY = 164;
public static readonly nint SYS_MOUNT = 165;
public static readonly nint SYS_UMOUNT2 = 166;
public static readonly nint SYS_SWAPON = 167;
public static readonly nint SYS_SWAPOFF = 168;
public static readonly nint SYS_REBOOT = 169;
public static readonly nint SYS_SETHOSTNAME = 170;
public static readonly nint SYS_SETDOMAINNAME = 171;
public static readonly nint SYS_IOPL = 172;
public static readonly nint SYS_IOPERM = 173;
public static readonly nint SYS_CREATE_MODULE = 174;
public static readonly nint SYS_INIT_MODULE = 175;
public static readonly nint SYS_DELETE_MODULE = 176;
public static readonly nint SYS_GET_KERNEL_SYMS = 177;
public static readonly nint SYS_QUERY_MODULE = 178;
public static readonly nint SYS_QUOTACTL = 179;
public static readonly nint SYS_NFSSERVCTL = 180;
public static readonly nint SYS_GETPMSG = 181;
public static readonly nint SYS_PUTPMSG = 182;
public static readonly nint SYS_AFS_SYSCALL = 183;
public static readonly nint SYS_TUXCALL = 184;
public static readonly nint SYS_SECURITY = 185;
public static readonly nint SYS_GETTID = 186;
public static readonly nint SYS_READAHEAD = 187;
public static readonly nint SYS_SETXATTR = 188;
public static readonly nint SYS_LSETXATTR = 189;
public static readonly nint SYS_FSETXATTR = 190;
public static readonly nint SYS_GETXATTR = 191;
public static readonly nint SYS_LGETXATTR = 192;
public static readonly nint SYS_FGETXATTR = 193;
public static readonly nint SYS_LISTXATTR = 194;
public static readonly nint SYS_LLISTXATTR = 195;
public static readonly nint SYS_FLISTXATTR = 196;
public static readonly nint SYS_REMOVEXATTR = 197;
public static readonly nint SYS_LREMOVEXATTR = 198;
public static readonly nint SYS_FREMOVEXATTR = 199;
public static readonly nint SYS_TKILL = 200;
public static readonly nint SYS_TIME = 201;
public static readonly nint SYS_FUTEX = 202;
public static readonly nint SYS_SCHED_SETAFFINITY = 203;
public static readonly nint SYS_SCHED_GETAFFINITY = 204;
public static readonly nint SYS_SET_THREAD_AREA = 205;
public static readonly nint SYS_IO_SETUP = 206;
public static readonly nint SYS_IO_DESTROY = 207;
public static readonly nint SYS_IO_GETEVENTS = 208;
public static readonly nint SYS_IO_SUBMIT = 209;
public static readonly nint SYS_IO_CANCEL = 210;
public static readonly nint SYS_GET_THREAD_AREA = 211;
public static readonly nint SYS_LOOKUP_DCOOKIE = 212;
public static readonly nint SYS_EPOLL_CREATE = 213;
public static readonly nint SYS_EPOLL_CTL_OLD = 214;
public static readonly nint SYS_EPOLL_WAIT_OLD = 215;
public static readonly nint SYS_REMAP_FILE_PAGES = 216;
public static readonly nint SYS_GETDENTS64 = 217;
public static readonly nint SYS_SET_TID_ADDRESS = 218;
public static readonly nint SYS_RESTART_SYSCALL = 219;
public static readonly nint SYS_SEMTIMEDOP = 220;
public static readonly nint SYS_FADVISE64 = 221;
public static readonly nint SYS_TIMER_CREATE = 222;
public static readonly nint SYS_TIMER_SETTIME = 223;
public static readonly nint SYS_TIMER_GETTIME = 224;
public static readonly nint SYS_TIMER_GETOVERRUN = 225;
public static readonly nint SYS_TIMER_DELETE = 226;
public static readonly nint SYS_CLOCK_SETTIME = 227;
public static readonly nint SYS_CLOCK_GETTIME = 228;
public static readonly nint SYS_CLOCK_GETRES = 229;
public static readonly nint SYS_CLOCK_NANOSLEEP = 230;
public static readonly nint SYS_EXIT_GROUP = 231;
public static readonly nint SYS_EPOLL_WAIT = 232;
public static readonly nint SYS_EPOLL_CTL = 233;
public static readonly nint SYS_TGKILL = 234;
public static readonly nint SYS_UTIMES = 235;
public static readonly nint SYS_VSERVER = 236;
public static readonly nint SYS_MBIND = 237;
public static readonly nint SYS_SET_MEMPOLICY = 238;
public static readonly nint SYS_GET_MEMPOLICY = 239;
public static readonly nint SYS_MQ_OPEN = 240;
public static readonly nint SYS_MQ_UNLINK = 241;
public static readonly nint SYS_MQ_TIMEDSEND = 242;
public static readonly nint SYS_MQ_TIMEDRECEIVE = 243;
public static readonly nint SYS_MQ_NOTIFY = 244;
public static readonly nint SYS_MQ_GETSETATTR = 245;
public static readonly nint SYS_KEXEC_LOAD = 246;
public static readonly nint SYS_WAITID = 247;
public static readonly nint SYS_ADD_KEY = 248;
public static readonly nint SYS_REQUEST_KEY = 249;
public static readonly nint SYS_KEYCTL = 250;
public static readonly nint SYS_IOPRIO_SET = 251;
public static readonly nint SYS_IOPRIO_GET = 252;
public static readonly nint SYS_INOTIFY_INIT = 253;
public static readonly nint SYS_INOTIFY_ADD_WATCH = 254;
public static readonly nint SYS_INOTIFY_RM_WATCH = 255;
public static readonly nint SYS_MIGRATE_PAGES = 256;
public static readonly nint SYS_OPENAT = 257;
public static readonly nint SYS_MKDIRAT = 258;
public static readonly nint SYS_MKNODAT = 259;
public static readonly nint SYS_FCHOWNAT = 260;
public static readonly nint SYS_FUTIMESAT = 261;
public static readonly nint SYS_NEWFSTATAT = 262;
public static readonly nint SYS_UNLINKAT = 263;
public static readonly nint SYS_RENAMEAT = 264;
public static readonly nint SYS_LINKAT = 265;
public static readonly nint SYS_SYMLINKAT = 266;
public static readonly nint SYS_READLINKAT = 267;
public static readonly nint SYS_FCHMODAT = 268;
public static readonly nint SYS_FACCESSAT = 269;
public static readonly nint SYS_PSELECT6 = 270;
public static readonly nint SYS_PPOLL = 271;
public static readonly nint SYS_UNSHARE = 272;
public static readonly nint SYS_SET_ROBUST_LIST = 273;
public static readonly nint SYS_GET_ROBUST_LIST = 274;
public static readonly nint SYS_SPLICE = 275;
public static readonly nint SYS_TEE = 276;
public static readonly nint SYS_SYNC_FILE_RANGE = 277;
public static readonly nint SYS_VMSPLICE = 278;
public static readonly nint SYS_MOVE_PAGES = 279;
public static readonly nint SYS_UTIMENSAT = 280;
public static readonly nint SYS_EPOLL_PWAIT = 281;
public static readonly nint SYS_SIGNALFD = 282;
public static readonly nint SYS_TIMERFD_CREATE = 283;
public static readonly nint SYS_EVENTFD = 284;
public static readonly nint SYS_FALLOCATE = 285;
public static readonly nint SYS_TIMERFD_SETTIME = 286;
public static readonly nint SYS_TIMERFD_GETTIME = 287;
public static readonly nint SYS_ACCEPT4 = 288;
public static readonly nint SYS_SIGNALFD4 = 289;
public static readonly nint SYS_EVENTFD2 = 290;
public static readonly nint SYS_EPOLL_CREATE1 = 291;
public static readonly nint SYS_DUP3 = 292;
public static readonly nint SYS_PIPE2 = 293;
public static readonly nint SYS_INOTIFY_INIT1 = 294;
public static readonly nint SYS_PREADV = 295;
public static readonly nint SYS_PWRITEV = 296;
public static readonly nint SYS_RT_TGSIGQUEUEINFO = 297;
public static readonly nint SYS_PERF_EVENT_OPEN = 298;
public static readonly nint SYS_RECVMMSG = 299;
public static readonly nint SYS_FANOTIFY_INIT = 300;
public static readonly nint SYS_FANOTIFY_MARK = 301;
public static readonly nint SYS_PRLIMIT64 = 302;
public static readonly nint SYS_NAME_TO_HANDLE_AT = 303;
public static readonly nint SYS_OPEN_BY_HANDLE_AT = 304;
public static readonly nint SYS_CLOCK_ADJTIME = 305;
public static readonly nint SYS_SYNCFS = 306;
public static readonly nint SYS_SENDMMSG = 307;
public static readonly nint SYS_SETNS = 308;
public static readonly nint SYS_GETCPU = 309;
public static readonly nint SYS_PROCESS_VM_READV = 310;
public static readonly nint SYS_PROCESS_VM_WRITEV = 311;
public static readonly nint SYS_KCMP = 312;
public static readonly nint SYS_FINIT_MODULE = 313;
public static readonly nint SYS_SCHED_SETATTR = 314;
public static readonly nint SYS_SCHED_GETATTR = 315;
public static readonly nint SYS_RENAMEAT2 = 316;
public static readonly nint SYS_SECCOMP = 317;
public static readonly nint SYS_GETRANDOM = 318;
public static readonly nint SYS_MEMFD_CREATE = 319;
public static readonly nint SYS_KEXEC_FILE_LOAD = 320;
public static readonly nint SYS_BPF = 321;
public static readonly nint SYS_EXECVEAT = 322;
public static readonly nint SYS_USERFAULTFD = 323;
public static readonly nint SYS_MEMBARRIER = 324;
public static readonly nint SYS_MLOCK2 = 325;
public static readonly nint SYS_COPY_FILE_RANGE = 326;
public static readonly nint SYS_PREADV2 = 327;
public static readonly nint SYS_PWRITEV2 = 328;
public static readonly nint SYS_PKEY_MPROTECT = 329;
public static readonly nint SYS_PKEY_ALLOC = 330;
public static readonly nint SYS_PKEY_FREE = 331;
public static readonly nint SYS_STATX = 332;
public static readonly nint SYS_IO_PGETEVENTS = 333;
public static readonly nint SYS_RSEQ = 334;
public static readonly nint SYS_PIDFD_SEND_SIGNAL = 424;
public static readonly nint SYS_IO_URING_SETUP = 425;
public static readonly nint SYS_IO_URING_ENTER = 426;
public static readonly nint SYS_IO_URING_REGISTER = 427;
public static readonly nint SYS_OPEN_TREE = 428;
public static readonly nint SYS_MOVE_MOUNT = 429;
public static readonly nint SYS_FSOPEN = 430;
public static readonly nint SYS_FSCONFIG = 431;
public static readonly nint SYS_FSMOUNT = 432;
public static readonly nint SYS_FSPICK = 433;
public static readonly nint SYS_PIDFD_OPEN = 434;
public static readonly nint SYS_CLONE3 = 435;
public static readonly nint SYS_CLOSE_RANGE = 436;
public static readonly nint SYS_OPENAT2 = 437;
public static readonly nint SYS_PIDFD_GETFD = 438;
public static readonly nint SYS_FACCESSAT2 = 439;
public static readonly nint SYS_PROCESS_MADVISE = 440;
public static readonly nint SYS_EPOLL_PWAIT2 = 441;
public static readonly nint SYS_MOUNT_SETATTR = 442;


} // end unix_package
