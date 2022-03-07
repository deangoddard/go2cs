// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

//go:build go1.8
// +build go1.8

// package gc -- go2cs converted at 2022 March 06 23:14:26 UTC
// import "cmd/compile/internal/gc" ==> using gc = go.cmd.compile.@internal.gc_package
// Original source: C:\Program Files\Go\src\cmd\compile\internal\gc\pprof.go
using runtime = go.runtime_package;

namespace go.cmd.compile.@internal;

public static partial class gc_package {

private static void startMutexProfiling() {
    runtime.SetMutexProfileFraction(1);
}

} // end gc_package
