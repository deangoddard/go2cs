// go run mksyscall.go -tags linux,riscv64 syscall_linux.go syscall_linux_riscv64.go
// Code generated by the command above; see README.md. DO NOT EDIT.

//go:build linux && riscv64
// +build linux,riscv64

// package unix -- go2cs converted at 2022 March 06 23:29:24 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Program Files\Go\src\cmd\vendor\golang.org\x\sys\unix\zsyscall_linux_riscv64.go
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;

namespace go.cmd.vendor.golang.org.x.sys;

public static partial class unix_package {

private static syscall.Errno _ = default;

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error fanotifyMark(nint fd, nuint flags, ulong mask, nint dirFd, ptr<byte> _addr_pathname) {
    error err = default!;
    ref byte pathname = ref _addr_pathname.val;

    var (_, _, e1) = Syscall6(SYS_FANOTIFY_MARK, uintptr(fd), uintptr(flags), uintptr(mask), uintptr(dirFd), uintptr(@unsafe.Pointer(pathname)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Fallocate(nint fd, uint mode, long off, long len) {
    error err = default!;

    var (_, _, e1) = Syscall6(SYS_FALLOCATE, uintptr(fd), uintptr(mode), uintptr(off), uintptr(len), 0, 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static (long, error) Tee(nint rfd, nint wfd, nint len, nint flags) {
    long n = default;
    error err = default!;

    var (r0, _, e1) = Syscall6(SYS_TEE, uintptr(rfd), uintptr(wfd), uintptr(len), uintptr(flags), 0, 0);
    n = int64(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static (nint, error) EpollWait(nint epfd, slice<EpollEvent> events, nint msec) {
    nint n = default;
    error err = default!;

    unsafe.Pointer _p0 = default;
    if (len(events) > 0) {
        _p0 = @unsafe.Pointer(_addr_events[0]);
    }
    else
 {
        _p0 = @unsafe.Pointer(_addr__zero);
    }
    var (r0, _, e1) = Syscall6(SYS_EPOLL_PWAIT, uintptr(epfd), uintptr(_p0), uintptr(len(events)), uintptr(msec), 0, 0);
    n = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Fadvise(nint fd, long offset, long length, nint advice) {
    error err = default!;

    var (_, _, e1) = Syscall6(SYS_FADVISE64, uintptr(fd), uintptr(offset), uintptr(length), uintptr(advice), 0, 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Fchown(nint fd, nint uid, nint gid) {
    error err = default!;

    var (_, _, e1) = Syscall(SYS_FCHOWN, uintptr(fd), uintptr(uid), uintptr(gid));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Fstat(nint fd, ptr<Stat_t> _addr_stat) {
    error err = default!;
    ref Stat_t stat = ref _addr_stat.val;

    var (_, _, e1) = Syscall(SYS_FSTAT, uintptr(fd), uintptr(@unsafe.Pointer(stat)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Fstatat(nint fd, @string path, ptr<Stat_t> _addr_stat, nint flags) {
    error err = default!;
    ref Stat_t stat = ref _addr_stat.val;

    ptr<byte> _p0;
    _p0, err = BytePtrFromString(path);
    if (err != null) {
        return ;
    }
    var (_, _, e1) = Syscall6(SYS_FSTATAT, uintptr(fd), uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(stat)), uintptr(flags), 0, 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Fstatfs(nint fd, ptr<Statfs_t> _addr_buf) {
    error err = default!;
    ref Statfs_t buf = ref _addr_buf.val;

    var (_, _, e1) = Syscall(SYS_FSTATFS, uintptr(fd), uintptr(@unsafe.Pointer(buf)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Ftruncate(nint fd, long length) {
    error err = default!;

    var (_, _, e1) = Syscall(SYS_FTRUNCATE, uintptr(fd), uintptr(length), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static nint Getegid() {
    nint egid = default;

    var (r0, _) = RawSyscallNoError(SYS_GETEGID, 0, 0, 0);
    egid = int(r0);
    return ;
}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static nint Geteuid() {
    nint euid = default;

    var (r0, _) = RawSyscallNoError(SYS_GETEUID, 0, 0, 0);
    euid = int(r0);
    return ;
}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static nint Getgid() {
    nint gid = default;

    var (r0, _) = RawSyscallNoError(SYS_GETGID, 0, 0, 0);
    gid = int(r0);
    return ;
}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Getrlimit(nint resource, ptr<Rlimit> _addr_rlim) {
    error err = default!;
    ref Rlimit rlim = ref _addr_rlim.val;

    var (_, _, e1) = RawSyscall(SYS_GETRLIMIT, uintptr(resource), uintptr(@unsafe.Pointer(rlim)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static nint Getuid() {
    nint uid = default;

    var (r0, _) = RawSyscallNoError(SYS_GETUID, 0, 0, 0);
    uid = int(r0);
    return ;
}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Listen(nint s, nint n) {
    error err = default!;

    var (_, _, e1) = Syscall(SYS_LISTEN, uintptr(s), uintptr(n), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static (nint, error) Pread(nint fd, slice<byte> p, long offset) {
    nint n = default;
    error err = default!;

    unsafe.Pointer _p0 = default;
    if (len(p) > 0) {
        _p0 = @unsafe.Pointer(_addr_p[0]);
    }
    else
 {
        _p0 = @unsafe.Pointer(_addr__zero);
    }
    var (r0, _, e1) = Syscall6(SYS_PREAD64, uintptr(fd), uintptr(_p0), uintptr(len(p)), uintptr(offset), 0, 0);
    n = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static (nint, error) Pwrite(nint fd, slice<byte> p, long offset) {
    nint n = default;
    error err = default!;

    unsafe.Pointer _p0 = default;
    if (len(p) > 0) {
        _p0 = @unsafe.Pointer(_addr_p[0]);
    }
    else
 {
        _p0 = @unsafe.Pointer(_addr__zero);
    }
    var (r0, _, e1) = Syscall6(SYS_PWRITE64, uintptr(fd), uintptr(_p0), uintptr(len(p)), uintptr(offset), 0, 0);
    n = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static (long, error) Seek(nint fd, long offset, nint whence) {
    long off = default;
    error err = default!;

    var (r0, _, e1) = Syscall(SYS_LSEEK, uintptr(fd), uintptr(offset), uintptr(whence));
    off = int64(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) sendfile(nint outfd, nint infd, ptr<long> _addr_offset, nint count) {
    nint written = default;
    error err = default!;
    ref long offset = ref _addr_offset.val;

    var (r0, _, e1) = Syscall6(SYS_SENDFILE, uintptr(outfd), uintptr(infd), uintptr(@unsafe.Pointer(offset)), uintptr(count), 0, 0);
    written = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) setfsgid(nint gid) {
    nint prev = default;
    error err = default!;

    var (r0, _, e1) = Syscall(SYS_SETFSGID, uintptr(gid), 0, 0);
    prev = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) setfsuid(nint uid) {
    nint prev = default;
    error err = default!;

    var (r0, _, e1) = Syscall(SYS_SETFSUID, uintptr(uid), 0, 0);
    prev = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Setregid(nint rgid, nint egid) {
    error err = default!;

    var (_, _, e1) = RawSyscall(SYS_SETREGID, uintptr(rgid), uintptr(egid), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Setresgid(nint rgid, nint egid, nint sgid) {
    error err = default!;

    var (_, _, e1) = RawSyscall(SYS_SETRESGID, uintptr(rgid), uintptr(egid), uintptr(sgid));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Setresuid(nint ruid, nint euid, nint suid) {
    error err = default!;

    var (_, _, e1) = RawSyscall(SYS_SETRESUID, uintptr(ruid), uintptr(euid), uintptr(suid));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Setrlimit(nint resource, ptr<Rlimit> _addr_rlim) {
    error err = default!;
    ref Rlimit rlim = ref _addr_rlim.val;

    var (_, _, e1) = RawSyscall(SYS_SETRLIMIT, uintptr(resource), uintptr(@unsafe.Pointer(rlim)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Setreuid(nint ruid, nint euid) {
    error err = default!;

    var (_, _, e1) = RawSyscall(SYS_SETREUID, uintptr(ruid), uintptr(euid), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Shutdown(nint fd, nint how) {
    error err = default!;

    var (_, _, e1) = Syscall(SYS_SHUTDOWN, uintptr(fd), uintptr(how), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static (long, error) Splice(nint rfd, ptr<long> _addr_roff, nint wfd, ptr<long> _addr_woff, nint len, nint flags) {
    long n = default;
    error err = default!;
    ref long roff = ref _addr_roff.val;
    ref long woff = ref _addr_woff.val;

    var (r0, _, e1) = Syscall6(SYS_SPLICE, uintptr(rfd), uintptr(@unsafe.Pointer(roff)), uintptr(wfd), uintptr(@unsafe.Pointer(woff)), uintptr(len), uintptr(flags));
    n = int64(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Statfs(@string path, ptr<Statfs_t> _addr_buf) {
    error err = default!;
    ref Statfs_t buf = ref _addr_buf.val;

    ptr<byte> _p0;
    _p0, err = BytePtrFromString(path);
    if (err != null) {
        return ;
    }
    var (_, _, e1) = Syscall(SYS_STATFS, uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(buf)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error SyncFileRange(nint fd, long off, long n, nint flags) {
    error err = default!;

    var (_, _, e1) = Syscall6(SYS_SYNC_FILE_RANGE, uintptr(fd), uintptr(off), uintptr(n), uintptr(flags), 0, 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Truncate(@string path, long length) {
    error err = default!;

    ptr<byte> _p0;
    _p0, err = BytePtrFromString(path);
    if (err != null) {
        return ;
    }
    var (_, _, e1) = Syscall(SYS_TRUNCATE, uintptr(@unsafe.Pointer(_p0)), uintptr(length), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) accept(nint s, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen) {
    nint fd = default;
    error err = default!;
    ref RawSockaddrAny rsa = ref _addr_rsa.val;
    ref _Socklen addrlen = ref _addr_addrlen.val;

    var (r0, _, e1) = Syscall(SYS_ACCEPT, uintptr(s), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)));
    fd = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) accept4(nint s, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen, nint flags) {
    nint fd = default;
    error err = default!;
    ref RawSockaddrAny rsa = ref _addr_rsa.val;
    ref _Socklen addrlen = ref _addr_addrlen.val;

    var (r0, _, e1) = Syscall6(SYS_ACCEPT4, uintptr(s), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)), uintptr(flags), 0, 0);
    fd = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error bind(nint s, unsafe.Pointer addr, _Socklen addrlen) {
    error err = default!;

    var (_, _, e1) = Syscall(SYS_BIND, uintptr(s), uintptr(addr), uintptr(addrlen));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error connect(nint s, unsafe.Pointer addr, _Socklen addrlen) {
    error err = default!;

    var (_, _, e1) = Syscall(SYS_CONNECT, uintptr(s), uintptr(addr), uintptr(addrlen));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) getgroups(nint n, ptr<_Gid_t> _addr_list) {
    nint nn = default;
    error err = default!;
    ref _Gid_t list = ref _addr_list.val;

    var (r0, _, e1) = RawSyscall(SYS_GETGROUPS, uintptr(n), uintptr(@unsafe.Pointer(list)), 0);
    nn = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error setgroups(nint n, ptr<_Gid_t> _addr_list) {
    error err = default!;
    ref _Gid_t list = ref _addr_list.val;

    var (_, _, e1) = RawSyscall(SYS_SETGROUPS, uintptr(n), uintptr(@unsafe.Pointer(list)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error getsockopt(nint s, nint level, nint name, unsafe.Pointer val, ptr<_Socklen> _addr_vallen) {
    error err = default!;
    ref _Socklen vallen = ref _addr_vallen.val;

    var (_, _, e1) = Syscall6(SYS_GETSOCKOPT, uintptr(s), uintptr(level), uintptr(name), uintptr(val), uintptr(@unsafe.Pointer(vallen)), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error setsockopt(nint s, nint level, nint name, unsafe.Pointer val, System.UIntPtr vallen) {
    error err = default!;

    var (_, _, e1) = Syscall6(SYS_SETSOCKOPT, uintptr(s), uintptr(level), uintptr(name), uintptr(val), uintptr(vallen), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) socket(nint domain, nint typ, nint proto) {
    nint fd = default;
    error err = default!;

    var (r0, _, e1) = RawSyscall(SYS_SOCKET, uintptr(domain), uintptr(typ), uintptr(proto));
    fd = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error socketpair(nint domain, nint typ, nint proto, ptr<array<int>> _addr_fd) {
    error err = default!;
    ref array<int> fd = ref _addr_fd.val;

    var (_, _, e1) = RawSyscall6(SYS_SOCKETPAIR, uintptr(domain), uintptr(typ), uintptr(proto), uintptr(@unsafe.Pointer(fd)), 0, 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error getpeername(nint fd, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen) {
    error err = default!;
    ref RawSockaddrAny rsa = ref _addr_rsa.val;
    ref _Socklen addrlen = ref _addr_addrlen.val;

    var (_, _, e1) = RawSyscall(SYS_GETPEERNAME, uintptr(fd), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error getsockname(nint fd, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen) {
    error err = default!;
    ref RawSockaddrAny rsa = ref _addr_rsa.val;
    ref _Socklen addrlen = ref _addr_addrlen.val;

    var (_, _, e1) = RawSyscall(SYS_GETSOCKNAME, uintptr(fd), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) recvfrom(nint fd, slice<byte> p, nint flags, ptr<RawSockaddrAny> _addr_from, ptr<_Socklen> _addr_fromlen) {
    nint n = default;
    error err = default!;
    ref RawSockaddrAny from = ref _addr_from.val;
    ref _Socklen fromlen = ref _addr_fromlen.val;

    unsafe.Pointer _p0 = default;
    if (len(p) > 0) {
        _p0 = @unsafe.Pointer(_addr_p[0]);
    }
    else
 {
        _p0 = @unsafe.Pointer(_addr__zero);
    }
    var (r0, _, e1) = Syscall6(SYS_RECVFROM, uintptr(fd), uintptr(_p0), uintptr(len(p)), uintptr(flags), uintptr(@unsafe.Pointer(from)), uintptr(@unsafe.Pointer(fromlen)));
    n = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error sendto(nint s, slice<byte> buf, nint flags, unsafe.Pointer to, _Socklen addrlen) {
    error err = default!;

    unsafe.Pointer _p0 = default;
    if (len(buf) > 0) {
        _p0 = @unsafe.Pointer(_addr_buf[0]);
    }
    else
 {
        _p0 = @unsafe.Pointer(_addr__zero);
    }
    var (_, _, e1) = Syscall6(SYS_SENDTO, uintptr(s), uintptr(_p0), uintptr(len(buf)), uintptr(flags), uintptr(to), uintptr(addrlen));
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) recvmsg(nint s, ptr<Msghdr> _addr_msg, nint flags) {
    nint n = default;
    error err = default!;
    ref Msghdr msg = ref _addr_msg.val;

    var (r0, _, e1) = Syscall(SYS_RECVMSG, uintptr(s), uintptr(@unsafe.Pointer(msg)), uintptr(flags));
    n = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (nint, error) sendmsg(nint s, ptr<Msghdr> _addr_msg, nint flags) {
    nint n = default;
    error err = default!;
    ref Msghdr msg = ref _addr_msg.val;

    var (r0, _, e1) = Syscall(SYS_SENDMSG, uintptr(s), uintptr(@unsafe.Pointer(msg)), uintptr(flags));
    n = int(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static (System.UIntPtr, error) mmap(System.UIntPtr addr, System.UIntPtr length, nint prot, nint flags, nint fd, long offset) {
    System.UIntPtr xaddr = default;
    error err = default!;

    var (r0, _, e1) = Syscall6(SYS_MMAP, uintptr(addr), uintptr(length), uintptr(prot), uintptr(flags), uintptr(fd), uintptr(offset));
    xaddr = uintptr(r0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

public static error Gettimeofday(ptr<Timeval> _addr_tv) {
    error err = default!;
    ref Timeval tv = ref _addr_tv.val;

    var (_, _, e1) = RawSyscall(SYS_GETTIMEOFDAY, uintptr(@unsafe.Pointer(tv)), 0, 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

// THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

private static error kexecFileLoad(nint kernelFd, nint initrdFd, nint cmdlineLen, @string cmdline, nint flags) {
    error err = default!;

    ptr<byte> _p0;
    _p0, err = BytePtrFromString(cmdline);
    if (err != null) {
        return ;
    }
    var (_, _, e1) = Syscall6(SYS_KEXEC_FILE_LOAD, uintptr(kernelFd), uintptr(initrdFd), uintptr(cmdlineLen), uintptr(@unsafe.Pointer(_p0)), uintptr(flags), 0);
    if (e1 != 0) {
        err = errnoErr(e1);
    }
    return ;

}

} // end unix_package
