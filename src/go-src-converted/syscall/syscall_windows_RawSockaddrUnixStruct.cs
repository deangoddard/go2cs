//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:27:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errorspkg = go.errors_package;
using itoa = go.@internal.itoa_package;
using oserror = go.@internal.oserror_package;
using race = go.@internal.race_package;
using unsafeheader = go.@internal.unsafeheader_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RawSockaddrUnix
        {
            // Constructors
            public RawSockaddrUnix(NilType _)
            {
                this.Family = default;
                this.Path = default;
            }

            public RawSockaddrUnix(ushort Family = default, array<sbyte> Path = default)
            {
                this.Family = Family;
                this.Path = Path;
            }

            // Enable comparisons between nil and RawSockaddrUnix struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrUnix value, NilType nil) => value.Equals(default(RawSockaddrUnix));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrUnix value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrUnix value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrUnix value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrUnix(NilType nil) => default(RawSockaddrUnix);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrUnix RawSockaddrUnix_cast(dynamic value)
        {
            return new RawSockaddrUnix(value.Family, value.Path);
        }
    }
}