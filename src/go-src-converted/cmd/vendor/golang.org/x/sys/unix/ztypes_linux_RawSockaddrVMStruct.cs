//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:29 UTC
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
        public partial struct RawSockaddrVM
        {
            // Constructors
            public RawSockaddrVM(NilType _)
            {
                this.Family = default;
                this.Reserved1 = default;
                this.Port = default;
                this.Cid = default;
                this.Flags = default;
                this.Zero = default;
            }

            public RawSockaddrVM(ushort Family = default, ushort Reserved1 = default, uint Port = default, uint Cid = default, byte Flags = default, array<byte> Zero = default)
            {
                this.Family = Family;
                this.Reserved1 = Reserved1;
                this.Port = Port;
                this.Cid = Cid;
                this.Flags = Flags;
                this.Zero = Zero;
            }

            // Enable comparisons between nil and RawSockaddrVM struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrVM value, NilType nil) => value.Equals(default(RawSockaddrVM));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrVM value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrVM value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrVM value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrVM(NilType nil) => default(RawSockaddrVM);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrVM RawSockaddrVM_cast(dynamic value)
        {
            return new RawSockaddrVM(value.Family, value.Reserved1, value.Port, value.Cid, value.Flags, value.Zero);
        }
    }
}}}}}}