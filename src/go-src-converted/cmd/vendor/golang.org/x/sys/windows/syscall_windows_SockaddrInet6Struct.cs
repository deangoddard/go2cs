//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errorspkg = go.errors_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrInet6
        {
            // Constructors
            public SockaddrInet6(NilType _)
            {
                this.Port = default;
                this.ZoneId = default;
                this.Addr = default;
                this.raw = default;
            }

            public SockaddrInet6(long Port = default, uint ZoneId = default, array<byte> Addr = default, RawSockaddrInet6 raw = default)
            {
                this.Port = Port;
                this.ZoneId = ZoneId;
                this.Addr = Addr;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrInet6 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrInet6 value, NilType nil) => value.Equals(default(SockaddrInet6));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrInet6 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrInet6 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrInet6 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrInet6(NilType nil) => default(SockaddrInet6);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrInet6 SockaddrInet6_cast(dynamic value)
        {
            return new SockaddrInet6(value.Port, value.ZoneId, value.Addr, value.raw);
        }
    }
}}}}}}