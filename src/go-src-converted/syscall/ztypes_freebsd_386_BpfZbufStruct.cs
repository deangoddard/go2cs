//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:23 UTC
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
        public partial struct BpfZbuf
        {
            // Constructors
            public BpfZbuf(NilType _)
            {
                this.Bufa = default;
                this.Bufb = default;
                this.Buflen = default;
            }

            public BpfZbuf(ref ptr<byte> Bufa = default, ref ptr<byte> Bufb = default, uint Buflen = default)
            {
                this.Bufa = Bufa;
                this.Bufb = Bufb;
                this.Buflen = Buflen;
            }

            // Enable comparisons between nil and BpfZbuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfZbuf value, NilType nil) => value.Equals(default(BpfZbuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfZbuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfZbuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfZbuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfZbuf(NilType nil) => default(BpfZbuf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfZbuf BpfZbuf_cast(dynamic value)
        {
            return new BpfZbuf(ref value.Bufa, ref value.Bufb, value.Buflen);
        }
    }
}