//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:23:56 UTC
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
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct ivalue
        {
            // Constructors
            public ivalue(NilType _)
            {
                this.name = default;
                this.value = default;
            }

            public ivalue(array<byte> name = default, short value = default)
            {
                this.name = name;
                this.value = value;
            }

            // Enable comparisons between nil and ivalue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ivalue value, NilType nil) => value.Equals(default(ivalue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ivalue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ivalue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ivalue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ivalue(NilType nil) => default(ivalue);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static ivalue ivalue_cast(dynamic value)
        {
            return new ivalue(value.name, value.value);
        }
    }
}