//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:51 UTC
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
        public partial struct ICMPv6Filter
        {
            // Constructors
            public ICMPv6Filter(NilType _)
            {
                this.X__icmp6_filt = default;
            }

            public ICMPv6Filter(array<uint> X__icmp6_filt = default)
            {
                this.X__icmp6_filt = X__icmp6_filt;
            }

            // Enable comparisons between nil and ICMPv6Filter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ICMPv6Filter value, NilType nil) => value.Equals(default(ICMPv6Filter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ICMPv6Filter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ICMPv6Filter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ICMPv6Filter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ICMPv6Filter(NilType nil) => default(ICMPv6Filter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ICMPv6Filter ICMPv6Filter_cast(dynamic value)
        {
            return new ICMPv6Filter(value.X__icmp6_filt);
        }
    }
}