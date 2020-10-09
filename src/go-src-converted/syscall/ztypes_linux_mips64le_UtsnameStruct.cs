//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:29 UTC
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
    public static partial class syscall_package
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
                this.Domainname = default;
            }

            public Utsname(array<sbyte> Sysname = default, array<sbyte> Nodename = default, array<sbyte> Release = default, array<sbyte> Version = default, array<sbyte> Machine = default, array<sbyte> Domainname = default)
            {
                this.Sysname = Sysname;
                this.Nodename = Nodename;
                this.Release = Release;
                this.Version = Version;
                this.Machine = Machine;
                this.Domainname = Domainname;
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
            return new Utsname(value.Sysname, value.Nodename, value.Release, value.Version, value.Machine, value.Domainname);
        }
    }
}