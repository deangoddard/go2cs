// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build darwin dragonfly freebsd linux nacl netbsd openbsd solaris

// package rand -- go2cs converted at 2020 August 29 08:30:48 UTC
// import "crypto/rand" ==> using rand = go.crypto.rand_package
// Original source: C:\Go\src\crypto\rand\eagain.go
using os = go.os_package;
using syscall = go.syscall_package;
using static go.builtin;

namespace go {
namespace crypto
{
    public static partial class rand_package
    {
        private static void init()
        {
            isEAGAIN = unixIsEAGAIN;
        }

        // unixIsEAGAIN reports whether err is a syscall.EAGAIN wrapped in a PathError.
        // See golang.org/issue/9205
        private static bool unixIsEAGAIN(error err)
        {
            {
                ref os.PathError (pe, ok) = err._<ref os.PathError>();

                if (ok)
                {
                    {
                        syscall.Errno (errno, ok) = pe.Err._<syscall.Errno>();

                        if (ok && errno == syscall.EAGAIN)
                        {
                            return true;
                        }

                    }
                }

            }
            return false;
        }
    }
}}
