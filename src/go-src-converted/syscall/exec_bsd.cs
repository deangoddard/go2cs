// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build darwin dragonfly freebsd netbsd openbsd

// package syscall -- go2cs converted at 2020 August 29 08:36:51 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\exec_bsd.go
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        public partial struct SysProcAttr
        {
            public @string Chroot; // Chroot.
            public ptr<Credential> Credential; // Credential.
            public bool Ptrace; // Enable tracing.
            public bool Setsid; // Create session.
            public bool Setpgid; // Set process group ID to Pgid, or, if Pgid == 0, to new pid.
            public bool Setctty; // Set controlling terminal to fd Ctty
            public bool Noctty; // Detach fd 0 from controlling terminal
            public long Ctty; // Controlling TTY fd
            public bool Foreground; // Place child's process group in foreground. (Implies Setpgid. Uses Ctty as fd of controlling TTY)
            public long Pgid; // Child's process group ID if Setpgid.
        }

        // Implemented in runtime package.
        private static void runtime_BeforeFork()
;
        private static void runtime_AfterFork()
;
        private static void runtime_AfterForkInChild()
;

        // Fork, dup fd onto 0..len(fd), and exec(argv0, argvv, envv) in child.
        // If a dup or exec fails, write the errno error to pipe.
        // (Pipe is close-on-exec so if exec succeeds, it will be closed.)
        // In the child, this function must not acquire any locks, because
        // they might have been locked at the time of the fork. This means
        // no rescheduling, no malloc calls, and no new stack segments.
        // For the same reason compiler does not race instrument it.
        // The calls to RawSyscall are okay because they are assembly
        // functions that do not grow the stack.
        //go:norace
        private static (long, Errno) forkAndExecInChild(ref byte argv0, slice<ref byte> argv, slice<ref byte> envv, ref byte chroot, ref byte dir, ref ProcAttr attr, ref SysProcAttr sys, long pipe)
        { 
            // Declare all variables at top in case any
            // declarations require heap allocation (e.g., err1).
            System.UIntPtr r1 = default;            System.UIntPtr r2 = default;
            Errno err1 = default;            long nextfd = default;            long i = default; 

            // guard against side effects of shuffling fds below.
            // Make sure that nextfd is beyond any currently open files so
            // that we can't run the risk of overwriting any of them.
            var fd = make_slice<long>(len(attr.Files));
            nextfd = len(attr.Files);
            {
                long i__prev1 = i;

                foreach (var (__i, __ufd) in attr.Files)
                {
                    i = __i;
                    ufd = __ufd;
                    if (nextfd < int(ufd))
                    {>>MARKER:FUNCTION_runtime_AfterForkInChild_BLOCK_PREFIX<<
                        nextfd = int(ufd);
                    }
                    fd[i] = int(ufd);
                }

                i = i__prev1;
            }

            nextfd++;

            var darwin = runtime.GOOS == "darwin"; 

            // About to call fork.
            // No more allocation or calls of non-assembly functions.
            runtime_BeforeFork();
            r1, r2, err1 = RawSyscall(SYS_FORK, 0L, 0L, 0L);
            if (err1 != 0L)
            {>>MARKER:FUNCTION_runtime_AfterFork_BLOCK_PREFIX<<
                runtime_AfterFork();
                return (0L, err1);
            } 

            // On Darwin:
            //    r1 = child pid in both parent and child.
            //    r2 = 0 in parent, 1 in child.
            // Convert to normal Unix r1 = 0 in child.
            if (darwin && r2 == 1L)
            {>>MARKER:FUNCTION_runtime_BeforeFork_BLOCK_PREFIX<<
                r1 = 0L;
            }
            if (r1 != 0L)
            { 
                // parent; return PID
                runtime_AfterFork();
                return (int(r1), 0L);
            } 

            // Fork succeeded, now in child.
            runtime_AfterForkInChild(); 

            // Enable tracing if requested.
            if (sys.Ptrace)
            {
                _, _, err1 = RawSyscall(SYS_PTRACE, uintptr(PTRACE_TRACEME), 0L, 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // Session ID
            if (sys.Setsid)
            {
                _, _, err1 = RawSyscall(SYS_SETSID, 0L, 0L, 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // Set process group
            if (sys.Setpgid || sys.Foreground)
            { 
                // Place child in process group.
                _, _, err1 = RawSyscall(SYS_SETPGID, 0L, uintptr(sys.Pgid), 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            }
            if (sys.Foreground)
            {
                var pgrp = sys.Pgid;
                if (pgrp == 0L)
                {
                    r1, _, err1 = RawSyscall(SYS_GETPID, 0L, 0L, 0L);
                    if (err1 != 0L)
                    {
                        goto childerror;
                    }
                    pgrp = int(r1);
                } 

                // Place process group in foreground.
                _, _, err1 = RawSyscall(SYS_IOCTL, uintptr(sys.Ctty), uintptr(TIOCSPGRP), uintptr(@unsafe.Pointer(ref pgrp)));
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // Chroot
            if (chroot != null)
            {
                _, _, err1 = RawSyscall(SYS_CHROOT, uintptr(@unsafe.Pointer(chroot)), 0L, 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // User and groups
            {
                var cred = sys.Credential;

                if (cred != null)
                {
                    var ngroups = uintptr(len(cred.Groups));
                    var groups = uintptr(0L);
                    if (ngroups > 0L)
                    {
                        groups = uintptr(@unsafe.Pointer(ref cred.Groups[0L]));
                    }
                    if (!cred.NoSetGroups)
                    {
                        _, _, err1 = RawSyscall(SYS_SETGROUPS, ngroups, groups, 0L);
                        if (err1 != 0L)
                        {
                            goto childerror;
                        }
                    }
                    _, _, err1 = RawSyscall(SYS_SETGID, uintptr(cred.Gid), 0L, 0L);
                    if (err1 != 0L)
                    {
                        goto childerror;
                    }
                    _, _, err1 = RawSyscall(SYS_SETUID, uintptr(cred.Uid), 0L, 0L);
                    if (err1 != 0L)
                    {
                        goto childerror;
                    }
                } 

                // Chdir

            } 

            // Chdir
            if (dir != null)
            {
                _, _, err1 = RawSyscall(SYS_CHDIR, uintptr(@unsafe.Pointer(dir)), 0L, 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // Pass 1: look for fd[i] < i and move those up above len(fd)
            // so that pass 2 won't stomp on an fd it needs later.
            if (pipe < nextfd)
            {
                _, _, err1 = RawSyscall(SYS_DUP2, uintptr(pipe), uintptr(nextfd), 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
                RawSyscall(SYS_FCNTL, uintptr(nextfd), F_SETFD, FD_CLOEXEC);
                pipe = nextfd;
                nextfd++;
            }
            for (i = 0L; i < len(fd); i++)
            {
                if (fd[i] >= 0L && fd[i] < int(i))
                {
                    if (nextfd == pipe)
                    { // don't stomp on pipe
                        nextfd++;
                    }
                    _, _, err1 = RawSyscall(SYS_DUP2, uintptr(fd[i]), uintptr(nextfd), 0L);
                    if (err1 != 0L)
                    {
                        goto childerror;
                    }
                    RawSyscall(SYS_FCNTL, uintptr(nextfd), F_SETFD, FD_CLOEXEC);
                    fd[i] = nextfd;
                    nextfd++;
                }
            } 

            // Pass 2: dup fd[i] down onto i.
 

            // Pass 2: dup fd[i] down onto i.
            for (i = 0L; i < len(fd); i++)
            {
                if (fd[i] == -1L)
                {
                    RawSyscall(SYS_CLOSE, uintptr(i), 0L, 0L);
                    continue;
                }
                if (fd[i] == int(i))
                { 
                    // dup2(i, i) won't clear close-on-exec flag on Linux,
                    // probably not elsewhere either.
                    _, _, err1 = RawSyscall(SYS_FCNTL, uintptr(fd[i]), F_SETFD, 0L);
                    if (err1 != 0L)
                    {
                        goto childerror;
                    }
                    continue;
                } 
                // The new fd is created NOT close-on-exec,
                // which is exactly what we want.
                _, _, err1 = RawSyscall(SYS_DUP2, uintptr(fd[i]), uintptr(i), 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // By convention, we don't close-on-exec the fds we are
            // started with, so if len(fd) < 3, close 0, 1, 2 as needed.
            // Programs that know they inherit fds >= 3 will need
            // to set them close-on-exec.
 

            // By convention, we don't close-on-exec the fds we are
            // started with, so if len(fd) < 3, close 0, 1, 2 as needed.
            // Programs that know they inherit fds >= 3 will need
            // to set them close-on-exec.
            for (i = len(fd); i < 3L; i++)
            {
                RawSyscall(SYS_CLOSE, uintptr(i), 0L, 0L);
            } 

            // Detach fd 0 from tty
 

            // Detach fd 0 from tty
            if (sys.Noctty)
            {
                _, _, err1 = RawSyscall(SYS_IOCTL, 0L, uintptr(TIOCNOTTY), 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // Set the controlling TTY to Ctty
            if (sys.Setctty)
            {
                _, _, err1 = RawSyscall(SYS_IOCTL, uintptr(sys.Ctty), uintptr(TIOCSCTTY), 0L);
                if (err1 != 0L)
                {
                    goto childerror;
                }
            } 

            // Time to exec.
            _, _, err1 = RawSyscall(SYS_EXECVE, uintptr(@unsafe.Pointer(argv0)), uintptr(@unsafe.Pointer(ref argv[0L])), uintptr(@unsafe.Pointer(ref envv[0L])));

childerror:
            RawSyscall(SYS_WRITE, uintptr(pipe), uintptr(@unsafe.Pointer(ref err1)), @unsafe.Sizeof(err1));
            while (true)
            {
                RawSyscall(SYS_EXIT, 253L, 0L, 0L);
            }

        }
    }
}
