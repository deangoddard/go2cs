//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


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

            public RawSockaddrInet4(ushort Family = default, ushort Port = default, array<byte> Addr = default, array<sbyte> Zero = default)
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