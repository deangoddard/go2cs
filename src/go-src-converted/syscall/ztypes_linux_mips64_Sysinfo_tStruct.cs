//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:28 UTC
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
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Sysinfo_t
        {
            // Constructors
            public Sysinfo_t(NilType _)
            {
                this.Uptime = default;
                this.Loads = default;
                this.Totalram = default;
                this.Freeram = default;
                this.Sharedram = default;
                this.Bufferram = default;
                this.Totalswap = default;
                this.Freeswap = default;
                this.Procs = default;
                this.Pad = default;
                this.Pad_cgo_0 = default;
                this.Totalhigh = default;
                this.Freehigh = default;
                this.Unit = default;
                this.X_f = default;
                this.Pad_cgo_1 = default;
            }

            public Sysinfo_t(long Uptime = default, array<ulong> Loads = default, ulong Totalram = default, ulong Freeram = default, ulong Sharedram = default, ulong Bufferram = default, ulong Totalswap = default, ulong Freeswap = default, ushort Procs = default, ushort Pad = default, array<byte> Pad_cgo_0 = default, ulong Totalhigh = default, ulong Freehigh = default, uint Unit = default, array<sbyte> X_f = default, array<byte> Pad_cgo_1 = default)
            {
                this.Uptime = Uptime;
                this.Loads = Loads;
                this.Totalram = Totalram;
                this.Freeram = Freeram;
                this.Sharedram = Sharedram;
                this.Bufferram = Bufferram;
                this.Totalswap = Totalswap;
                this.Freeswap = Freeswap;
                this.Procs = Procs;
                this.Pad = Pad;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Totalhigh = Totalhigh;
                this.Freehigh = Freehigh;
                this.Unit = Unit;
                this.X_f = X_f;
                this.Pad_cgo_1 = Pad_cgo_1;
            }

            // Enable comparisons between nil and Sysinfo_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sysinfo_t value, NilType nil) => value.Equals(default(Sysinfo_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sysinfo_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sysinfo_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sysinfo_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sysinfo_t(NilType nil) => default(Sysinfo_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Sysinfo_t Sysinfo_t_cast(dynamic value)
        {
            return new Sysinfo_t(value.Uptime, value.Loads, value.Totalram, value.Freeram, value.Sharedram, value.Bufferram, value.Totalswap, value.Freeswap, value.Procs, value.Pad, value.Pad_cgo_0, value.Totalhigh, value.Freehigh, value.Unit, value.X_f, value.Pad_cgo_1);
        }
    }
}