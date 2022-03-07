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
        public partial struct Timex
        {
            // Constructors
            public Timex(NilType _)
            {
                this.Modes = default;
                this.Offset = default;
                this.Freq = default;
                this.Maxerror = default;
                this.Esterror = default;
                this.Status = default;
                this.Constant = default;
                this.Precision = default;
                this.Tolerance = default;
                this.Time = default;
                this.Tick = default;
                this.Ppsfreq = default;
                this.Jitter = default;
                this.Shift = default;
                this.Stabil = default;
                this.Jitcnt = default;
                this.Calcnt = default;
                this.Errcnt = default;
                this.Stbcnt = default;
                this.Tai = default;
                this._ = default;
            }

            public Timex(uint Modes = default, long Offset = default, long Freq = default, long Maxerror = default, long Esterror = default, int Status = default, long Constant = default, long Precision = default, long Tolerance = default, Timeval Time = default, long Tick = default, long Ppsfreq = default, long Jitter = default, int Shift = default, long Stabil = default, long Jitcnt = default, long Calcnt = default, long Errcnt = default, long Stbcnt = default, int Tai = default, array<byte> _ = default)
            {
                this.Modes = Modes;
                this.Offset = Offset;
                this.Freq = Freq;
                this.Maxerror = Maxerror;
                this.Esterror = Esterror;
                this.Status = Status;
                this.Constant = Constant;
                this.Precision = Precision;
                this.Tolerance = Tolerance;
                this.Time = Time;
                this.Tick = Tick;
                this.Ppsfreq = Ppsfreq;
                this.Jitter = Jitter;
                this.Shift = Shift;
                this.Stabil = Stabil;
                this.Jitcnt = Jitcnt;
                this.Calcnt = Calcnt;
                this.Errcnt = Errcnt;
                this.Stbcnt = Stbcnt;
                this.Tai = Tai;
                this._ = _;
            }

            // Enable comparisons between nil and Timex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Timex value, NilType nil) => value.Equals(default(Timex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Timex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Timex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Timex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Timex(NilType nil) => default(Timex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Timex Timex_cast(dynamic value)
        {
            return new Timex(value.Modes, value.Offset, value.Freq, value.Maxerror, value.Esterror, value.Status, value.Constant, value.Precision, value.Tolerance, value.Time, value.Tick, value.Ppsfreq, value.Jitter, value.Shift, value.Stabil, value.Jitcnt, value.Calcnt, value.Errcnt, value.Stbcnt, value.Tai, value._);
        }
    }
}}}}}}