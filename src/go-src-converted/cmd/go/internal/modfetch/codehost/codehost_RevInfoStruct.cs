//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using sha256 = go.crypto.sha256_package;
using fmt = go.fmt_package;
using exec = go.@internal.execabs_package;
using io = go.io_package;
using fs = go.io.fs_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using cfg = go.cmd.go.@internal.cfg_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using str = go.cmd.go.@internal.str_package;
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
        public partial struct RevInfo
        {
            // Constructors
            public RevInfo(NilType _)
            {
                this.Name = default;
                this.Short = default;
                this.Version = default;
                this.Time = default;
                this.Tags = default;
            }

            public RevInfo(@string Name = default, @string Short = default, @string Version = default, time.Time Time = default, slice<@string> Tags = default)
            {
                this.Name = Name;
                this.Short = Short;
                this.Version = Version;
                this.Time = Time;
                this.Tags = Tags;
            }

            // Enable comparisons between nil and RevInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RevInfo value, NilType nil) => value.Equals(default(RevInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RevInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RevInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RevInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RevInfo(NilType nil) => default(RevInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RevInfo RevInfo_cast(dynamic value)
        {
            return new RevInfo(value.Name, value.Short, value.Version, value.Time, value.Tags);
        }
    }
}}}}}