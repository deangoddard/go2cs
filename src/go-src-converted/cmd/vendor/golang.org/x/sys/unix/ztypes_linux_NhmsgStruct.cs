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
        public partial struct Nhmsg
        {
            // Constructors
            public Nhmsg(NilType _)
            {
                this.Family = default;
                this.Scope = default;
                this.Protocol = default;
                this.Resvd = default;
                this.Flags = default;
            }

            public Nhmsg(byte Family = default, byte Scope = default, byte Protocol = default, byte Resvd = default, uint Flags = default)
            {
                this.Family = Family;
                this.Scope = Scope;
                this.Protocol = Protocol;
                this.Resvd = Resvd;
                this.Flags = Flags;
            }

            // Enable comparisons between nil and Nhmsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Nhmsg value, NilType nil) => value.Equals(default(Nhmsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Nhmsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Nhmsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Nhmsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Nhmsg(NilType nil) => default(Nhmsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Nhmsg Nhmsg_cast(dynamic value)
        {
            return new Nhmsg(value.Family, value.Scope, value.Protocol, value.Resvd, value.Flags);
        }
    }
}}}}}}