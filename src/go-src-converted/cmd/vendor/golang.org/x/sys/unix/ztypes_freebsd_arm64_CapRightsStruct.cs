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
        public partial struct CapRights
        {
            // Constructors
            public CapRights(NilType _)
            {
                this.Rights = default;
            }

            public CapRights(array<ulong> Rights = default)
            {
                this.Rights = Rights;
            }

            // Enable comparisons between nil and CapRights struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CapRights value, NilType nil) => value.Equals(default(CapRights));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CapRights value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CapRights value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CapRights value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CapRights(NilType nil) => default(CapRights);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CapRights CapRights_cast(dynamic value)
        {
            return new CapRights(value.Rights);
        }
    }
}}}}}}