//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:28 UTC
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
        public partial struct FdSet
        {
            // Constructors
            public FdSet(NilType _)
            {
                this.Bits = default;
            }

            public FdSet(array<int> Bits = default)
            {
                this.Bits = Bits;
            }

            // Enable comparisons between nil and FdSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FdSet value, NilType nil) => value.Equals(default(FdSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FdSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FdSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FdSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FdSet(NilType nil) => default(FdSet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FdSet FdSet_cast(dynamic value)
        {
            return new FdSet(value.Bits);
        }
    }
}