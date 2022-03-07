// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package main -- go2cs converted at 2022 March 06 22:26:10 UTC
// Original source: C:\Program Files\Go\src\runtime\testdata\testprogcgo\bigstack_windows.go
/*
typedef void callback(char*);
extern void CallGoBigStack1(char*);
extern void bigStack(callback*);
*/
using C = go.C_package;

namespace go;

public static partial class main_package {

private static void init() {
    register("BigStack", BigStack);
}

public static void BigStack() { 
    // Create a large thread stack and call back into Go to test
    // if Go correctly determines the stack bounds.
    C.bigStack((C.callback.val)(C.CallGoBigStack1));

}

//export goBigStack1
private static void goBigStack1(ptr<C.char> _addr_x) {
    ref C.char x = ref _addr_x.val;

    println("OK");
}

} // end main_package
