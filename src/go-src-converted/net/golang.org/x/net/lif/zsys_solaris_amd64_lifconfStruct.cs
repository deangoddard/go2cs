//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:51:49 UTC
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
namespace golang.org {
namespace x {
namespace net
{
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lifconf
        {
            // Constructors
            public lifconf(NilType _)
            {
                this.Family = default;
                this.Pad_cgo_0 = default;
                this.Flags = default;
                this.Len = default;
                this.Pad_cgo_1 = default;
                this.Lifcu = default;
            }

            public lifconf(ushort Family = default, array<byte> Pad_cgo_0 = default, int Flags = default, int Len = default, array<byte> Pad_cgo_1 = default, array<byte> Lifcu = default)
            {
                this.Family = Family;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Flags = Flags;
                this.Len = Len;
                this.Pad_cgo_1 = Pad_cgo_1;
                this.Lifcu = Lifcu;
            }

            // Enable comparisons between nil and lifconf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lifconf value, NilType nil) => value.Equals(default(lifconf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lifconf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lifconf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lifconf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lifconf(NilType nil) => default(lifconf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lifconf lifconf_cast(dynamic value)
        {
            return new lifconf(value.Family, value.Pad_cgo_0, value.Flags, value.Len, value.Pad_cgo_1, value.Lifcu);
        }
    }
}}}}