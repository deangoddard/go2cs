//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RawSockaddr
        {
            // Constructors
            public RawSockaddr(NilType _)
            {
                this.Len = default;
                this.Family = default;
                this.Data = default;
            }

            public RawSockaddr(byte Len = default, byte Family = default, array<sbyte> Data = default)
            {
                this.Len = Len;
                this.Family = Family;
                this.Data = Data;
            }

            // Enable comparisons between nil and RawSockaddr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddr value, NilType nil) => value.Equals(default(RawSockaddr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddr(NilType nil) => default(RawSockaddr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddr RawSockaddr_cast(dynamic value)
        {
            return new RawSockaddr(value.Len, value.Family, value.Data);
        }
    }
}}}}}}