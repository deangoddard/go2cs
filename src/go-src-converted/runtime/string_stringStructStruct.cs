//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:00 UTC
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
        private partial struct stringStruct
        {
            // Constructors
            public stringStruct(NilType _)
            {
                this.str = default;
                this.len = default;
            }

            public stringStruct(unsafe.Pointer str = default, long len = default)
            {
                this.str = str;
                this.len = len;
            }

            // Enable comparisons between nil and stringStruct struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringStruct value, NilType nil) => value.Equals(default(stringStruct));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringStruct value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringStruct value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringStruct value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringStruct(NilType nil) => default(stringStruct);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stringStruct stringStruct_cast(dynamic value)
        {
            return new stringStruct(value.str, value.len);
        }
    }
}