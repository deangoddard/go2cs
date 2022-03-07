// package main -- go2cs converted at 2022 March 06 23:09:38 UTC
// Original source: C:\Program Files\Go\src\cmd\compile\internal\ssa\testdata\i22600.go
using fmt = go.fmt_package;
using os = go.os_package;

namespace go;

public static partial class main_package {

private static void test() {
    var (pwd, err) = os.Getwd();
    if (err != null) {
        fmt.Println(err);
        os.Exit(1);
    }
    fmt.Println(pwd);

}

private static void Main() {
    growstack(); // Use stack early to prevent growth during test, which confuses gdb
    test();

}

private static @string snk = default;

//go:noinline
private static void growstack() {
    snk = fmt.Sprintf("%#v,%#v,%#v", 1, true, "cat");
}

} // end main_package
