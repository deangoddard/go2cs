//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytealg = go.@internal.bytealg_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TypeAssertionError
        {
            // Constructors
            public TypeAssertionError(NilType _)
            {
                this._interface = default;
                this.concrete = default;
                this.asserted = default;
                this.missingMethod = default;
            }

            public TypeAssertionError(ref ptr<_type> _interface = default, ref ptr<_type> concrete = default, ref ptr<_type> asserted = default, @string missingMethod = default)
            {
                this._interface = _interface;
                this.concrete = concrete;
                this.asserted = asserted;
                this.missingMethod = missingMethod;
            }

            // Enable comparisons between nil and TypeAssertionError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TypeAssertionError value, NilType nil) => value.Equals(default(TypeAssertionError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TypeAssertionError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TypeAssertionError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TypeAssertionError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TypeAssertionError(NilType nil) => default(TypeAssertionError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TypeAssertionError TypeAssertionError_cast(dynamic value)
        {
            return new TypeAssertionError(ref value._interface, ref value.concrete, ref value.asserted, value.missingMethod);
        }
    }
}