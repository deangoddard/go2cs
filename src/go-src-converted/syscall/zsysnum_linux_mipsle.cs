// mksysnum_linux.pl /usr/include/mips-linux-gnu/asm/unistd.h
// MACHINE GENERATED BY THE ABOVE COMMAND; DO NOT EDIT

// package syscall -- go2cs converted at 2020 August 29 08:42:02 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\zsysnum_linux_mipsle.go

using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        public static readonly long SYS_SYSCALL = 4000L;
        public static readonly long SYS_EXIT = 4001L;
        public static readonly long SYS_FORK = 4002L;
        public static readonly long SYS_READ = 4003L;
        public static readonly long SYS_WRITE = 4004L;
        public static readonly long SYS_OPEN = 4005L;
        public static readonly long SYS_CLOSE = 4006L;
        public static readonly long SYS_WAITPID = 4007L;
        public static readonly long SYS_CREAT = 4008L;
        public static readonly long SYS_LINK = 4009L;
        public static readonly long SYS_UNLINK = 4010L;
        public static readonly long SYS_EXECVE = 4011L;
        public static readonly long SYS_CHDIR = 4012L;
        public static readonly long SYS_TIME = 4013L;
        public static readonly long SYS_MKNOD = 4014L;
        public static readonly long SYS_CHMOD = 4015L;
        public static readonly long SYS_LCHOWN = 4016L;
        public static readonly long SYS_BREAK = 4017L;
        public static readonly long SYS_UNUSED18 = 4018L;
        public static readonly long SYS_LSEEK = 4019L;
        public static readonly long SYS_GETPID = 4020L;
        public static readonly long SYS_MOUNT = 4021L;
        public static readonly long SYS_UMOUNT = 4022L;
        public static readonly long SYS_SETUID = 4023L;
        public static readonly long SYS_GETUID = 4024L;
        public static readonly long SYS_STIME = 4025L;
        public static readonly long SYS_PTRACE = 4026L;
        public static readonly long SYS_ALARM = 4027L;
        public static readonly long SYS_UNUSED28 = 4028L;
        public static readonly long SYS_PAUSE = 4029L;
        public static readonly long SYS_UTIME = 4030L;
        public static readonly long SYS_STTY = 4031L;
        public static readonly long SYS_GTTY = 4032L;
        public static readonly long SYS_ACCESS = 4033L;
        public static readonly long SYS_NICE = 4034L;
        public static readonly long SYS_FTIME = 4035L;
        public static readonly long SYS_SYNC = 4036L;
        public static readonly long SYS_KILL = 4037L;
        public static readonly long SYS_RENAME = 4038L;
        public static readonly long SYS_MKDIR = 4039L;
        public static readonly long SYS_RMDIR = 4040L;
        public static readonly long SYS_DUP = 4041L;
        public static readonly long SYS_PIPE = 4042L;
        public static readonly long SYS_TIMES = 4043L;
        public static readonly long SYS_PROF = 4044L;
        public static readonly long SYS_BRK = 4045L;
        public static readonly long SYS_SETGID = 4046L;
        public static readonly long SYS_GETGID = 4047L;
        public static readonly long SYS_SIGNAL = 4048L;
        public static readonly long SYS_GETEUID = 4049L;
        public static readonly long SYS_GETEGID = 4050L;
        public static readonly long SYS_ACCT = 4051L;
        public static readonly long SYS_UMOUNT2 = 4052L;
        public static readonly long SYS_LOCK = 4053L;
        public static readonly long SYS_IOCTL = 4054L;
        public static readonly long SYS_FCNTL = 4055L;
        public static readonly long SYS_MPX = 4056L;
        public static readonly long SYS_SETPGID = 4057L;
        public static readonly long SYS_ULIMIT = 4058L;
        public static readonly long SYS_UNUSED59 = 4059L;
        public static readonly long SYS_UMASK = 4060L;
        public static readonly long SYS_CHROOT = 4061L;
        public static readonly long SYS_USTAT = 4062L;
        public static readonly long SYS_DUP2 = 4063L;
        public static readonly long SYS_GETPPID = 4064L;
        public static readonly long SYS_GETPGRP = 4065L;
        public static readonly long SYS_SETSID = 4066L;
        public static readonly long SYS_SIGACTION = 4067L;
        public static readonly long SYS_SGETMASK = 4068L;
        public static readonly long SYS_SSETMASK = 4069L;
        public static readonly long SYS_SETREUID = 4070L;
        public static readonly long SYS_SETREGID = 4071L;
        public static readonly long SYS_SIGSUSPEND = 4072L;
        public static readonly long SYS_SIGPENDING = 4073L;
        public static readonly long SYS_SETHOSTNAME = 4074L;
        public static readonly long SYS_SETRLIMIT = 4075L;
        public static readonly long SYS_GETRLIMIT = 4076L;
        public static readonly long SYS_GETRUSAGE = 4077L;
        public static readonly long SYS_GETTIMEOFDAY = 4078L;
        public static readonly long SYS_SETTIMEOFDAY = 4079L;
        public static readonly long SYS_GETGROUPS = 4080L;
        public static readonly long SYS_SETGROUPS = 4081L;
        public static readonly long SYS_RESERVED82 = 4082L;
        public static readonly long SYS_SYMLINK = 4083L;
        public static readonly long SYS_UNUSED84 = 4084L;
        public static readonly long SYS_READLINK = 4085L;
        public static readonly long SYS_USELIB = 4086L;
        public static readonly long SYS_SWAPON = 4087L;
        public static readonly long SYS_REBOOT = 4088L;
        public static readonly long SYS_READDIR = 4089L;
        public static readonly long SYS_MMAP = 4090L;
        public static readonly long SYS_MUNMAP = 4091L;
        public static readonly long SYS_TRUNCATE = 4092L;
        public static readonly long SYS_FTRUNCATE = 4093L;
        public static readonly long SYS_FCHMOD = 4094L;
        public static readonly long SYS_FCHOWN = 4095L;
        public static readonly long SYS_GETPRIORITY = 4096L;
        public static readonly long SYS_SETPRIORITY = 4097L;
        public static readonly long SYS_PROFIL = 4098L;
        public static readonly long SYS_STATFS = 4099L;
        public static readonly long SYS_FSTATFS = 4100L;
        public static readonly long SYS_IOPERM = 4101L;
        public static readonly long SYS_SOCKETCALL = 4102L;
        public static readonly long SYS_SYSLOG = 4103L;
        public static readonly long SYS_SETITIMER = 4104L;
        public static readonly long SYS_GETITIMER = 4105L;
        public static readonly long SYS_STAT = 4106L;
        public static readonly long SYS_LSTAT = 4107L;
        public static readonly long SYS_FSTAT = 4108L;
        public static readonly long SYS_UNUSED109 = 4109L;
        public static readonly long SYS_IOPL = 4110L;
        public static readonly long SYS_VHANGUP = 4111L;
        public static readonly long SYS_IDLE = 4112L;
        public static readonly long SYS_VM86 = 4113L;
        public static readonly long SYS_WAIT4 = 4114L;
        public static readonly long SYS_SWAPOFF = 4115L;
        public static readonly long SYS_SYSINFO = 4116L;
        public static readonly long SYS_IPC = 4117L;
        public static readonly long SYS_FSYNC = 4118L;
        public static readonly long SYS_SIGRETURN = 4119L;
        public static readonly long SYS_CLONE = 4120L;
        public static readonly long SYS_SETDOMAINNAME = 4121L;
        public static readonly long SYS_UNAME = 4122L;
        public static readonly long SYS_MODIFY_LDT = 4123L;
        public static readonly long SYS_ADJTIMEX = 4124L;
        public static readonly long SYS_MPROTECT = 4125L;
        public static readonly long SYS_SIGPROCMASK = 4126L;
        public static readonly long SYS_CREATE_MODULE = 4127L;
        public static readonly long SYS_INIT_MODULE = 4128L;
        public static readonly long SYS_DELETE_MODULE = 4129L;
        public static readonly long SYS_GET_KERNEL_SYMS = 4130L;
        public static readonly long SYS_QUOTACTL = 4131L;
        public static readonly long SYS_GETPGID = 4132L;
        public static readonly long SYS_FCHDIR = 4133L;
        public static readonly long SYS_BDFLUSH = 4134L;
        public static readonly long SYS_SYSFS = 4135L;
        public static readonly long SYS_PERSONALITY = 4136L;
        public static readonly long SYS_AFS_SYSCALL = 4137L;
        public static readonly long SYS_SETFSUID = 4138L;
        public static readonly long SYS_SETFSGID = 4139L;
        public static readonly long SYS__LLSEEK = 4140L;
        public static readonly long SYS_GETDENTS = 4141L;
        public static readonly long SYS__NEWSELECT = 4142L;
        public static readonly long SYS_FLOCK = 4143L;
        public static readonly long SYS_MSYNC = 4144L;
        public static readonly long SYS_READV = 4145L;
        public static readonly long SYS_WRITEV = 4146L;
        public static readonly long SYS_CACHEFLUSH = 4147L;
        public static readonly long SYS_CACHECTL = 4148L;
        public static readonly long SYS_SYSMIPS = 4149L;
        public static readonly long SYS_UNUSED150 = 4150L;
        public static readonly long SYS_GETSID = 4151L;
        public static readonly long SYS_FDATASYNC = 4152L;
        public static readonly long SYS__SYSCTL = 4153L;
        public static readonly long SYS_MLOCK = 4154L;
        public static readonly long SYS_MUNLOCK = 4155L;
        public static readonly long SYS_MLOCKALL = 4156L;
        public static readonly long SYS_MUNLOCKALL = 4157L;
        public static readonly long SYS_SCHED_SETPARAM = 4158L;
        public static readonly long SYS_SCHED_GETPARAM = 4159L;
        public static readonly long SYS_SCHED_SETSCHEDULER = 4160L;
        public static readonly long SYS_SCHED_GETSCHEDULER = 4161L;
        public static readonly long SYS_SCHED_YIELD = 4162L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MAX = 4163L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MIN = 4164L;
        public static readonly long SYS_SCHED_RR_GET_INTERVAL = 4165L;
        public static readonly long SYS_NANOSLEEP = 4166L;
        public static readonly long SYS_MREMAP = 4167L;
        public static readonly long SYS_ACCEPT = 4168L;
        public static readonly long SYS_BIND = 4169L;
        public static readonly long SYS_CONNECT = 4170L;
        public static readonly long SYS_GETPEERNAME = 4171L;
        public static readonly long SYS_GETSOCKNAME = 4172L;
        public static readonly long SYS_GETSOCKOPT = 4173L;
        public static readonly long SYS_LISTEN = 4174L;
        public static readonly long SYS_RECV = 4175L;
        public static readonly long SYS_RECVFROM = 4176L;
        public static readonly long SYS_RECVMSG = 4177L;
        public static readonly long SYS_SEND = 4178L;
        public static readonly long SYS_SENDMSG = 4179L;
        public static readonly long SYS_SENDTO = 4180L;
        public static readonly long SYS_SETSOCKOPT = 4181L;
        public static readonly long SYS_SHUTDOWN = 4182L;
        public static readonly long SYS_SOCKET = 4183L;
        public static readonly long SYS_SOCKETPAIR = 4184L;
        public static readonly long SYS_SETRESUID = 4185L;
        public static readonly long SYS_GETRESUID = 4186L;
        public static readonly long SYS_QUERY_MODULE = 4187L;
        public static readonly long SYS_POLL = 4188L;
        public static readonly long SYS_NFSSERVCTL = 4189L;
        public static readonly long SYS_SETRESGID = 4190L;
        public static readonly long SYS_GETRESGID = 4191L;
        public static readonly long SYS_PRCTL = 4192L;
        public static readonly long SYS_RT_SIGRETURN = 4193L;
        public static readonly long SYS_RT_SIGACTION = 4194L;
        public static readonly long SYS_RT_SIGPROCMASK = 4195L;
        public static readonly long SYS_RT_SIGPENDING = 4196L;
        public static readonly long SYS_RT_SIGTIMEDWAIT = 4197L;
        public static readonly long SYS_RT_SIGQUEUEINFO = 4198L;
        public static readonly long SYS_RT_SIGSUSPEND = 4199L;
        public static readonly long SYS_PREAD64 = 4200L;
        public static readonly long SYS_PWRITE64 = 4201L;
        public static readonly long SYS_CHOWN = 4202L;
        public static readonly long SYS_GETCWD = 4203L;
        public static readonly long SYS_CAPGET = 4204L;
        public static readonly long SYS_CAPSET = 4205L;
        public static readonly long SYS_SIGALTSTACK = 4206L;
        public static readonly long SYS_SENDFILE = 4207L;
        public static readonly long SYS_GETPMSG = 4208L;
        public static readonly long SYS_PUTPMSG = 4209L;
        public static readonly long SYS_MMAP2 = 4210L;
        public static readonly long SYS_TRUNCATE64 = 4211L;
        public static readonly long SYS_FTRUNCATE64 = 4212L;
        public static readonly long SYS_STAT64 = 4213L;
        public static readonly long SYS_LSTAT64 = 4214L;
        public static readonly long SYS_FSTAT64 = 4215L;
        public static readonly long SYS_PIVOT_ROOT = 4216L;
        public static readonly long SYS_MINCORE = 4217L;
        public static readonly long SYS_MADVISE = 4218L;
        public static readonly long SYS_GETDENTS64 = 4219L;
        public static readonly long SYS_FCNTL64 = 4220L;
        public static readonly long SYS_RESERVED221 = 4221L;
        public static readonly long SYS_GETTID = 4222L;
        public static readonly long SYS_READAHEAD = 4223L;
        public static readonly long SYS_SETXATTR = 4224L;
        public static readonly long SYS_LSETXATTR = 4225L;
        public static readonly long SYS_FSETXATTR = 4226L;
        public static readonly long SYS_GETXATTR = 4227L;
        public static readonly long SYS_LGETXATTR = 4228L;
        public static readonly long SYS_FGETXATTR = 4229L;
        public static readonly long SYS_LISTXATTR = 4230L;
        public static readonly long SYS_LLISTXATTR = 4231L;
        public static readonly long SYS_FLISTXATTR = 4232L;
        public static readonly long SYS_REMOVEXATTR = 4233L;
        public static readonly long SYS_LREMOVEXATTR = 4234L;
        public static readonly long SYS_FREMOVEXATTR = 4235L;
        public static readonly long SYS_TKILL = 4236L;
        public static readonly long SYS_SENDFILE64 = 4237L;
        public static readonly long SYS_FUTEX = 4238L;
        public static readonly long SYS_SCHED_SETAFFINITY = 4239L;
        public static readonly long SYS_SCHED_GETAFFINITY = 4240L;
        public static readonly long SYS_IO_SETUP = 4241L;
        public static readonly long SYS_IO_DESTROY = 4242L;
        public static readonly long SYS_IO_GETEVENTS = 4243L;
        public static readonly long SYS_IO_SUBMIT = 4244L;
        public static readonly long SYS_IO_CANCEL = 4245L;
        public static readonly long SYS_EXIT_GROUP = 4246L;
        public static readonly long SYS_LOOKUP_DCOOKIE = 4247L;
        public static readonly long SYS_EPOLL_CREATE = 4248L;
        public static readonly long SYS_EPOLL_CTL = 4249L;
        public static readonly long SYS_EPOLL_WAIT = 4250L;
        public static readonly long SYS_REMAP_FILE_PAGES = 4251L;
        public static readonly long SYS_SET_TID_ADDRESS = 4252L;
        public static readonly long SYS_RESTART_SYSCALL = 4253L;
        public static readonly long SYS_FADVISE64 = 4254L;
        public static readonly long SYS_STATFS64 = 4255L;
        public static readonly long SYS_FSTATFS64 = 4256L;
        public static readonly long SYS_TIMER_CREATE = 4257L;
        public static readonly long SYS_TIMER_SETTIME = 4258L;
        public static readonly long SYS_TIMER_GETTIME = 4259L;
        public static readonly long SYS_TIMER_GETOVERRUN = 4260L;
        public static readonly long SYS_TIMER_DELETE = 4261L;
        public static readonly long SYS_CLOCK_SETTIME = 4262L;
        public static readonly long SYS_CLOCK_GETTIME = 4263L;
        public static readonly long SYS_CLOCK_GETRES = 4264L;
        public static readonly long SYS_CLOCK_NANOSLEEP = 4265L;
        public static readonly long SYS_TGKILL = 4266L;
        public static readonly long SYS_UTIMES = 4267L;
        public static readonly long SYS_MBIND = 4268L;
        public static readonly long SYS_GET_MEMPOLICY = 4269L;
        public static readonly long SYS_SET_MEMPOLICY = 4270L;
        public static readonly long SYS_MQ_OPEN = 4271L;
        public static readonly long SYS_MQ_UNLINK = 4272L;
        public static readonly long SYS_MQ_TIMEDSEND = 4273L;
        public static readonly long SYS_MQ_TIMEDRECEIVE = 4274L;
        public static readonly long SYS_MQ_NOTIFY = 4275L;
        public static readonly long SYS_MQ_GETSETATTR = 4276L;
        public static readonly long SYS_VSERVER = 4277L;
        public static readonly long SYS_WAITID = 4278L;
        public static readonly long SYS_ADD_KEY = 4280L;
        public static readonly long SYS_REQUEST_KEY = 4281L;
        public static readonly long SYS_KEYCTL = 4282L;
        public static readonly long SYS_SET_THREAD_AREA = 4283L;
        public static readonly long SYS_INOTIFY_INIT = 4284L;
        public static readonly long SYS_INOTIFY_ADD_WATCH = 4285L;
        public static readonly long SYS_INOTIFY_RM_WATCH = 4286L;
        public static readonly long SYS_MIGRATE_PAGES = 4287L;
        public static readonly long SYS_OPENAT = 4288L;
        public static readonly long SYS_MKDIRAT = 4289L;
        public static readonly long SYS_MKNODAT = 4290L;
        public static readonly long SYS_FCHOWNAT = 4291L;
        public static readonly long SYS_FUTIMESAT = 4292L;
        public static readonly long SYS_FSTATAT64 = 4293L;
        public static readonly long SYS_UNLINKAT = 4294L;
        public static readonly long SYS_RENAMEAT = 4295L;
        public static readonly long SYS_LINKAT = 4296L;
        public static readonly long SYS_SYMLINKAT = 4297L;
        public static readonly long SYS_READLINKAT = 4298L;
        public static readonly long SYS_FCHMODAT = 4299L;
        public static readonly long SYS_FACCESSAT = 4300L;
        public static readonly long SYS_PSELECT6 = 4301L;
        public static readonly long SYS_PPOLL = 4302L;
        public static readonly long SYS_UNSHARE = 4303L;
        public static readonly long SYS_SPLICE = 4304L;
        public static readonly long SYS_SYNC_FILE_RANGE = 4305L;
        public static readonly long SYS_TEE = 4306L;
        public static readonly long SYS_VMSPLICE = 4307L;
        public static readonly long SYS_MOVE_PAGES = 4308L;
        public static readonly long SYS_SET_ROBUST_LIST = 4309L;
        public static readonly long SYS_GET_ROBUST_LIST = 4310L;
        public static readonly long SYS_KEXEC_LOAD = 4311L;
        public static readonly long SYS_GETCPU = 4312L;
        public static readonly long SYS_EPOLL_PWAIT = 4313L;
        public static readonly long SYS_IOPRIO_SET = 4314L;
        public static readonly long SYS_IOPRIO_GET = 4315L;
        public static readonly long SYS_UTIMENSAT = 4316L;
        public static readonly long SYS_SIGNALFD = 4317L;
        public static readonly long SYS_TIMERFD = 4318L;
        public static readonly long SYS_EVENTFD = 4319L;
        public static readonly long SYS_FALLOCATE = 4320L;
        public static readonly long SYS_TIMERFD_CREATE = 4321L;
        public static readonly long SYS_TIMERFD_GETTIME = 4322L;
        public static readonly long SYS_TIMERFD_SETTIME = 4323L;
        public static readonly long SYS_SIGNALFD4 = 4324L;
        public static readonly long SYS_EVENTFD2 = 4325L;
        public static readonly long SYS_EPOLL_CREATE1 = 4326L;
        public static readonly long SYS_DUP3 = 4327L;
        public static readonly long SYS_PIPE2 = 4328L;
        public static readonly long SYS_INOTIFY_INIT1 = 4329L;
        public static readonly long SYS_PREADV = 4330L;
        public static readonly long SYS_PWRITEV = 4331L;
        public static readonly long SYS_RT_TGSIGQUEUEINFO = 4332L;
        public static readonly long SYS_PERF_EVENT_OPEN = 4333L;
        public static readonly long SYS_ACCEPT4 = 4334L;
        public static readonly long SYS_RECVMMSG = 4335L;
        public static readonly long SYS_FANOTIFY_INIT = 4336L;
        public static readonly long SYS_FANOTIFY_MARK = 4337L;
        public static readonly long SYS_PRLIMIT64 = 4338L;
        public static readonly long SYS_NAME_TO_HANDLE_AT = 4339L;
        public static readonly long SYS_OPEN_BY_HANDLE_AT = 4340L;
        public static readonly long SYS_CLOCK_ADJTIME = 4341L;
        public static readonly long SYS_SYNCFS = 4342L;
        public static readonly long SYS_SENDMMSG = 4343L;
        public static readonly long SYS_SETNS = 4344L;
        public static readonly long SYS_PROCESS_VM_READV = 4345L;
        public static readonly long SYS_PROCESS_VM_WRITEV = 4346L;
        public static readonly long SYS_LINUX_SYSCALLS = 4346L;
        public static readonly long SYS_O32_LINUX_SYSCALLS = 4346L;
        public static readonly long SYS_64_LINUX_SYSCALLS = 4305L;
        public static readonly long SYS_N32_LINUX_SYSCALLS = 4310L;
    }
}