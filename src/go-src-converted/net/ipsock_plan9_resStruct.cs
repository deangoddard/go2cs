//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:26:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using os = go.os_package;
using syscall = go.syscall_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct res
        {
            // Constructors
            public res(NilType _)
            {
                this.fd = default;
                this.err = default;
            }

            public res(ref ptr<netFD> fd = default, error err = default)
            {
                this.fd = fd;
                this.err = err;
            }

            // Enable comparisons between nil and res struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(res value, NilType nil) => value.Equals(default(res));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(res value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, res value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, res value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator res(NilType nil) => default(res);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static res res_cast(dynamic value)
        {
            return new res(ref value.fd, value.err);
        }
    }
}