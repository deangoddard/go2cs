//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:34 UTC
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
                this.Filt = default;
            }

            public ICMPv6Filter(array<uint> Filt = default)
            {
                this.Filt = Filt;
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
            return new ICMPv6Filter(value.Filt);
        }
    }
}