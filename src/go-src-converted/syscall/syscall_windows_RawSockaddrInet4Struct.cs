//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:27:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errorspkg = go.errors_package;
using itoa = go.@internal.itoa_package;
using oserror = go.@internal.oserror_package;
using race = go.@internal.race_package;
using unsafeheader = go.@internal.unsafeheader_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RawSockaddrInet4
        {
            // Constructors
            public RawSockaddrInet4(NilType _)
            {
                this.Family = default;
                this.Port = default;
                this.Addr = default;
                this.Zero = default;
            }

            public RawSockaddrInet4(ushort Family = default, ushort Port = default, array<byte> Addr = default, array<byte> Zero = default)
            {
                this.Family = Family;
                this.Port = Port;
                this.Addr = Addr;
                this.Zero = Zero;
            }

            // Enable comparisons between nil and RawSockaddrInet4 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrInet4 value, NilType nil) => value.Equals(default(RawSockaddrInet4));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrInet4 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrInet4 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrInet4 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrInet4(NilType nil) => default(RawSockaddrInet4);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrInet4 RawSockaddrInet4_cast(dynamic value)
        {
            return new RawSockaddrInet4(value.Family, value.Port, value.Addr, value.Zero);
        }
    }
}