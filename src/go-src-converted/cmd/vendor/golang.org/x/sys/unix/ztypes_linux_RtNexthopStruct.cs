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
        public partial struct RtNexthop
        {
            // Constructors
            public RtNexthop(NilType _)
            {
                this.Len = default;
                this.Flags = default;
                this.Hops = default;
                this.Ifindex = default;
            }

            public RtNexthop(ushort Len = default, byte Flags = default, byte Hops = default, int Ifindex = default)
            {
                this.Len = Len;
                this.Flags = Flags;
                this.Hops = Hops;
                this.Ifindex = Ifindex;
            }

            // Enable comparisons between nil and RtNexthop struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RtNexthop value, NilType nil) => value.Equals(default(RtNexthop));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RtNexthop value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RtNexthop value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RtNexthop value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RtNexthop(NilType nil) => default(RtNexthop);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RtNexthop RtNexthop_cast(dynamic value)
        {
            return new RtNexthop(value.Len, value.Flags, value.Hops, value.Ifindex);
        }
    }
}}}}}}