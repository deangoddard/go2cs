//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using http = go.net.http_package;
using regexp = go.regexp_package;
using time = go.time_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class plugin_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Options
        {
            // Constructors
            public Options(NilType _)
            {
                this.Writer = default;
                this.Flagset = default;
                this.Fetch = default;
                this.Sym = default;
                this.Obj = default;
                this.UI = default;
                this.HTTPServer = default;
                this.HTTPTransport = default;
            }

            public Options(Writer Writer = default, FlagSet Flagset = default, Fetcher Fetch = default, Symbolizer Sym = default, ObjTool Obj = default, UI UI = default, Func<ptr<HTTPServerArgs>, error> HTTPServer = default, http.RoundTripper HTTPTransport = default)
            {
                this.Writer = Writer;
                this.Flagset = Flagset;
                this.Fetch = Fetch;
                this.Sym = Sym;
                this.Obj = Obj;
                this.UI = UI;
                this.HTTPServer = HTTPServer;
                this.HTTPTransport = HTTPTransport;
            }

            // Enable comparisons between nil and Options struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Options value, NilType nil) => value.Equals(default(Options));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Options value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Options value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Options value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Options(NilType nil) => default(Options);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Options Options_cast(dynamic value)
        {
            return new Options(value.Writer, value.Flagset, value.Fetch, value.Sym, value.Obj, value.UI, value.HTTPServer, value.HTTPTransport);
        }
    }
}}}}}}}