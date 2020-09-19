//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:44:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using syscall = go.syscall_package;
using time = go.time_package;

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fileStat
        {
            // Constructors
            public fileStat(NilType _)
            {
                this.name = default;
                this.size = default;
                this.mode = default;
                this.modTime = default;
                this.sys = default;
            }

            public fileStat(@string name = default, long size = default, FileMode mode = default, time.Time modTime = default, syscall.Stat_t sys = default)
            {
                this.name = name;
                this.size = size;
                this.mode = mode;
                this.modTime = modTime;
                this.sys = sys;
            }

            // Enable comparisons between nil and fileStat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileStat value, NilType nil) => value.Equals(default(fileStat));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileStat value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileStat value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileStat value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileStat(NilType nil) => default(fileStat);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fileStat fileStat_cast(dynamic value)
        {
            return new fileStat(value.name, value.size, value.mode, value.modTime, value.sys);
        }
    }
}