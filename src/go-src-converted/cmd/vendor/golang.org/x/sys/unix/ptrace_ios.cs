// Copyright 2020 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

//go:build ios
// +build ios

// package unix -- go2cs converted at 2022 March 06 23:26:38 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Program Files\Go\src\cmd\vendor\golang.org\x\sys\unix\ptrace_ios.go


namespace go.cmd.vendor.golang.org.x.sys;

public static partial class unix_package {

private static error ptrace(nint request, nint pid, System.UIntPtr addr, System.UIntPtr data) {
    error err = default!;

    return error.As(ENOTSUP)!;
}

} // end unix_package
