//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;

namespace go
{
    public static partial class strings_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stringWriter
        {
            // Constructors
            public stringWriter(NilType _)
            {
                this.w = default;
            }

            public stringWriter(io.Writer w = default)
            {
                this.w = w;
            }

            // Enable comparisons between nil and stringWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringWriter value, NilType nil) => value.Equals(default(stringWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringWriter(NilType nil) => default(stringWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stringWriter stringWriter_cast(dynamic value)
        {
            return new stringWriter(value.w);
        }
    }
}