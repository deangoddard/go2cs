// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package iotest -- go2cs converted at 2020 August 29 10:05:58 UTC
// import "testing/iotest" ==> using iotest = go.testing.iotest_package
// Original source: C:\Go\src\testing\iotest\writer.go
using io = go.io_package;
using static go.builtin;

namespace go {
namespace testing
{
    public static partial class iotest_package
    {
        // TruncateWriter returns a Writer that writes to w
        // but stops silently after n bytes.
        public static io.Writer TruncateWriter(io.Writer w, long n)
        {
            return ref new truncateWriter(w,n);
        }

        private partial struct truncateWriter
        {
            public io.Writer w;
            public long n;
        }

        private static (long, error) Write(this ref truncateWriter t, slice<byte> p)
        {
            if (t.n <= 0L)
            {
                return (len(p), null);
            } 
            // real write
            n = len(p);
            if (int64(n) > t.n)
            {
                n = int(t.n);
            }
            n, err = t.w.Write(p[0L..n]);
            t.n -= int64(n);
            if (err == null)
            {
                n = len(p);
            }
            return;
        }
    }
}}
