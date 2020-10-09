//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:51 UTC
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
        private partial struct timeval
        {
            // Constructors
            public timeval(NilType _)
            {
                this.tv_sec = default;
                this.tv_usec = default;
            }

            public timeval(int tv_sec = default, int tv_usec = default)
            {
                this.tv_sec = tv_sec;
                this.tv_usec = tv_usec;
            }

            // Enable comparisons between nil and timeval struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(timeval value, NilType nil) => value.Equals(default(timeval));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(timeval value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, timeval value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, timeval value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator timeval(NilType nil) => default(timeval);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static timeval timeval_cast(dynamic value)
        {
            return new timeval(value.tv_sec, value.tv_usec);
        }
    }
}