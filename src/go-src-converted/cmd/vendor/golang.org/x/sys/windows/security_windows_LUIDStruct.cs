//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:52 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LUID
        {
            // Constructors
            public LUID(NilType _)
            {
                this.LowPart = default;
                this.HighPart = default;
            }

            public LUID(uint LowPart = default, int HighPart = default)
            {
                this.LowPart = LowPart;
                this.HighPart = HighPart;
            }

            // Enable comparisons between nil and LUID struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LUID value, NilType nil) => value.Equals(default(LUID));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LUID value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LUID value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LUID value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LUID(NilType nil) => default(LUID);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LUID LUID_cast(dynamic value)
        {
            return new LUID(value.LowPart, value.HighPart);
        }
    }
}}}}}}