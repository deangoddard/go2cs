//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:16:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lifreq
        {
            // Constructors
            public lifreq(NilType _)
            {
                this.Name = default;
                this.Lifru1 = default;
                this.Type = default;
                this.Lifru = default;
            }

            public lifreq(array<sbyte> Name = default, array<byte> Lifru1 = default, uint Type = default, array<byte> Lifru = default)
            {
                this.Name = Name;
                this.Lifru1 = Lifru1;
                this.Type = Type;
                this.Lifru = Lifru;
            }

            // Enable comparisons between nil and lifreq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lifreq value, NilType nil) => value.Equals(default(lifreq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lifreq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lifreq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lifreq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lifreq(NilType nil) => default(lifreq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lifreq lifreq_cast(dynamic value)
        {
            return new lifreq(value.Name, value.Lifru1, value.Type, value.Lifru);
        }
    }
}}}}