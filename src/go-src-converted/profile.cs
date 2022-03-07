// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package cover provides support for parsing coverage profiles
// generated by "go test -coverprofile=cover.out".
// package cover -- go2cs converted at 2022 March 06 23:15:10 UTC
// import "golang.org/x/tools/cover" ==> using cover = go.golang.org.x.tools.cover_package
// Original source: C:\Users\ritchie\go\src\golang.org\x\tools\cover\profile.go
// import "golang.org/x/tools/cover"

using bufio = go.bufio_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using math = go.math_package;
using os = go.os_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using System;


namespace go.golang.org.x.tools;

public static partial class cover_package {

    // Profile represents the profiling data for a specific file.
public partial struct Profile {
    public @string FileName;
    public @string Mode;
    public slice<ProfileBlock> Blocks;
}

// ProfileBlock represents a single block of profiling data.
public partial struct ProfileBlock {
    public nint StartLine;
    public nint StartCol;
    public nint EndLine;
    public nint EndCol;
    public nint NumStmt;
    public nint Count;
}

private partial struct byFileName { // : slice<ptr<Profile>>
}

private static nint Len(this byFileName p) {
    return len(p);
}
private static bool Less(this byFileName p, nint i, nint j) {
    return p[i].FileName < p[j].FileName;
}
private static void Swap(this byFileName p, nint i, nint j) {
    (p[i], p[j]) = (p[j], p[i]);
}

// ParseProfiles parses profile data in the specified file and returns a
// Profile for each source file described therein.
public static (slice<ptr<Profile>>, error) ParseProfiles(@string fileName) => func((defer, _, _) => {
    slice<ptr<Profile>> _p0 = default;
    error _p0 = default!;

    var (pf, err) = os.Open(fileName);
    if (err != null) {
        return (null, error.As(err)!);
    }
    defer(pf.Close());

    var files = make_map<@string, ptr<Profile>>();
    var buf = bufio.NewReader(pf); 
    // First line is "mode: foo", where foo is "set", "count", or "atomic".
    // Rest of file is in the format
    //    encoding/base64/base64.go:34.44,37.40 3 1
    // where the fields are: name.go:line.column,line.column numberOfStatements count
    var s = bufio.NewScanner(buf);
    @string mode = "";
    while (s.Scan()) {
        var line = s.Text();
        if (mode == "") {
            const @string p = "mode: ";

            if (!strings.HasPrefix(line, p) || line == p) {
                return (null, error.As(fmt.Errorf("bad mode line: %v", line))!);
            }
            mode = line[(int)len(p)..];
            continue;
        }
        var (fn, b, err) = parseLine(line);
        if (err != null) {
            return (null, error.As(fmt.Errorf("line %q doesn't match expected format: %v", line, err))!);
        }
        var p = files[fn];
        if (p == null) {
            p = addr(new Profile(FileName:fn,Mode:mode,));
            files[fn] = p;
        }
        p.Blocks = append(p.Blocks, b);

    }
    {
        var err = s.Err();

        if (err != null) {
            return (null, error.As(err)!);
        }
    }

    {
        var p__prev1 = p;

        foreach (var (_, __p) in files) {
            p = __p;
            sort.Sort(blocksByStart(p.Blocks)); 
            // Merge samples from the same location.
            nint j = 1;
            for (nint i = 1; i < len(p.Blocks); i++) {
                var b = p.Blocks[i];
                var last = p.Blocks[j - 1];
                if (b.StartLine == last.StartLine && b.StartCol == last.StartCol && b.EndLine == last.EndLine && b.EndCol == last.EndCol) {
                    if (b.NumStmt != last.NumStmt) {
                        return (null, error.As(fmt.Errorf("inconsistent NumStmt: changed from %d to %d", last.NumStmt, b.NumStmt))!);
                    }
                    if (mode == "set") {
                        p.Blocks[j - 1].Count |= b.Count;
                    }
                    else
 {
                        p.Blocks[j - 1].Count += b.Count;
                    }

                    continue;

                }

                p.Blocks[j] = b;
                j++;

            }

            p.Blocks = p.Blocks[..(int)j];

        }
        p = p__prev1;
    }

    var profiles = make_slice<ptr<Profile>>(0, len(files));
    foreach (var (_, profile) in files) {
        profiles = append(profiles, profile);
    }    sort.Sort(byFileName(profiles));
    return (profiles, error.As(null!)!);

});

// parseLine parses a line from a coverage file.
// It is equivalent to the regex
// ^(.+):([0-9]+)\.([0-9]+),([0-9]+)\.([0-9]+) ([0-9]+) ([0-9]+)$
//
// However, it is much faster: https://golang.org/cl/179377
private static (@string, ProfileBlock, error) parseLine(@string l) {
    @string fileName = default;
    ProfileBlock block = default;
    error err = default!;

    var end = len(l);

    ProfileBlock b = new ProfileBlock();
    b.Count, end, err = seekBack(l, ' ', end, "Count");
    if (err != null) {
        return ("", b, error.As(err)!);
    }
    b.NumStmt, end, err = seekBack(l, ' ', end, "NumStmt");
    if (err != null) {
        return ("", b, error.As(err)!);
    }
    b.EndCol, end, err = seekBack(l, '.', end, "EndCol");
    if (err != null) {
        return ("", b, error.As(err)!);
    }
    b.EndLine, end, err = seekBack(l, ',', end, "EndLine");
    if (err != null) {
        return ("", b, error.As(err)!);
    }
    b.StartCol, end, err = seekBack(l, '.', end, "StartCol");
    if (err != null) {
        return ("", b, error.As(err)!);
    }
    b.StartLine, end, err = seekBack(l, ':', end, "StartLine");
    if (err != null) {
        return ("", b, error.As(err)!);
    }
    var fn = l[(int)0..(int)end];
    if (fn == "") {
        return ("", b, error.As(errors.New("a FileName cannot be blank"))!);
    }
    return (fn, b, error.As(null!)!);

}

// seekBack searches backwards from end to find sep in l, then returns the
// value between sep and end as an integer.
// If seekBack fails, the returned error will reference what.
private static (nint, nint, error) seekBack(@string l, byte sep, nint end, @string what) {
    nint value = default;
    nint nextSep = default;
    error err = default!;
 
    // Since we're seeking backwards and we know only ASCII is legal for these values,
    // we can ignore the possibility of non-ASCII characters.
    for (var start = end - 1; start >= 0; start--) {
        if (l[start] == sep) {
            var (i, err) = strconv.Atoi(l[(int)start + 1..(int)end]);
            if (err != null) {
                return (0, 0, error.As(fmt.Errorf("couldn't parse %q: %v", what, err))!);
            }
            if (i < 0) {
                return (0, 0, error.As(fmt.Errorf("negative values are not allowed for %s, found %d", what, i))!);
            }
            return (i, start, error.As(null!)!);
        }
    }
    return (0, 0, error.As(fmt.Errorf("couldn't find a %s before %s", string(sep), what))!);

}

private partial struct blocksByStart { // : slice<ProfileBlock>
}

private static nint Len(this blocksByStart b) {
    return len(b);
}
private static void Swap(this blocksByStart b, nint i, nint j) {
    (b[i], b[j]) = (b[j], b[i]);
}
private static bool Less(this blocksByStart b, nint i, nint j) {
    var bi = b[i];
    var bj = b[j];
    return bi.StartLine < bj.StartLine || bi.StartLine == bj.StartLine && bi.StartCol < bj.StartCol;

}

// Boundary represents the position in a source file of the beginning or end of a
// block as reported by the coverage profile. In HTML mode, it will correspond to
// the opening or closing of a <span> tag and will be used to colorize the source
public partial struct Boundary {
    public nint Offset; // Location as a byte offset in the source file.
    public bool Start; // Is this the start of a block?
    public nint Count; // Event count from the cover profile.
    public double Norm; // Count normalized to [0..1].
}

// Boundaries returns a Profile as a set of Boundary objects within the provided src.
private static slice<Boundary> Boundaries(this ptr<Profile> _addr_p, slice<byte> src) {
    slice<Boundary> boundaries = default;
    ref Profile p = ref _addr_p.val;
 
    // Find maximum count.
    nint max = 0;
    {
        var b__prev1 = b;

        foreach (var (_, __b) in p.Blocks) {
            b = __b;
            if (b.Count > max) {
                max = b.Count;
            }
        }
        b = b__prev1;
    }

    var divisor = math.Log(float64(max)); 

    // boundary returns a Boundary, populating the Norm field with a normalized Count.
    Func<nint, bool, nint, Boundary> boundary = (offset, start, count) => {
        Boundary b = new Boundary(Offset:offset,Start:start,Count:count);
        if (!start || count == 0) {
            return b;
        }
        if (max <= 1) {
            b.Norm = 0.8F; // Profile is in"set" mode; we want a heat map. Use cov8 in the CSS.
        }
        else if (count > 0) {
            b.Norm = math.Log(float64(count)) / divisor;
        }
        return b;

    };

    nint line = 1;
    nint col = 2; // TODO: Why is this 2?
    {
        nint si = 0;
        nint bi = 0;

        while (si < len(src) && bi < len(p.Blocks)) {
            b = p.Blocks[bi];
            if (b.StartLine == line && b.StartCol == col) {
                boundaries = append(boundaries, boundary(si, true, b.Count));
            }
            if (b.EndLine == line && b.EndCol == col || line > b.EndLine) {
                boundaries = append(boundaries, boundary(si, false, 0));
                bi++;
                continue; // Don't advance through src; maybe the next block starts here.
            }

            if (src[si] == '\n') {
                line++;
                col = 0;
            }

            col++;
            si++;

        }
    }
    sort.Sort(boundariesByPos(boundaries));
    return ;

}

private partial struct boundariesByPos { // : slice<Boundary>
}

private static nint Len(this boundariesByPos b) {
    return len(b);
}
private static void Swap(this boundariesByPos b, nint i, nint j) {
    (b[i], b[j]) = (b[j], b[i]);
}
private static bool Less(this boundariesByPos b, nint i, nint j) {
    if (b[i].Offset == b[j].Offset) {
        return !b[i].Start && b[j].Start;
    }
    return b[i].Offset < b[j].Offset;

}

} // end cover_package
