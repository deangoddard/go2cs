// package main -- go2cs converted at 2022 March 06 23:22:34 UTC
// Original source: C:\Program Files\Go\src\cmd\link\internal\ld\testdata\issue42484\main.go
using fmt = go.fmt_package;

namespace go;

public static partial class main_package {

private static void Main() {
    nint a = 0;
    a++;
    nint b = 0;
    f1(a, b);
}

private static void f1(nint a, nint b) {
    fmt.Printf("%d %d\n", a, b);
}

} // end main_package