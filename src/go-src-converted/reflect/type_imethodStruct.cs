//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using unsafeheader = go.@internal.unsafeheader_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct imethod
        {
            // Constructors
            public imethod(NilType _)
            {
                this.name = default;
                this.typ = default;
            }

            public imethod(nameOff name = default, typeOff typ = default)
            {
                this.name = name;
                this.typ = typ;
            }

            // Enable comparisons between nil and imethod struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(imethod value, NilType nil) => value.Equals(default(imethod));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(imethod value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, imethod value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, imethod value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator imethod(NilType nil) => default(imethod);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static imethod imethod_cast(dynamic value)
        {
            return new imethod(value.name, value.typ);
        }
    }
}