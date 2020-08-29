// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build darwin dragonfly freebsd linux netbsd openbsd solaris

// package net -- go2cs converted at 2020 August 29 08:25:13 UTC
// import "net" ==> using net = go.net_package
// Original source: C:\Go\src\net\conf.go
using os = go.os_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using static go.builtin;
using System;

namespace go
{
    public static partial class net_package
    {
        // conf represents a system's network configuration.
        private partial struct conf
        {
            public bool forceCgoLookupHost;
            public bool netGo; // go DNS resolution forced
            public bool netCgo; // cgo DNS resolution forced

// machine has an /etc/mdns.allow file
            public bool hasMDNSAllow;
            public @string goos; // the runtime.GOOS, to ease testing
            public long dnsDebugLevel;
            public ptr<nssConf> nss;
            public ptr<dnsConfig> resolv;
        }

        private static sync.Once confOnce = default;        private static conf confVal = ref new conf(goos:runtime.GOOS);

        // systemConf returns the machine's network configuration.
        private static ref conf systemConf()
        {
            confOnce.Do(initConfVal);
            return confVal;
        }

        private static void initConfVal() => func((defer, _, __) =>
        {
            var (dnsMode, debugLevel) = goDebugNetDNS();
            confVal.dnsDebugLevel = debugLevel;
            confVal.netGo = netGo || dnsMode == "go";
            confVal.netCgo = netCgo || dnsMode == "cgo";

            if (confVal.dnsDebugLevel > 0L)
            {
                defer(() =>
                {

                    if (confVal.netGo) 
                        if (netGo)
                        {
                            println("go package net: built with netgo build tag; using Go's DNS resolver");
                        }
                        else
                        {
                            println("go package net: GODEBUG setting forcing use of Go's resolver");
                        }
                    else if (confVal.forceCgoLookupHost) 
                        println("go package net: using cgo DNS resolver");
                    else 
                        println("go package net: dynamic selection of DNS resolver");
                                    }());
            } 

            // Darwin pops up annoying dialog boxes if programs try to do
            // their own DNS requests. So always use cgo instead, which
            // avoids that.
            if (runtime.GOOS == "darwin")
            {
                confVal.forceCgoLookupHost = true;
                return;
            } 

            // If any environment-specified resolver options are specified,
            // force cgo. Note that LOCALDOMAIN can change behavior merely
            // by being specified with the empty string.
            var (_, localDomainDefined) = syscall.Getenv("LOCALDOMAIN");
            if (os.Getenv("RES_OPTIONS") != "" || os.Getenv("HOSTALIASES") != "" || confVal.netCgo || localDomainDefined)
            {
                confVal.forceCgoLookupHost = true;
                return;
            } 

            // OpenBSD apparently lets you override the location of resolv.conf
            // with ASR_CONFIG. If we notice that, defer to libc.
            if (runtime.GOOS == "openbsd" && os.Getenv("ASR_CONFIG") != "")
            {
                confVal.forceCgoLookupHost = true;
                return;
            }
            if (runtime.GOOS != "openbsd")
            {
                confVal.nss = parseNSSConfFile("/etc/nsswitch.conf");
            }
            confVal.resolv = dnsReadConfig("/etc/resolv.conf");
            if (confVal.resolv.err != null && !os.IsNotExist(confVal.resolv.err) && !os.IsPermission(confVal.resolv.err))
            { 
                // If we can't read the resolv.conf file, assume it
                // had something important in it and defer to cgo.
                // libc's resolver might then fail too, but at least
                // it wasn't our fault.
                confVal.forceCgoLookupHost = true;
            }
            {
                var (_, err) = os.Stat("/etc/mdns.allow");

                if (err == null)
                {
                    confVal.hasMDNSAllow = true;
                }

            }
        });

        // canUseCgo reports whether calling cgo functions is allowed
        // for non-hostname lookups.
        private static bool canUseCgo(this ref conf c)
        {
            return c.hostLookupOrder("") == hostLookupCgo;
        }

