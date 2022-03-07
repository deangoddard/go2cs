// mksysnum_linux.pl /usr/include/asm-generic/unistd.h
// Code generated by the command above; DO NOT EDIT.

//go:build arm64 && linux
// +build arm64,linux

// package syscall -- go2cs converted at 2022 March 06 22:29:48 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Program Files\Go\src\syscall\zsysnum_linux_arm64.go


namespace go;

public static partial class syscall_package {

public static readonly nint SYS_IO_SETUP = 0;
public static readonly nint SYS_IO_DESTROY = 1;
public static readonly nint SYS_IO_SUBMIT = 2;
public static readonly nint SYS_IO_CANCEL = 3;
public static readonly nint SYS_IO_GETEVENTS = 4;
public static readonly nint SYS_SETXATTR = 5;
public static readonly nint SYS_LSETXATTR = 6;
public static readonly nint SYS_FSETXATTR = 7;
public static readonly nint SYS_GETXATTR = 8;
public static readonly nint SYS_LGETXATTR = 9;
public static readonly nint SYS_FGETXATTR = 10;
public static readonly nint SYS_LISTXATTR = 11;
public static readonly nint SYS_LLISTXATTR = 12;
public static readonly nint SYS_FLISTXATTR = 13;
public static readonly nint SYS_REMOVEXATTR = 14;
public static readonly nint SYS_LREMOVEXATTR = 15;
public static readonly nint SYS_FREMOVEXATTR = 16;
public static readonly nint SYS_GETCWD = 17;
public static readonly nint SYS_LOOKUP_DCOOKIE = 18;
public static readonly nint SYS_EVENTFD2 = 19;
public static readonly nint SYS_EPOLL_CREATE1 = 20;
public static readonly nint SYS_EPOLL_CTL = 21;
public static readonly nint SYS_EPOLL_PWAIT = 22;
public static readonly nint SYS_DUP = 23;
public static readonly nint SYS_DUP3 = 24;
public static readonly nint SYS_FCNTL = 25;
public static readonly nint SYS_INOTIFY_INIT1 = 26;
public static readonly nint SYS_INOTIFY_ADD_WATCH = 27;
public static readonly nint SYS_INOTIFY_RM_WATCH = 28;
public static readonly nint SYS_IOCTL = 29;
public static readonly nint SYS_IOPRIO_SET = 30;
public static readonly nint SYS_IOPRIO_GET = 31;
public static readonly nint SYS_FLOCK = 32;
public static readonly nint SYS_MKNODAT = 33;
public static readonly nint SYS_MKDIRAT = 34;
public static readonly nint SYS_UNLINKAT = 35;
public static readonly nint SYS_SYMLINKAT = 36;
public static readonly nint SYS_LINKAT = 37;
public static readonly nint SYS_RENAMEAT = 38;
public static readonly nint SYS_UMOUNT2 = 39;
public static readonly nint SYS_MOUNT = 40;
public static readonly nint SYS_PIVOT_ROOT = 41;
public static readonly nint SYS_NFSSERVCTL = 42;
public static readonly nint SYS_STATFS = 43;
public static readonly nint SYS_FSTATFS = 44;
public static readonly nint SYS_TRUNCATE = 45;
public static readonly nint SYS_FTRUNCATE = 46;
public static readonly nint SYS_FALLOCATE = 47;
public static readonly nint SYS_FACCESSAT = 48;
public static readonly nint SYS_CHDIR = 49;
public static readonly nint SYS_FCHDIR = 50;
public static readonly nint SYS_CHROOT = 51;
public static readonly nint SYS_FCHMOD = 52;
public static readonly nint SYS_FCHMODAT = 53;
public static readonly nint SYS_FCHOWNAT = 54;
public static readonly nint SYS_FCHOWN = 55;
public static readonly nint SYS_OPENAT = 56;
public static readonly nint SYS_CLOSE = 57;
public static readonly nint SYS_VHANGUP = 58;
public static readonly nint SYS_PIPE2 = 59;
public static readonly nint SYS_QUOTACTL = 60;
public static readonly nint SYS_GETDENTS64 = 61;
public static readonly nint SYS_LSEEK = 62;
public static readonly nint SYS_READ = 63;
public static readonly nint SYS_WRITE = 64;
public static readonly nint SYS_READV = 65;
public static readonly nint SYS_WRITEV = 66;
public static readonly nint SYS_PREAD64 = 67;
public static readonly nint SYS_PWRITE64 = 68;
public static readonly nint SYS_PREADV = 69;
public static readonly nint SYS_PWRITEV = 70;
public static readonly nint SYS_SENDFILE = 71;
public static readonly nint SYS_PSELECT6 = 72;
public static readonly nint SYS_PPOLL = 73;
public static readonly nint SYS_SIGNALFD4 = 74;
public static readonly nint SYS_VMSPLICE = 75;
public static readonly nint SYS_SPLICE = 76;
public static readonly nint SYS_TEE = 77;
public static readonly nint SYS_READLINKAT = 78;
public static readonly nint SYS_FSTATAT = 79;
public static readonly nint SYS_FSTAT = 80;
public static readonly nint SYS_SYNC = 81;
public static readonly nint SYS_FSYNC = 82;
public static readonly nint SYS_FDATASYNC = 83;
public static readonly nint SYS_SYNC_FILE_RANGE2 = 84;
public static readonly nint SYS_SYNC_FILE_RANGE = 84;
public static readonly nint SYS_TIMERFD_CREATE = 85;
public static readonly nint SYS_TIMERFD_SETTIME = 86;
public static readonly nint SYS_TIMERFD_GETTIME = 87;
public static readonly nint SYS_UTIMENSAT = 88;
public static readonly nint SYS_ACCT = 89;
public static readonly nint SYS_CAPGET = 90;
public static readonly nint SYS_CAPSET = 91;
public static readonly nint SYS_PERSONALITY = 92;
public static readonly nint SYS_EXIT = 93;
public static readonly nint SYS_EXIT_GROUP = 94;
public static readonly nint SYS_WAITID = 95;
public static readonly nint SYS_SET_TID_ADDRESS = 96;
public static readonly nint SYS_UNSHARE = 97;
public static readonly nint SYS_FUTEX = 98;
public static readonly nint SYS_SET_ROBUST_LIST = 99;
public static readonly nint SYS_GET_ROBUST_LIST = 100;
public static readonly nint SYS_NANOSLEEP = 101;
public static readonly nint SYS_GETITIMER = 102;
public static readonly nint SYS_SETITIMER = 103;
public static readonly nint SYS_KEXEC_LOAD = 104;
public static readonly nint SYS_INIT_MODULE = 105;
public static readonly nint SYS_DELETE_MODULE = 106;
public static readonly nint SYS_TIMER_CREATE = 107;
public static readonly nint SYS_TIMER_GETTIME = 108;
public static readonly nint SYS_TIMER_GETOVERRUN = 109;
public static readonly nint SYS_TIMER_SETTIME = 110;
public static readonly nint SYS_TIMER_DELETE = 111;
public static readonly nint SYS_CLOCK_SETTIME = 112;
public static readonly nint SYS_CLOCK_GETTIME = 113;
public static readonly nint SYS_CLOCK_GETRES = 114;
public static readonly nint SYS_CLOCK_NANOSLEEP = 115;
public static readonly nint SYS_SYSLOG = 116;
public static readonly nint SYS_PTRACE = 117;
public static readonly nint SYS_SCHED_SETPARAM = 118;
public static readonly nint SYS_SCHED_SETSCHEDULER = 119;
public static readonly nint SYS_SCHED_GETSCHEDULER = 120;
public static readonly nint SYS_SCHED_GETPARAM = 121;
public static readonly nint SYS_SCHED_SETAFFINITY = 122;
public static readonly nint SYS_SCHED_GETAFFINITY = 123;
public static readonly nint SYS_SCHED_YIELD = 124;
public static readonly nint SYS_SCHED_GET_PRIORITY_MAX = 125;
public static readonly nint SYS_SCHED_GET_PRIORITY_MIN = 126;
public static readonly nint SYS_SCHED_RR_GET_INTERVAL = 127;
public static readonly nint SYS_RESTART_SYSCALL = 128;
public static readonly nint SYS_KILL = 129;
public static readonly nint SYS_TKILL = 130;
public static readonly nint SYS_TGKILL = 131;
public static readonly nint SYS_SIGALTSTACK = 132;
public static readonly nint SYS_RT_SIGSUSPEND = 133;
public static readonly nint SYS_RT_SIGACTION = 134;
public static readonly nint SYS_RT_SIGPROCMASK = 135;
public static readonly nint SYS_RT_SIGPENDING = 136;
public static readonly nint SYS_RT_SIGTIMEDWAIT = 137;
public static readonly nint SYS_RT_SIGQUEUEINFO = 138;
public static readonly nint SYS_RT_SIGRETURN = 139;
public static readonly nint SYS_SETPRIORITY = 140;
public static readonly nint SYS_GETPRIORITY = 141;
public static readonly nint SYS_REBOOT = 142;
public static readonly nint SYS_SETREGID = 143;
public static readonly nint SYS_SETGID = 144;
public static readonly nint SYS_SETREUID = 145;
public static readonly nint SYS_SETUID = 146;
public static readonly nint SYS_SETRESUID = 147;
public static readonly nint SYS_GETRESUID = 148;
public static readonly nint SYS_SETRESGID = 149;
public static readonly nint SYS_GETRESGID = 150;
public static readonly nint SYS_SETFSUID = 151;
public static readonly nint SYS_SETFSGID = 152;
public static readonly nint SYS_TIMES = 153;
public static readonly nint SYS_SETPGID = 154;
public static readonly nint SYS_GETPGID = 155;
public static readonly nint SYS_GETSID = 156;
public static readonly nint SYS_SETSID = 157;
public static readonly nint SYS_GETGROUPS = 158;
public static readonly nint SYS_SETGROUPS = 159;
public static readonly nint SYS_UNAME = 160;
public static readonly nint SYS_SETHOSTNAME = 161;
public static readonly nint SYS_SETDOMAINNAME = 162;
public static readonly nint SYS_GETRLIMIT = 163;
public static readonly nint SYS_SETRLIMIT = 164;
public static readonly nint SYS_GETRUSAGE = 165;
public static readonly nint SYS_UMASK = 166;
public static readonly nint SYS_PRCTL = 167;
public static readonly nint SYS_GETCPU = 168;
public static readonly nint SYS_GETTIMEOFDAY = 169;
public static readonly nint SYS_SETTIMEOFDAY = 170;
public static readonly nint SYS_ADJTIMEX = 171;
public static readonly nint SYS_GETPID = 172;
public static readonly nint SYS_GETPPID = 173;
public static readonly nint SYS_GETUID = 174;
public static readonly nint SYS_GETEUID = 175;
public static readonly nint SYS_GETGID = 176;
public static readonly nint SYS_GETEGID = 177;
public static readonly nint SYS_GETTID = 178;
public static readonly nint SYS_SYSINFO = 179;
public static readonly nint SYS_MQ_OPEN = 180;
public static readonly nint SYS_MQ_UNLINK = 181;
public static readonly nint SYS_MQ_TIMEDSEND = 182;
public static readonly nint SYS_MQ_TIMEDRECEIVE = 183;
public static readonly nint SYS_MQ_NOTIFY = 184;
public static readonly nint SYS_MQ_GETSETATTR = 185;
public static readonly nint SYS_MSGGET = 186;
public static readonly nint SYS_MSGCTL = 187;
public static readonly nint SYS_MSGRCV = 188;
public static readonly nint SYS_MSGSND = 189;
public static readonly nint SYS_SEMGET = 190;
public static readonly nint SYS_SEMCTL = 191;
public static readonly nint SYS_SEMTIMEDOP = 192;
public static readonly nint SYS_SEMOP = 193;
public static readonly nint SYS_SHMGET = 194;
public static readonly nint SYS_SHMCTL = 195;
public static readonly nint SYS_SHMAT = 196;
public static readonly nint SYS_SHMDT = 197;
public static readonly nint SYS_SOCKET = 198;
public static readonly nint SYS_SOCKETPAIR = 199;
public static readonly nint SYS_BIND = 200;
public static readonly nint SYS_LISTEN = 201;
public static readonly nint SYS_ACCEPT = 202;
public static readonly nint SYS_CONNECT = 203;
public static readonly nint SYS_GETSOCKNAME = 204;
public static readonly nint SYS_GETPEERNAME = 205;
public static readonly nint SYS_SENDTO = 206;
public static readonly nint SYS_RECVFROM = 207;
public static readonly nint SYS_SETSOCKOPT = 208;
public static readonly nint SYS_GETSOCKOPT = 209;
public static readonly nint SYS_SHUTDOWN = 210;
public static readonly nint SYS_SENDMSG = 211;
public static readonly nint SYS_RECVMSG = 212;
public static readonly nint SYS_READAHEAD = 213;
public static readonly nint SYS_BRK = 214;
public static readonly nint SYS_MUNMAP = 215;
public static readonly nint SYS_MREMAP = 216;
public static readonly nint SYS_ADD_KEY = 217;
public static readonly nint SYS_REQUEST_KEY = 218;
public static readonly nint SYS_KEYCTL = 219;
public static readonly nint SYS_CLONE = 220;
public static readonly nint SYS_EXECVE = 221;
public static readonly nint SYS_MMAP = 222;
public static readonly nint SYS_FADVISE64 = 223;
public static readonly nint SYS_SWAPON = 224;
public static readonly nint SYS_SWAPOFF = 225;
public static readonly nint SYS_MPROTECT = 226;
public static readonly nint SYS_MSYNC = 227;
public static readonly nint SYS_MLOCK = 228;
public static readonly nint SYS_MUNLOCK = 229;
public static readonly nint SYS_MLOCKALL = 230;
public static readonly nint SYS_MUNLOCKALL = 231;
public static readonly nint SYS_MINCORE = 232;
public static readonly nint SYS_MADVISE = 233;
public static readonly nint SYS_REMAP_FILE_PAGES = 234;
public static readonly nint SYS_MBIND = 235;
public static readonly nint SYS_GET_MEMPOLICY = 236;
public static readonly nint SYS_SET_MEMPOLICY = 237;
public static readonly nint SYS_MIGRATE_PAGES = 238;
public static readonly nint SYS_MOVE_PAGES = 239;
public static readonly nint SYS_RT_TGSIGQUEUEINFO = 240;
public static readonly nint SYS_PERF_EVENT_OPEN = 241;
public static readonly nint SYS_ACCEPT4 = 242;
public static readonly nint SYS_RECVMMSG = 243;
public static readonly nint SYS_ARCH_SPECIFIC_SYSCALL = 244;
public static readonly nint SYS_WAIT4 = 260;
public static readonly nint SYS_PRLIMIT64 = 261;
public static readonly nint SYS_FANOTIFY_INIT = 262;
public static readonly nint SYS_FANOTIFY_MARK = 263;
public static readonly nint SYS_NAME_TO_HANDLE_AT = 264;
public static readonly nint SYS_OPEN_BY_HANDLE_AT = 265;
public static readonly nint SYS_CLOCK_ADJTIME = 266;
public static readonly nint SYS_SYNCFS = 267;
public static readonly nint SYS_SETNS = 268;
public static readonly nint SYS_SENDMMSG = 269;
public static readonly nint SYS_PROCESS_VM_READV = 270;
public static readonly nint SYS_PROCESS_VM_WRITEV = 271;
public static readonly nint SYS_KCMP = 272;
public static readonly nint SYS_FINIT_MODULE = 273;
public static readonly nint SYS_SCHED_SETATTR = 274;
public static readonly nint SYS_SCHED_GETATTR = 275;
public static readonly nint SYS_RENAMEAT2 = 276;
public static readonly nint SYS_SECCOMP = 277;
public static readonly nint SYS_GETRANDOM = 278;
public static readonly nint SYS_MEMFD_CREATE = 279;
public static readonly nint SYS_BPF = 280;
public static readonly nint SYS_EXECVEAT = 281;


} // end syscall_package
