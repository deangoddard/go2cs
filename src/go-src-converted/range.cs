// package main -- go2cs converted at 2022 March 06 23:33:45 UTC
// Original source: C:\Users\ritchie\go\src\golang.org\x\tools\go\ssa\interp\testdata\range.go
// Tests of range loops.

using fmt = go.fmt_package;

namespace go;

public static partial class main_package {

    // Range over string.
private static void init() => func((_, panic, _) => {
    {
        var x__prev1 = x;

        var x = len("Hello, 世界");

        if (x != 13) { // bytes
            panic(x);

        }
        x = x__prev1;

    }

    slice<nint> indices = default;
    slice<int> runes = default;
    {
        @string r__prev1 = r;

        foreach (var (__i, __r) in "Hello, 世界") {
            i = __i;
            r = __r;
            runes = append(runes, r);
            indices = append(indices, i);
        }
        r = r__prev1;
    }

    {
        var x__prev1 = x;

        x = fmt.Sprint(runes);

        if (x != "[72 101 108 108 111 44 32 19990 30028]") {
            panic(x);
        }
        x = x__prev1;

    }

    {
        var x__prev1 = x;

        x = fmt.Sprint(indices);

        if (x != "[0 1 2 3 4 5 6 7 10]") {
            panic(x);
        }
        x = x__prev1;

    }

    @string s = "";
    {
        @string r__prev1 = r;

        foreach (var (_, __r) in runes) {
            r = __r;
            s += string(r);
        }
        r = r__prev1;
    }

    if (s != "Hello, 世界") {
        panic(s);
    }
    x = default;
    foreach (>>MARKER:FORRANGEEXPRESSIONS_LEVEL_1<< in "Hello, 世界") {>>MARKER:FORRANGEMUTABLEEXPRESSIONS_LEVEL_1<<
        x++;
    }    if (x != len(indices)) {
        panic(x);
    }
});

// Regression test for range of pointer to named array type.
private static void init() => func((_, panic, _) => {
    private partial struct intarr { // : array<nint>
    }
    intarr ia = new intarr(1,2,3);
    nint count = default;
    {
        var x__prev1 = x;

        foreach (var (_, __x) in _addr_ia) {
            x = __x;
            count += x;
        }
        x = x__prev1;
    }

    if (count != 6) {
        panic(count);
    }
});

private static void Main() {
}

} // end main_package
