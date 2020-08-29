// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package rpc -- go2cs converted at 2020 August 29 08:36:32 UTC
// import "net/rpc" ==> using rpc = go.net.rpc_package
// Original source: C:\Go\src\net\rpc\debug.go
/*
    Some HTML presented at http://machine:port/debug/rpc
    Lists services, their methods, and some statistics, still rudimentary.
*/

using fmt = go.fmt_package;
using template = go.html.template_package;
using http = go.net.http_package;
using sort = go.sort_package;
using static go.builtin;
using System;

namespace go {
namespace net
{
    public static partial class rpc_package
    {
        private static readonly @string debugText = @"<html>
	<body>
	<title>Services</title>
	{{range .}}
	<hr>
	Service {{.Name}}
	<hr>
		<table>
		<th align=center>Method</th><th align=center>Calls</th>
		{{range .Method}}
			<tr>
			<td align=left font=fixed>{{.Name}}({{.Type.ArgType}}, {{.Type.ReplyType}}) error</td>
			<td align=center>{{.Type.NumCalls}}</td>
			</tr>
		{{end}}
		</table>
	{{end}}
	</body>
	</html>";



        private static var debug = template.Must(template.New("RPC debug").Parse(debugText));

        // If set, print log statements for internal and I/O errors.
        private static var debugLog = false;

        private partial struct debugMethod
        {
            public ptr<methodType> Type;
            public @string Name;
        }

        private partial struct methodArray // : slice<debugMethod>
        {
        }

        private partial struct debugService
        {
            public ptr<service> Service;
            public @string Name;
            public methodArray Method;
        }

        private partial struct serviceArray // : slice<debugService>
        {
        }

        private static long Len(this serviceArray s)
        {
            return len(s);
        }
        private static bool Less(this serviceArray s, long i, long j)
        {
            return s[i].Name < s[j].Name;
        }
        private static void Swap(this serviceArray s, long i, long j)
        {
            s[i] = s[j];
            s[j] = s[i];

        }

        private static long Len(this methodArray m)
        {
            return len(m);
        }
        private static bool Less(this methodArray m, long i, long j)
        {
            return m[i].Name < m[j].Name;
        }
        private static void Swap(this methodArray m, long i, long j)
        {
            m[i] = m[j];
            m[j] = m[i];

        }

        private partial struct debugHTTP
        {
            public ref Server Server => ref Server_ptr;
        }

        // Runs at /debug/rpc
        private static void ServeHTTP(this debugHTTP server, http.ResponseWriter w, ref http.Request req)
        { 
            // Build a sorted version of the data.
            serviceArray services = default;
            server.serviceMap.Range((snamei, svci) =>
            {
                ref service svc = svci._<ref service>();
                debugService ds = new debugService(svc,snamei.(string),make(methodArray,0,len(svc.method)));
                foreach (var (mname, method) in svc.method)
                {
                    ds.Method = append(ds.Method, new debugMethod(method,mname));
                }
                sort.Sort(ds.Method);
                services = append(services, ds);
                return true;
            });
            sort.Sort(services);
            var err = debug.Execute(w, services);
            if (err != null)
            {
                fmt.Fprintln(w, "rpc: error executing template:", err.Error());
            }
        }
    }
}}
