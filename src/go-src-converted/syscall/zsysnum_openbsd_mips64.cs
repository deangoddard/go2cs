// mksysnum_openbsd.pl
// Code generated by the command above; DO NOT EDIT.

// package syscall -- go2cs converted at 2022 March 06 22:29:48 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Program Files\Go\src\syscall\zsysnum_openbsd_mips64.go


namespace go;

public static partial class syscall_package {

public static readonly nint SYS_EXIT = 1; // { void sys_exit(int rval); }
public static readonly nint SYS_FORK = 2; // { int sys_fork(void); }
public static readonly nint SYS_READ = 3; // { ssize_t sys_read(int fd, void *buf, size_t nbyte); }
public static readonly nint SYS_WRITE = 4; // { ssize_t sys_write(int fd, const void *buf, \
public static readonly nint SYS_OPEN = 5; // { int sys_open(const char *path, \
public static readonly nint SYS_CLOSE = 6; // { int sys_close(int fd); }
public static readonly nint SYS_GETENTROPY = 7; // { int sys_getentropy(void *buf, size_t nbyte); }
public static readonly nint SYS___TFORK = 8; // { int sys___tfork(const struct __tfork *param, \
public static readonly nint SYS_LINK = 9; // { int sys_link(const char *path, const char *link); }
public static readonly nint SYS_UNLINK = 10; // { int sys_unlink(const char *path); }
public static readonly nint SYS_WAIT4 = 11; // { pid_t sys_wait4(pid_t pid, int *status, \
public static readonly nint SYS_CHDIR = 12; // { int sys_chdir(const char *path); }
public static readonly nint SYS_FCHDIR = 13; // { int sys_fchdir(int fd); }
public static readonly nint SYS_MKNOD = 14; // { int sys_mknod(const char *path, mode_t mode, \
public static readonly nint SYS_CHMOD = 15; // { int sys_chmod(const char *path, mode_t mode); }
public static readonly nint SYS_CHOWN = 16; // { int sys_chown(const char *path, uid_t uid, \
public static readonly nint SYS_OBREAK = 17; // { int sys_obreak(char *nsize); } break
public static readonly nint SYS_GETDTABLECOUNT = 18; // { int sys_getdtablecount(void); }
public static readonly nint SYS_GETRUSAGE = 19; // { int sys_getrusage(int who, \
public static readonly nint SYS_GETPID = 20; // { pid_t sys_getpid(void); }
public static readonly nint SYS_MOUNT = 21; // { int sys_mount(const char *type, const char *path, \
public static readonly nint SYS_UNMOUNT = 22; // { int sys_unmount(const char *path, int flags); }
public static readonly nint SYS_SETUID = 23; // { int sys_setuid(uid_t uid); }
public static readonly nint SYS_GETUID = 24; // { uid_t sys_getuid(void); }
public static readonly nint SYS_GETEUID = 25; // { uid_t sys_geteuid(void); }
public static readonly nint SYS_PTRACE = 26; // { int sys_ptrace(int req, pid_t pid, caddr_t addr, \
public static readonly nint SYS_RECVMSG = 27; // { ssize_t sys_recvmsg(int s, struct msghdr *msg, \
public static readonly nint SYS_SENDMSG = 28; // { ssize_t sys_sendmsg(int s, \
public static readonly nint SYS_RECVFROM = 29; // { ssize_t sys_recvfrom(int s, void *buf, size_t len, \
public static readonly nint SYS_ACCEPT = 30; // { int sys_accept(int s, struct sockaddr *name, \
public static readonly nint SYS_GETPEERNAME = 31; // { int sys_getpeername(int fdes, struct sockaddr *asa, \
public static readonly nint SYS_GETSOCKNAME = 32; // { int sys_getsockname(int fdes, struct sockaddr *asa, \
public static readonly nint SYS_ACCESS = 33; // { int sys_access(const char *path, int amode); }
public static readonly nint SYS_CHFLAGS = 34; // { int sys_chflags(const char *path, u_int flags); }
public static readonly nint SYS_FCHFLAGS = 35; // { int sys_fchflags(int fd, u_int flags); }
public static readonly nint SYS_SYNC = 36; // { void sys_sync(void); }
public static readonly nint SYS_MSYSCALL = 37; // { int sys_msyscall(void *addr, size_t len); }
public static readonly nint SYS_STAT = 38; // { int sys_stat(const char *path, struct stat *ub); }
public static readonly nint SYS_GETPPID = 39; // { pid_t sys_getppid(void); }
public static readonly nint SYS_LSTAT = 40; // { int sys_lstat(const char *path, struct stat *ub); }
public static readonly nint SYS_DUP = 41; // { int sys_dup(int fd); }
public static readonly nint SYS_FSTATAT = 42; // { int sys_fstatat(int fd, const char *path, \
public static readonly nint SYS_GETEGID = 43; // { gid_t sys_getegid(void); }
public static readonly nint SYS_PROFIL = 44; // { int sys_profil(caddr_t samples, size_t size, \
public static readonly nint SYS_KTRACE = 45; // { int sys_ktrace(const char *fname, int ops, \
public static readonly nint SYS_SIGACTION = 46; // { int sys_sigaction(int signum, \
public static readonly nint SYS_GETGID = 47; // { gid_t sys_getgid(void); }
public static readonly nint SYS_SIGPROCMASK = 48; // { int sys_sigprocmask(int how, sigset_t mask); }
public static readonly nint SYS_SETLOGIN = 50; // { int sys_setlogin(const char *namebuf); }
public static readonly nint SYS_ACCT = 51; // { int sys_acct(const char *path); }
public static readonly nint SYS_SIGPENDING = 52; // { int sys_sigpending(void); }
public static readonly nint SYS_FSTAT = 53; // { int sys_fstat(int fd, struct stat *sb); }
public static readonly nint SYS_IOCTL = 54; // { int sys_ioctl(int fd, \
public static readonly nint SYS_REBOOT = 55; // { int sys_reboot(int opt); }
public static readonly nint SYS_REVOKE = 56; // { int sys_revoke(const char *path); }
public static readonly nint SYS_SYMLINK = 57; // { int sys_symlink(const char *path, \
public static readonly nint SYS_READLINK = 58; // { ssize_t sys_readlink(const char *path, \
public static readonly nint SYS_EXECVE = 59; // { int sys_execve(const char *path, \
public static readonly nint SYS_UMASK = 60; // { mode_t sys_umask(mode_t newmask); }
public static readonly nint SYS_CHROOT = 61; // { int sys_chroot(const char *path); }
public static readonly nint SYS_GETFSSTAT = 62; // { int sys_getfsstat(struct statfs *buf, size_t bufsize, \
public static readonly nint SYS_STATFS = 63; // { int sys_statfs(const char *path, \
public static readonly nint SYS_FSTATFS = 64; // { int sys_fstatfs(int fd, struct statfs *buf); }
public static readonly nint SYS_FHSTATFS = 65; // { int sys_fhstatfs(const fhandle_t *fhp, \
public static readonly nint SYS_VFORK = 66; // { int sys_vfork(void); }
public static readonly nint SYS_GETTIMEOFDAY = 67; // { int sys_gettimeofday(struct timeval *tp, \
public static readonly nint SYS_SETTIMEOFDAY = 68; // { int sys_settimeofday(const struct timeval *tv, \
public static readonly nint SYS_SETITIMER = 69; // { int sys_setitimer(int which, \
public static readonly nint SYS_GETITIMER = 70; // { int sys_getitimer(int which, \
public static readonly nint SYS_SELECT = 71; // { int sys_select(int nd, fd_set *in, fd_set *ou, \
public static readonly nint SYS_KEVENT = 72; // { int sys_kevent(int fd, \
public static readonly nint SYS_MUNMAP = 73; // { int sys_munmap(void *addr, size_t len); }
public static readonly nint SYS_MPROTECT = 74; // { int sys_mprotect(void *addr, size_t len, \
public static readonly nint SYS_MADVISE = 75; // { int sys_madvise(void *addr, size_t len, \
public static readonly nint SYS_UTIMES = 76; // { int sys_utimes(const char *path, \
public static readonly nint SYS_FUTIMES = 77; // { int sys_futimes(int fd, \
public static readonly nint SYS_GETGROUPS = 79; // { int sys_getgroups(int gidsetsize, \
public static readonly nint SYS_SETGROUPS = 80; // { int sys_setgroups(int gidsetsize, \
public static readonly nint SYS_GETPGRP = 81; // { int sys_getpgrp(void); }
public static readonly nint SYS_SETPGID = 82; // { int sys_setpgid(pid_t pid, pid_t pgid); }
public static readonly nint SYS_FUTEX = 83; // { int sys_futex(uint32_t *f, int op, int val, \
public static readonly nint SYS_UTIMENSAT = 84; // { int sys_utimensat(int fd, const char *path, \
public static readonly nint SYS_FUTIMENS = 85; // { int sys_futimens(int fd, \
public static readonly nint SYS_KBIND = 86; // { int sys_kbind(const struct __kbind *param, \
public static readonly nint SYS_CLOCK_GETTIME = 87; // { int sys_clock_gettime(clockid_t clock_id, \
public static readonly nint SYS_CLOCK_SETTIME = 88; // { int sys_clock_settime(clockid_t clock_id, \
public static readonly nint SYS_CLOCK_GETRES = 89; // { int sys_clock_getres(clockid_t clock_id, \
public static readonly nint SYS_DUP2 = 90; // { int sys_dup2(int from, int to); }
public static readonly nint SYS_NANOSLEEP = 91; // { int sys_nanosleep(const struct timespec *rqtp, \
public static readonly nint SYS_FCNTL = 92; // { int sys_fcntl(int fd, int cmd, ... void *arg); }
public static readonly nint SYS_ACCEPT4 = 93; // { int sys_accept4(int s, struct sockaddr *name, \
public static readonly nint SYS___THRSLEEP = 94; // { int sys___thrsleep(const volatile void *ident, \
public static readonly nint SYS_FSYNC = 95; // { int sys_fsync(int fd); }
public static readonly nint SYS_SETPRIORITY = 96; // { int sys_setpriority(int which, id_t who, int prio); }
public static readonly nint SYS_SOCKET = 97; // { int sys_socket(int domain, int type, int protocol); }
public static readonly nint SYS_CONNECT = 98; // { int sys_connect(int s, const struct sockaddr *name, \
public static readonly nint SYS_GETDENTS = 99; // { int sys_getdents(int fd, void *buf, size_t buflen); }
public static readonly nint SYS_GETPRIORITY = 100; // { int sys_getpriority(int which, id_t who); }
public static readonly nint SYS_PIPE2 = 101; // { int sys_pipe2(int *fdp, int flags); }
public static readonly nint SYS_DUP3 = 102; // { int sys_dup3(int from, int to, int flags); }
public static readonly nint SYS_SIGRETURN = 103; // { int sys_sigreturn(struct sigcontext *sigcntxp); }
public static readonly nint SYS_BIND = 104; // { int sys_bind(int s, const struct sockaddr *name, \
public static readonly nint SYS_SETSOCKOPT = 105; // { int sys_setsockopt(int s, int level, int name, \
public static readonly nint SYS_LISTEN = 106; // { int sys_listen(int s, int backlog); }
public static readonly nint SYS_CHFLAGSAT = 107; // { int sys_chflagsat(int fd, const char *path, \
public static readonly nint SYS_PLEDGE = 108; // { int sys_pledge(const char *promises, \
public static readonly nint SYS_PPOLL = 109; // { int sys_ppoll(struct pollfd *fds, \
public static readonly nint SYS_PSELECT = 110; // { int sys_pselect(int nd, fd_set *in, fd_set *ou, \
public static readonly nint SYS_SIGSUSPEND = 111; // { int sys_sigsuspend(int mask); }
public static readonly nint SYS_SENDSYSLOG = 112; // { int sys_sendsyslog(const char *buf, size_t nbyte, \
public static readonly nint SYS_UNVEIL = 114; // { int sys_unveil(const char *path, \
public static readonly nint SYS___REALPATH = 115; // { int sys___realpath(const char *pathname, \
public static readonly nint SYS_GETSOCKOPT = 118; // { int sys_getsockopt(int s, int level, int name, \
public static readonly nint SYS_THRKILL = 119; // { int sys_thrkill(pid_t tid, int signum, void *tcb); }
public static readonly nint SYS_READV = 120; // { ssize_t sys_readv(int fd, \
public static readonly nint SYS_WRITEV = 121; // { ssize_t sys_writev(int fd, \
public static readonly nint SYS_KILL = 122; // { int sys_kill(int pid, int signum); }
public static readonly nint SYS_FCHOWN = 123; // { int sys_fchown(int fd, uid_t uid, gid_t gid); }
public static readonly nint SYS_FCHMOD = 124; // { int sys_fchmod(int fd, mode_t mode); }
public static readonly nint SYS_SETREUID = 126; // { int sys_setreuid(uid_t ruid, uid_t euid); }
public static readonly nint SYS_SETREGID = 127; // { int sys_setregid(gid_t rgid, gid_t egid); }
public static readonly nint SYS_RENAME = 128; // { int sys_rename(const char *from, const char *to); }
public static readonly nint SYS_FLOCK = 131; // { int sys_flock(int fd, int how); }
public static readonly nint SYS_MKFIFO = 132; // { int sys_mkfifo(const char *path, mode_t mode); }
public static readonly nint SYS_SENDTO = 133; // { ssize_t sys_sendto(int s, const void *buf, \
public static readonly nint SYS_SHUTDOWN = 134; // { int sys_shutdown(int s, int how); }
public static readonly nint SYS_SOCKETPAIR = 135; // { int sys_socketpair(int domain, int type, \
public static readonly nint SYS_MKDIR = 136; // { int sys_mkdir(const char *path, mode_t mode); }
public static readonly nint SYS_RMDIR = 137; // { int sys_rmdir(const char *path); }
public static readonly nint SYS_ADJTIME = 140; // { int sys_adjtime(const struct timeval *delta, \
public static readonly nint SYS_GETLOGIN_R = 141; // { int sys_getlogin_r(char *namebuf, u_int namelen); }
public static readonly nint SYS_SETSID = 147; // { int sys_setsid(void); }
public static readonly nint SYS_QUOTACTL = 148; // { int sys_quotactl(const char *path, int cmd, \
public static readonly nint SYS_NFSSVC = 155; // { int sys_nfssvc(int flag, void *argp); }
public static readonly nint SYS_GETFH = 161; // { int sys_getfh(const char *fname, fhandle_t *fhp); }
public static readonly nint SYS___TMPFD = 164; // { int sys___tmpfd(int flags); }
public static readonly nint SYS_SYSARCH = 165; // { int sys_sysarch(int op, void *parms); }
public static readonly nint SYS_PREAD = 173; // { ssize_t sys_pread(int fd, void *buf, \
public static readonly nint SYS_PWRITE = 174; // { ssize_t sys_pwrite(int fd, const void *buf, \
public static readonly nint SYS_SETGID = 181; // { int sys_setgid(gid_t gid); }
public static readonly nint SYS_SETEGID = 182; // { int sys_setegid(gid_t egid); }
public static readonly nint SYS_SETEUID = 183; // { int sys_seteuid(uid_t euid); }
public static readonly nint SYS_PATHCONF = 191; // { long sys_pathconf(const char *path, int name); }
public static readonly nint SYS_FPATHCONF = 192; // { long sys_fpathconf(int fd, int name); }
public static readonly nint SYS_SWAPCTL = 193; // { int sys_swapctl(int cmd, const void *arg, int misc); }
public static readonly nint SYS_GETRLIMIT = 194; // { int sys_getrlimit(int which, \
public static readonly nint SYS_SETRLIMIT = 195; // { int sys_setrlimit(int which, \
public static readonly nint SYS_MMAP = 197; // { void *sys_mmap(void *addr, size_t len, int prot, \
public static readonly nint SYS_LSEEK = 199; // { off_t sys_lseek(int fd, int pad, off_t offset, \
public static readonly nint SYS_TRUNCATE = 200; // { int sys_truncate(const char *path, int pad, \
public static readonly nint SYS_FTRUNCATE = 201; // { int sys_ftruncate(int fd, int pad, off_t length); }
public static readonly nint SYS_SYSCTL = 202; // { int sys_sysctl(const int *name, u_int namelen, \
public static readonly nint SYS_MLOCK = 203; // { int sys_mlock(const void *addr, size_t len); }
public static readonly nint SYS_MUNLOCK = 204; // { int sys_munlock(const void *addr, size_t len); }
public static readonly nint SYS_GETPGID = 207; // { pid_t sys_getpgid(pid_t pid); }
public static readonly nint SYS_UTRACE = 209; // { int sys_utrace(const char *label, const void *addr, \
public static readonly nint SYS_SEMGET = 221; // { int sys_semget(key_t key, int nsems, int semflg); }
public static readonly nint SYS_MSGGET = 225; // { int sys_msgget(key_t key, int msgflg); }
public static readonly nint SYS_MSGSND = 226; // { int sys_msgsnd(int msqid, const void *msgp, size_t msgsz, \
public static readonly nint SYS_MSGRCV = 227; // { int sys_msgrcv(int msqid, void *msgp, size_t msgsz, \
public static readonly nint SYS_SHMAT = 228; // { void *sys_shmat(int shmid, const void *shmaddr, \
public static readonly nint SYS_SHMDT = 230; // { int sys_shmdt(const void *shmaddr); }
public static readonly nint SYS_MINHERIT = 250; // { int sys_minherit(void *addr, size_t len, \
public static readonly nint SYS_POLL = 252; // { int sys_poll(struct pollfd *fds, \
public static readonly nint SYS_ISSETUGID = 253; // { int sys_issetugid(void); }
public static readonly nint SYS_LCHOWN = 254; // { int sys_lchown(const char *path, uid_t uid, gid_t gid); }
public static readonly nint SYS_GETSID = 255; // { pid_t sys_getsid(pid_t pid); }
public static readonly nint SYS_MSYNC = 256; // { int sys_msync(void *addr, size_t len, int flags); }
public static readonly nint SYS_PIPE = 263; // { int sys_pipe(int *fdp); }
public static readonly nint SYS_FHOPEN = 264; // { int sys_fhopen(const fhandle_t *fhp, int flags); }
public static readonly nint SYS_PREADV = 267; // { ssize_t sys_preadv(int fd, \
public static readonly nint SYS_PWRITEV = 268; // { ssize_t sys_pwritev(int fd, \
public static readonly nint SYS_KQUEUE = 269; // { int sys_kqueue(void); }
public static readonly nint SYS_MLOCKALL = 271; // { int sys_mlockall(int flags); }
public static readonly nint SYS_MUNLOCKALL = 272; // { int sys_munlockall(void); }
public static readonly nint SYS_GETRESUID = 281; // { int sys_getresuid(uid_t *ruid, uid_t *euid, \
public static readonly nint SYS_SETRESUID = 282; // { int sys_setresuid(uid_t ruid, uid_t euid, \
public static readonly nint SYS_GETRESGID = 283; // { int sys_getresgid(gid_t *rgid, gid_t *egid, \
public static readonly nint SYS_SETRESGID = 284; // { int sys_setresgid(gid_t rgid, gid_t egid, \
public static readonly nint SYS_MQUERY = 286; // { void *sys_mquery(void *addr, size_t len, int prot, \
public static readonly nint SYS_CLOSEFROM = 287; // { int sys_closefrom(int fd); }
public static readonly nint SYS_SIGALTSTACK = 288; // { int sys_sigaltstack(const struct sigaltstack *nss, \
public static readonly nint SYS_SHMGET = 289; // { int sys_shmget(key_t key, size_t size, int shmflg); }
public static readonly nint SYS_SEMOP = 290; // { int sys_semop(int semid, struct sembuf *sops, \
public static readonly nint SYS_FHSTAT = 294; // { int sys_fhstat(const fhandle_t *fhp, \
public static readonly nint SYS___SEMCTL = 295; // { int sys___semctl(int semid, int semnum, int cmd, \
public static readonly nint SYS_SHMCTL = 296; // { int sys_shmctl(int shmid, int cmd, \
public static readonly nint SYS_MSGCTL = 297; // { int sys_msgctl(int msqid, int cmd, \
public static readonly nint SYS_SCHED_YIELD = 298; // { int sys_sched_yield(void); }
public static readonly nint SYS_GETTHRID = 299; // { pid_t sys_getthrid(void); }
public static readonly nint SYS___THRWAKEUP = 301; // { int sys___thrwakeup(const volatile void *ident, \
public static readonly nint SYS___THREXIT = 302; // { void sys___threxit(pid_t *notdead); }
public static readonly nint SYS___THRSIGDIVERT = 303; // { int sys___thrsigdivert(sigset_t sigmask, \
public static readonly nint SYS___GETCWD = 304; // { int sys___getcwd(char *buf, size_t len); }
public static readonly nint SYS_ADJFREQ = 305; // { int sys_adjfreq(const int64_t *freq, \
public static readonly nint SYS_SETRTABLE = 310; // { int sys_setrtable(int rtableid); }
public static readonly nint SYS_GETRTABLE = 311; // { int sys_getrtable(void); }
public static readonly nint SYS_FACCESSAT = 313; // { int sys_faccessat(int fd, const char *path, \
public static readonly nint SYS_FCHMODAT = 314; // { int sys_fchmodat(int fd, const char *path, \
public static readonly nint SYS_FCHOWNAT = 315; // { int sys_fchownat(int fd, const char *path, \
public static readonly nint SYS_LINKAT = 317; // { int sys_linkat(int fd1, const char *path1, int fd2, \
public static readonly nint SYS_MKDIRAT = 318; // { int sys_mkdirat(int fd, const char *path, \
public static readonly nint SYS_MKFIFOAT = 319; // { int sys_mkfifoat(int fd, const char *path, \
public static readonly nint SYS_MKNODAT = 320; // { int sys_mknodat(int fd, const char *path, \
public static readonly nint SYS_OPENAT = 321; // { int sys_openat(int fd, const char *path, int flags, \
public static readonly nint SYS_READLINKAT = 322; // { ssize_t sys_readlinkat(int fd, const char *path, \
public static readonly nint SYS_RENAMEAT = 323; // { int sys_renameat(int fromfd, const char *from, \
public static readonly nint SYS_SYMLINKAT = 324; // { int sys_symlinkat(const char *path, int fd, \
public static readonly nint SYS_UNLINKAT = 325; // { int sys_unlinkat(int fd, const char *path, \
public static readonly nint SYS___SET_TCB = 329; // { void sys___set_tcb(void *tcb); }
public static readonly nint SYS___GET_TCB = 330; // { void *sys___get_tcb(void); }

} // end syscall_package
