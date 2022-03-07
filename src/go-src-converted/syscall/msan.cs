// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

//go:build msan
// +build msan

// package syscall -- go2cs converted at 2022 March 06 22:26:38 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Program Files\Go\src\syscall\msan.go
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;

namespace go;

public static partial class syscall_package {

private static readonly var msanenabled = true;



private static void msanRead(unsafe.Pointer addr, nint len) {
    runtime.MSanRead(addr, len);
}

private static void msanWrite(unsafe.Pointer addr, nint len) {
    runtime.MSanWrite(addr, len);
}

} // end syscall_package
