//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:31 UTC
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
        public partial struct Timeval
        {
            // Constructors
            public Timeval(NilType _)
            {
                this.Sec = default;
                this.Usec = default;
            }

            public Timeval(long Sec = default, long Usec = default)
            {
                this.Sec = Sec;
                this.Usec = Usec;
            }

            // Enable comparisons between nil and Timeval struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Timeval value, NilType nil) => value.Equals(default(Timeval));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Timeval value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Timeval value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Timeval value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Timeval(NilType nil) => default(Timeval);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Timeval Timeval_cast(dynamic value)
        {
            return new Timeval(value.Sec, value.Usec);
        }
    }
}}}}}}