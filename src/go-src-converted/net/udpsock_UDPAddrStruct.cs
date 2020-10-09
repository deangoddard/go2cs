//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:52:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using syscall = go.syscall_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct UDPAddr
        {
            // Constructors
            public UDPAddr(NilType _)
            {
                this.IP = default;
                this.Port = default;
                this.Zone = default;
            }

            public UDPAddr(IP IP = default, long Port = default, @string Zone = default)
            {
                this.IP = IP;
                this.Port = Port;
                this.Zone = Zone;
            }

            // Enable comparisons between nil and UDPAddr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UDPAddr value, NilType nil) => value.Equals(default(UDPAddr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UDPAddr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UDPAddr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UDPAddr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UDPAddr(NilType nil) => default(UDPAddr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UDPAddr UDPAddr_cast(dynamic value)
        {
            return new UDPAddr(value.IP, value.Port, value.Zone);
        }
    }
}