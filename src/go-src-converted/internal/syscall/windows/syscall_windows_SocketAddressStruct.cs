//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:13:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using unsafeheader = go.@internal.unsafeheader_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace @internal {
namespace syscall
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SocketAddress
        {
            // Constructors
            public SocketAddress(NilType _)
            {
                this.Sockaddr = default;
                this.SockaddrLength = default;
            }

            public SocketAddress(ref ptr<syscall.RawSockaddrAny> Sockaddr = default, int SockaddrLength = default)
            {
                this.Sockaddr = Sockaddr;
                this.SockaddrLength = SockaddrLength;
            }

            // Enable comparisons between nil and SocketAddress struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SocketAddress value, NilType nil) => value.Equals(default(SocketAddress));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SocketAddress value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SocketAddress value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SocketAddress value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SocketAddress(NilType nil) => default(SocketAddress);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SocketAddress SocketAddress_cast(dynamic value)
        {
            return new SocketAddress(ref value.Sockaddr, value.SockaddrLength);
        }
    }
}}}