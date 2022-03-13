//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:30:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using exec = go.@internal.execabs_package;
using lazyregexp = go.@internal.lazyregexp_package;
using singleflight = go.@internal.singleflight_package;
using fs = go.io.fs_package;
using log = go.log_package;
using urlpkg = go.net.url_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using search = go.cmd.go.@internal.search_package;
using str = go.cmd.go.@internal.str_package;
using web = go.cmd.go.@internal.web_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class vcs_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct vcsPath
        {
            // Constructors
            public vcsPath(NilType _)
            {
                this.pathPrefix = default;
                this.regexp = default;
                this.repo = default;
                this.vcs = default;
                this.check = default;
                this.schemelessRepo = default;
            }

            public vcsPath(@string pathPrefix = default, ref ptr<lazyregexp.Regexp> regexp = default, @string repo = default, @string vcs = default, Func<map<@string, @string>, error> check = default, bool schemelessRepo = default)
            {
                this.pathPrefix = pathPrefix;
                this.regexp = regexp;
                this.repo = repo;
                this.vcs = vcs;
                this.check = check;
                this.schemelessRepo = schemelessRepo;
            }

            // Enable comparisons between nil and vcsPath struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vcsPath value, NilType nil) => value.Equals(default(vcsPath));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vcsPath value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vcsPath value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vcsPath value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vcsPath(NilType nil) => default(vcsPath);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static vcsPath vcsPath_cast(dynamic value)
        {
            return new vcsPath(value.pathPrefix, ref value.regexp, value.repo, value.vcs, value.check, value.schemelessRepo);
        }
    }
}}}}