//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:24 UTC
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
        private partial struct mibentry
        {
            // Constructors
            public mibentry(NilType _)
            {
                this.ctlname = default;
                this.ctloid = default;
            }

            public mibentry(@string ctlname = default, slice<_C_int> ctloid = default)
            {
                this.ctlname = ctlname;
                this.ctloid = ctloid;
            }

            // Enable comparisons between nil and mibentry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mibentry value, NilType nil) => value.Equals(default(mibentry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mibentry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mibentry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mibentry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mibentry(NilType nil) => default(mibentry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mibentry mibentry_cast(dynamic value)
        {
            return new mibentry(value.ctlname, value.ctloid);
        }
    }
}}}}}}