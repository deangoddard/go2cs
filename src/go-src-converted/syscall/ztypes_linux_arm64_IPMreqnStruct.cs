//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:49 UTC
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
        public partial struct IPMreqn
        {
            // Constructors
            public IPMreqn(NilType _)
            {
                this.Multiaddr = default;
                this.Address = default;
                this.Ifindex = default;
            }

            public IPMreqn(array<byte> Multiaddr = default, array<byte> Address = default, int Ifindex = default)
            {
                this.Multiaddr = Multiaddr;
                this.Address = Address;
                this.Ifindex = Ifindex;
            }

            // Enable comparisons between nil and IPMreqn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPMreqn value, NilType nil) => value.Equals(default(IPMreqn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPMreqn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPMreqn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPMreqn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPMreqn(NilType nil) => default(IPMreqn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IPMreqn IPMreqn_cast(dynamic value)
        {
            return new IPMreqn(value.Multiaddr, value.Address, value.Ifindex);
        }
    }
}