// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package mycgo -- go2cs converted at 2020 August 29 08:46:21 UTC
// import "cmd/internal/goobj/testdata/mycgo" ==> using mycgo = go.cmd.@internal.goobj.testdata.mycgo_package
// Original source: C:\Go\src\cmd\internal\goobj\testdata\mycgo\go1.go
using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace @internal {
namespace goobj {
namespace testdata
{
    public static partial class mycgo_package
    {
        private static void go1()
        {
            fmt.Println("go1");
        }
    }
}}}}}
