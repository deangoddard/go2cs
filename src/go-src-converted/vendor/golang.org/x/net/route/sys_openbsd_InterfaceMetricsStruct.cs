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
        public partial struct InterfaceMetrics
        {
            // Constructors
            public InterfaceMetrics(NilType _)
            {
                this.Type = default;
                this.MTU = default;
            }

            public InterfaceMetrics(long Type = default, long MTU = default)
            {
                this.Type = Type;
                this.MTU = MTU;
            }

            // Enable comparisons between nil and InterfaceMetrics struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InterfaceMetrics value, NilType nil) => value.Equals(default(InterfaceMetrics));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InterfaceMetrics value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InterfaceMetrics value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InterfaceMetrics value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InterfaceMetrics(NilType nil) => default(InterfaceMetrics);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InterfaceMetrics InterfaceMetrics_cast(dynamic value)
        {
            return new InterfaceMetrics(value.Type, value.MTU);
        }
    }
}}}}}