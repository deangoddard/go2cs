//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct keventt
        {
            // Constructors
            public keventt(NilType _)
            {
                this.ident = default;
                this.filter = default;
                this.flags = default;
                this.fflags = default;
                this.pad_cgo_0 = default;
                this.data = default;
                this.udata = default;
                this.pad_cgo_1 = default;
            }

            public keventt(uint ident = default, short filter = default, ushort flags = default, uint fflags = default, array<byte> pad_cgo_0 = default, long data = default, ref ptr<byte> udata = default, array<byte> pad_cgo_1 = default)
            {
                this.ident = ident;
                this.filter = filter;
                this.flags = flags;
                this.fflags = fflags;
                this.pad_cgo_0 = pad_cgo_0;
                this.data = data;
                this.udata = udata;
                this.pad_cgo_1 = pad_cgo_1;
            }

            // Enable comparisons between nil and keventt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(keventt value, NilType nil) => value.Equals(default(keventt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(keventt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, keventt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, keventt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator keventt(NilType nil) => default(keventt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static keventt keventt_cast(dynamic value)
        {
            return new keventt(value.ident, value.filter, value.flags, value.fflags, value.pad_cgo_0, value.data, ref value.udata, value.pad_cgo_1);
        }
    }
}