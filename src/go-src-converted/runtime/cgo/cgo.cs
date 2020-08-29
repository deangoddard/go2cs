// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

/*
Package cgo contains runtime support for code generated
by the cgo tool.  See the documentation for the cgo command
for details on using cgo.
*/
// package cgo -- go2cs converted at 2020 August 29 08:21:41 UTC
// import "runtime/cgo" ==> using cgo = go.runtime.cgo_package
// Original source: C:\Go\src\runtime\cgo\cgo.go
/*

#cgo darwin,!arm,!arm64 LDFLAGS: -lpthread
#cgo darwin,arm LDFLAGS: -framework CoreFoundation
#cgo darwin,arm64 LDFLAGS: -framework CoreFoundation
#cgo dragonfly LDFLAGS: -lpthread
#cgo freebsd LDFLAGS: -lpthread
#cgo android LDFLAGS: -llog
#cgo !android,linux LDFLAGS: -lpthread
#cgo netbsd LDFLAGS: -lpthread
#cgo openbsd LDFLAGS: -lpthread

#cgo CFLAGS: -Wall -Werror

#cgo solaris CPPFLAGS: -D_POSIX_PTHREAD_SEMANTICS

*/
using C = go.C_package;    }

