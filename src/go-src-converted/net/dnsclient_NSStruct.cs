//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:25:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using rand = go.math.rand_package;
using sort = go.sort_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NS
        {
            // Constructors
            public NS(NilType _)
            {
                this.Host = default;
            }

            public NS(@string Host = default)
            {
                this.Host = Host;
            }

            // Enable comparisons between nil and NS struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NS value, NilType nil) => value.Equals(default(NS));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NS value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NS value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NS value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NS(NilType nil) => default(NS);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NS NS_cast(dynamic value)
        {
            return new NS(value.Host);
        }
    }
}