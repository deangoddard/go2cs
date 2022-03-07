// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package net -- go2cs converted at 2022 March 06 22:16:45 UTC
// import "net" ==> using net = go.net_package
// Original source: C:\Program Files\Go\src\net\tcpsockopt_darwin.go
using runtime = go.runtime_package;
using syscall = go.syscall_package;
using time = go.time_package;

namespace go;

public static partial class net_package {

    // syscall.TCP_KEEPINTVL is missing on some darwin architectures.
private static readonly nuint sysTCP_KEEPINTVL = 0x101;



private static error setKeepAlivePeriod(ptr<netFD> _addr_fd, time.Duration d) {
    ref netFD fd = ref _addr_fd.val;
 
    // The kernel expects seconds so round to next highest second.
    var secs = int(roundDurationUp(d, time.Second));
    {
        var err__prev1 = err;

        var err = fd.pfd.SetsockoptInt(syscall.IPPROTO_TCP, sysTCP_KEEPINTVL, secs);

        if (err != null) {
            return error.As(wrapSyscallError("setsockopt", err))!;
        }
        err = err__prev1;

    }

    err = fd.pfd.SetsockoptInt(syscall.IPPROTO_TCP, syscall.TCP_KEEPALIVE, secs);
    runtime.KeepAlive(fd);
    return error.As(wrapSyscallError("setsockopt", err))!;

}

} // end net_package
