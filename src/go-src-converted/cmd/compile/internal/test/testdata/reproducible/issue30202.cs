// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package p -- go2cs converted at 2022 March 06 23:15:06 UTC
// import "cmd/compile/internal/test/testdata.p" ==> using p = go.cmd.compile.@internal.test.testdata.p_package
// Original source: C:\Program Files\Go\src\cmd\compile\internal\test\testdata\reproducible\issue30202.go


namespace go.cmd.compile.@internal.test;

public static partial class p_package {

public static nint A(object x) {
    return x.X();
}

public static nint B(object x) {
    return x.X();
}

} // end p_package
