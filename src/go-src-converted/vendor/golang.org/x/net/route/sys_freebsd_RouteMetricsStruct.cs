//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:07:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RouteMetrics
        {
            // Constructors
            public RouteMetrics(NilType _)
            {
                this.PathMTU = default;
            }

            public RouteMetrics(long PathMTU = default)
            {
                this.PathMTU = PathMTU;
            }

            // Enable comparisons between nil and RouteMetrics struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RouteMetrics value, NilType nil) => value.Equals(default(RouteMetrics));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RouteMetrics value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RouteMetrics value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RouteMetrics value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RouteMetrics(NilType nil) => default(RouteMetrics);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RouteMetrics RouteMetrics_cast(dynamic value)
        {
            return new RouteMetrics(value.PathMTU);
        }
    }
}}}}}