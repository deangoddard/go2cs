//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:36:52 UTC
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
namespace crypto
{
    public static partial class poly1305_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mac
        {
            // Constructors
            public mac(NilType _)
            {
                this.macGeneric = default;
            }

            public mac(macGeneric macGeneric = default)
            {
                this.macGeneric = macGeneric;
            }

            // Enable comparisons between nil and mac struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mac value, NilType nil) => value.Equals(default(mac));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mac value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mac value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mac value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mac(NilType nil) => default(mac);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mac mac_cast(dynamic value)
        {
            return new mac(value.macGeneric);
        }
    }
}}}}}