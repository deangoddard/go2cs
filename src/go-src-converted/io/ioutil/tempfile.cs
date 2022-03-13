// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package ioutil -- go2cs converted at 2022 March 13 05:27:48 UTC
// import "io/ioutil" ==> using ioutil = go.io.ioutil_package
// Original source: C:\Program Files\Go\src\io\ioutil\tempfile.go
namespace go.io;

using os = os_package;


// TempFile creates a new temporary file in the directory dir,
// opens the file for reading and writing, and returns the resulting *os.File.
// The filename is generated by taking pattern and adding a random
// string to the end. If pattern includes a "*", the random string
// replaces the last "*".
// If dir is the empty string, TempFile uses the default directory
// for temporary files (see os.TempDir).
// Multiple programs calling TempFile simultaneously
// will not choose the same file. The caller can use f.Name()
// to find the pathname of the file. It is the caller's responsibility
// to remove the file when no longer needed.
//
// As of Go 1.17, this function simply calls os.CreateTemp.

public static partial class ioutil_package {

public static (ptr<os.File>, error) TempFile(@string dir, @string pattern) {
    ptr<os.File> f = default!;
    error err = default!;

    return _addr_os.CreateTemp(dir, pattern)!;
}

// TempDir creates a new temporary directory in the directory dir.
// The directory name is generated by taking pattern and applying a
// random string to the end. If pattern includes a "*", the random string
// replaces the last "*". TempDir returns the name of the new directory.
// If dir is the empty string, TempDir uses the
// default directory for temporary files (see os.TempDir).
// Multiple programs calling TempDir simultaneously
// will not choose the same directory. It is the caller's responsibility
// to remove the directory when no longer needed.
//
// As of Go 1.17, this function simply calls os.MkdirTemp.
public static (@string, error) TempDir(@string dir, @string pattern) {
    @string name = default;
    error err = default!;

    return os.MkdirTemp(dir, pattern);
}

} // end ioutil_package
