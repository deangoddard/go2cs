//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using runtime = go.runtime_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Inet4Addr
        {
            // Constructors
            public Inet4Addr(NilType _)
            {
                this.IP = default;
            }

            public Inet4Addr(array<byte> IP = default)
            {
                this.IP = IP;
            }

            // Enable comparisons between nil and Inet4Addr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Inet4Addr value, NilType nil) => value.Equals(default(Inet4Addr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Inet4Addr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Inet4Addr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Inet4Addr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Inet4Addr(NilType nil) => default(Inet4Addr);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Inet4Addr Inet4Addr_cast(dynamic value)
        {
            return new Inet4Addr(value.IP);
        }
    }
}}}}}