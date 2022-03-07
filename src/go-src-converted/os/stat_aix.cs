// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package os -- go2cs converted at 2022 March 06 22:13:46 UTC
// import "os" ==> using os = go.os_package
// Original source: C:\Program Files\Go\src\os\stat_aix.go
using syscall = go.syscall_package;
using time = go.time_package;

namespace go;

public static partial class os_package {

private static void fillFileStatFromSys(ptr<fileStat> _addr_fs, @string name) {
    ref fileStat fs = ref _addr_fs.val;

    fs.name = basename(name);
    fs.size = int64(fs.sys.Size);
    fs.modTime = stTimespecToTime(fs.sys.Mtim);
    fs.mode = FileMode(fs.sys.Mode & 0777);

    if (fs.sys.Mode & syscall.S_IFMT == syscall.S_IFBLK) 
        fs.mode |= ModeDevice;
    else if (fs.sys.Mode & syscall.S_IFMT == syscall.S_IFCHR) 
        fs.mode |= ModeDevice | ModeCharDevice;
    else if (fs.sys.Mode & syscall.S_IFMT == syscall.S_IFDIR) 
        fs.mode |= ModeDir;
    else if (fs.sys.Mode & syscall.S_IFMT == syscall.S_IFIFO) 
        fs.mode |= ModeNamedPipe;
    else if (fs.sys.Mode & syscall.S_IFMT == syscall.S_IFLNK) 
        fs.mode |= ModeSymlink;
    else if (fs.sys.Mode & syscall.S_IFMT == syscall.S_IFREG)     else if (fs.sys.Mode & syscall.S_IFMT == syscall.S_IFSOCK) 
        fs.mode |= ModeSocket;
        if (fs.sys.Mode & syscall.S_ISGID != 0) {
        fs.mode |= ModeSetgid;
    }
    if (fs.sys.Mode & syscall.S_ISUID != 0) {
        fs.mode |= ModeSetuid;
    }
    if (fs.sys.Mode & syscall.S_ISVTX != 0) {
        fs.mode |= ModeSticky;
    }
}

private static time.Time stTimespecToTime(syscall.StTimespec_t ts) {
    return time.Unix(int64(ts.Sec), int64(ts.Nsec));
}

// For testing.
private static time.Time atime(FileInfo fi) {
    return stTimespecToTime(fi.Sys()._<ptr<syscall.Stat_t>>().Atim);
}

} // end os_package
