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
        public partial struct Strioctl
        {
            // Constructors
            public Strioctl(NilType _)
            {
                this.Cmd = default;
                this.Timout = default;
                this.Len = default;
                this.Dp = default;
            }

            public Strioctl(int Cmd = default, int Timout = default, int Len = default, ref ptr<sbyte> Dp = default)
            {
                this.Cmd = Cmd;
                this.Timout = Timout;
                this.Len = Len;
                this.Dp = Dp;
            }

            // Enable comparisons between nil and Strioctl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Strioctl value, NilType nil) => value.Equals(default(Strioctl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Strioctl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Strioctl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Strioctl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Strioctl(NilType nil) => default(Strioctl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Strioctl Strioctl_cast(dynamic value)
        {
            return new Strioctl(value.Cmd, value.Timout, value.Len, ref value.Dp);
        }
    }
}}}}}}