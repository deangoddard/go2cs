//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RawSockaddrNetlink
        {
            // Constructors
            public RawSockaddrNetlink(NilType _)
            {
                this.Family = default;
                this.Pad = default;
                this.Pid = default;
                this.Groups = default;
            }

            public RawSockaddrNetlink(ushort Family = default, ushort Pad = default, uint Pid = default, uint Groups = default)
            {
                this.Family = Family;
                this.Pad = Pad;
                this.Pid = Pid;
                this.Groups = Groups;
            }

            // Enable comparisons between nil and RawSockaddrNetlink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrNetlink value, NilType nil) => value.Equals(default(RawSockaddrNetlink));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrNetlink value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrNetlink value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrNetlink value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrNetlink(NilType nil) => default(RawSockaddrNetlink);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrNetlink RawSockaddrNetlink_cast(dynamic value)
        {
            return new RawSockaddrNetlink(value.Family, value.Pad, value.Pid, value.Groups);
        }
    }
}