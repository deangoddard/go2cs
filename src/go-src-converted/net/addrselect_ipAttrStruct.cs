//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:50:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sort = go.sort_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ipAttr
        {
            // Constructors
            public ipAttr(NilType _)
            {
                this.Scope = default;
                this.Precedence = default;
                this.Label = default;
            }

            public ipAttr(scope Scope = default, byte Precedence = default, byte Label = default)
            {
                this.Scope = Scope;
                this.Precedence = Precedence;
                this.Label = Label;
            }

            // Enable comparisons between nil and ipAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ipAttr value, NilType nil) => value.Equals(default(ipAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ipAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ipAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ipAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ipAttr(NilType nil) => default(ipAttr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ipAttr ipAttr_cast(dynamic value)
        {
            return new ipAttr(value.Scope, value.Precedence, value.Label);
        }
    }
}