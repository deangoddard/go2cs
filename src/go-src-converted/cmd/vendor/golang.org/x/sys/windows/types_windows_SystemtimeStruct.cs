//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using net = go.net_package;
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
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Systemtime
        {
            // Constructors
            public Systemtime(NilType _)
            {
                this.Year = default;
                this.Month = default;
                this.DayOfWeek = default;
                this.Day = default;
                this.Hour = default;
                this.Minute = default;
                this.Second = default;
                this.Milliseconds = default;
            }

            public Systemtime(ushort Year = default, ushort Month = default, ushort DayOfWeek = default, ushort Day = default, ushort Hour = default, ushort Minute = default, ushort Second = default, ushort Milliseconds = default)
            {
                this.Year = Year;
                this.Month = Month;
                this.DayOfWeek = DayOfWeek;
                this.Day = Day;
                this.Hour = Hour;
                this.Minute = Minute;
                this.Second = Second;
                this.Milliseconds = Milliseconds;
            }

            // Enable comparisons between nil and Systemtime struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Systemtime value, NilType nil) => value.Equals(default(Systemtime));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Systemtime value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Systemtime value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Systemtime value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Systemtime(NilType nil) => default(Systemtime);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Systemtime Systemtime_cast(dynamic value)
        {
            return new Systemtime(value.Year, value.Month, value.DayOfWeek, value.Day, value.Hour, value.Minute, value.Second, value.Milliseconds);
        }
    }
}}}}}}