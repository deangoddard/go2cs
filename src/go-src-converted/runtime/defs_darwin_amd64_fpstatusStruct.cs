//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fpstatus
        {
            // Constructors
            public fpstatus(NilType _)
            {
                this.pad_cgo_0 = default;
            }

            public fpstatus(array<byte> pad_cgo_0 = default)
            {
                this.pad_cgo_0 = pad_cgo_0;
            }

            // Enable comparisons between nil and fpstatus struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fpstatus value, NilType nil) => value.Equals(default(fpstatus));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fpstatus value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fpstatus value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fpstatus value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fpstatus(NilType nil) => default(fpstatus);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fpstatus fpstatus_cast(dynamic value)
        {
            return new fpstatus(value.pad_cgo_0);
        }
    }
}