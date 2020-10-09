// go run linux/mksysnum.go -Wall -Werror -static -I/tmp/include /tmp/include/asm/unistd.h
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build mips64le,linux

// package unix -- go2cs converted at 2020 October 09 06:00:25 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_linux_mips64le.go

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
        public static readonly long SYS_READ = (long)5000L;
        public static readonly long SYS_WRITE = (long)5001L;
        public static readonly long SYS_OPEN = (long)5002L;
        public static readonly long SYS_CLOSE = (long)5003L;
        public static readonly long SYS_STAT = (long)5004L;
        public static readonly long SYS_FSTAT = (long)5005L;
        public static readonly long SYS_LSTAT = (long)5006L;
        public static readonly long SYS_POLL = (long)5007L;
        public static readonly long SYS_LSEEK = (long)5008L;
        public static readonly long SYS_MMAP = (long)5009L;
        public static readonly long SYS_MPROTECT = (long)5010L;
        public static readonly long SYS_MUNMAP = (long)5011L;
        public static readonly long SYS_BRK = (long)5012L;
        public static readonly long SYS_RT_SIGACTION = (long)5013L;
        public static readonly long SYS_RT_SIGPROCMASK = (long)5014L;
        public static readonly long SYS_IOCTL = (long)5015L;
        public static readonly long SYS_PREAD64 = (long)5016L;
        public static readonly long SYS_PWRITE64 = (long)5017L;
        public static readonly long SYS_READV = (long)5018L;
        public static readonly long SYS_WRITEV = (long)5019L;
        public static readonly long SYS_ACCESS = (long)5020L;
        public static readonly long SYS_PIPE = (long)5021L;
        public static readonly long SYS__NEWSELECT = (long)5022L;
        public static readonly long SYS_SCHED_YIELD = (long)5023L;
        public static readonly long SYS_MREMAP = (long)5024L;
        public static readonly long SYS_MSYNC = (long)5025L;
        public static readonly long SYS_MINCORE = (long)5026L;
        public static readonly long SYS_MADVISE = (long)5027L;
        public static readonly long SYS_SHMGET = (long)5028L;
        public static readonly long SYS_SHMAT = (long)5029L;
        public static readonly long SYS_SHMCTL = (long)5030L;
        public static readonly long SYS_DUP = (long)5031L;
        public static readonly long SYS_DUP2 = (long)5032L;
        public static readonly long SYS_PAUSE = (long)5033L;
        public static readonly long SYS_NANOSLEEP = (long)5034L;
        public static readonly long SYS_GETITIMER = (long)5035L;
        public static readonly long SYS_SETITIMER = (long)5036L;
        public static readonly long SYS_ALARM = (long)5037L;
        public static readonly long SYS_GETPID = (long)5038L;
        public static readonly long SYS_SENDFILE = (long)5039L;
        public static readonly long SYS_SOCKET = (long)5040L;
        public static readonly long SYS_CONNECT = (long)5041L;
        public static readonly long SYS_ACCEPT = (long)5042L;
        public static readonly long SYS_SENDTO = (long)5043L;
        public static readonly long SYS_RECVFROM = (long)5044L;
        public static readonly long SYS_SENDMSG = (long)5045L;
        public static readonly long SYS_RECVMSG = (long)5046L;
        public static readonly long SYS_SHUTDOWN = (long)5047L;
        public static readonly long SYS_BIND = (long)5048L;
        public static readonly long SYS_LISTEN = (long)5049L;
        public static readonly long SYS_GETSOCKNAME = (long)5050L;
        public static readonly long SYS_GETPEERNAME = (long)5051L;
        public static readonly long SYS_SOCKETPAIR = (long)5052L;
        public static readonly long SYS_SETSOCKOPT = (long)5053L;
        public static readonly long SYS_GETSOCKOPT = (long)5054L;
        public static readonly long SYS_CLONE = (long)5055L;
        public static readonly long SYS_FORK = (long)5056L;
        public static readonly long SYS_EXECVE = (long)5057L;
        public static readonly long SYS_EXIT = (long)5058L;
        public static readonly long SYS_WAIT4 = (long)5059L;
        public static readonly long SYS_KILL = (long)5060L;
        public static readonly long SYS_UNAME = (long)5061L;
        public static readonly long SYS_SEMGET = (long)5062L;
        public static readonly long SYS_SEMOP = (long)5063L;
        public static readonly long SYS_SEMCTL = (long)5064L;
        public static readonly long SYS_SHMDT = (long)5065L;
        public static readonly long SYS_MSGGET = (long)5066L;
        public static readonly long SYS_MSGSND = (long)5067L;
        public static readonly long SYS_MSGRCV = (long)5068L;
        public static readonly long SYS_MSGCTL = (long)5069L;
        public static readonly long SYS_FCNTL = (long)5070L;
        public static readonly long SYS_FLOCK = (long)5071L;
        public static readonly long SYS_FSYNC = (long)5072L;
        public static readonly long SYS_FDATASYNC = (long)5073L;
        public static readonly long SYS_TRUNCATE = (long)5074L;
        public static readonly long SYS_FTRUNCATE = (long)5075L;
        public static readonly long SYS_GETDENTS = (long)5076L;
        public static readonly long SYS_GETCWD = (long)5077L;
        public static readonly long SYS_CHDIR = (long)5078L;
        public static readonly long SYS_FCHDIR = (long)5079L;
        public static readonly long SYS_RENAME = (long)5080L;
        public static readonly long SYS_MKDIR = (long)5081L;
        public static readonly long SYS_RMDIR = (long)5082L;
        public static readonly long SYS_CREAT = (long)5083L;
        public static readonly long SYS_LINK = (long)5084L;
        public static readonly long SYS_UNLINK = (long)5085L;
        public static readonly long SYS_SYMLINK = (long)5086L;
        public static readonly long SYS_READLINK = (long)5087L;
        public static readonly long SYS_CHMOD = (long)5088L;
        public static readonly long SYS_FCHMOD = (long)5089L;
        public static readonly long SYS_CHOWN = (long)5090L;
        public static readonly long SYS_FCHOWN = (long)5091L;
        public static readonly long SYS_LCHOWN = (long)5092L;
        public static readonly long SYS_UMASK = (long)5093L;
        public static readonly long SYS_GETTIMEOFDAY = (long)5094L;
        public static readonly long SYS_GETRLIMIT = (long)5095L;
        public static readonly long SYS_GETRUSAGE = (long)5096L;
        public static readonly long SYS_SYSINFO = (long)5097L;
        public static readonly long SYS_TIMES = (long)5098L;
        public static readonly long SYS_PTRACE = (long)5099L;
        public static readonly long SYS_GETUID = (long)5100L;
        public static readonly long SYS_SYSLOG = (long)5101L;
        public static readonly long SYS_GETGID = (long)5102L;
        public static readonly long SYS_SETUID = (long)5103L;
        public static readonly long SYS_SETGID = (long)5104L;
        public static readonly long SYS_GETEUID = (long)5105L;
        public static readonly long SYS_GETEGID = (long)5106L;
        public static readonly long SYS_SETPGID = (long)5107L;
        public static readonly long SYS_GETPPID = (long)5108L;
        public static readonly long SYS_GETPGRP = (long)5109L;
        public static readonly long SYS_SETSID = (long)5110L;
        public static readonly long SYS_SETREUID = (long)5111L;
        public static readonly long SYS_SETREGID = (long)5112L;
        public static readonly long SYS_GETGROUPS = (long)5113L;
        public static readonly long SYS_SETGROUPS = (long)5114L;
        public static readonly long SYS_SETRESUID = (long)5115L;
        public static readonly long SYS_GETRESUID = (long)5116L;
        public static readonly long SYS_SETRESGID = (long)5117L;
        public static readonly long SYS_GETRESGID = (long)5118L;
        public static readonly long SYS_GETPGID = (long)5119L;
        public static readonly long SYS_SETFSUID = (long)5120L;
        public static readonly long SYS_SETFSGID = (long)5121L;
        public static readonly long SYS_GETSID = (long)5122L;
        public static readonly long SYS_CAPGET = (long)5123L;
        public static readonly long SYS_CAPSET = (long)5124L;
        public static readonly long SYS_RT_SIGPENDING = (long)5125L;
        public static readonly long SYS_RT_SIGTIMEDWAIT = (long)5126L;
        public static readonly long SYS_RT_SIGQUEUEINFO = (long)5127L;
        public static readonly long SYS_RT_SIGSUSPEND = (long)5128L;
        public static readonly long SYS_SIGALTSTACK = (long)5129L;
        public static readonly long SYS_UTIME = (long)5130L;
        public static readonly long SYS_MKNOD = (long)5131L;
        public static readonly long SYS_PERSONALITY = (long)5132L;
        public static readonly long SYS_USTAT = (long)5133L;
        public static readonly long SYS_STATFS = (long)5134L;
        public static readonly long SYS_FSTATFS = (long)5135L;
        public static readonly long SYS_SYSFS = (long)5136L;
        public static readonly long SYS_GETPRIORITY = (long)5137L;
        public static readonly long SYS_SETPRIORITY = (long)5138L;
        public static readonly long SYS_SCHED_SETPARAM = (long)5139L;
        public static readonly long SYS_SCHED_GETPARAM = (long)5140L;
        public static readonly long SYS_SCHED_SETSCHEDULER = (long)5141L;
        public static readonly long SYS_SCHED_GETSCHEDULER = (long)5142L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MAX = (long)5143L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MIN = (long)5144L;
        public static readonly long SYS_SCHED_RR_GET_INTERVAL = (long)5145L;
        public static readonly long SYS_MLOCK = (long)5146L;
        public static readonly long SYS_MUNLOCK = (long)5147L;
        public static readonly long SYS_MLOCKALL = (long)5148L;
        public static readonly long SYS_MUNLOCKALL = (long)5149L;
        public static readonly long SYS_VHANGUP = (long)5150L;
        public static readonly long SYS_PIVOT_ROOT = (long)5151L;
        public static readonly long SYS__SYSCTL = (long)5152L;
        public static readonly long SYS_PRCTL = (long)5153L;
        public static readonly long SYS_ADJTIMEX = (long)5154L;
        public static readonly long SYS_SETRLIMIT = (long)5155L;
        public static readonly long SYS_CHROOT = (long)5156L;
        public static readonly long SYS_SYNC = (long)5157L;
        public static readonly long SYS_ACCT = (long)5158L;
        public static readonly long SYS_SETTIMEOFDAY = (long)5159L;
        public static readonly long SYS_MOUNT = (long)5160L;
        public static readonly long SYS_UMOUNT2 = (long)5161L;
        public static readonly long SYS_SWAPON = (long)5162L;
        public static readonly long SYS_SWAPOFF = (long)5163L;
        public static readonly long SYS_REBOOT = (long)5164L;
        public static readonly long SYS_SETHOSTNAME = (long)5165L;
        public static readonly long SYS_SETDOMAINNAME = (long)5166L;
        public static readonly long SYS_CREATE_MODULE = (long)5167L;
        public static readonly long SYS_INIT_MODULE = (long)5168L;
        public static readonly long SYS_DELETE_MODULE = (long)5169L;
        public static readonly long SYS_GET_KERNEL_SYMS = (long)5170L;
        public static readonly long SYS_QUERY_MODULE = (long)5171L;
        public static readonly long SYS_QUOTACTL = (long)5172L;
        public static readonly long SYS_NFSSERVCTL = (long)5173L;
        public static readonly long SYS_GETPMSG = (long)5174L;
        public static readonly long SYS_PUTPMSG = (long)5175L;
        public static readonly long SYS_AFS_SYSCALL = (long)5176L;
        public static readonly long SYS_RESERVED177 = (long)5177L;
        public static readonly long SYS_GETTID = (long)5178L;
        public static readonly long SYS_READAHEAD = (long)5179L;
        public static readonly long SYS_SETXATTR = (long)5180L;
        public static readonly long SYS_LSETXATTR = (long)5181L;
        public static readonly long SYS_FSETXATTR = (long)5182L;
        public static readonly long SYS_GETXATTR = (long)5183L;
        public static readonly long SYS_LGETXATTR = (long)5184L;
        public static readonly long SYS_FGETXATTR = (long)5185L;
        public static readonly long SYS_LISTXATTR = (long)5186L;
        public static readonly long SYS_LLISTXATTR = (long)5187L;
        public static readonly long SYS_FLISTXATTR = (long)5188L;
        public static readonly long SYS_REMOVEXATTR = (long)5189L;
        public static readonly long SYS_LREMOVEXATTR = (long)5190L;
        public static readonly long SYS_FREMOVEXATTR = (long)5191L;
        public static readonly long SYS_TKILL = (long)5192L;
        public static readonly long SYS_RESERVED193 = (long)5193L;
        public static readonly long SYS_FUTEX = (long)5194L;
        public static readonly long SYS_SCHED_SETAFFINITY = (long)5195L;
        public static readonly long SYS_SCHED_GETAFFINITY = (long)5196L;
        public static readonly long SYS_CACHEFLUSH = (long)5197L;
        public static readonly long SYS_CACHECTL = (long)5198L;
        public static readonly long SYS_SYSMIPS = (long)5199L;
        public static readonly long SYS_IO_SETUP = (long)5200L;
        public static readonly long SYS_IO_DESTROY = (long)5201L;
        public static readonly long SYS_IO_GETEVENTS = (long)5202L;
        public static readonly long SYS_IO_SUBMIT = (long)5203L;
        public static readonly long SYS_IO_CANCEL = (long)5204L;
        public static readonly long SYS_EXIT_GROUP = (long)5205L;
        public static readonly long SYS_LOOKUP_DCOOKIE = (long)5206L;
        public static readonly long SYS_EPOLL_CREATE = (long)5207L;
        public static readonly long SYS_EPOLL_CTL = (long)5208L;
        public static readonly long SYS_EPOLL_WAIT = (long)5209L;
        public static readonly long SYS_REMAP_FILE_PAGES = (long)5210L;
        public static readonly long SYS_RT_SIGRETURN = (long)5211L;
        public static readonly long SYS_SET_TID_ADDRESS = (long)5212L;
        public static readonly long SYS_RESTART_SYSCALL = (long)5213L;
        public static readonly long SYS_SEMTIMEDOP = (long)5214L;
        public static readonly long SYS_FADVISE64 = (long)5215L;
        public static readonly long SYS_TIMER_CREATE = (long)5216L;
        public static readonly long SYS_TIMER_SETTIME = (long)5217L;
        public static readonly long SYS_TIMER_GETTIME = (long)5218L;
        public static readonly long SYS_TIMER_GETOVERRUN = (long)5219L;
        public static readonly long SYS_TIMER_DELETE = (long)5220L;
        public static readonly long SYS_CLOCK_SETTIME = (long)5221L;
        public static readonly long SYS_CLOCK_GETTIME = (long)5222L;
        public static readonly long SYS_CLOCK_GETRES = (long)5223L;
        public static readonly long SYS_CLOCK_NANOSLEEP = (long)5224L;
        public static readonly long SYS_TGKILL = (long)5225L;
        public static readonly long SYS_UTIMES = (long)5226L;
        public static readonly long SYS_MBIND = (long)5227L;
        public static readonly long SYS_GET_MEMPOLICY = (long)5228L;
        public static readonly long SYS_SET_MEMPOLICY = (long)5229L;
        public static readonly long SYS_MQ_OPEN = (long)5230L;
        public static readonly long SYS_MQ_UNLINK = (long)5231L;
        public static readonly long SYS_MQ_TIMEDSEND = (long)5232L;
        public static readonly long SYS_MQ_TIMEDRECEIVE = (long)5233L;
        public static readonly long SYS_MQ_NOTIFY = (long)5234L;
        public static readonly long SYS_MQ_GETSETATTR = (long)5235L;
        public static readonly long SYS_VSERVER = (long)5236L;
        public static readonly long SYS_WAITID = (long)5237L;
        public static readonly long SYS_ADD_KEY = (long)5239L;
        public static readonly long SYS_REQUEST_KEY = (long)5240L;
        public static readonly long SYS_KEYCTL = (long)5241L;
        public static readonly long SYS_SET_THREAD_AREA = (long)5242L;
        public static readonly long SYS_INOTIFY_INIT = (long)5243L;
        public static readonly long SYS_INOTIFY_ADD_WATCH = (long)5244L;
        public static readonly long SYS_INOTIFY_RM_WATCH = (long)5245L;
        public static readonly long SYS_MIGRATE_PAGES = (long)5246L;
        public static readonly long SYS_OPENAT = (long)5247L;
        public static readonly long SYS_MKDIRAT = (long)5248L;
        public static readonly long SYS_MKNODAT = (long)5249L;
        public static readonly long SYS_FCHOWNAT = (long)5250L;
        public static readonly long SYS_FUTIMESAT = (long)5251L;
        public static readonly long SYS_NEWFSTATAT = (long)5252L;
        public static readonly long SYS_UNLINKAT = (long)5253L;
        public static readonly long SYS_RENAMEAT = (long)5254L;
        public static readonly long SYS_LINKAT = (long)5255L;
        public static readonly long SYS_SYMLINKAT = (long)5256L;
        public static readonly long SYS_READLINKAT = (long)5257L;
        public static readonly long SYS_FCHMODAT = (long)5258L;
        public static readonly long SYS_FACCESSAT = (long)5259L;
        public static readonly long SYS_PSELECT6 = (long)5260L;
        public static readonly long SYS_PPOLL = (long)5261L;
        public static readonly long SYS_UNSHARE = (long)5262L;
        public static readonly long SYS_SPLICE = (long)5263L;
        public static readonly long SYS_SYNC_FILE_RANGE = (long)5264L;
        public static readonly long SYS_TEE = (long)5265L;
        public static readonly long SYS_VMSPLICE = (long)5266L;
        public static readonly long SYS_MOVE_PAGES = (long)5267L;
        public static readonly long SYS_SET_ROBUST_LIST = (long)5268L;
        public static readonly long SYS_GET_ROBUST_LIST = (long)5269L;
        public static readonly long SYS_KEXEC_LOAD = (long)5270L;
        public static readonly long SYS_GETCPU = (long)5271L;
        public static readonly long SYS_EPOLL_PWAIT = (long)5272L;
        public static readonly long SYS_IOPRIO_SET = (long)5273L;
        public static readonly long SYS_IOPRIO_GET = (long)5274L;
        public static readonly long SYS_UTIMENSAT = (long)5275L;
        public static readonly long SYS_SIGNALFD = (long)5276L;
        public static readonly long SYS_TIMERFD = (long)5277L;
        public static readonly long SYS_EVENTFD = (long)5278L;
        public static readonly long SYS_FALLOCATE = (long)5279L;
        public static readonly long SYS_TIMERFD_CREATE = (long)5280L;
        public static readonly long SYS_TIMERFD_GETTIME = (long)5281L;
        public static readonly long SYS_TIMERFD_SETTIME = (long)5282L;
        public static readonly long SYS_SIGNALFD4 = (long)5283L;
        public static readonly long SYS_EVENTFD2 = (long)5284L;
        public static readonly long SYS_EPOLL_CREATE1 = (long)5285L;
        public static readonly long SYS_DUP3 = (long)5286L;
        public static readonly long SYS_PIPE2 = (long)5287L;
        public static readonly long SYS_INOTIFY_INIT1 = (long)5288L;
        public static readonly long SYS_PREADV = (long)5289L;
        public static readonly long SYS_PWRITEV = (long)5290L;
        public static readonly long SYS_RT_TGSIGQUEUEINFO = (long)5291L;
        public static readonly long SYS_PERF_EVENT_OPEN = (long)5292L;
        public static readonly long SYS_ACCEPT4 = (long)5293L;
        public static readonly long SYS_RECVMMSG = (long)5294L;
        public static readonly long SYS_FANOTIFY_INIT = (long)5295L;
        public static readonly long SYS_FANOTIFY_MARK = (long)5296L;
        public static readonly long SYS_PRLIMIT64 = (long)5297L;
        public static readonly long SYS_NAME_TO_HANDLE_AT = (long)5298L;
        public static readonly long SYS_OPEN_BY_HANDLE_AT = (long)5299L;
        public static readonly long SYS_CLOCK_ADJTIME = (long)5300L;
        public static readonly long SYS_SYNCFS = (long)5301L;
        public static readonly long SYS_SENDMMSG = (long)5302L;
        public static readonly long SYS_SETNS = (long)5303L;
        public static readonly long SYS_PROCESS_VM_READV = (long)5304L;
        public static readonly long SYS_PROCESS_VM_WRITEV = (long)5305L;
        public static readonly long SYS_KCMP = (long)5306L;
        public static readonly long SYS_FINIT_MODULE = (long)5307L;
        public static readonly long SYS_GETDENTS64 = (long)5308L;
        public static readonly long SYS_SCHED_SETATTR = (long)5309L;
        public static readonly long SYS_SCHED_GETATTR = (long)5310L;
        public static readonly long SYS_RENAMEAT2 = (long)5311L;
        public static readonly long SYS_SECCOMP = (long)5312L;
        public static readonly long SYS_GETRANDOM = (long)5313L;
        public static readonly long SYS_MEMFD_CREATE = (long)5314L;
        public static readonly long SYS_BPF = (long)5315L;
        public static readonly long SYS_EXECVEAT = (long)5316L;
        public static readonly long SYS_USERFAULTFD = (long)5317L;
        public static readonly long SYS_MEMBARRIER = (long)5318L;
        public static readonly long SYS_MLOCK2 = (long)5319L;
        public static readonly long SYS_COPY_FILE_RANGE = (long)5320L;
        public static readonly long SYS_PREADV2 = (long)5321L;
        public static readonly long SYS_PWRITEV2 = (long)5322L;
        public static readonly long SYS_PKEY_MPROTECT = (long)5323L;
        public static readonly long SYS_PKEY_ALLOC = (long)5324L;
        public static readonly long SYS_PKEY_FREE = (long)5325L;
        public static readonly long SYS_STATX = (long)5326L;
        public static readonly long SYS_RSEQ = (long)5327L;
        public static readonly long SYS_IO_PGETEVENTS = (long)5328L;
        public static readonly long SYS_PIDFD_SEND_SIGNAL = (long)5424L;
        public static readonly long SYS_IO_URING_SETUP = (long)5425L;
        public static readonly long SYS_IO_URING_ENTER = (long)5426L;
        public static readonly long SYS_IO_URING_REGISTER = (long)5427L;
        public static readonly long SYS_OPEN_TREE = (long)5428L;
        public static readonly long SYS_MOVE_MOUNT = (long)5429L;
        public static readonly long SYS_FSOPEN = (long)5430L;
        public static readonly long SYS_FSCONFIG = (long)5431L;
        public static readonly long SYS_FSMOUNT = (long)5432L;
        public static readonly long SYS_FSPICK = (long)5433L;
        public static readonly long SYS_PIDFD_OPEN = (long)5434L;
        public static readonly long SYS_CLONE3 = (long)5435L;
        public static readonly long SYS_OPENAT2 = (long)5437L;
        public static readonly long SYS_PIDFD_GETFD = (long)5438L;

    }
}}}}}}
