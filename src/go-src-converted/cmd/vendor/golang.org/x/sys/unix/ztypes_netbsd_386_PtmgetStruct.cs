//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:31 UTC
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
        public partial struct Ptmget
        {
            // Constructors
            public Ptmget(NilType _)
            {
                this.Cfd = default;
                this.Sfd = default;
                this.Cn = default;
                this.Sn = default;
            }

            public Ptmget(int Cfd = default, int Sfd = default, array<byte> Cn = default, array<byte> Sn = default)
            {
                this.Cfd = Cfd;
                this.Sfd = Sfd;
                this.Cn = Cn;
                this.Sn = Sn;
            }

            // Enable comparisons between nil and Ptmget struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Ptmget value, NilType nil) => value.Equals(default(Ptmget));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Ptmget value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Ptmget value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Ptmget value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Ptmget(NilType nil) => default(Ptmget);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Ptmget Ptmget_cast(dynamic value)
        {
            return new Ptmget(value.Cfd, value.Sfd, value.Cn, value.Sn);
        }
    }
}}}}}}