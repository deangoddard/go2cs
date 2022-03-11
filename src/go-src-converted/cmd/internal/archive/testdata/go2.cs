// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package mypkg -- go2cs converted at 2022 March 06 22:32:29 UTC
// import "cmd/internal/archive.mypkg" ==> using mypkg = go.cmd.@internal.archive.mypkg_package
// Original source: C:\Program Files\Go\src\cmd\internal\archive\testdata\go2.go
using fmt = go.fmt_package;

namespace go.cmd.@internal;

public static partial class mypkg_package {

private static void go2() {
    fmt.Println("go2");
}

} // end mypkg_package