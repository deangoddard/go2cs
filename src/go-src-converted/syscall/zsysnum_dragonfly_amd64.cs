// mksysnum_dragonfly.pl
// Code generated by the command above; DO NOT EDIT.

//go:build amd64 && dragonfly
// +build amd64,dragonfly

// package syscall -- go2cs converted at 2022 March 06 22:29:48 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Program Files\Go\src\syscall\zsysnum_dragonfly_amd64.go


namespace go;

public static partial class syscall_package {

 
// SYS_NOSYS = 0;  // { int nosys(void); } syscall nosys_args int
public static readonly nint SYS_EXIT = 1; // { void exit(int rval); }
public static readonly nint SYS_FORK = 2; // { int fork(void); }
public static readonly nint SYS_READ = 3; // { ssize_t read(int fd, void *buf, size_t nbyte); }
public static readonly nint SYS_WRITE = 4; // { ssize_t write(int fd, const void *buf, size_t nbyte); }
public static readonly nint SYS_OPEN = 5; // { int open(char *path, int flags, int mode); }
public static readonly nint SYS_CLOSE = 6; // { int close(int fd); }
public static readonly nint SYS_WAIT4 = 7; // { int wait4(int pid, int *status, int options, \
public static readonly nint SYS_LINK = 9; // { int link(char *path, char *link); }
public static readonly nint SYS_UNLINK = 10; // { int unlink(char *path); }
public static readonly nint SYS_CHDIR = 12; // { int chdir(char *path); }
public static readonly nint SYS_FCHDIR = 13; // { int fchdir(int fd); }
public static readonly nint SYS_MKNOD = 14; // { int mknod(char *path, int mode, int dev); }
public static readonly nint SYS_CHMOD = 15; // { int chmod(char *path, int mode); }
public static readonly nint SYS_CHOWN = 16; // { int chown(char *path, int uid, int gid); }
public static readonly nint SYS_OBREAK = 17; // { int obreak(char *nsize); } break obreak_args int
public static readonly nint SYS_GETFSSTAT = 18; // { int getfsstat(struct statfs *buf, long bufsize, \
public static readonly nint SYS_GETPID = 20; // { pid_t getpid(void); }
public static readonly nint SYS_MOUNT = 21; // { int mount(char *type, char *path, int flags, \
public static readonly nint SYS_UNMOUNT = 22; // { int unmount(char *path, int flags); }
public static readonly nint SYS_SETUID = 23; // { int setuid(uid_t uid); }
public static readonly nint SYS_GETUID = 24; // { uid_t getuid(void); }
public static readonly nint SYS_GETEUID = 25; // { uid_t geteuid(void); }
public static readonly nint SYS_PTRACE = 26; // { int ptrace(int req, pid_t pid, caddr_t addr, \
public static readonly nint SYS_RECVMSG = 27; // { int recvmsg(int s, struct msghdr *msg, int flags); }
public static readonly nint SYS_SENDMSG = 28; // { int sendmsg(int s, caddr_t msg, int flags); }
public static readonly nint SYS_RECVFROM = 29; // { int recvfrom(int s, caddr_t buf, size_t len, \
public static readonly nint SYS_ACCEPT = 30; // { int accept(int s, caddr_t name, int *anamelen); }
public static readonly nint SYS_GETPEERNAME = 31; // { int getpeername(int fdes, caddr_t asa, int *alen); }
public static readonly nint SYS_GETSOCKNAME = 32; // { int getsockname(int fdes, caddr_t asa, int *alen); }
public static readonly nint SYS_ACCESS = 33; // { int access(char *path, int flags); }
public static readonly nint SYS_CHFLAGS = 34; // { int chflags(char *path, int flags); }
public static readonly nint SYS_FCHFLAGS = 35; // { int fchflags(int fd, int flags); }
public static readonly nint SYS_SYNC = 36; // { int sync(void); }
public static readonly nint SYS_KILL = 37; // { int kill(int pid, int signum); }
public static readonly nint SYS_GETPPID = 39; // { pid_t getppid(void); }
public static readonly nint SYS_DUP = 41; // { int dup(u_int fd); }
public static readonly nint SYS_PIPE = 42; // { int pipe(void); }
public static readonly nint SYS_GETEGID = 43; // { gid_t getegid(void); }
public static readonly nint SYS_PROFIL = 44; // { int profil(caddr_t samples, size_t size, \
public static readonly nint SYS_KTRACE = 45; // { int ktrace(const char *fname, int ops, int facs, \
public static readonly nint SYS_GETGID = 47; // { gid_t getgid(void); }
public static readonly nint SYS_GETLOGIN = 49; // { int getlogin(char *namebuf, u_int namelen); }
public static readonly nint SYS_SETLOGIN = 50; // { int setlogin(char *namebuf); }
public static readonly nint SYS_ACCT = 51; // { int acct(char *path); }
public static readonly nint SYS_SIGALTSTACK = 53; // { int sigaltstack(stack_t *ss, stack_t *oss); }
public static readonly nint SYS_IOCTL = 54; // { int ioctl(int fd, u_long com, caddr_t data); }
public static readonly nint SYS_REBOOT = 55; // { int reboot(int opt); }
public static readonly nint SYS_REVOKE = 56; // { int revoke(char *path); }
public static readonly nint SYS_SYMLINK = 57; // { int symlink(char *path, char *link); }
public static readonly nint SYS_READLINK = 58; // { int readlink(char *path, char *buf, int count); }
public static readonly nint SYS_EXECVE = 59; // { int execve(char *fname, char **argv, char **envv); }
public static readonly nint SYS_UMASK = 60; // { int umask(int newmask); } umask umask_args int
public static readonly nint SYS_CHROOT = 61; // { int chroot(char *path); }
public static readonly nint SYS_MSYNC = 65; // { int msync(void *addr, size_t len, int flags); }
public static readonly nint SYS_VFORK = 66; // { pid_t vfork(void); }
public static readonly nint SYS_SBRK = 69; // { int sbrk(int incr); }
public static readonly nint SYS_SSTK = 70; // { int sstk(int incr); }
public static readonly nint SYS_MUNMAP = 73; // { int munmap(void *addr, size_t len); }
public static readonly nint SYS_MPROTECT = 74; // { int mprotect(void *addr, size_t len, int prot); }
public static readonly nint SYS_MADVISE = 75; // { int madvise(void *addr, size_t len, int behav); }
public static readonly nint SYS_MINCORE = 78; // { int mincore(const void *addr, size_t len, \
public static readonly nint SYS_GETGROUPS = 79; // { int getgroups(u_int gidsetsize, gid_t *gidset); }
public static readonly nint SYS_SETGROUPS = 80; // { int setgroups(u_int gidsetsize, gid_t *gidset); }
public static readonly nint SYS_GETPGRP = 81; // { int getpgrp(void); }
public static readonly nint SYS_SETPGID = 82; // { int setpgid(int pid, int pgid); }
public static readonly nint SYS_SETITIMER = 83; // { int setitimer(u_int which, struct itimerval *itv, \
public static readonly nint SYS_SWAPON = 85; // { int swapon(char *name); }
public static readonly nint SYS_GETITIMER = 86; // { int getitimer(u_int which, struct itimerval *itv); }
public static readonly nint SYS_GETDTABLESIZE = 89; // { int getdtablesize(void); }
public static readonly nint SYS_DUP2 = 90; // { int dup2(u_int from, u_int to); }
public static readonly nint SYS_FCNTL = 92; // { int fcntl(int fd, int cmd, long arg); }
public static readonly nint SYS_SELECT = 93; // { int select(int nd, fd_set *in, fd_set *ou, \
public static readonly nint SYS_FSYNC = 95; // { int fsync(int fd); }
public static readonly nint SYS_SETPRIORITY = 96; // { int setpriority(int which, int who, int prio); }
public static readonly nint SYS_SOCKET = 97; // { int socket(int domain, int type, int protocol); }
public static readonly nint SYS_CONNECT = 98; // { int connect(int s, caddr_t name, int namelen); }
public static readonly nint SYS_GETPRIORITY = 100; // { int getpriority(int which, int who); }
public static readonly nint SYS_BIND = 104; // { int bind(int s, caddr_t name, int namelen); }
public static readonly nint SYS_SETSOCKOPT = 105; // { int setsockopt(int s, int level, int name, \
public static readonly nint SYS_LISTEN = 106; // { int listen(int s, int backlog); }
public static readonly nint SYS_GETTIMEOFDAY = 116; // { int gettimeofday(struct timeval *tp, \
public static readonly nint SYS_GETRUSAGE = 117; // { int getrusage(int who, struct rusage *rusage); }
public static readonly nint SYS_GETSOCKOPT = 118; // { int getsockopt(int s, int level, int name, \
public static readonly nint SYS_READV = 120; // { int readv(int fd, struct iovec *iovp, u_int iovcnt); }
public static readonly nint SYS_WRITEV = 121; // { int writev(int fd, struct iovec *iovp, \
public static readonly nint SYS_SETTIMEOFDAY = 122; // { int settimeofday(struct timeval *tv, \
public static readonly nint SYS_FCHOWN = 123; // { int fchown(int fd, int uid, int gid); }
public static readonly nint SYS_FCHMOD = 124; // { int fchmod(int fd, int mode); }
public static readonly nint SYS_SETREUID = 126; // { int setreuid(int ruid, int euid); }
public static readonly nint SYS_SETREGID = 127; // { int setregid(int rgid, int egid); }
public static readonly nint SYS_RENAME = 128; // { int rename(char *from, char *to); }
public static readonly nint SYS_FLOCK = 131; // { int flock(int fd, int how); }
public static readonly nint SYS_MKFIFO = 132; // { int mkfifo(char *path, int mode); }
public static readonly nint SYS_SENDTO = 133; // { int sendto(int s, caddr_t buf, size_t len, \
public static readonly nint SYS_SHUTDOWN = 134; // { int shutdown(int s, int how); }
public static readonly nint SYS_SOCKETPAIR = 135; // { int socketpair(int domain, int type, int protocol, \
public static readonly nint SYS_MKDIR = 136; // { int mkdir(char *path, int mode); }
public static readonly nint SYS_RMDIR = 137; // { int rmdir(char *path); }
public static readonly nint SYS_UTIMES = 138; // { int utimes(char *path, struct timeval *tptr); }
public static readonly nint SYS_ADJTIME = 140; // { int adjtime(struct timeval *delta, \
public static readonly nint SYS_SETSID = 147; // { int setsid(void); }
public static readonly nint SYS_QUOTACTL = 148; // { int quotactl(char *path, int cmd, int uid, \
public static readonly nint SYS_STATFS = 157; // { int statfs(char *path, struct statfs *buf); }
public static readonly nint SYS_FSTATFS = 158; // { int fstatfs(int fd, struct statfs *buf); }
public static readonly nint SYS_GETFH = 161; // { int getfh(char *fname, struct fhandle *fhp); }
public static readonly nint SYS_GETDOMAINNAME = 162; // { int getdomainname(char *domainname, int len); }
public static readonly nint SYS_SETDOMAINNAME = 163; // { int setdomainname(char *domainname, int len); }
public static readonly nint SYS_UNAME = 164; // { int uname(struct utsname *name); }
public static readonly nint SYS_SYSARCH = 165; // { int sysarch(int op, char *parms); }
public static readonly nint SYS_RTPRIO = 166; // { int rtprio(int function, pid_t pid, \
public static readonly nint SYS_EXTPREAD = 173; // { ssize_t extpread(int fd, void *buf, \
public static readonly nint SYS_EXTPWRITE = 174; // { ssize_t extpwrite(int fd, const void *buf, \
public static readonly nint SYS_NTP_ADJTIME = 176; // { int ntp_adjtime(struct timex *tp); }
public static readonly nint SYS_SETGID = 181; // { int setgid(gid_t gid); }
public static readonly nint SYS_SETEGID = 182; // { int setegid(gid_t egid); }
public static readonly nint SYS_SETEUID = 183; // { int seteuid(uid_t euid); }
public static readonly nint SYS_PATHCONF = 191; // { int pathconf(char *path, int name); }
public static readonly nint SYS_FPATHCONF = 192; // { int fpathconf(int fd, int name); }
public static readonly nint SYS_GETRLIMIT = 194; // { int getrlimit(u_int which, \
public static readonly nint SYS_SETRLIMIT = 195; // { int setrlimit(u_int which, \
public static readonly nint SYS_MMAP = 197; // { caddr_t mmap(caddr_t addr, size_t len, int prot, \
// SYS_NOSYS = 198;  // { int nosys(void); } __syscall __syscall_args int
public static readonly nint SYS_LSEEK = 199; // { off_t lseek(int fd, int pad, off_t offset, \
public static readonly nint SYS_TRUNCATE = 200; // { int truncate(char *path, int pad, off_t length); }
public static readonly nint SYS_FTRUNCATE = 201; // { int ftruncate(int fd, int pad, off_t length); }
public static readonly nint SYS___SYSCTL = 202; // { int __sysctl(int *name, u_int namelen, void *old, \
public static readonly nint SYS_MLOCK = 203; // { int mlock(const void *addr, size_t len); }
public static readonly nint SYS_MUNLOCK = 204; // { int munlock(const void *addr, size_t len); }
public static readonly nint SYS_UNDELETE = 205; // { int undelete(char *path); }
public static readonly nint SYS_FUTIMES = 206; // { int futimes(int fd, struct timeval *tptr); }
public static readonly nint SYS_GETPGID = 207; // { int getpgid(pid_t pid); }
public static readonly nint SYS_POLL = 209; // { int poll(struct pollfd *fds, u_int nfds, \
public static readonly nint SYS___SEMCTL = 220; // { int __semctl(int semid, int semnum, int cmd, \
public static readonly nint SYS_SEMGET = 221; // { int semget(key_t key, int nsems, int semflg); }
public static readonly nint SYS_SEMOP = 222; // { int semop(int semid, struct sembuf *sops, \
public static readonly nint SYS_MSGCTL = 224; // { int msgctl(int msqid, int cmd, \
public static readonly nint SYS_MSGGET = 225; // { int msgget(key_t key, int msgflg); }
public static readonly nint SYS_MSGSND = 226; // { int msgsnd(int msqid, void *msgp, size_t msgsz, \
public static readonly nint SYS_MSGRCV = 227; // { int msgrcv(int msqid, void *msgp, size_t msgsz, \
public static readonly nint SYS_SHMAT = 228; // { caddr_t shmat(int shmid, const void *shmaddr, \
public static readonly nint SYS_SHMCTL = 229; // { int shmctl(int shmid, int cmd, \
public static readonly nint SYS_SHMDT = 230; // { int shmdt(const void *shmaddr); }
public static readonly nint SYS_SHMGET = 231; // { int shmget(key_t key, size_t size, int shmflg); }
public static readonly nint SYS_CLOCK_GETTIME = 232; // { int clock_gettime(clockid_t clock_id, \
public static readonly nint SYS_CLOCK_SETTIME = 233; // { int clock_settime(clockid_t clock_id, \
public static readonly nint SYS_CLOCK_GETRES = 234; // { int clock_getres(clockid_t clock_id, \
public static readonly nint SYS_NANOSLEEP = 240; // { int nanosleep(const struct timespec *rqtp, \
public static readonly nint SYS_MINHERIT = 250; // { int minherit(void *addr, size_t len, int inherit); }
public static readonly nint SYS_RFORK = 251; // { int rfork(int flags); }
public static readonly nint SYS_OPENBSD_POLL = 252; // { int openbsd_poll(struct pollfd *fds, u_int nfds, \
public static readonly nint SYS_ISSETUGID = 253; // { int issetugid(void); }
public static readonly nint SYS_LCHOWN = 254; // { int lchown(char *path, int uid, int gid); }
public static readonly nint SYS_LCHMOD = 274; // { int lchmod(char *path, mode_t mode); }
public static readonly nint SYS_LUTIMES = 276; // { int lutimes(char *path, struct timeval *tptr); }
public static readonly nint SYS_EXTPREADV = 289; // { ssize_t extpreadv(int fd, struct iovec *iovp, \
public static readonly nint SYS_EXTPWRITEV = 290; // { ssize_t extpwritev(int fd, struct iovec *iovp,\
public static readonly nint SYS_FHSTATFS = 297; // { int fhstatfs(const struct fhandle *u_fhp, struct statfs *buf); }
public static readonly nint SYS_FHOPEN = 298; // { int fhopen(const struct fhandle *u_fhp, int flags); }
public static readonly nint SYS_MODNEXT = 300; // { int modnext(int modid); }
public static readonly nint SYS_MODSTAT = 301; // { int modstat(int modid, struct module_stat* stat); }
public static readonly nint SYS_MODFNEXT = 302; // { int modfnext(int modid); }
public static readonly nint SYS_MODFIND = 303; // { int modfind(const char *name); }
public static readonly nint SYS_KLDLOAD = 304; // { int kldload(const char *file); }
public static readonly nint SYS_KLDUNLOAD = 305; // { int kldunload(int fileid); }
public static readonly nint SYS_KLDFIND = 306; // { int kldfind(const char *file); }
public static readonly nint SYS_KLDNEXT = 307; // { int kldnext(int fileid); }
public static readonly nint SYS_KLDSTAT = 308; // { int kldstat(int fileid, struct kld_file_stat* stat); }
public static readonly nint SYS_KLDFIRSTMOD = 309; // { int kldfirstmod(int fileid); }
public static readonly nint SYS_GETSID = 310; // { int getsid(pid_t pid); }
public static readonly nint SYS_SETRESUID = 311; // { int setresuid(uid_t ruid, uid_t euid, uid_t suid); }
public static readonly nint SYS_SETRESGID = 312; // { int setresgid(gid_t rgid, gid_t egid, gid_t sgid); }
public static readonly nint SYS_AIO_RETURN = 314; // { int aio_return(struct aiocb *aiocbp); }
public static readonly nint SYS_AIO_SUSPEND = 315; // { int aio_suspend(struct aiocb * const * aiocbp, int nent, const struct timespec *timeout); }
public static readonly nint SYS_AIO_CANCEL = 316; // { int aio_cancel(int fd, struct aiocb *aiocbp); }
public static readonly nint SYS_AIO_ERROR = 317; // { int aio_error(struct aiocb *aiocbp); }
public static readonly nint SYS_AIO_READ = 318; // { int aio_read(struct aiocb *aiocbp); }
public static readonly nint SYS_AIO_WRITE = 319; // { int aio_write(struct aiocb *aiocbp); }
public static readonly nint SYS_LIO_LISTIO = 320; // { int lio_listio(int mode, struct aiocb * const *acb_list, int nent, struct sigevent *sig); }
public static readonly nint SYS_YIELD = 321; // { int yield(void); }
public static readonly nint SYS_MLOCKALL = 324; // { int mlockall(int how); }
public static readonly nint SYS_MUNLOCKALL = 325; // { int munlockall(void); }
public static readonly nint SYS___GETCWD = 326; // { int __getcwd(u_char *buf, u_int buflen); }
public static readonly nint SYS_SCHED_SETPARAM = 327; // { int sched_setparam (pid_t pid, const struct sched_param *param); }
public static readonly nint SYS_SCHED_GETPARAM = 328; // { int sched_getparam (pid_t pid, struct sched_param *param); }
public static readonly nint SYS_SCHED_SETSCHEDULER = 329; // { int sched_setscheduler (pid_t pid, int policy, const struct sched_param *param); }
public static readonly nint SYS_SCHED_GETSCHEDULER = 330; // { int sched_getscheduler (pid_t pid); }
public static readonly nint SYS_SCHED_YIELD = 331; // { int sched_yield (void); }
public static readonly nint SYS_SCHED_GET_PRIORITY_MAX = 332; // { int sched_get_priority_max (int policy); }
public static readonly nint SYS_SCHED_GET_PRIORITY_MIN = 333; // { int sched_get_priority_min (int policy); }
public static readonly nint SYS_SCHED_RR_GET_INTERVAL = 334; // { int sched_rr_get_interval (pid_t pid, struct timespec *interval); }
public static readonly nint SYS_UTRACE = 335; // { int utrace(const void *addr, size_t len); }
public static readonly nint SYS_KLDSYM = 337; // { int kldsym(int fileid, int cmd, void *data); }
public static readonly nint SYS_JAIL = 338; // { int jail(struct jail *jail); }
public static readonly nint SYS_SIGPROCMASK = 340; // { int sigprocmask(int how, const sigset_t *set, \
public static readonly nint SYS_SIGSUSPEND = 341; // { int sigsuspend(const sigset_t *sigmask); }
public static readonly nint SYS_SIGACTION = 342; // { int sigaction(int sig, const struct sigaction *act, \
public static readonly nint SYS_SIGPENDING = 343; // { int sigpending(sigset_t *set); }
public static readonly nint SYS_SIGRETURN = 344; // { int sigreturn(ucontext_t *sigcntxp); }
public static readonly nint SYS_SIGTIMEDWAIT = 345; // { int sigtimedwait(const sigset_t *set,\
public static readonly nint SYS_SIGWAITINFO = 346; // { int sigwaitinfo(const sigset_t *set,\
public static readonly nint SYS___ACL_GET_FILE = 347; // { int __acl_get_file(const char *path, \
public static readonly nint SYS___ACL_SET_FILE = 348; // { int __acl_set_file(const char *path, \
public static readonly nint SYS___ACL_GET_FD = 349; // { int __acl_get_fd(int filedes, acl_type_t type, \
public static readonly nint SYS___ACL_SET_FD = 350; // { int __acl_set_fd(int filedes, acl_type_t type, \
public static readonly nint SYS___ACL_DELETE_FILE = 351; // { int __acl_delete_file(const char *path, \
public static readonly nint SYS___ACL_DELETE_FD = 352; // { int __acl_delete_fd(int filedes, acl_type_t type); }
public static readonly nint SYS___ACL_ACLCHECK_FILE = 353; // { int __acl_aclcheck_file(const char *path, \
public static readonly nint SYS___ACL_ACLCHECK_FD = 354; // { int __acl_aclcheck_fd(int filedes, acl_type_t type, \
public static readonly nint SYS_EXTATTRCTL = 355; // { int extattrctl(const char *path, int cmd, \
public static readonly nint SYS_EXTATTR_SET_FILE = 356; // { int extattr_set_file(const char *path, \
public static readonly nint SYS_EXTATTR_GET_FILE = 357; // { int extattr_get_file(const char *path, \
public static readonly nint SYS_EXTATTR_DELETE_FILE = 358; // { int extattr_delete_file(const char *path, \
public static readonly nint SYS_AIO_WAITCOMPLETE = 359; // { int aio_waitcomplete(struct aiocb **aiocbp, struct timespec *timeout); }
public static readonly nint SYS_GETRESUID = 360; // { int getresuid(uid_t *ruid, uid_t *euid, uid_t *suid); }
public static readonly nint SYS_GETRESGID = 361; // { int getresgid(gid_t *rgid, gid_t *egid, gid_t *sgid); }
public static readonly nint SYS_KQUEUE = 362; // { int kqueue(void); }
public static readonly nint SYS_KEVENT = 363; // { int kevent(int fd, \
public static readonly nint SYS_SCTP_PEELOFF = 364; // { int sctp_peeloff(int sd, caddr_t name ); }
public static readonly nint SYS_LCHFLAGS = 391; // { int lchflags(char *path, int flags); }
public static readonly nint SYS_UUIDGEN = 392; // { int uuidgen(struct uuid *store, int count); }
public static readonly nint SYS_SENDFILE = 393; // { int sendfile(int fd, int s, off_t offset, size_t nbytes, \
public static readonly nint SYS_VARSYM_SET = 450; // { int varsym_set(int level, const char *name, const char *data); }
public static readonly nint SYS_VARSYM_GET = 451; // { int varsym_get(int mask, const char *wild, char *buf, int bufsize); }
public static readonly nint SYS_VARSYM_LIST = 452; // { int varsym_list(int level, char *buf, int maxsize, int *marker); }
public static readonly nint SYS_EXEC_SYS_REGISTER = 465; // { int exec_sys_register(void *entry); }
public static readonly nint SYS_EXEC_SYS_UNREGISTER = 466; // { int exec_sys_unregister(int id); }
public static readonly nint SYS_SYS_CHECKPOINT = 467; // { int sys_checkpoint(int type, int fd, pid_t pid, int retval); }
public static readonly nint SYS_MOUNTCTL = 468; // { int mountctl(const char *path, int op, int fd, const void *ctl, int ctllen, void *buf, int buflen); }
public static readonly nint SYS_UMTX_SLEEP = 469; // { int umtx_sleep(volatile const int *ptr, int value, int timeout); }
public static readonly nint SYS_UMTX_WAKEUP = 470; // { int umtx_wakeup(volatile const int *ptr, int count); }
public static readonly nint SYS_JAIL_ATTACH = 471; // { int jail_attach(int jid); }
public static readonly nint SYS_SET_TLS_AREA = 472; // { int set_tls_area(int which, struct tls_info *info, size_t infosize); }
public static readonly nint SYS_GET_TLS_AREA = 473; // { int get_tls_area(int which, struct tls_info *info, size_t infosize); }
public static readonly nint SYS_CLOSEFROM = 474; // { int closefrom(int fd); }
public static readonly nint SYS_STAT = 475; // { int stat(const char *path, struct stat *ub); }
public static readonly nint SYS_FSTAT = 476; // { int fstat(int fd, struct stat *sb); }
public static readonly nint SYS_LSTAT = 477; // { int lstat(const char *path, struct stat *ub); }
public static readonly nint SYS_FHSTAT = 478; // { int fhstat(const struct fhandle *u_fhp, struct stat *sb); }
public static readonly nint SYS_GETDIRENTRIES = 479; // { int getdirentries(int fd, char *buf, u_int count, \
public static readonly nint SYS_GETDENTS = 480; // { int getdents(int fd, char *buf, size_t count); }
public static readonly nint SYS_USCHED_SET = 481; // { int usched_set(pid_t pid, int cmd, void *data, \
public static readonly nint SYS_EXTACCEPT = 482; // { int extaccept(int s, int flags, caddr_t name, int *anamelen); }
public static readonly nint SYS_EXTCONNECT = 483; // { int extconnect(int s, int flags, caddr_t name, int namelen); }
public static readonly nint SYS_MCONTROL = 485; // { int mcontrol(void *addr, size_t len, int behav, off_t value); }
public static readonly nint SYS_VMSPACE_CREATE = 486; // { int vmspace_create(void *id, int type, void *data); }
public static readonly nint SYS_VMSPACE_DESTROY = 487; // { int vmspace_destroy(void *id); }
public static readonly nint SYS_VMSPACE_CTL = 488; // { int vmspace_ctl(void *id, int cmd,         \
public static readonly nint SYS_VMSPACE_MMAP = 489; // { int vmspace_mmap(void *id, void *addr, size_t len, \
public static readonly nint SYS_VMSPACE_MUNMAP = 490; // { int vmspace_munmap(void *id, void *addr,    \
public static readonly nint SYS_VMSPACE_MCONTROL = 491; // { int vmspace_mcontrol(void *id, void *addr,     \
public static readonly nint SYS_VMSPACE_PREAD = 492; // { ssize_t vmspace_pread(void *id, void *buf, \
public static readonly nint SYS_VMSPACE_PWRITE = 493; // { ssize_t vmspace_pwrite(void *id, const void *buf, \
public static readonly nint SYS_EXTEXIT = 494; // { void extexit(int how, int status, void *addr); }
public static readonly nint SYS_LWP_CREATE = 495; // { int lwp_create(struct lwp_params *params); }
public static readonly nint SYS_LWP_GETTID = 496; // { lwpid_t lwp_gettid(void); }
public static readonly nint SYS_LWP_KILL = 497; // { int lwp_kill(pid_t pid, lwpid_t tid, int signum); }
public static readonly nint SYS_LWP_RTPRIO = 498; // { int lwp_rtprio(int function, pid_t pid, lwpid_t tid, struct rtprio *rtp); }
public static readonly nint SYS_PSELECT = 499; // { int pselect(int nd, fd_set *in, fd_set *ou, \
public static readonly nint SYS_STATVFS = 500; // { int statvfs(const char *path, struct statvfs *buf); }
public static readonly nint SYS_FSTATVFS = 501; // { int fstatvfs(int fd, struct statvfs *buf); }
public static readonly nint SYS_FHSTATVFS = 502; // { int fhstatvfs(const struct fhandle *u_fhp, struct statvfs *buf); }
public static readonly nint SYS_GETVFSSTAT = 503; // { int getvfsstat(struct statfs *buf,          \
public static readonly nint SYS_OPENAT = 504; // { int openat(int fd, char *path, int flags, int mode); }
public static readonly nint SYS_FSTATAT = 505; // { int fstatat(int fd, char *path,     \
public static readonly nint SYS_FCHMODAT = 506; // { int fchmodat(int fd, char *path, int mode, \
public static readonly nint SYS_FCHOWNAT = 507; // { int fchownat(int fd, char *path, int uid, int gid, \
public static readonly nint SYS_UNLINKAT = 508; // { int unlinkat(int fd, char *path, int flags); }
public static readonly nint SYS_FACCESSAT = 509; // { int faccessat(int fd, char *path, int amode, \
public static readonly nint SYS_MQ_OPEN = 510; // { mqd_t mq_open(const char * name, int oflag, \
public static readonly nint SYS_MQ_CLOSE = 511; // { int mq_close(mqd_t mqdes); }
public static readonly nint SYS_MQ_UNLINK = 512; // { int mq_unlink(const char *name); }
public static readonly nint SYS_MQ_GETATTR = 513; // { int mq_getattr(mqd_t mqdes, \
public static readonly nint SYS_MQ_SETATTR = 514; // { int mq_setattr(mqd_t mqdes, \
public static readonly nint SYS_MQ_NOTIFY = 515; // { int mq_notify(mqd_t mqdes, \
public static readonly nint SYS_MQ_SEND = 516; // { int mq_send(mqd_t mqdes, const char *msg_ptr, \
public static readonly nint SYS_MQ_RECEIVE = 517; // { ssize_t mq_receive(mqd_t mqdes, char *msg_ptr, \
public static readonly nint SYS_MQ_TIMEDSEND = 518; // { int mq_timedsend(mqd_t mqdes, \
public static readonly nint SYS_MQ_TIMEDRECEIVE = 519; // { ssize_t mq_timedreceive(mqd_t mqdes, \
public static readonly nint SYS_IOPRIO_SET = 520; // { int ioprio_set(int which, int who, int prio); }
public static readonly nint SYS_IOPRIO_GET = 521; // { int ioprio_get(int which, int who); }
public static readonly nint SYS_CHROOT_KERNEL = 522; // { int chroot_kernel(char *path); }
public static readonly nint SYS_RENAMEAT = 523; // { int renameat(int oldfd, char *old, int newfd, \
public static readonly nint SYS_MKDIRAT = 524; // { int mkdirat(int fd, char *path, mode_t mode); }
public static readonly nint SYS_MKFIFOAT = 525; // { int mkfifoat(int fd, char *path, mode_t mode); }
public static readonly nint SYS_MKNODAT = 526; // { int mknodat(int fd, char *path, mode_t mode, \
public static readonly nint SYS_READLINKAT = 527; // { int readlinkat(int fd, char *path, char *buf, \
public static readonly nint SYS_SYMLINKAT = 528; // { int symlinkat(char *path1, int fd, char *path2); }
public static readonly nint SYS_SWAPOFF = 529; // { int swapoff(char *name); }
public static readonly nint SYS_VQUOTACTL = 530; // { int vquotactl(const char *path, \
public static readonly nint SYS_LINKAT = 531; // { int linkat(int fd1, char *path1, int fd2, \
public static readonly nint SYS_EACCESS = 532; // { int eaccess(char *path, int flags); }
public static readonly nint SYS_LPATHCONF = 533; // { int lpathconf(char *path, int name); }
public static readonly nint SYS_VMM_GUEST_CTL = 534; // { int vmm_guest_ctl(int op, struct vmm_guest_options *options); }
public static readonly nint SYS_VMM_GUEST_SYNC_ADDR = 535; // { int vmm_guest_sync_addr(long *dstaddr, long *srcaddr); }
public static readonly nint SYS_PIPE2 = 538; // { int pipe2(int *fildes, int flags); }
public static readonly nint SYS_UTIMENSAT = 539; // { int utimensat(int fd, const char *path, const struct timespec *ts, int flags); }
public static readonly nint SYS_ACCEPT4 = 541; // { int accept4(int s, caddr_t name, int *anamelen, int flags); }
public static readonly nint SYS_WAIT6 = 548; // { int wait6(idtype_t idtype, id_t id, int *status, int options, struct __wrusage *wrusage, siginfo_t *info); }

} // end syscall_package
