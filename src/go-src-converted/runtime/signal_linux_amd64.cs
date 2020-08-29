// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package runtime -- go2cs converted at 2020 August 29 08:20:12 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\signal_linux_amd64.go
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private partial struct sigctxt
        {
            public ptr<siginfo> info;
            public unsafe.Pointer ctxt;
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static ref sigcontext regs(this ref sigctxt c)
        {
            return (sigcontext.Value)(@unsafe.Pointer(ref (ucontext.Value)(c.ctxt).uc_mcontext));
        }

        private static ulong rax(this ref sigctxt c)
        {
            return c.regs().rax;
        }
        private static ulong rbx(this ref sigctxt c)
        {
            return c.regs().rbx;
        }
        private static ulong rcx(this ref sigctxt c)
        {
            return c.regs().rcx;
        }
        private static ulong rdx(this ref sigctxt c)
        {
            return c.regs().rdx;
        }
        private static ulong rdi(this ref sigctxt c)
        {
            return c.regs().rdi;
        }
        private static ulong rsi(this ref sigctxt c)
        {
            return c.regs().rsi;
        }
        private static ulong rbp(this ref sigctxt c)
        {
            return c.regs().rbp;
        }
        private static ulong rsp(this ref sigctxt c)
        {
            return c.regs().rsp;
        }
        private static ulong r8(this ref sigctxt c)
        {
            return c.regs().r8;
        }
        private static ulong r9(this ref sigctxt c)
        {
            return c.regs().r9;
        }
        private static ulong r10(this ref sigctxt c)
        {
            return c.regs().r10;
        }
        private static ulong r11(this ref sigctxt c)
        {
            return c.regs().r11;
        }
        private static ulong r12(this ref sigctxt c)
        {
            return c.regs().r12;
        }
        private static ulong r13(this ref sigctxt c)
        {
            return c.regs().r13;
        }
        private static ulong r14(this ref sigctxt c)
        {
            return c.regs().r14;
        }
        private static ulong r15(this ref sigctxt c)
        {
            return c.regs().r15;
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static ulong rip(this ref sigctxt c)
        {
            return c.regs().rip;
        }

        private static ulong rflags(this ref sigctxt c)
        {
            return c.regs().eflags;
        }
        private static ulong cs(this ref sigctxt c)
        {
            return uint64(c.regs().cs);
        }
        private static ulong fs(this ref sigctxt c)
        {
            return uint64(c.regs().fs);
        }
        private static ulong gs(this ref sigctxt c)
        {
            return uint64(c.regs().gs);
        }
        private static ulong sigcode(this ref sigctxt c)
        {
            return uint64(c.info.si_code);
        }
        private static ulong sigaddr(this ref sigctxt c)
        {
            return c.info.si_addr;
        }

        private static void set_rip(this ref sigctxt c, ulong x)
        {
            c.regs().rip = x;

        }
        private static void set_rsp(this ref sigctxt c, ulong x)
        {
            c.regs().rsp = x;

        }
        private static void set_sigcode(this ref sigctxt c, ulong x)
        {
            c.info.si_code = int32(x);

        }
        private static void set_sigaddr(this ref sigctxt c, ulong x)
        {
            (uintptr.Value)(add(@unsafe.Pointer(c.info), 2L * sys.PtrSize)).Value;

            uintptr(x);
        }
    }
}
