//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:35 UTC
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
        public partial struct Tms
        {
            // Constructors
            public Tms(NilType _)
            {
                this.Utime = default;
                this.Stime = default;
                this.Cutime = default;
                this.Cstime = default;
            }

            public Tms(long Utime = default, long Stime = default, long Cutime = default, long Cstime = default)
            {
                this.Utime = Utime;
                this.Stime = Stime;
                this.Cutime = Cutime;
                this.Cstime = Cstime;
            }

            // Enable comparisons between nil and Tms struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tms value, NilType nil) => value.Equals(default(Tms));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tms value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tms value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tms value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tms(NilType nil) => default(Tms);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tms Tms_cast(dynamic value)
        {
            return new Tms(value.Utime, value.Stime, value.Cutime, value.Cstime);
        }
    }
}}}}}}