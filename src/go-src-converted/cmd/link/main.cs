// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package main -- go2cs converted at 2022 March 13 06:32:36 UTC
// Original source: C:\Program Files\Go\src\cmd\link\main.go
namespace go;

using sys = cmd.@internal.sys_package;
using amd64 = cmd.link.@internal.amd64_package;
using arm = cmd.link.@internal.arm_package;
using arm64 = cmd.link.@internal.arm64_package;
using ld = cmd.link.@internal.ld_package;
using mips = cmd.link.@internal.mips_package;
using mips64 = cmd.link.@internal.mips64_package;
using ppc64 = cmd.link.@internal.ppc64_package;
using riscv64 = cmd.link.@internal.riscv64_package;
using s390x = cmd.link.@internal.s390x_package;
using wasm = cmd.link.@internal.wasm_package;
using x86 = cmd.link.@internal.x86_package;
using fmt = fmt_package;
using buildcfg = @internal.buildcfg_package;
using os = os_package;


// The bulk of the linker implementation lives in cmd/link/internal/ld.
// Architecture-specific code lives in cmd/link/internal/GOARCH.
//
// Program initialization:
//
// Before any argument parsing is done, the Init function of relevant
// architecture package is called. The only job done in Init is
// configuration of the architecture-specific variables.
//
// Then control flow passes to ld.Main, which parses flags, makes
// some configuration decisions, and then gives the architecture
// packages a second chance to modify the linker's configuration
// via the ld.Arch.Archinit function.

public static partial class main_package {

private static void Main() {
    ptr<sys.Arch> arch;
    ld.Arch theArch = default;

    buildcfg.Check();
    switch (buildcfg.GOARCH) {
        case "386": 
            arch, theArch = x86.Init();
            break;
        case "amd64": 
            arch, theArch = amd64.Init();
            break;
        case "arm": 
            arch, theArch = arm.Init();
            break;
        case "arm64": 
            arch, theArch = arm64.Init();
            break;
        case "mips": 

        case "mipsle": 
            arch, theArch = mips.Init();
            break;
        case "mips64": 

        case "mips64le": 
            arch, theArch = mips64.Init();
            break;
        case "ppc64": 

        case "ppc64le": 
            arch, theArch = ppc64.Init();
            break;
        case "riscv64": 
            arch, theArch = riscv64.Init();
            break;
        case "s390x": 
            arch, theArch = s390x.Init();
            break;
        case "wasm": 
            arch, theArch = wasm.Init();
            break;
        default: 
            fmt.Fprintf(os.Stderr, "link: unknown architecture %q\n", buildcfg.GOARCH);
            os.Exit(2);
            break;
    }
    ld.Main(arch, theArch);
}

} // end main_package
