//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:52:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using io = go.io_package;
using os = go.os_package;
using syscall = go.syscall_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TCPListener
        {
            // Constructors
            public TCPListener(NilType _)
            {
                this.fd = default;
                this.lc = default;
            }

            public TCPListener(ref ptr<netFD> fd = default, ListenConfig lc = default)
            {
                this.fd = fd;
                this.lc = lc;
            }

            // Enable comparisons between nil and TCPListener struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TCPListener value, NilType nil) => value.Equals(default(TCPListener));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TCPListener value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TCPListener value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TCPListener value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TCPListener(NilType nil) => default(TCPListener);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TCPListener TCPListener_cast(dynamic value)
        {
            return new TCPListener(ref value.fd, value.lc);
        }
    }
}