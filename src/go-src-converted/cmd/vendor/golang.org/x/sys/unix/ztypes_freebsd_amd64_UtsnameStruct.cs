//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

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
        public partial struct Utsname
        {
            // Constructors
            public Utsname(NilType _)
            {
                this.Sysname = default;
                this.Nodename = default;
                this.Release = default;
                this.Version = default;
                this.Machine = default;
            }

            public Utsname(array<byte> Sysname = default, array<byte> Nodename = default, array<byte> Release = default, array<byte> Version = default, array<byte> Machine = default)
            {
                this.Sysname = Sysname;
                this.Nodename = Nodename;
                this.Release = Release;
                this.Version = Version;
                this.Machine = Machine;
            }

            // Enable comparisons between nil and Utsname struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Utsname value, NilType nil) => value.Equals(default(Utsname));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Utsname value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Utsname value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Utsname value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Utsname(NilType nil) => default(Utsname);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Utsname Utsname_cast(dynamic value)
        {
            return new Utsname(value.Sysname, value.Nodename, value.Release, value.Version, value.Machine);
        }
    }
}}}}}}