//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct vreg
        {
            // Constructors
            public vreg(NilType _)
            {
                this.u = default;
            }

            public vreg(array<uint> u = default)
            {
                this.u = u;
            }

            // Enable comparisons between nil and vreg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vreg value, NilType nil) => value.Equals(default(vreg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vreg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vreg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vreg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vreg(NilType nil) => default(vreg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static vreg vreg_cast(dynamic value)
        {
            return new vreg(value.u);
        }
    }
}