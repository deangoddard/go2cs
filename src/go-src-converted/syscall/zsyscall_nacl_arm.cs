// mksyscall.pl -l32 -nacl -arm -tags nacl,arm syscall_nacl.go syscall_nacl_arm.go
// MACHINE GENERATED BY THE COMMAND ABOVE; DO NOT EDIT

// +build nacl,arm

// package syscall -- go2cs converted at 2020 August 29 08:41:06 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\zsyscall_nacl_arm.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT
        private static error naclClose(long fd)
        {
            var (_, _, e1) = Syscall(sys_close, uintptr(fd), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }
            return;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error naclFstat(long fd, ref Stat_t stat)
        {
            var (_, _, e1) = Syscall(sys_fstat, uintptr(fd), uintptr(@unsafe.Pointer(stat)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }
            return;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) naclRead(long fd, slice<byte> b)
        {
            unsafe.Pointer _p0 = default;
            if (len(b) > 0L)
            {
                _p0 = @unsafe.Pointer(ref b[0L]);
            }
            else
            {
                _p0 = @unsafe.Pointer(ref _zero);
            }
            var (r0, _, e1) = Syscall(sys_read, uintptr(fd), uintptr(_p0), uintptr(len(b)));
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }
            return;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error naclSeek(long fd, ref long off, long whence)
        {
            var (_, _, e1) = Syscall(sys_lseek, uintptr(fd), uintptr(@unsafe.Pointer(off)), uintptr(whence));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }
            return;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error naclGetRandomBytes(slice<byte> b)
        {
            unsafe.Pointer _p0 = default;
            if (len(b) > 0L)
            {
                _p0 = @unsafe.Pointer(ref b[0L]);
            }
            else
            {
                _p0 = @unsafe.Pointer(ref _zero);
            }
            var (_, _, e1) = Syscall(sys_get_random_bytes, uintptr(_p0), uintptr(len(b)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }
            return;
        }
    }
}
