//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:33 UTC
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
        public partial struct IfInfomsg
        {
            // Constructors
            public IfInfomsg(NilType _)
            {
                this.Family = default;
                this._ = default;
                this.Type = default;
                this.Index = default;
                this.Flags = default;
                this.Change = default;
            }

            public IfInfomsg(byte Family = default, byte _ = default, ushort Type = default, int Index = default, uint Flags = default, uint Change = default)
            {
                this.Family = Family;
                this._ = _;
                this.Type = Type;
                this.Index = Index;
                this.Flags = Flags;
                this.Change = Change;
            }

            // Enable comparisons between nil and IfInfomsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfInfomsg value, NilType nil) => value.Equals(default(IfInfomsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfInfomsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfInfomsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfInfomsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfInfomsg(NilType nil) => default(IfInfomsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfInfomsg IfInfomsg_cast(dynamic value)
        {
            return new IfInfomsg(value.Family, value._, value.Type, value.Index, value.Flags, value.Change);
        }
    }
}}}}}}