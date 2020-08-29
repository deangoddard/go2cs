// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build mips mipsle

// package runtime -- go2cs converted at 2020 August 29 08:21:12 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\sys_mipsx.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        // adjust Gobuf as if it executed a call to fn with context ctxt
        // and then did an immediate Gosave.
        private static void gostartcall(ref gobuf buf, unsafe.Pointer fn, unsafe.Pointer ctxt)
        {
            if (buf.lr != 0L)
            {
                throw("invalid use of gostartcall");
            }
            buf.lr = buf.pc;
            buf.pc = uintptr(fn);
            buf.ctxt = ctxt;
        }
    }
}
