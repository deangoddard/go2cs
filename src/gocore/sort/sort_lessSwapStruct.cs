//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go;

public static partial class sort_package
{
    [GeneratedCode("go2cs", "0.1.0.0")]
    private partial struct lessSwap
    {
        // Constructors
        public lessSwap(NilType _)
        {
            this.Less = default!;
            this.Swap = default!;
        }

        public lessSwap(Func<nint, nint, bool> Less = default!, Action<nint, nint> Swap = default!)
        {
            this.Less = Less;
            this.Swap = Swap;
        }

        // Enable comparisons between nil and lessSwap struct
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(lessSwap value, NilType nil) => value.Equals(default(lessSwap));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(lessSwap value, NilType nil) => !(value == nil);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(NilType nil, lessSwap value) => value == nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(NilType nil, lessSwap value) => value != nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator lessSwap(NilType nil) => default(lessSwap);
    }

    [GeneratedCode("go2cs", "0.1.0.0")]
    private static lessSwap lessSwap_cast(dynamic value)
    {
        return new lessSwap(value.Less, value.Swap);
    }
}