        // hostLookupOrder determines which strategy to use to resolve hostname.
        private static hostLookupOrder hostLookupOrder(this ref conf _c, @string hostname) => func(_c, (ref conf c, Defer defer, Panic _, Recover __) =>
        {
            if (c.dnsDebugLevel > 1L)
            {
                defer(() =>
                {
                    print("go package net: hostLookupOrder(", hostname, ") = ", ret.String(), "\n");
                }());
            }
            var fallbackOrder = hostLookupCgo;
            if (c.netGo)
            {
                fallbackOrder = hostLookupFilesDNS;
            }
            if (c.forceCgoLookupHost || c.resolv.unknownOpt || c.goos == "android")
            {
                return fallbackOrder;
            }
            if (byteIndex(hostname, '\\') != -1L || byteIndex(hostname, '%') != -1L)
            { 
                // Don't deal with special form hostnames with backslashes
                // or '%'.
                return fallbackOrder;
            } 

            // OpenBSD is unique and doesn't use nsswitch.conf.
            // It also doesn't support mDNS.
            if (c.goos == "openbsd")
            { 
                // OpenBSD's resolv.conf manpage says that a non-existent
                // resolv.conf means "lookup" defaults to only "files",
                // without DNS lookups.
                if (os.IsNotExist(c.resolv.err))
                {
                    return hostLookupFiles;
                }
                var lookup = c.resolv.lookup;
                if (len(lookup) == 0L)
                { 
                    // http://www.openbsd.org/cgi-bin/man.cgi/OpenBSD-current/man5/resolv.conf.5
                    // "If the lookup keyword is not used in the
                    // system's resolv.conf file then the assumed
                    // order is 'bind file'"
                    return hostLookupDNSFiles;
                }
                if (len(lookup) < 1L || len(lookup) > 2L)
                {
                    return fallbackOrder;
                }
                switch (lookup[0L])
                {
                    case "bind": 
                        if (len(lookup) == 2L)
                        {
                            if (lookup[1L] == "file")
                            {
                                return hostLookupDNSFiles;
                            }
                            return fallbackOrder;
                        }
                        return hostLookupDNS;
                        break;
                    case "file": 
                        if (len(lookup) == 2L)
                        {
                            if (lookup[1L] == "bind")
                            {
                                return hostLookupFilesDNS;
                            }
                            return fallbackOrder;
                        }
                        return hostLookupFiles;
                        break;
                    default: 
                        return fallbackOrder;
                        break;
                }
            } 

            // Canonicalize the hostname by removing any trailing dot.
            if (stringsHasSuffix(hostname, "."))
            {
                hostname = hostname[..len(hostname) - 1L];
            }
            if (stringsHasSuffixFold(hostname, ".local"))
            { 
                // Per RFC 6762, the ".local" TLD is special. And
                // because Go's native resolver doesn't do mDNS or
                // similar local resolution mechanisms, assume that
                // libc might (via Avahi, etc) and use cgo.
                return fallbackOrder;
            }
            var nss = c.nss;
            var srcs = nss.sources["hosts"]; 
            // If /etc/nsswitch.conf doesn't exist or doesn't specify any
            // sources for "hosts", assume Go's DNS will work fine.
            if (os.IsNotExist(nss.err) || (nss.err == null && len(srcs) == 0L))
            {
                if (c.goos == "solaris")
                { 
                    // illumos defaults to "nis [NOTFOUND=return] files"
                    return fallbackOrder;
                }
                if (c.goos == "linux")
                { 
                    // glibc says the default is "dns [!UNAVAIL=return] files"
                    // http://www.gnu.org/software/libc/manual/html_node/Notes-on-NSS-Configuration-File.html.
                    return hostLookupDNSFiles;
                }
                return hostLookupFilesDNS;
            }
            if (nss.err != null)
            { 
                // We failed to parse or open nsswitch.conf, so
                // conservatively assume we should use cgo if it's
                // available.
                return fallbackOrder;
            }
            bool mdnsSource = default;            bool filesSource = default;            bool dnsSource = default;

            @string first = default;
            foreach (var (_, src) in srcs)
            {
                if (src.source == "myhostname")
                {
                    if (isLocalhost(hostname) || isGateway(hostname))
                    {
                        return fallbackOrder;
                    }
                    var (hn, err) = getHostname();
                    if (err != null || stringsEqualFold(hostname, hn))
                    {
                        return fallbackOrder;
                    }
                    continue;
                }
                if (src.source == "files" || src.source == "dns")
                {
                    if (!src.standardCriteria())
                    {
                        return fallbackOrder; // non-standard; let libc deal with it.
                    }
                    if (src.source == "files")
                    {
                        filesSource = true;
                    }
                    else if (src.source == "dns")
                    {
                        dnsSource = true;
                    }
                    if (first == "")
                    {
                        first = src.source;
                    }
                    continue;
                }
                if (stringsHasPrefix(src.source, "mdns"))
                { 
                    // e.g. "mdns4", "mdns4_minimal"
                    // We already returned true before if it was *.local.
                    // libc wouldn't have found a hit on this anyway.
                    mdnsSource = true;
                    continue;
                } 
                // Some source we don't know how to deal with.
                return fallbackOrder;
            } 

            // We don't parse mdns.allow files. They're rare. If one
            // exists, it might list other TLDs (besides .local) or even
            // '*', so just let libc deal with it.
            if (mdnsSource && c.hasMDNSAllow)
            {
                return fallbackOrder;
            } 

            // Cases where Go can handle it without cgo and C thread
            // overhead.

            if (filesSource && dnsSource) 
                if (first == "files")
                {
                    return hostLookupFilesDNS;
                }
                else
                {
                    return hostLookupDNSFiles;
                }
            else if (filesSource) 
                return hostLookupFiles;
            else if (dnsSource) 
                return hostLookupDNS;
            // Something weird. Let libc deal with it.
            return fallbackOrder;
        });

        // goDebugNetDNS parses the value of the GODEBUG "netdns" value.
        // The netdns value can be of the form:
        //    1       // debug level 1
        //    2       // debug level 2
        //    cgo     // use cgo for DNS lookups
        //    go      // use go for DNS lookups
        //    cgo+1   // use cgo for DNS lookups + debug level 1
        //    1+cgo   // same
        //    cgo+2   // same, but debug level 2
        // etc.
        private static (@string, long) goDebugNetDNS()
        {
            var goDebug = goDebugString("netdns");
            Action<@string> parsePart = s =>
            {
                if (s == "")
                {
                    return;
                }
                if ('0' <= s[0L] && s[0L] <= '9')
                {
                    debugLevel, _, _ = dtoi(s);
                }
                else
                {
                    dnsMode = s;
                }
            }
;
            {
                var i = byteIndex(goDebug, '+');

                if (i != -1L)
                {
                    parsePart(goDebug[..i]);
                    parsePart(goDebug[i + 1L..]);
                    return;
                }

            }
            parsePart(goDebug);
            return;
        }

        // isLocalhost reports whether h should be considered a "localhost"
        // name for the myhostname NSS module.
        private static bool isLocalhost(@string h)
        {
            return stringsEqualFold(h, "localhost") || stringsEqualFold(h, "localhost.localdomain") || stringsHasSuffixFold(h, ".localhost") || stringsHasSuffixFold(h, ".localhost.localdomain");
        }

        // isGateway reports whether h should be considered a "gateway"
        // name for the myhostname NSS module.
        private static bool isGateway(@string h)
        {
            return stringsEqualFold(h, "gateway");
        }
    }
}
