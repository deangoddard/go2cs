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
        public partial struct IPMreq
        {
            // Constructors
            public IPMreq(NilType _)
            {
                this.Multiaddr = default;
                this.Interface = default;
            }

            public IPMreq(array<byte> Multiaddr = default, array<byte> Interface = default)
            {
                this.Multiaddr = Multiaddr;
                this.Interface = Interface;
            }

            // Enable comparisons between nil and IPMreq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPMreq value, NilType nil) => value.Equals(default(IPMreq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPMreq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPMreq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPMreq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPMreq(NilType nil) => default(IPMreq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IPMreq IPMreq_cast(dynamic value)
        {
            return new IPMreq(value.Multiaddr, value.Interface);
        }
    }
}}}}}}