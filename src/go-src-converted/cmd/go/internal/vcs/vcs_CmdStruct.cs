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
        public partial struct Cmd
        {
            // Constructors
            public Cmd(NilType _)
            {
                this.Name = default;
                this.Cmd = default;
                this.CreateCmd = default;
                this.DownloadCmd = default;
                this.TagCmd = default;
                this.TagLookupCmd = default;
                this.TagSyncCmd = default;
                this.TagSyncDefault = default;
                this.Scheme = default;
                this.PingCmd = default;
                this.RemoteRepo = default;
                this.ResolveRepo = default;
            }

            public Cmd(@string Name = default, @string Cmd = default, slice<@string> CreateCmd = default, slice<@string> DownloadCmd = default, slice<tagCmd> TagCmd = default, slice<tagCmd> TagLookupCmd = default, slice<@string> TagSyncCmd = default, slice<@string> TagSyncDefault = default, slice<@string> Scheme = default, @string PingCmd = default, Func<ptr<Cmd>, @string, (@string, error)> RemoteRepo = default, Func<ptr<Cmd>, @string, @string, (@string, error)> ResolveRepo = default)
            {
                this.Name = Name;
                this.Cmd = Cmd;
                this.CreateCmd = CreateCmd;
                this.DownloadCmd = DownloadCmd;
                this.TagCmd = TagCmd;
                this.TagLookupCmd = TagLookupCmd;
                this.TagSyncCmd = TagSyncCmd;
                this.TagSyncDefault = TagSyncDefault;
                this.Scheme = Scheme;
                this.PingCmd = PingCmd;
                this.RemoteRepo = RemoteRepo;
                this.ResolveRepo = ResolveRepo;
            }

            // Enable comparisons between nil and Cmd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Cmd value, NilType nil) => value.Equals(default(Cmd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Cmd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Cmd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Cmd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Cmd(NilType nil) => default(Cmd);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Cmd Cmd_cast(dynamic value)
        {
            return new Cmd(value.Name, value.Cmd, value.CreateCmd, value.DownloadCmd, value.TagCmd, value.TagLookupCmd, value.TagSyncCmd, value.TagSyncDefault, value.Scheme, value.PingCmd, value.RemoteRepo, value.ResolveRepo);
        }
    }
}}}}