//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BpfProgram
        {
            // Constructors
            public BpfProgram(NilType _)
            {
                this.Len = default;
                this.Pad_cgo_0 = default;
                this.Insns = default;
            }

            public BpfProgram(uint Len = default, array<byte> Pad_cgo_0 = default, ref ptr<BpfInsn> Insns = default)
            {
                this.Len = Len;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Insns = Insns;
            }

            // Enable comparisons between nil and BpfProgram struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfProgram value, NilType nil) => value.Equals(default(BpfProgram));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfProgram value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfProgram value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfProgram value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfProgram(NilType nil) => default(BpfProgram);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfProgram BpfProgram_cast(dynamic value)
        {
            return new BpfProgram(value.Len, value.Pad_cgo_0, ref value.Insns);
        }
    }
}