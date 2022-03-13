// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package os -- go2cs converted at 2022 March 13 05:28:06 UTC
// import "os" ==> using os = go.os_package
// Original source: C:\Program Files\Go\src\os\tempfile.go
namespace go;

using errors = errors_package;
using itoa = @internal.itoa_package;


// fastrand provided by runtime.
// We generate random temporary file names so that there's a good
// chance the file doesn't exist yet - keeps the number of tries in
// TempFile to a minimum.

public static partial class os_package {

private static uint fastrand();

private static @string nextRandom() {
    return itoa.Uitoa(uint(fastrand()));
}

// CreateTemp creates a new temporary file in the directory dir,
// opens the file for reading and writing, and returns the resulting file.
// The filename is generated by taking pattern and adding a random string to the end.
// If pattern includes a "*", the random string replaces the last "*".
// If dir is the empty string, CreateTemp uses the default directory for temporary files, as returned by TempDir.
// Multiple programs or goroutines calling CreateTemp simultaneously will not choose the same file.
// The caller can use the file's Name method to find the pathname of the file.
// It is the caller's responsibility to remove the file when it is no longer needed.
public static (ptr<File>, error) CreateTemp(@string dir, @string pattern) {
    ptr<File> _p0 = default!;
    error _p0 = default!;

    if (dir == "") {>>MARKER:FUNCTION_fastrand_BLOCK_PREFIX<<
        dir = TempDir();
    }
    var (prefix, suffix, err) = prefixAndSuffix(pattern);
    if (err != null) {
        return (_addr_null!, error.As(addr(new PathError(Op:"createtemp",Path:pattern,Err:err))!)!);
    }
    prefix = joinPath(dir, prefix);

    nint @try = 0;
    while (true) {
        var name = prefix + nextRandom() + suffix;
        var (f, err) = OpenFile(name, O_RDWR | O_CREATE | O_EXCL, 0600);
        if (IsExist(err)) {
            try++;

            if (try < 10000) {
                continue;
            }
            return (_addr_null!, error.As(addr(new PathError(Op:"createtemp",Path:dir+string(PathSeparator)+prefix+"*"+suffix,Err:ErrExist))!)!);
        }
        return (_addr_f!, error.As(err)!);
    }
}

private static var errPatternHasSeparator = errors.New("pattern contains path separator");

// prefixAndSuffix splits pattern by the last wildcard "*", if applicable,
// returning prefix as the part before "*" and suffix as the part after "*".
private static (@string, @string, error) prefixAndSuffix(@string pattern) {
    @string prefix = default;
    @string suffix = default;
    error err = default!;

    for (nint i = 0; i < len(pattern); i++) {
        if (IsPathSeparator(pattern[i])) {
            return ("", "", error.As(errPatternHasSeparator)!);
        }
    }
    {
        var pos = lastIndex(pattern, '*');

        if (pos != -1) {
            (prefix, suffix) = (pattern[..(int)pos], pattern[(int)pos + 1..]);
        }
        else
 {
            prefix = pattern;
        }
    }
    return (prefix, suffix, error.As(null!)!);
}

// MkdirTemp creates a new temporary directory in the directory dir
// and returns the pathname of the new directory.
// The new directory's name is generated by adding a random string to the end of pattern.
// If pattern includes a "*", the random string replaces the last "*" instead.
// If dir is the empty string, MkdirTemp uses the default directory for temporary files, as returned by TempDir.
// Multiple programs or goroutines calling MkdirTemp simultaneously will not choose the same directory.
// It is the caller's responsibility to remove the directory when it is no longer needed.
public static (@string, error) MkdirTemp(@string dir, @string pattern) {
    @string _p0 = default;
    error _p0 = default!;

    if (dir == "") {
        dir = TempDir();
    }
    var (prefix, suffix, err) = prefixAndSuffix(pattern);
    if (err != null) {
        return ("", error.As(addr(new PathError(Op:"mkdirtemp",Path:pattern,Err:err))!)!);
    }
    prefix = joinPath(dir, prefix);

    nint @try = 0;
    while (true) {
        var name = prefix + nextRandom() + suffix;
        var err = Mkdir(name, 0700);
        if (err == null) {
            return (name, error.As(null!)!);
        }
        if (IsExist(err)) {
            try++;

            if (try < 10000) {
                continue;
            }
            return ("", error.As(addr(new PathError(Op:"mkdirtemp",Path:dir+string(PathSeparator)+prefix+"*"+suffix,Err:ErrExist))!)!);
        }
        if (IsNotExist(err)) {
            {
                var (_, err) = Stat(dir);

                if (IsNotExist(err)) {
                    return ("", error.As(err)!);
                }

            }
        }
        return ("", error.As(err)!);
    }
}

private static @string joinPath(@string dir, @string name) {
    if (len(dir) > 0 && IsPathSeparator(dir[len(dir) - 1])) {
        return dir + name;
    }
    return dir + string(PathSeparator) + name;
}

// LastIndexByte from the strings package.
private static nint lastIndex(@string s, byte sep) {
    for (var i = len(s) - 1; i >= 0; i--) {
        if (s[i] == sep) {
            return i;
        }
    }
    return -1;
}

} // end os_package
