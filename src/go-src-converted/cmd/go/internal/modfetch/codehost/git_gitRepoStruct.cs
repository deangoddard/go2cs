//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using exec = go.@internal.execabs_package;
using io = go.io_package;
using fs = go.io.fs_package;
using url = go.net.url_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using par = go.cmd.go.@internal.par_package;
using web = go.cmd.go.@internal.web_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal {
namespace modfetch
{
    public static partial class codehost_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gitRepo
        {
            // Constructors
            public gitRepo(NilType _)
            {
                this.remote = default;
                this.remoteURL = default;
                this.local = default;
                this.dir = default;
                this.mu = default;
                this.fetchLevel = default;
                this.statCache = default;
                this.refsOnce = default;
                this.refs = default;
                this.refsErr = default;
                this.localTagsOnce = default;
                this.localTags = default;
            }

            public gitRepo(@string remote = default, @string remoteURL = default, bool local = default, @string dir = default, lockedfile.Mutex mu = default, nint fetchLevel = default, par.Cache statCache = default, sync.Once refsOnce = default, map<@string, @string> refs = default, error refsErr = default, sync.Once localTagsOnce = default, map<@string, bool> localTags = default)
            {
                this.remote = remote;
                this.remoteURL = remoteURL;
                this.local = local;
                this.dir = dir;
                this.mu = mu;
                this.fetchLevel = fetchLevel;
                this.statCache = statCache;
                this.refsOnce = refsOnce;
                this.refs = refs;
                this.refsErr = refsErr;
                this.localTagsOnce = localTagsOnce;
                this.localTags = localTags;
            }

            // Enable comparisons between nil and gitRepo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gitRepo value, NilType nil) => value.Equals(default(gitRepo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gitRepo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gitRepo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gitRepo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gitRepo(NilType nil) => default(gitRepo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gitRepo gitRepo_cast(dynamic value)
        {
            return new gitRepo(value.remote, value.remoteURL, value.local, value.dir, value.mu, value.fetchLevel, value.statCache, value.refsOnce, value.refs, value.refsErr, value.localTagsOnce, value.localTags);
        }
    }
}}}}}