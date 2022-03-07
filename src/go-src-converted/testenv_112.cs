// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build go1.12

// package testenv -- go2cs converted at 2022 March 06 23:31:22 UTC
// import "golang.org/x/tools/internal/testenv" ==> using testenv = go.golang.org.x.tools.@internal.testenv_package
// Original source: C:\Users\ritchie\go\src\golang.org\x\tools\internal\testenv\testenv_112.go
using debug = go.runtime.debug_package;

namespace go.golang.org.x.tools.@internal;

public static partial class testenv_package {

private static bool packageMainIsDevelModule() {
    var (info, ok) = debug.ReadBuildInfo();
    if (!ok) { 
        // Most test binaries currently lack build info, but this should become more
        // permissive once https://golang.org/issue/33976 is fixed.
        return true;

    }
    return info.Main.Version == "(devel)";

}

private static void init() {
    packageMainIsDevel = packageMainIsDevelModule;
}

} // end testenv_package
