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
        public partial struct Filetime
        {
            // Constructors
            public Filetime(NilType _)
            {
                this.LowDateTime = default;
                this.HighDateTime = default;
            }

            public Filetime(uint LowDateTime = default, uint HighDateTime = default)
            {
                this.LowDateTime = LowDateTime;
                this.HighDateTime = HighDateTime;
            }

            // Enable comparisons between nil and Filetime struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Filetime value, NilType nil) => value.Equals(default(Filetime));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Filetime value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Filetime value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Filetime value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Filetime(NilType nil) => default(Filetime);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Filetime Filetime_cast(dynamic value)
        {
            return new Filetime(value.LowDateTime, value.HighDateTime);
        }
    }
}}}}}}