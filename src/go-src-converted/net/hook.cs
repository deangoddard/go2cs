// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package net -- go2cs converted at 2022 March 06 22:15:48 UTC
// import "net" ==> using net = go.net_package
// Original source: C:\Program Files\Go\src\net\hook.go
using context = go.context_package;
using time = go.time_package;
using System;


namespace go;

public static partial class net_package {

 
// if non-nil, overrides dialTCP.
private static Func<context.Context, @string, ptr<TCPAddr>, ptr<TCPAddr>, (ptr<TCPConn>, error)> testHookDialTCP = default;private static @string testHookHostsPath = "/etc/hosts";private static Func<context.Context, Func<context.Context, @string, @string, (slice<IPAddr>, error)>, @string, @string, (slice<IPAddr>, error)> testHookLookupIP = (ctx, fn, network, host) => {
    return fn(ctx, network, host);
};private static Action<time.Duration> testHookSetKeepAlive = _p0 => {
};

} // end net_package
