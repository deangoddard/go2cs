//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:32 UTC
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
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct elfVerdef
        {
            // Constructors
            public elfVerdef(NilType _)
            {
                this.vd_version = default;
                this.vd_flags = default;
                this.vd_ndx = default;
                this.vd_cnt = default;
                this.vd_hash = default;
                this.vd_aux = default;
                this.vd_next = default;
            }

            public elfVerdef(ushort vd_version = default, ushort vd_flags = default, ushort vd_ndx = default, ushort vd_cnt = default, uint vd_hash = default, uint vd_aux = default, uint vd_next = default)
            {
                this.vd_version = vd_version;
                this.vd_flags = vd_flags;
                this.vd_ndx = vd_ndx;
                this.vd_cnt = vd_cnt;
                this.vd_hash = vd_hash;
                this.vd_aux = vd_aux;
                this.vd_next = vd_next;
            }

            // Enable comparisons between nil and elfVerdef struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elfVerdef value, NilType nil) => value.Equals(default(elfVerdef));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elfVerdef value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elfVerdef value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elfVerdef value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elfVerdef(NilType nil) => default(elfVerdef);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static elfVerdef elfVerdef_cast(dynamic value)
        {
            return new elfVerdef(value.vd_version, value.vd_flags, value.vd_ndx, value.vd_cnt, value.vd_hash, value.vd_aux, value.vd_next);
        }
    }
}