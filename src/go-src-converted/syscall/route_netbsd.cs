// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package syscall -- go2cs converted at 2020 October 09 05:01:30 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\route_netbsd.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        private static RoutingMessage toRoutingMessage(this ptr<anyMessage> _addr_any, slice<byte> b)
        {
            ref anyMessage any = ref _addr_any.val;


            if (any.Type == RTM_ADD || any.Type == RTM_DELETE || any.Type == RTM_CHANGE || any.Type == RTM_GET || any.Type == RTM_LOSING || any.Type == RTM_REDIRECT || any.Type == RTM_MISS || any.Type == RTM_LOCK || any.Type == RTM_RESOLVE) 
                var p = (RouteMessage.val)(@unsafe.Pointer(any)); 
                // We don't support sockaddr_mpls for now.
                p.Header.Addrs &= RTA_DST | RTA_GATEWAY | RTA_NETMASK | RTA_GENMASK | RTA_IFA | RTA_IFP | RTA_BRD | RTA_AUTHOR;
                return addr(new RouteMessage(Header:p.Header,Data:b[SizeofRtMsghdr:any.Msglen]));
            else if (any.Type == RTM_IFINFO) 
                p = (InterfaceMessage.val)(@unsafe.Pointer(any));
                return addr(new InterfaceMessage(Header:p.Header,Data:b[SizeofIfMsghdr:any.Msglen]));
            else if (any.Type == RTM_IFANNOUNCE) 
                p = (InterfaceAnnounceMessage.val)(@unsafe.Pointer(any));
                return addr(new InterfaceAnnounceMessage(Header:p.Header));
            else if (any.Type == RTM_NEWADDR || any.Type == RTM_DELADDR) 
                p = (InterfaceAddrMessage.val)(@unsafe.Pointer(any));
                return addr(new InterfaceAddrMessage(Header:p.Header,Data:b[SizeofIfaMsghdr:any.Msglen]));
                        return null;

        }

        // InterfaceAnnounceMessage represents a routing message containing
        // network interface arrival and departure information.
        //
        // Deprecated: Use golang.org/x/net/route instead.
        public partial struct InterfaceAnnounceMessage
        {
            public IfAnnounceMsghdr Header;
        }

        private static (slice<Sockaddr>, error) sockaddr(this ptr<InterfaceAnnounceMessage> _addr_m)
        {
            slice<Sockaddr> _p0 = default;
            error _p0 = default!;
            ref InterfaceAnnounceMessage m = ref _addr_m.val;

            return (null, error.As(null!)!);
        }
    }
}
