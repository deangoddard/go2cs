//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:38:05 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lifnum
        {
            // Constructors
            public lifnum(NilType _)
            {
                this.Family = default;
                this.Pad_cgo_0 = default;
                this.Flags = default;
                this.Count = default;
            }

            public lifnum(ushort Family = default, array<byte> Pad_cgo_0 = default, int Flags = default, int Count = default)
            {
                this.Family = Family;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Flags = Flags;
                this.Count = Count;
            }

            // Enable comparisons between nil and lifnum struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lifnum value, NilType nil) => value.Equals(default(lifnum));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lifnum value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lifnum value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lifnum value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lifnum(NilType nil) => default(lifnum);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lifnum lifnum_cast(dynamic value)
        {
            return new lifnum(value.Family, value.Pad_cgo_0, value.Flags, value.Count);
        }
    }
}}}}}