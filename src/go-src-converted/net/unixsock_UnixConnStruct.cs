//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:30:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct UnixConn
        {
            // Constructors
            public UnixConn(NilType _)
            {
                this.conn = default;
            }

            public UnixConn(conn conn = default)
            {
                this.conn = conn;
            }

            // Enable comparisons between nil and UnixConn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnixConn value, NilType nil) => value.Equals(default(UnixConn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnixConn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnixConn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnixConn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnixConn(NilType nil) => default(UnixConn);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static UnixConn UnixConn_cast(dynamic value)
        {
            return new UnixConn(value.conn);
        }
    }
}