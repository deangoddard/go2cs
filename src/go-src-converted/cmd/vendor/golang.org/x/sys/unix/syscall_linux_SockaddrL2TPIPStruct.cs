//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:56:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using runtime = go.runtime_package;
using syscall = go.syscall_package;
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
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrL2TPIP
        {
            // Constructors
            public SockaddrL2TPIP(NilType _)
            {
                this.Addr = default;
                this.ConnId = default;
                this.raw = default;
            }

            public SockaddrL2TPIP(array<byte> Addr = default, uint ConnId = default, RawSockaddrL2TPIP raw = default)
            {
                this.Addr = Addr;
                this.ConnId = ConnId;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrL2TPIP struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrL2TPIP value, NilType nil) => value.Equals(default(SockaddrL2TPIP));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrL2TPIP value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrL2TPIP value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrL2TPIP value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrL2TPIP(NilType nil) => default(SockaddrL2TPIP);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrL2TPIP SockaddrL2TPIP_cast(dynamic value)
        {
            return new SockaddrL2TPIP(value.Addr, value.ConnId, value.raw);
        }
    }
}}}}}}