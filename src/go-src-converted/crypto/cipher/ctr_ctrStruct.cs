//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:53:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using subtle = go.crypto.@internal.subtle_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ctr
        {
            // Constructors
            public ctr(NilType _)
            {
                this.b = default;
                this.ctr = default;
                this.@out = default;
                this.outUsed = default;
            }

            public ctr(Block b = default, slice<byte> ctr = default, slice<byte> @out = default, long outUsed = default)
            {
                this.b = b;
                this.ctr = ctr;
                this.@out = @out;
                this.outUsed = outUsed;
            }

            // Enable comparisons between nil and ctr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ctr value, NilType nil) => value.Equals(default(ctr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ctr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ctr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ctr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ctr(NilType nil) => default(ctr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ctr ctr_cast(dynamic value)
        {
            return new ctr(value.b, value.ctr, value.@out, value.outUsed);
        }
    }
}}