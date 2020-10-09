// go run mksysnum.go https://cvsweb.openbsd.org/cgi-bin/cvsweb/~checkout~/src/sys/kern/syscalls.master
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build amd64,openbsd

// package unix -- go2cs converted at 2020 October 09 06:00:26 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_openbsd_amd64.go

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
        public static readonly long SYS_EXIT = (long)1L; // { void sys_exit(int rval); }
        public static readonly long SYS_FORK = (long)2L; // { int sys_fork(void); }
        public static readonly long SYS_READ = (long)3L; // { ssize_t sys_read(int fd, void *buf, size_t nbyte); }
        public static readonly long SYS_WRITE = (long)4L; // { ssize_t sys_write(int fd, const void *buf, size_t nbyte); }
        public static readonly long SYS_OPEN = (long)5L; // { int sys_open(const char *path, int flags, ... mode_t mode); }
        public static readonly long SYS_CLOSE = (long)6L; // { int sys_close(int fd); }
        public static readonly long SYS_GETENTROPY = (long)7L; // { int sys_getentropy(void *buf, size_t nbyte); }
        public static readonly long SYS___TFORK = (long)8L; // { int sys___tfork(const struct __tfork *param, size_t psize); }
        public static readonly long SYS_LINK = (long)9L; // { int sys_link(const char *path, const char *link); }
        public static readonly long SYS_UNLINK = (long)10L; // { int sys_unlink(const char *path); }
        public static readonly long SYS_WAIT4 = (long)11L; // { pid_t sys_wait4(pid_t pid, int *status, int options, struct rusage *rusage); }
        public static readonly long SYS_CHDIR = (long)12L; // { int sys_chdir(const char *path); }
        public static readonly long SYS_FCHDIR = (long)13L; // { int sys_fchdir(int fd); }
        public static readonly long SYS_MKNOD = (long)14L; // { int sys_mknod(const char *path, mode_t mode, dev_t dev); }
        public static readonly long SYS_CHMOD = (long)15L; // { int sys_chmod(const char *path, mode_t mode); }
        public static readonly long SYS_CHOWN = (long)16L; // { int sys_chown(const char *path, uid_t uid, gid_t gid); }
        public static readonly long SYS_OBREAK = (long)17L; // { int sys_obreak(char *nsize); } break
        public static readonly long SYS_GETDTABLECOUNT = (long)18L; // { int sys_getdtablecount(void); }
        public static readonly long SYS_GETRUSAGE = (long)19L; // { int sys_getrusage(int who, struct rusage *rusage); }
        public static readonly long SYS_GETPID = (long)20L; // { pid_t sys_getpid(void); }
        public static readonly long SYS_MOUNT = (long)21L; // { int sys_mount(const char *type, const char *path, int flags, void *data); }
        public static readonly long SYS_UNMOUNT = (long)22L; // { int sys_unmount(const char *path, int flags); }
        public static readonly long SYS_SETUID = (long)23L; // { int sys_setuid(uid_t uid); }
        public static readonly long SYS_GETUID = (long)24L; // { uid_t sys_getuid(void); }
        public static readonly long SYS_GETEUID = (long)25L; // { uid_t sys_geteuid(void); }
        public static readonly long SYS_PTRACE = (long)26L; // { int sys_ptrace(int req, pid_t pid, caddr_t addr, int data); }
        public static readonly long SYS_RECVMSG = (long)27L; // { ssize_t sys_recvmsg(int s, struct msghdr *msg, int flags); }
        public static readonly long SYS_SENDMSG = (long)28L; // { ssize_t sys_sendmsg(int s, const struct msghdr *msg, int flags); }
        public static readonly long SYS_RECVFROM = (long)29L; // { ssize_t sys_recvfrom(int s, void *buf, size_t len, int flags, struct sockaddr *from, socklen_t *fromlenaddr); }
        public static readonly long SYS_ACCEPT = (long)30L; // { int sys_accept(int s, struct sockaddr *name, socklen_t *anamelen); }
        public static readonly long SYS_GETPEERNAME = (long)31L; // { int sys_getpeername(int fdes, struct sockaddr *asa, socklen_t *alen); }
        public static readonly long SYS_GETSOCKNAME = (long)32L; // { int sys_getsockname(int fdes, struct sockaddr *asa, socklen_t *alen); }
        public static readonly long SYS_ACCESS = (long)33L; // { int sys_access(const char *path, int amode); }
        public static readonly long SYS_CHFLAGS = (long)34L; // { int sys_chflags(const char *path, u_int flags); }
        public static readonly long SYS_FCHFLAGS = (long)35L; // { int sys_fchflags(int fd, u_int flags); }
        public static readonly long SYS_SYNC = (long)36L; // { void sys_sync(void); }
        public static readonly long SYS_STAT = (long)38L; // { int sys_stat(const char *path, struct stat *ub); }
        public static readonly long SYS_GETPPID = (long)39L; // { pid_t sys_getppid(void); }
        public static readonly long SYS_LSTAT = (long)40L; // { int sys_lstat(const char *path, struct stat *ub); }
        public static readonly long SYS_DUP = (long)41L; // { int sys_dup(int fd); }
        public static readonly long SYS_FSTATAT = (long)42L; // { int sys_fstatat(int fd, const char *path, struct stat *buf, int flag); }
        public static readonly long SYS_GETEGID = (long)43L; // { gid_t sys_getegid(void); }
        public static readonly long SYS_PROFIL = (long)44L; // { int sys_profil(caddr_t samples, size_t size, u_long offset, u_int scale); }
        public static readonly long SYS_KTRACE = (long)45L; // { int sys_ktrace(const char *fname, int ops, int facs, pid_t pid); }
        public static readonly long SYS_SIGACTION = (long)46L; // { int sys_sigaction(int signum, const struct sigaction *nsa, struct sigaction *osa); }
        public static readonly long SYS_GETGID = (long)47L; // { gid_t sys_getgid(void); }
        public static readonly long SYS_SIGPROCMASK = (long)48L; // { int sys_sigprocmask(int how, sigset_t mask); }
        public static readonly long SYS_SETLOGIN = (long)50L; // { int sys_setlogin(const char *namebuf); }
        public static readonly long SYS_ACCT = (long)51L; // { int sys_acct(const char *path); }
        public static readonly long SYS_SIGPENDING = (long)52L; // { int sys_sigpending(void); }
        public static readonly long SYS_FSTAT = (long)53L; // { int sys_fstat(int fd, struct stat *sb); }
        public static readonly long SYS_IOCTL = (long)54L; // { int sys_ioctl(int fd, u_long com, ... void *data); }
        public static readonly long SYS_REBOOT = (long)55L; // { int sys_reboot(int opt); }
        public static readonly long SYS_REVOKE = (long)56L; // { int sys_revoke(const char *path); }
        public static readonly long SYS_SYMLINK = (long)57L; // { int sys_symlink(const char *path, const char *link); }
        public static readonly long SYS_READLINK = (long)58L; // { ssize_t sys_readlink(const char *path, char *buf, size_t count); }
        public static readonly long SYS_EXECVE = (long)59L; // { int sys_execve(const char *path, char * const *argp, char * const *envp); }
        public static readonly long SYS_UMASK = (long)60L; // { mode_t sys_umask(mode_t newmask); }
        public static readonly long SYS_CHROOT = (long)61L; // { int sys_chroot(const char *path); }
        public static readonly long SYS_GETFSSTAT = (long)62L; // { int sys_getfsstat(struct statfs *buf, size_t bufsize, int flags); }
        public static readonly long SYS_STATFS = (long)63L; // { int sys_statfs(const char *path, struct statfs *buf); }
        public static readonly long SYS_FSTATFS = (long)64L; // { int sys_fstatfs(int fd, struct statfs *buf); }
        public static readonly long SYS_FHSTATFS = (long)65L; // { int sys_fhstatfs(const fhandle_t *fhp, struct statfs *buf); }
        public static readonly long SYS_VFORK = (long)66L; // { int sys_vfork(void); }
        public static readonly long SYS_GETTIMEOFDAY = (long)67L; // { int sys_gettimeofday(struct timeval *tp, struct timezone *tzp); }
        public static readonly long SYS_SETTIMEOFDAY = (long)68L; // { int sys_settimeofday(const struct timeval *tv, const struct timezone *tzp); }
        public static readonly long SYS_SETITIMER = (long)69L; // { int sys_setitimer(int which, const struct itimerval *itv, struct itimerval *oitv); }
        public static readonly long SYS_GETITIMER = (long)70L; // { int sys_getitimer(int which, struct itimerval *itv); }
        public static readonly long SYS_SELECT = (long)71L; // { int sys_select(int nd, fd_set *in, fd_set *ou, fd_set *ex, struct timeval *tv); }
        public static readonly long SYS_KEVENT = (long)72L; // { int sys_kevent(int fd, const struct kevent *changelist, int nchanges, struct kevent *eventlist, int nevents, const struct timespec *timeout); }
        public static readonly long SYS_MUNMAP = (long)73L; // { int sys_munmap(void *addr, size_t len); }
        public static readonly long SYS_MPROTECT = (long)74L; // { int sys_mprotect(void *addr, size_t len, int prot); }
        public static readonly long SYS_MADVISE = (long)75L; // { int sys_madvise(void *addr, size_t len, int behav); }
        public static readonly long SYS_UTIMES = (long)76L; // { int sys_utimes(const char *path, const struct timeval *tptr); }
        public static readonly long SYS_FUTIMES = (long)77L; // { int sys_futimes(int fd, const struct timeval *tptr); }
        public static readonly long SYS_MINCORE = (long)78L; // { int sys_mincore(void *addr, size_t len, char *vec); }
        public static readonly long SYS_GETGROUPS = (long)79L; // { int sys_getgroups(int gidsetsize, gid_t *gidset); }
        public static readonly long SYS_SETGROUPS = (long)80L; // { int sys_setgroups(int gidsetsize, const gid_t *gidset); }
        public static readonly long SYS_GETPGRP = (long)81L; // { int sys_getpgrp(void); }
        public static readonly long SYS_SETPGID = (long)82L; // { int sys_setpgid(pid_t pid, pid_t pgid); }
        public static readonly long SYS_FUTEX = (long)83L; // { int sys_futex(uint32_t *f, int op, int val, const struct timespec *timeout, uint32_t *g); }
        public static readonly long SYS_UTIMENSAT = (long)84L; // { int sys_utimensat(int fd, const char *path, const struct timespec *times, int flag); }
        public static readonly long SYS_FUTIMENS = (long)85L; // { int sys_futimens(int fd, const struct timespec *times); }
        public static readonly long SYS_KBIND = (long)86L; // { int sys_kbind(const struct __kbind *param, size_t psize, int64_t proc_cookie); }
        public static readonly long SYS_CLOCK_GETTIME = (long)87L; // { int sys_clock_gettime(clockid_t clock_id, struct timespec *tp); }
        public static readonly long SYS_CLOCK_SETTIME = (long)88L; // { int sys_clock_settime(clockid_t clock_id, const struct timespec *tp); }
        public static readonly long SYS_CLOCK_GETRES = (long)89L; // { int sys_clock_getres(clockid_t clock_id, struct timespec *tp); }
        public static readonly long SYS_DUP2 = (long)90L; // { int sys_dup2(int from, int to); }
        public static readonly long SYS_NANOSLEEP = (long)91L; // { int sys_nanosleep(const struct timespec *rqtp, struct timespec *rmtp); }
        public static readonly long SYS_FCNTL = (long)92L; // { int sys_fcntl(int fd, int cmd, ... void *arg); }
        public static readonly long SYS_ACCEPT4 = (long)93L; // { int sys_accept4(int s, struct sockaddr *name, socklen_t *anamelen, int flags); }
        public static readonly long SYS___THRSLEEP = (long)94L; // { int sys___thrsleep(const volatile void *ident, clockid_t clock_id, const struct timespec *tp, void *lock, const int *abort); }
        public static readonly long SYS_FSYNC = (long)95L; // { int sys_fsync(int fd); }
        public static readonly long SYS_SETPRIORITY = (long)96L; // { int sys_setpriority(int which, id_t who, int prio); }
        public static readonly long SYS_SOCKET = (long)97L; // { int sys_socket(int domain, int type, int protocol); }
        public static readonly long SYS_CONNECT = (long)98L; // { int sys_connect(int s, const struct sockaddr *name, socklen_t namelen); }
        public static readonly long SYS_GETDENTS = (long)99L; // { int sys_getdents(int fd, void *buf, size_t buflen); }
        public static readonly long SYS_GETPRIORITY = (long)100L; // { int sys_getpriority(int which, id_t who); }
        public static readonly long SYS_PIPE2 = (long)101L; // { int sys_pipe2(int *fdp, int flags); }
        public static readonly long SYS_DUP3 = (long)102L; // { int sys_dup3(int from, int to, int flags); }
        public static readonly long SYS_SIGRETURN = (long)103L; // { int sys_sigreturn(struct sigcontext *sigcntxp); }
        public static readonly long SYS_BIND = (long)104L; // { int sys_bind(int s, const struct sockaddr *name, socklen_t namelen); }
        public static readonly long SYS_SETSOCKOPT = (long)105L; // { int sys_setsockopt(int s, int level, int name, const void *val, socklen_t valsize); }
        public static readonly long SYS_LISTEN = (long)106L; // { int sys_listen(int s, int backlog); }
        public static readonly long SYS_CHFLAGSAT = (long)107L; // { int sys_chflagsat(int fd, const char *path, u_int flags, int atflags); }
        public static readonly long SYS_PLEDGE = (long)108L; // { int sys_pledge(const char *promises, const char *execpromises); }
        public static readonly long SYS_PPOLL = (long)109L; // { int sys_ppoll(struct pollfd *fds, u_int nfds, const struct timespec *ts, const sigset_t *mask); }
        public static readonly long SYS_PSELECT = (long)110L; // { int sys_pselect(int nd, fd_set *in, fd_set *ou, fd_set *ex, const struct timespec *ts, const sigset_t *mask); }
        public static readonly long SYS_SIGSUSPEND = (long)111L; // { int sys_sigsuspend(int mask); }
        public static readonly long SYS_SENDSYSLOG = (long)112L; // { int sys_sendsyslog(const char *buf, size_t nbyte, int flags); }
        public static readonly long SYS_UNVEIL = (long)114L; // { int sys_unveil(const char *path, const char *permissions); }
        public static readonly long SYS_GETSOCKOPT = (long)118L; // { int sys_getsockopt(int s, int level, int name, void *val, socklen_t *avalsize); }
        public static readonly long SYS_THRKILL = (long)119L; // { int sys_thrkill(pid_t tid, int signum, void *tcb); }
        public static readonly long SYS_READV = (long)120L; // { ssize_t sys_readv(int fd, const struct iovec *iovp, int iovcnt); }
        public static readonly long SYS_WRITEV = (long)121L; // { ssize_t sys_writev(int fd, const struct iovec *iovp, int iovcnt); }
        public static readonly long SYS_KILL = (long)122L; // { int sys_kill(int pid, int signum); }
        public static readonly long SYS_FCHOWN = (long)123L; // { int sys_fchown(int fd, uid_t uid, gid_t gid); }
        public static readonly long SYS_FCHMOD = (long)124L; // { int sys_fchmod(int fd, mode_t mode); }
        public static readonly long SYS_SETREUID = (long)126L; // { int sys_setreuid(uid_t ruid, uid_t euid); }
        public static readonly long SYS_SETREGID = (long)127L; // { int sys_setregid(gid_t rgid, gid_t egid); }
        public static readonly long SYS_RENAME = (long)128L; // { int sys_rename(const char *from, const char *to); }
        public static readonly long SYS_FLOCK = (long)131L; // { int sys_flock(int fd, int how); }
        public static readonly long SYS_MKFIFO = (long)132L; // { int sys_mkfifo(const char *path, mode_t mode); }
        public static readonly long SYS_SENDTO = (long)133L; // { ssize_t sys_sendto(int s, const void *buf, size_t len, int flags, const struct sockaddr *to, socklen_t tolen); }
        public static readonly long SYS_SHUTDOWN = (long)134L; // { int sys_shutdown(int s, int how); }
        public static readonly long SYS_SOCKETPAIR = (long)135L; // { int sys_socketpair(int domain, int type, int protocol, int *rsv); }
        public static readonly long SYS_MKDIR = (long)136L; // { int sys_mkdir(const char *path, mode_t mode); }
        public static readonly long SYS_RMDIR = (long)137L; // { int sys_rmdir(const char *path); }
        public static readonly long SYS_ADJTIME = (long)140L; // { int sys_adjtime(const struct timeval *delta, struct timeval *olddelta); }
        public static readonly long SYS_GETLOGIN_R = (long)141L; // { int sys_getlogin_r(char *namebuf, u_int namelen); }
        public static readonly long SYS_SETSID = (long)147L; // { int sys_setsid(void); }
        public static readonly long SYS_QUOTACTL = (long)148L; // { int sys_quotactl(const char *path, int cmd, int uid, char *arg); }
        public static readonly long SYS_NFSSVC = (long)155L; // { int sys_nfssvc(int flag, void *argp); }
        public static readonly long SYS_GETFH = (long)161L; // { int sys_getfh(const char *fname, fhandle_t *fhp); }
        public static readonly long SYS_SYSARCH = (long)165L; // { int sys_sysarch(int op, void *parms); }
        public static readonly long SYS_PREAD = (long)173L; // { ssize_t sys_pread(int fd, void *buf, size_t nbyte, int pad, off_t offset); }
        public static readonly long SYS_PWRITE = (long)174L; // { ssize_t sys_pwrite(int fd, const void *buf, size_t nbyte, int pad, off_t offset); }
        public static readonly long SYS_SETGID = (long)181L; // { int sys_setgid(gid_t gid); }
        public static readonly long SYS_SETEGID = (long)182L; // { int sys_setegid(gid_t egid); }
        public static readonly long SYS_SETEUID = (long)183L; // { int sys_seteuid(uid_t euid); }
        public static readonly long SYS_PATHCONF = (long)191L; // { long sys_pathconf(const char *path, int name); }
        public static readonly long SYS_FPATHCONF = (long)192L; // { long sys_fpathconf(int fd, int name); }
        public static readonly long SYS_SWAPCTL = (long)193L; // { int sys_swapctl(int cmd, const void *arg, int misc); }
        public static readonly long SYS_GETRLIMIT = (long)194L; // { int sys_getrlimit(int which, struct rlimit *rlp); }
        public static readonly long SYS_SETRLIMIT = (long)195L; // { int sys_setrlimit(int which, const struct rlimit *rlp); }
        public static readonly long SYS_MMAP = (long)197L; // { void *sys_mmap(void *addr, size_t len, int prot, int flags, int fd, long pad, off_t pos); }
        public static readonly long SYS_LSEEK = (long)199L; // { off_t sys_lseek(int fd, int pad, off_t offset, int whence); }
        public static readonly long SYS_TRUNCATE = (long)200L; // { int sys_truncate(const char *path, int pad, off_t length); }
        public static readonly long SYS_FTRUNCATE = (long)201L; // { int sys_ftruncate(int fd, int pad, off_t length); }
        public static readonly long SYS_SYSCTL = (long)202L; // { int sys_sysctl(const int *name, u_int namelen, void *old, size_t *oldlenp, void *new, size_t newlen); }
        public static readonly long SYS_MLOCK = (long)203L; // { int sys_mlock(const void *addr, size_t len); }
        public static readonly long SYS_MUNLOCK = (long)204L; // { int sys_munlock(const void *addr, size_t len); }
        public static readonly long SYS_GETPGID = (long)207L; // { pid_t sys_getpgid(pid_t pid); }
        public static readonly long SYS_UTRACE = (long)209L; // { int sys_utrace(const char *label, const void *addr, size_t len); }
        public static readonly long SYS_SEMGET = (long)221L; // { int sys_semget(key_t key, int nsems, int semflg); }
        public static readonly long SYS_MSGGET = (long)225L; // { int sys_msgget(key_t key, int msgflg); }
        public static readonly long SYS_MSGSND = (long)226L; // { int sys_msgsnd(int msqid, const void *msgp, size_t msgsz, int msgflg); }
        public static readonly long SYS_MSGRCV = (long)227L; // { int sys_msgrcv(int msqid, void *msgp, size_t msgsz, long msgtyp, int msgflg); }
        public static readonly long SYS_SHMAT = (long)228L; // { void *sys_shmat(int shmid, const void *shmaddr, int shmflg); }
        public static readonly long SYS_SHMDT = (long)230L; // { int sys_shmdt(const void *shmaddr); }
        public static readonly long SYS_MINHERIT = (long)250L; // { int sys_minherit(void *addr, size_t len, int inherit); }
        public static readonly long SYS_POLL = (long)252L; // { int sys_poll(struct pollfd *fds, u_int nfds, int timeout); }
        public static readonly long SYS_ISSETUGID = (long)253L; // { int sys_issetugid(void); }
        public static readonly long SYS_LCHOWN = (long)254L; // { int sys_lchown(const char *path, uid_t uid, gid_t gid); }
        public static readonly long SYS_GETSID = (long)255L; // { pid_t sys_getsid(pid_t pid); }
        public static readonly long SYS_MSYNC = (long)256L; // { int sys_msync(void *addr, size_t len, int flags); }
        public static readonly long SYS_PIPE = (long)263L; // { int sys_pipe(int *fdp); }
        public static readonly long SYS_FHOPEN = (long)264L; // { int sys_fhopen(const fhandle_t *fhp, int flags); }
        public static readonly long SYS_PREADV = (long)267L; // { ssize_t sys_preadv(int fd, const struct iovec *iovp, int iovcnt, int pad, off_t offset); }
        public static readonly long SYS_PWRITEV = (long)268L; // { ssize_t sys_pwritev(int fd, const struct iovec *iovp, int iovcnt, int pad, off_t offset); }
        public static readonly long SYS_KQUEUE = (long)269L; // { int sys_kqueue(void); }
        public static readonly long SYS_MLOCKALL = (long)271L; // { int sys_mlockall(int flags); }
        public static readonly long SYS_MUNLOCKALL = (long)272L; // { int sys_munlockall(void); }
        public static readonly long SYS_GETRESUID = (long)281L; // { int sys_getresuid(uid_t *ruid, uid_t *euid, uid_t *suid); }
        public static readonly long SYS_SETRESUID = (long)282L; // { int sys_setresuid(uid_t ruid, uid_t euid, uid_t suid); }
        public static readonly long SYS_GETRESGID = (long)283L; // { int sys_getresgid(gid_t *rgid, gid_t *egid, gid_t *sgid); }
        public static readonly long SYS_SETRESGID = (long)284L; // { int sys_setresgid(gid_t rgid, gid_t egid, gid_t sgid); }
        public static readonly long SYS_MQUERY = (long)286L; // { void *sys_mquery(void *addr, size_t len, int prot, int flags, int fd, long pad, off_t pos); }
        public static readonly long SYS_CLOSEFROM = (long)287L; // { int sys_closefrom(int fd); }
        public static readonly long SYS_SIGALTSTACK = (long)288L; // { int sys_sigaltstack(const struct sigaltstack *nss, struct sigaltstack *oss); }
        public static readonly long SYS_SHMGET = (long)289L; // { int sys_shmget(key_t key, size_t size, int shmflg); }
        public static readonly long SYS_SEMOP = (long)290L; // { int sys_semop(int semid, struct sembuf *sops, size_t nsops); }
        public static readonly long SYS_FHSTAT = (long)294L; // { int sys_fhstat(const fhandle_t *fhp, struct stat *sb); }
        public static readonly long SYS___SEMCTL = (long)295L; // { int sys___semctl(int semid, int semnum, int cmd, union semun *arg); }
        public static readonly long SYS_SHMCTL = (long)296L; // { int sys_shmctl(int shmid, int cmd, struct shmid_ds *buf); }
        public static readonly long SYS_MSGCTL = (long)297L; // { int sys_msgctl(int msqid, int cmd, struct msqid_ds *buf); }
        public static readonly long SYS_SCHED_YIELD = (long)298L; // { int sys_sched_yield(void); }
        public static readonly long SYS_GETTHRID = (long)299L; // { pid_t sys_getthrid(void); }
        public static readonly long SYS___THRWAKEUP = (long)301L; // { int sys___thrwakeup(const volatile void *ident, int n); }
        public static readonly long SYS___THREXIT = (long)302L; // { void sys___threxit(pid_t *notdead); }
        public static readonly long SYS___THRSIGDIVERT = (long)303L; // { int sys___thrsigdivert(sigset_t sigmask, siginfo_t *info, const struct timespec *timeout); }
        public static readonly long SYS___GETCWD = (long)304L; // { int sys___getcwd(char *buf, size_t len); }
        public static readonly long SYS_ADJFREQ = (long)305L; // { int sys_adjfreq(const int64_t *freq, int64_t *oldfreq); }
        public static readonly long SYS_SETRTABLE = (long)310L; // { int sys_setrtable(int rtableid); }
        public static readonly long SYS_GETRTABLE = (long)311L; // { int sys_getrtable(void); }
        public static readonly long SYS_FACCESSAT = (long)313L; // { int sys_faccessat(int fd, const char *path, int amode, int flag); }
        public static readonly long SYS_FCHMODAT = (long)314L; // { int sys_fchmodat(int fd, const char *path, mode_t mode, int flag); }
        public static readonly long SYS_FCHOWNAT = (long)315L; // { int sys_fchownat(int fd, const char *path, uid_t uid, gid_t gid, int flag); }
        public static readonly long SYS_LINKAT = (long)317L; // { int sys_linkat(int fd1, const char *path1, int fd2, const char *path2, int flag); }
        public static readonly long SYS_MKDIRAT = (long)318L; // { int sys_mkdirat(int fd, const char *path, mode_t mode); }
        public static readonly long SYS_MKFIFOAT = (long)319L; // { int sys_mkfifoat(int fd, const char *path, mode_t mode); }
        public static readonly long SYS_MKNODAT = (long)320L; // { int sys_mknodat(int fd, const char *path, mode_t mode, dev_t dev); }
        public static readonly long SYS_OPENAT = (long)321L; // { int sys_openat(int fd, const char *path, int flags, ... mode_t mode); }
        public static readonly long SYS_READLINKAT = (long)322L; // { ssize_t sys_readlinkat(int fd, const char *path, char *buf, size_t count); }
        public static readonly long SYS_RENAMEAT = (long)323L; // { int sys_renameat(int fromfd, const char *from, int tofd, const char *to); }
        public static readonly long SYS_SYMLINKAT = (long)324L; // { int sys_symlinkat(const char *path, int fd, const char *link); }
        public static readonly long SYS_UNLINKAT = (long)325L; // { int sys_unlinkat(int fd, const char *path, int flag); }
        public static readonly long SYS___SET_TCB = (long)329L; // { void sys___set_tcb(void *tcb); }
        public static readonly long SYS___GET_TCB = (long)330L; // { void *sys___get_tcb(void); }
    }
}}}}}}
