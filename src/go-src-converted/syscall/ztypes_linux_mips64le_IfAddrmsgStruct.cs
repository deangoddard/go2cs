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
        public partial struct IfAddrmsg
        {
            // Constructors
            public IfAddrmsg(NilType _)
            {
                this.Family = default;
                this.Prefixlen = default;
                this.Flags = default;
                this.Scope = default;
                this.Index = default;
            }

            public IfAddrmsg(byte Family = default, byte Prefixlen = default, byte Flags = default, byte Scope = default, uint Index = default)
            {
                this.Family = Family;
                this.Prefixlen = Prefixlen;
                this.Flags = Flags;
                this.Scope = Scope;
                this.Index = Index;
            }

            // Enable comparisons between nil and IfAddrmsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfAddrmsg value, NilType nil) => value.Equals(default(IfAddrmsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfAddrmsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfAddrmsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfAddrmsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfAddrmsg(NilType nil) => default(IfAddrmsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfAddrmsg IfAddrmsg_cast(dynamic value)
        {
            return new IfAddrmsg(value.Family, value.Prefixlen, value.Flags, value.Scope, value.Index);
        }
    }
}