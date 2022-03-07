// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

//go:build !race
// +build !race

// package race -- go2cs converted at 2022 March 06 22:08:15 UTC
// import "internal/race" ==> using race = go.@internal.race_package
// Original source: C:\Program Files\Go\src\internal\race\norace.go
using @unsafe = go.@unsafe_package;

namespace go.@internal;

public static partial class race_package {

public static readonly var Enabled = false;



public static void Acquire(unsafe.Pointer addr) {
}

public static void Release(unsafe.Pointer addr) {
}

public static void ReleaseMerge(unsafe.Pointer addr) {
}

public static void Disable() {
}

public static void Enable() {
}

public static void Read(unsafe.Pointer addr) {
}

public static void Write(unsafe.Pointer addr) {
}

public static void ReadRange(unsafe.Pointer addr, nint len) {
}

public static void WriteRange(unsafe.Pointer addr, nint len) {
}

public static nint Errors() {
    return 0;
}

} // end race_package
