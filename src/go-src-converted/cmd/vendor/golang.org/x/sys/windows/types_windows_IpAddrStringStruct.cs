//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using net = go.net_package;
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
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IpAddrString
        {
            // Constructors
            public IpAddrString(NilType _)
            {
                this.Next = default;
                this.IpAddress = default;
                this.IpMask = default;
                this.Context = default;
            }

            public IpAddrString(ref ptr<IpAddrString> Next = default, IpAddressString IpAddress = default, IpMaskString IpMask = default, uint Context = default)
            {
                this.Next = Next;
                this.IpAddress = IpAddress;
                this.IpMask = IpMask;
                this.Context = Context;
            }

            // Enable comparisons between nil and IpAddrString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IpAddrString value, NilType nil) => value.Equals(default(IpAddrString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IpAddrString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IpAddrString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IpAddrString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IpAddrString(NilType nil) => default(IpAddrString);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IpAddrString IpAddrString_cast(dynamic value)
        {
            return new IpAddrString(ref value.Next, value.IpAddress, value.IpMask, value.Context);
        }
    }
}}}}}}