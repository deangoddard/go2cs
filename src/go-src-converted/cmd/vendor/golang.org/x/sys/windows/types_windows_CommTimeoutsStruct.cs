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
        public partial struct CommTimeouts
        {
            // Constructors
            public CommTimeouts(NilType _)
            {
                this.ReadIntervalTimeout = default;
                this.ReadTotalTimeoutMultiplier = default;
                this.ReadTotalTimeoutConstant = default;
                this.WriteTotalTimeoutMultiplier = default;
                this.WriteTotalTimeoutConstant = default;
            }

            public CommTimeouts(uint ReadIntervalTimeout = default, uint ReadTotalTimeoutMultiplier = default, uint ReadTotalTimeoutConstant = default, uint WriteTotalTimeoutMultiplier = default, uint WriteTotalTimeoutConstant = default)
            {
                this.ReadIntervalTimeout = ReadIntervalTimeout;
                this.ReadTotalTimeoutMultiplier = ReadTotalTimeoutMultiplier;
                this.ReadTotalTimeoutConstant = ReadTotalTimeoutConstant;
                this.WriteTotalTimeoutMultiplier = WriteTotalTimeoutMultiplier;
                this.WriteTotalTimeoutConstant = WriteTotalTimeoutConstant;
            }

            // Enable comparisons between nil and CommTimeouts struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CommTimeouts value, NilType nil) => value.Equals(default(CommTimeouts));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CommTimeouts value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CommTimeouts value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CommTimeouts value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CommTimeouts(NilType nil) => default(CommTimeouts);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CommTimeouts CommTimeouts_cast(dynamic value)
        {
            return new CommTimeouts(value.ReadIntervalTimeout, value.ReadTotalTimeoutMultiplier, value.ReadTotalTimeoutConstant, value.WriteTotalTimeoutMultiplier, value.WriteTotalTimeoutConstant);
        }
    }
}}}}}}