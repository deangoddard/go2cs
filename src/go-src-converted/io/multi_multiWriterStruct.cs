//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:12:43 UTC
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
    public static partial class io_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct multiWriter
        {
            // Constructors
            public multiWriter(NilType _)
            {
                this.writers = default;
            }

            public multiWriter(slice<Writer> writers = default)
            {
                this.writers = writers;
            }

            // Enable comparisons between nil and multiWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(multiWriter value, NilType nil) => value.Equals(default(multiWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(multiWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, multiWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, multiWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator multiWriter(NilType nil) => default(multiWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static multiWriter multiWriter_cast(dynamic value)
        {
            return new multiWriter(value.writers);
        }
    }
}