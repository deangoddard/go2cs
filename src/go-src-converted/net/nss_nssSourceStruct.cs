//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:27:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using os = go.os_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nssSource
        {
            // Constructors
            public nssSource(NilType _)
            {
                this.source = default;
                this.criteria = default;
            }

            public nssSource(@string source = default, slice<nssCriterion> criteria = default)
            {
                this.source = source;
                this.criteria = criteria;
            }

            // Enable comparisons between nil and nssSource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nssSource value, NilType nil) => value.Equals(default(nssSource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nssSource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nssSource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nssSource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nssSource(NilType nil) => default(nssSource);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nssSource nssSource_cast(dynamic value)
        {
            return new nssSource(value.source, value.criteria);
        }
    }
}