//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:49 UTC
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
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Radvisory_t
        {
            // Constructors
            public Radvisory_t(NilType _)
            {
                this.Offset = default;
                this.Count = default;
                this.Pad_cgo_0 = default;
            }

            public Radvisory_t(long Offset = default, int Count = default, array<byte> Pad_cgo_0 = default)
            {
                this.Offset = Offset;
                this.Count = Count;
                this.Pad_cgo_0 = Pad_cgo_0;
            }

            // Enable comparisons between nil and Radvisory_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Radvisory_t value, NilType nil) => value.Equals(default(Radvisory_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Radvisory_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Radvisory_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Radvisory_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Radvisory_t(NilType nil) => default(Radvisory_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Radvisory_t Radvisory_t_cast(dynamic value)
        {
            return new Radvisory_t(value.Offset, value.Count, value.Pad_cgo_0);
        }
    }
}