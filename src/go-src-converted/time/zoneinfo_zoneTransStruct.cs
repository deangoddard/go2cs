//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using sync = go.sync_package;
using syscall = go.syscall_package;

namespace go
{
    public static partial class time_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct zoneTrans
        {
            // Constructors
            public zoneTrans(NilType _)
            {
                this.when = default;
                this.index = default;
                this.isstd = default;
                this.isutc = default;
            }

            public zoneTrans(long when = default, byte index = default, bool isstd = default, bool isutc = default)
            {
                this.when = when;
                this.index = index;
                this.isstd = isstd;
                this.isutc = isutc;
            }

            // Enable comparisons between nil and zoneTrans struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(zoneTrans value, NilType nil) => value.Equals(default(zoneTrans));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(zoneTrans value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, zoneTrans value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, zoneTrans value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator zoneTrans(NilType nil) => default(zoneTrans);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static zoneTrans zoneTrans_cast(dynamic value)
        {
            return new zoneTrans(value.when, value.index, value.isstd, value.isutc);
        }
    }
}