//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:28 UTC
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
        public partial struct Fsid64_t
        {
            // Constructors
            public Fsid64_t(NilType _)
            {
                this.Val = default;
            }

            public Fsid64_t(array<ulong> Val = default)
            {
                this.Val = Val;
            }

            // Enable comparisons between nil and Fsid64_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Fsid64_t value, NilType nil) => value.Equals(default(Fsid64_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Fsid64_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Fsid64_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Fsid64_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Fsid64_t(NilType nil) => default(Fsid64_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Fsid64_t Fsid64_t_cast(dynamic value)
        {
            return new Fsid64_t(value.Val);
        }
    }
}}}}}}