//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct chantype
        {
            // Constructors
            public chantype(NilType _)
            {
                this.typ = default;
                this.elem = default;
                this.dir = default;
            }

            public chantype(_type typ = default, ref ptr<_type> elem = default, System.UIntPtr dir = default)
            {
                this.typ = typ;
                this.elem = elem;
                this.dir = dir;
            }

            // Enable comparisons between nil and chantype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(chantype value, NilType nil) => value.Equals(default(chantype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(chantype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, chantype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, chantype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chantype(NilType nil) => default(chantype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static chantype chantype_cast(dynamic value)
        {
            return new chantype(value.typ, ref value.elem, value.dir);
        }
    }
}