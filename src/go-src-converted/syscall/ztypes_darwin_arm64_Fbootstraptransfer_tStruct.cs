//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:22 UTC
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
        public partial struct Fbootstraptransfer_t
        {
            // Constructors
            public Fbootstraptransfer_t(NilType _)
            {
                this.Offset = default;
                this.Length = default;
                this.Buffer = default;
            }

            public Fbootstraptransfer_t(long Offset = default, ulong Length = default, ref ptr<byte> Buffer = default)
            {
                this.Offset = Offset;
                this.Length = Length;
                this.Buffer = Buffer;
            }

            // Enable comparisons between nil and Fbootstraptransfer_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Fbootstraptransfer_t value, NilType nil) => value.Equals(default(Fbootstraptransfer_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Fbootstraptransfer_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Fbootstraptransfer_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Fbootstraptransfer_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Fbootstraptransfer_t(NilType nil) => default(Fbootstraptransfer_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Fbootstraptransfer_t Fbootstraptransfer_t_cast(dynamic value)
        {
            return new Fbootstraptransfer_t(value.Offset, value.Length, ref value.Buffer);
        }
    }
}