//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using poll = go.@internal.poll_package;
using unix = go.@internal.syscall.unix_package;
using runtime = go.runtime_package;
using syscall = go.syscall_package;

#nullable enable

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct file
        {
            // Constructors
            public file(NilType _)
            {
                this.pfd = default;
                this.name = default;
                this.dirinfo = default;
                this.nonblock = default;
                this.stdoutOrErr = default;
                this.appendMode = default;
            }

            public file(poll.FD pfd = default, @string name = default, ref ptr<dirInfo> dirinfo = default, bool nonblock = default, bool stdoutOrErr = default, bool appendMode = default)
            {
                this.pfd = pfd;
                this.name = name;
                this.dirinfo = dirinfo;
                this.nonblock = nonblock;
                this.stdoutOrErr = stdoutOrErr;
                this.appendMode = appendMode;
            }

            // Enable comparisons between nil and file struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(file value, NilType nil) => value.Equals(default(file));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(file value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, file value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, file value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator file(NilType nil) => default(file);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static file file_cast(dynamic value)
        {
            return new file(value.pfd, value.name, ref value.dirinfo, value.nonblock, value.stdoutOrErr, value.appendMode);
        }
    }
}