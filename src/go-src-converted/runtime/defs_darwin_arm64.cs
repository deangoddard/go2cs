// created by cgo -cdefs and then converted to Go
// cgo -cdefs defs_darwin.go

// package runtime -- go2cs converted at 2020 August 29 08:16:44 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\defs_darwin_arm64.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private static readonly ulong _EINTR = 0x4UL;
        private static readonly ulong _EFAULT = 0xeUL;

        private static readonly ulong _PROT_NONE = 0x0UL;
        private static readonly ulong _PROT_READ = 0x1UL;
        private static readonly ulong _PROT_WRITE = 0x2UL;
        private static readonly ulong _PROT_EXEC = 0x4UL;

        private static readonly ulong _MAP_ANON = 0x1000UL;
        private static readonly ulong _MAP_PRIVATE = 0x2UL;
        private static readonly ulong _MAP_FIXED = 0x10UL;

        private static readonly ulong _MADV_DONTNEED = 0x4UL;
        private static readonly ulong _MADV_FREE = 0x5UL;

        private static readonly ulong _MACH_MSG_TYPE_MOVE_RECEIVE = 0x10UL;
        private static readonly ulong _MACH_MSG_TYPE_MOVE_SEND = 0x11UL;
        private static readonly ulong _MACH_MSG_TYPE_MOVE_SEND_ONCE = 0x12UL;
        private static readonly ulong _MACH_MSG_TYPE_COPY_SEND = 0x13UL;
        private static readonly ulong _MACH_MSG_TYPE_MAKE_SEND = 0x14UL;
        private static readonly ulong _MACH_MSG_TYPE_MAKE_SEND_ONCE = 0x15UL;
        private static readonly ulong _MACH_MSG_TYPE_COPY_RECEIVE = 0x16UL;

        private static readonly ulong _MACH_MSG_PORT_DESCRIPTOR = 0x0UL;
        private static readonly ulong _MACH_MSG_OOL_DESCRIPTOR = 0x1UL;
        private static readonly ulong _MACH_MSG_OOL_PORTS_DESCRIPTOR = 0x2UL;
        private static readonly ulong _MACH_MSG_OOL_VOLATILE_DESCRIPTOR = 0x3UL;

        private static readonly ulong _MACH_MSGH_BITS_COMPLEX = 0x80000000UL;

        private static readonly ulong _MACH_SEND_MSG = 0x1UL;
        private static readonly ulong _MACH_RCV_MSG = 0x2UL;
        private static readonly ulong _MACH_RCV_LARGE = 0x4UL;

        private static readonly ulong _MACH_SEND_TIMEOUT = 0x10UL;
        private static readonly ulong _MACH_SEND_INTERRUPT = 0x40UL;
        private static readonly ulong _MACH_SEND_ALWAYS = 0x10000UL;
        private static readonly ulong _MACH_SEND_TRAILER = 0x20000UL;
        private static readonly ulong _MACH_RCV_TIMEOUT = 0x100UL;
        private static readonly ulong _MACH_RCV_NOTIFY = 0x200UL;
        private static readonly ulong _MACH_RCV_INTERRUPT = 0x400UL;
        private static readonly ulong _MACH_RCV_OVERWRITE = 0x1000UL;

        private static readonly ulong _NDR_PROTOCOL_2_0 = 0x0UL;
        private static readonly ulong _NDR_INT_BIG_ENDIAN = 0x0UL;
        private static readonly ulong _NDR_INT_LITTLE_ENDIAN = 0x1UL;
        private static readonly ulong _NDR_FLOAT_IEEE = 0x0UL;
        private static readonly ulong _NDR_CHAR_ASCII = 0x0UL;

        private static readonly ulong _SA_SIGINFO = 0x40UL;
        private static readonly ulong _SA_RESTART = 0x2UL;
        private static readonly ulong _SA_ONSTACK = 0x1UL;
        private static readonly ulong _SA_USERTRAMP = 0x100UL;
        private static readonly ulong _SA_64REGSET = 0x200UL;

        private static readonly ulong _SIGHUP = 0x1UL;
        private static readonly ulong _SIGINT = 0x2UL;
        private static readonly ulong _SIGQUIT = 0x3UL;
        private static readonly ulong _SIGILL = 0x4UL;
        private static readonly ulong _SIGTRAP = 0x5UL;
        private static readonly ulong _SIGABRT = 0x6UL;
        private static readonly ulong _SIGEMT = 0x7UL;
        private static readonly ulong _SIGFPE = 0x8UL;
        private static readonly ulong _SIGKILL = 0x9UL;
        private static readonly ulong _SIGBUS = 0xaUL;
        private static readonly ulong _SIGSEGV = 0xbUL;
        private static readonly ulong _SIGSYS = 0xcUL;
        private static readonly ulong _SIGPIPE = 0xdUL;
        private static readonly ulong _SIGALRM = 0xeUL;
        private static readonly ulong _SIGTERM = 0xfUL;
        private static readonly ulong _SIGURG = 0x10UL;
        private static readonly ulong _SIGSTOP = 0x11UL;
        private static readonly ulong _SIGTSTP = 0x12UL;
        private static readonly ulong _SIGCONT = 0x13UL;
        private static readonly ulong _SIGCHLD = 0x14UL;
        private static readonly ulong _SIGTTIN = 0x15UL;
        private static readonly ulong _SIGTTOU = 0x16UL;
        private static readonly ulong _SIGIO = 0x17UL;
        private static readonly ulong _SIGXCPU = 0x18UL;
        private static readonly ulong _SIGXFSZ = 0x19UL;
        private static readonly ulong _SIGVTALRM = 0x1aUL;
        private static readonly ulong _SIGPROF = 0x1bUL;
        private static readonly ulong _SIGWINCH = 0x1cUL;
        private static readonly ulong _SIGINFO = 0x1dUL;
        private static readonly ulong _SIGUSR1 = 0x1eUL;
        private static readonly ulong _SIGUSR2 = 0x1fUL;

        private static readonly ulong _FPE_INTDIV = 0x7UL;
        private static readonly ulong _FPE_INTOVF = 0x8UL;
        private static readonly ulong _FPE_FLTDIV = 0x1UL;
        private static readonly ulong _FPE_FLTOVF = 0x2UL;
        private static readonly ulong _FPE_FLTUND = 0x3UL;
        private static readonly ulong _FPE_FLTRES = 0x4UL;
        private static readonly ulong _FPE_FLTINV = 0x5UL;
        private static readonly ulong _FPE_FLTSUB = 0x6UL;

        private static readonly ulong _BUS_ADRALN = 0x1UL;
        private static readonly ulong _BUS_ADRERR = 0x2UL;
        private static readonly ulong _BUS_OBJERR = 0x3UL;

        private static readonly ulong _SEGV_MAPERR = 0x1UL;
        private static readonly ulong _SEGV_ACCERR = 0x2UL;

        private static readonly ulong _ITIMER_REAL = 0x0UL;
        private static readonly ulong _ITIMER_VIRTUAL = 0x1UL;
        private static readonly ulong _ITIMER_PROF = 0x2UL;

        private static readonly ulong _EV_ADD = 0x1UL;
        private static readonly ulong _EV_DELETE = 0x2UL;
        private static readonly ulong _EV_CLEAR = 0x20UL;
        private static readonly ulong _EV_RECEIPT = 0x40UL;
        private static readonly ulong _EV_ERROR = 0x4000UL;
        private static readonly ulong _EV_EOF = 0x8000UL;
        private static readonly ulong _EVFILT_READ = -0x1UL;
        private static readonly ulong _EVFILT_WRITE = -0x2UL;

        private partial struct machbody
        {
            public uint msgh_descriptor_count;
        }

        private partial struct machheader
        {
            public uint msgh_bits;
            public uint msgh_size;
            public uint msgh_remote_port;
            public uint msgh_local_port;
            public uint msgh_reserved;
            public int msgh_id;
        }

        private partial struct machndr
        {
            public byte mig_vers;
            public byte if_vers;
            public byte reserved1;
            public byte mig_encoding;
            public byte int_rep;
            public byte char_rep;
            public byte float_rep;
            public byte reserved2;
        }

        private partial struct machport
        {
            public uint name;
            public uint pad1;
            public ushort pad2;
            public byte disposition;
            public byte _type;
        }

        private partial struct stackt
        {
            public ptr<byte> ss_sp;
            public System.UIntPtr ss_size;
            public int ss_flags;
            public array<byte> pad_cgo_0;
        }

        private partial struct sigactiont
        {
            public array<byte> __sigaction_u;
            public unsafe.Pointer sa_tramp;
            public uint sa_mask;
            public int sa_flags;
        }

        private partial struct usigactiont
        {
            public array<byte> __sigaction_u;
            public uint sa_mask;
            public int sa_flags;
        }

        private partial struct siginfo
        {
            public int si_signo;
            public int si_errno;
            public int si_code;
            public int si_pid;
            public uint si_uid;
            public int si_status;
            public ptr<byte> si_addr;
            public array<byte> si_value;
            public long si_band;
            public array<ulong> __pad;
        }

        private partial struct timeval
        {
            public long tv_sec;
            public int tv_usec;
            public array<byte> pad_cgo_0;
        }

        private static void set_usec(this ref timeval tv, int x)
        {
            tv.tv_usec = x;
        }

        private partial struct itimerval
        {
            public timeval it_interval;
            public timeval it_value;
        }

        private partial struct timespec
        {
            public long tv_sec;
            public long tv_nsec;
        }

        private partial struct exceptionstate64
        {
            public ulong far; // virtual fault addr
            public uint esr; // exception syndrome
            public uint exc; // number of arm exception taken
        }

        private partial struct regs64
        {
            public array<ulong> x; // registers x0 to x28
            public ulong fp; // frame register, x29
            public ulong lr; // link register, x30
            public ulong sp; // stack pointer, x31
            public ulong pc; // program counter
            public uint cpsr; // current program status register
            public uint __pad;
        }

        private partial struct neonstate64
        {
            public array<ulong> v; // actually [32]uint128
            public uint fpsr;
            public uint fpcr;
        }

        private partial struct mcontext64
        {
            public exceptionstate64 es;
            public regs64 ss;
            public neonstate64 ns;
        }

        private partial struct ucontext
        {
            public int uc_onstack;
            public uint uc_sigmask;
            public stackt uc_stack;
            public ptr<ucontext> uc_link;
            public ulong uc_mcsize;
            public ptr<mcontext64> uc_mcontext;
        }

        private partial struct keventt
        {
            public ulong ident;
            public short filter;
            public ushort flags;
            public uint fflags;
            public long data;
            public ptr<byte> udata;
        }
    }
}
