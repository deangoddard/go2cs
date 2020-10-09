//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:47 UTC
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
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct timespec
        {
            // Constructors
            public timespec(NilType _)
            {
                this.tv_sec = default;
                this.tv_nsec = default;
            }

            public timespec(long tv_sec = default, long tv_nsec = default)
            {
                this.tv_sec = tv_sec;
                this.tv_nsec = tv_nsec;
            }

            // Enable comparisons between nil and timespec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(timespec value, NilType nil) => value.Equals(default(timespec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(timespec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, timespec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, timespec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator timespec(NilType nil) => default(timespec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static timespec timespec_cast(dynamic value)
        {
            return new timespec(value.tv_sec, value.tv_nsec);
        }
    }
}