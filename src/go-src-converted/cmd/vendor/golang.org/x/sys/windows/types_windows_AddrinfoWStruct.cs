//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        public partial struct AddrinfoW
        {
            // Constructors
            public AddrinfoW(NilType _)
            {
                this.Flags = default;
                this.Family = default;
                this.Socktype = default;
                this.Protocol = default;
                this.Addrlen = default;
                this.Canonname = default;
                this.Addr = default;
                this.Next = default;
            }

            public AddrinfoW(int Flags = default, int Family = default, int Socktype = default, int Protocol = default, System.UIntPtr Addrlen = default, ref ptr<ushort> Canonname = default, System.UIntPtr Addr = default, ref ptr<AddrinfoW> Next = default)
            {
                this.Flags = Flags;
                this.Family = Family;
                this.Socktype = Socktype;
                this.Protocol = Protocol;
                this.Addrlen = Addrlen;
                this.Canonname = Canonname;
                this.Addr = Addr;
                this.Next = Next;
            }

            // Enable comparisons between nil and AddrinfoW struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AddrinfoW value, NilType nil) => value.Equals(default(AddrinfoW));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AddrinfoW value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AddrinfoW value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AddrinfoW value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AddrinfoW(NilType nil) => default(AddrinfoW);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static AddrinfoW AddrinfoW_cast(dynamic value)
        {
            return new AddrinfoW(value.Flags, value.Family, value.Socktype, value.Protocol, value.Addrlen, ref value.Canonname, value.Addr, ref value.Next);
        }
    }
}}}}}}