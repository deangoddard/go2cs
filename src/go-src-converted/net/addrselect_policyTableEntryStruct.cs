//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:25:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sort = go.sort_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct policyTableEntry
        {
            // Constructors
            public policyTableEntry(NilType _)
            {
                this.Prefix = default;
                this.Precedence = default;
                this.Label = default;
            }

            public policyTableEntry(ref ptr<IPNet> Prefix = default, byte Precedence = default, byte Label = default)
            {
                this.Prefix = Prefix;
                this.Precedence = Precedence;
                this.Label = Label;
            }

            // Enable comparisons between nil and policyTableEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(policyTableEntry value, NilType nil) => value.Equals(default(policyTableEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(policyTableEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, policyTableEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, policyTableEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator policyTableEntry(NilType nil) => default(policyTableEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static policyTableEntry policyTableEntry_cast(dynamic value)
        {
            return new policyTableEntry(ref value.Prefix, value.Precedence, value.Label);
        }
    }
}