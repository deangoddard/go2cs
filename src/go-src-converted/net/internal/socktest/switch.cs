// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package socktest provides utilities for socket testing.
// package socktest -- go2cs converted at 2020 August 29 08:36:18 UTC
// import "net/internal/socktest" ==> using socktest = go.net.@internal.socktest_package
// Original source: C:\Go\src\net\internal\socktest\switch.go
using fmt = go.fmt_package;
using sync = go.sync_package;
using static go.builtin;

namespace go {
namespace net {
namespace @internal
{
    public static partial class socktest_package
    {
        // A Switch represents a callpath point switch for socket system
        // calls.
        public partial struct Switch
        {
            public sync.Once once;
            public sync.RWMutex fmu;
            public map<FilterType, Filter> fltab;
            public sync.RWMutex smu;
            public Sockets sotab;
            public stats stats;
        }

        private static void init(this ref Switch sw)
        {
            sw.fltab = make_map<FilterType, Filter>();
            sw.sotab = make(Sockets);
            sw.stats = make(stats);
        }

        // Stats returns a list of per-cookie socket statistics.
        private static slice<Stat> Stats(this ref Switch sw)
        {
            slice<Stat> st = default;
            sw.smu.RLock();
            foreach (var (_, s) in sw.stats)
            {
                var ns = s.Value;
                st = append(st, ns);
            }
            sw.smu.RUnlock();
            return st;
        }

        // Sockets returns mappings of socket descriptor to socket status.
        private static Sockets Sockets(this ref Switch sw)
        {
            sw.smu.RLock();
            var tab = make(Sockets, len(sw.sotab));
            foreach (var (i, s) in sw.sotab)
            {
                tab[i] = s;
            }
            sw.smu.RUnlock();
            return tab;
        }

        // A Cookie represents a 3-tuple of a socket; address family, socket
        // type and protocol number.
        public partial struct Cookie // : ulong
        {
        }

        // Family returns an address family.
        public static long Family(this Cookie c)
        {
            return int(c >> (int)(48L));
        }

        // Type returns a socket type.
        public static long Type(this Cookie c)
        {
            return int(c << (int)(16L) >> (int)(32L));
        }

        // Protocol returns a protocol number.
        public static long Protocol(this Cookie c)
        {
            return int(c & 0xffUL);
        }

        private static Cookie cookie(long family, long sotype, long proto)
        {
            return Cookie(family) << (int)(48L) | Cookie(sotype) & 0xffffffffUL << (int)(16L) | Cookie(proto) & 0xffUL;
        }

        // A Status represents the status of a socket.
        public partial struct Status
        {
            public Cookie Cookie;
            public error Err; // error status of socket system call
            public error SocketErr; // error status of socket by SO_ERROR
        }

        public static @string String(this Status so)
        {
            return fmt.Sprintf("(%s, %s, %s): syscallerr=%v socketerr=%v", familyString(so.Cookie.Family()), typeString(so.Cookie.Type()), protocolString(so.Cookie.Protocol()), so.Err, so.SocketErr);
        }

        // A Stat represents a per-cookie socket statistics.
        public partial struct Stat
        {
            public long Family; // address family
            public long Type; // socket type
            public long Protocol; // protocol number

            public ulong Opened; // number of sockets opened
            public ulong Connected; // number of sockets connected
            public ulong Listened; // number of sockets listened
            public ulong Accepted; // number of sockets accepted
            public ulong Closed; // number of sockets closed

            public ulong OpenFailed; // number of sockets open failed
            public ulong ConnectFailed; // number of sockets connect failed
            public ulong ListenFailed; // number of sockets listen failed
            public ulong AcceptFailed; // number of sockets accept failed
            public ulong CloseFailed; // number of sockets close failed
        }

        public static @string String(this Stat st)
        {
            return fmt.Sprintf("(%s, %s, %s): opened=%d connected=%d listened=%d accepted=%d closed=%d openfailed=%d connectfailed=%d listenfailed=%d acceptfailed=%d closefailed=%d", familyString(st.Family), typeString(st.Type), protocolString(st.Protocol), st.Opened, st.Connected, st.Listened, st.Accepted, st.Closed, st.OpenFailed, st.ConnectFailed, st.ListenFailed, st.AcceptFailed, st.CloseFailed);
        }

        private partial struct stats // : map<Cookie, ref Stat>
        {
        }

        private static ref Stat getLocked(this stats st, Cookie c)
        {
            var (s, ok) = st[c];
            if (!ok)
            {
                s = ref new Stat(Family:c.Family(),Type:c.Type(),Protocol:c.Protocol());
                st[c] = s;
            }
            return s;
        }

        // A FilterType represents a filter type.
        public partial struct FilterType // : long
        {
        }

        public static readonly FilterType FilterSocket = iota; // for Socket
        public static readonly var FilterConnect = 0; // for Connect or ConnectEx
        public static readonly var FilterListen = 1; // for Listen
        public static readonly var FilterAccept = 2; // for Accept, Accept4 or AcceptEx
        public static readonly var FilterGetsockoptInt = 3; // for GetsockoptInt
        public static readonly var FilterClose = 4; // for Close or Closesocket

        // A Filter represents a socket system call filter.
        //
        // It will only be executed before a system call for a socket that has
        // an entry in internal table.
        // If the filter returns a non-nil error, the execution of system call
        // will be canceled and the system call function returns the non-nil
        // error.
        // It can return a non-nil AfterFilter for filtering after the
        // execution of the system call.
        public delegate  error) Filter(ref Status,  (AfterFilter);

        public static (AfterFilter, error) apply(this Filter f, ref Status st)
        {
            if (f == null)
            {
                return (null, null);
            }
            return f(st);
        }

        // An AfterFilter represents a socket system call filter after an
        // execution of a system call.
        //
        // It will only be executed after a system call for a socket that has
        // an entry in internal table.
        // If the filter returns a non-nil error, the system call function
        // returns the non-nil error.
        public delegate  error AfterFilter(ref Status);

        public static error apply(this AfterFilter f, ref Status st)
        {
            if (f == null)
            {
                return error.As(null);
            }
            return error.As(f(st));
        }

        // Set deploys the socket system call filter f for the filter type t.
        private static void Set(this ref Switch sw, FilterType t, Filter f)
        {
            sw.once.Do(sw.init);
            sw.fmu.Lock();
            sw.fltab[t] = f;
            sw.fmu.Unlock();
        }
    }
}}}
