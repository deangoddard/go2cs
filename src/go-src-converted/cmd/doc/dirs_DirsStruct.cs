//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:15:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using exec = go.@internal.execabs_package;
using log = go.log_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using strings = go.strings_package;
using sync = go.sync_package;
using semver = go.golang.org.x.mod.semver_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Dirs
        {
            // Constructors
            public Dirs(NilType _)
            {
                this.scan = default;
                this.hist = default;
                this.offset = default;
            }

            public Dirs(channel<Dir> scan = default, slice<Dir> hist = default, nint offset = default)
            {
                this.scan = scan;
                this.hist = hist;
                this.offset = offset;
            }

            // Enable comparisons between nil and Dirs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dirs value, NilType nil) => value.Equals(default(Dirs));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dirs value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dirs value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dirs value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dirs(NilType nil) => default(Dirs);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Dirs Dirs_cast(dynamic value)
        {
            return new Dirs(value.scan, value.hist, value.offset);
        }
    }
}