// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package main -- go2cs converted at 2022 March 13 06:22:53 UTC
// Original source: C:\Program Files\Go\src\cmd\compile\internal\ssa\testdata\scopes.go
namespace go;

using fmt = fmt_package;
using time = time_package;

public static partial class main_package {

private static void Main() {
    growstack(); // Use stack early to prevent growth during test, which confuses gdb
    test();
}

//go:noinline
private static nint id(nint x) {
    return x;
}

private static void test() {
    var x = id(0);
    var y = id(0);
    fmt.Println(x);
    {
        var i__prev1 = i;

        for (var i = x; i < 3; i++) {
            x = i * i;
            y += id(x); //gdb-dbg=(x,y)//gdb-opt=(x,y)
        }

        i = i__prev1;
    }
    y = x + y; //gdb-dbg=(x,y)//gdb-opt=(x,y)
    fmt.Println(x, y);

    {
        var x__prev1 = x;

        for (x = 0; x <= 1; x++) { // From delve scopetest.go
            var a = y;
            f1(a);
 {
                nint b = 0;
                f2(b);
                if (gretbool()) {
                    nint c = 0;
                    f3(c);
                }
                else
 {
                    c = 1.1F;
                    f4(int(c));
                }
                f5(b);
            }
            f6(a);
        }

        x = x__prev1;
    }

 { // From delve testnextprog.go
        var j = id(1);        var f = id(2);
        {
            var i__prev1 = i;

            for (i = 0; i <= 5; i++) {
                j += j * (j ^ 3) / 100;
                if (i == f) {
                    fmt.Println("foo");
                    break;
                }
                sleepytime();
            }


            i = i__prev1;
        }
        helloworld();
    }
}

private static void sleepytime() {
    time.Sleep(5 * time.Millisecond);
}

private static void helloworld() {
    fmt.Println("Hello, World!");
}

//go:noinline
private static void f1(nint x) {
}

//go:noinline
private static void f2(nint x) {
}

//go:noinline
private static void f3(nint x) {
}

//go:noinline
private static void f4(nint x) {
}

//go:noinline
private static void f5(nint x) {
}

//go:noinline
private static void f6(nint x) {
}

private static var boolvar = true;

private static bool gretbool() {
    var x = boolvar;
    boolvar = !boolvar;
    return x;
}

private static @string sink = default;

//go:noinline
private static void growstack() {
    sink = fmt.Sprintf("%#v,%#v,%#v", 1, true, "cat");
}

} // end main_package
