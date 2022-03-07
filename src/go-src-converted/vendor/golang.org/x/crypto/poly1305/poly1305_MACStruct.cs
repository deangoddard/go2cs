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
using subtle = go.crypto.subtle_package;
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
        public partial struct MAC
        {
            // Constructors
            public MAC(NilType _)
            {
                this.mac = default;
                this.finalized = default;
            }

            public MAC(mac mac = default, bool finalized = default)
            {
                this.mac = mac;
                this.finalized = finalized;
            }

            // Enable comparisons between nil and MAC struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MAC value, NilType nil) => value.Equals(default(MAC));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MAC value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MAC value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MAC value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MAC(NilType nil) => default(MAC);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MAC MAC_cast(dynamic value)
        {
            return new MAC(value.mac, value.finalized);
        }
    }
}}}}}