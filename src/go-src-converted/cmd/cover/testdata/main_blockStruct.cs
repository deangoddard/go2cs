//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:59:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using os = go.os_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct block
        {
            // Constructors
            public block(NilType _)
            {
                this.count = default;
                this.line = default;
            }

            public block(uint count = default, uint line = default)
            {
                this.count = count;
                this.line = line;
            }

            // Enable comparisons between nil and block struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(block value, NilType nil) => value.Equals(default(block));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(block value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, block value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, block value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator block(NilType nil) => default(block);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static block block_cast(dynamic value)
        {
            return new block(value.count, value.line);
        }
    }
}