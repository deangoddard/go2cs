//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:32 UTC
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
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct elfDyn
        {
            // Constructors
            public elfDyn(NilType _)
            {
                this.d_tag = default;
                this.d_val = default;
            }

            public elfDyn(int d_tag = default, uint d_val = default)
            {
                this.d_tag = d_tag;
                this.d_val = d_val;
            }

            // Enable comparisons between nil and elfDyn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elfDyn value, NilType nil) => value.Equals(default(elfDyn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elfDyn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elfDyn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elfDyn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elfDyn(NilType nil) => default(elfDyn);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static elfDyn elfDyn_cast(dynamic value)
        {
            return new elfDyn(value.d_tag, value.d_val);
        }
    }
}