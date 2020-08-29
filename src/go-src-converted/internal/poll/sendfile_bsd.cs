// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build dragonfly freebsd

// package poll -- go2cs converted at 2020 August 29 08:25:36 UTC
// import "internal/poll" ==> using poll = go.@internal.poll_package
// Original source: C:\Go\src\internal\poll\sendfile_bsd.go
using syscall = go.syscall_package;
using static go.builtin;

namespace go {
namespace @internal
{
    public static partial class poll_package
    {
        // maxSendfileSize is the largest chunk size we ask the kernel to copy
        // at a time.
        private static readonly long maxSendfileSize = 4L << (int)(20L);

        // SendFile wraps the sendfile system call.


        // SendFile wraps the sendfile system call.
        public static (long, error) SendFile(ref FD _dstFD, long src, long pos, long remain) => func(_dstFD, (ref FD dstFD, Defer defer, Panic _, Recover __) =>
        {
            {
                var err__prev1 = err;

                var err = dstFD.writeLock();

                if (err != null)
                {
                    return (0L, err);
                }

                err = err__prev1;

            }
            defer(dstFD.writeUnlock());
            var dst = int(dstFD.Sysfd);
            long written = default;
            err = default;
            while (remain > 0L)
            {
                var n = maxSendfileSize;
                if (int64(n) > remain)
                {
                    n = int(remain);
                }
                var pos1 = pos;
                var (n, err1) = syscall.Sendfile(dst, src, ref pos1, n);
                if (n > 0L)
                {
                    pos += int64(n);
                    written += int64(n);
                    remain -= int64(n);
                }
                if (n == 0L && err1 == null)
                {
                    break;
                }
                if (err1 == syscall.EAGAIN)
                {
                    err1 = dstFD.pd.waitWrite(dstFD.isFile);

                    if (err1 == null)
                    {
                        continue;
                    }
                }
                if (err1 != null)
                { 
                    // This includes syscall.ENOSYS (no kernel
                    // support) and syscall.EINVAL (fd types which
                    // don't implement sendfile)
                    err = err1;
                    break;
                }
            }

            return (written, err);
        });
    }
}}
