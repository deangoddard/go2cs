//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using _@unsafe_ = go.@unsafe_package;

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
                this.interfaceString = default;
                this.concreteString = default;
                this.assertedString = default;
                this.missingMethod = default;
            }

            public TypeAssertionError(@string interfaceString = default, @string concreteString = default, @string assertedString = default, @string missingMethod = default)
            {
                this.interfaceString = interfaceString;
                this.concreteString = concreteString;
                this.assertedString = assertedString;
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
            return new TypeAssertionError(value.interfaceString, value.concreteString, value.assertedString, value.missingMethod);
        }
    }
}