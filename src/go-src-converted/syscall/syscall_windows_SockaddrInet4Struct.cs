//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:38:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errorspkg = go.errors_package;
using race = go.@internal.race_package;
using sync = go.sync_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrInet4
        {
            // Constructors
            public SockaddrInet4(NilType _)
            {
                this.Port = default;
                this.Addr = default;
                this.raw = default;
            }

            public SockaddrInet4(long Port = default, array<byte> Addr = default, RawSockaddrInet4 raw = default)
            {
                this.Port = Port;
                this.Addr = Addr;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrInet4 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrInet4 value, NilType nil) => value.Equals(default(SockaddrInet4));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrInet4 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrInet4 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrInet4 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrInet4(NilType nil) => default(SockaddrInet4);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrInet4 SockaddrInet4_cast(dynamic value)
        {
            return new SockaddrInet4(value.Port, value.Addr, value.raw);
        }
    }
}