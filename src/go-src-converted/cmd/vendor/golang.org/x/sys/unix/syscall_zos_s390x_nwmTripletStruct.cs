//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:27:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
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
        private partial struct nwmTriplet
        {
            // Constructors
            public nwmTriplet(NilType _)
            {
                this.offset = default;
                this.length = default;
                this.number = default;
            }

            public nwmTriplet(uint offset = default, uint length = default, uint number = default)
            {
                this.offset = offset;
                this.length = length;
                this.number = number;
            }

            // Enable comparisons between nil and nwmTriplet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nwmTriplet value, NilType nil) => value.Equals(default(nwmTriplet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nwmTriplet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nwmTriplet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nwmTriplet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nwmTriplet(NilType nil) => default(nwmTriplet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nwmTriplet nwmTriplet_cast(dynamic value)
        {
            return new nwmTriplet(value.offset, value.length, value.number);
        }
    }
}}}}}}