//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:16:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using syscall = go.syscall_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IPConn
        {
            // Constructors
            public IPConn(NilType _)
            {
                this.conn = default;
            }

            public IPConn(conn conn = default)
            {
                this.conn = conn;
            }

            // Enable comparisons between nil and IPConn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPConn value, NilType nil) => value.Equals(default(IPConn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPConn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPConn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPConn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPConn(NilType nil) => default(IPConn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IPConn IPConn_cast(dynamic value)
        {
            return new IPConn(value.conn);
        }
    }
}