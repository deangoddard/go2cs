//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:27:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct SockaddrNetlink
        {
            // Constructors
            public SockaddrNetlink(NilType _)
            {
                this.Family = default;
                this.Pad = default;
                this.Pid = default;
                this.Groups = default;
                this.raw = default;
            }

            public SockaddrNetlink(ushort Family = default, ushort Pad = default, uint Pid = default, uint Groups = default, RawSockaddrNetlink raw = default)
            {
                this.Family = Family;
                this.Pad = Pad;
                this.Pid = Pid;
                this.Groups = Groups;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrNetlink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrNetlink value, NilType nil) => value.Equals(default(SockaddrNetlink));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrNetlink value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrNetlink value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrNetlink value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrNetlink(NilType nil) => default(SockaddrNetlink);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrNetlink SockaddrNetlink_cast(dynamic value)
        {
            return new SockaddrNetlink(value.Family, value.Pad, value.Pid, value.Groups, value.raw);
        }
    }
}}}}}}