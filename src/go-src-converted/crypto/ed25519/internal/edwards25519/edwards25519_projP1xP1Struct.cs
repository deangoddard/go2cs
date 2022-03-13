//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:30:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using field = go.crypto.ed25519.@internal.edwards25519.field_package;
using errors = go.errors_package;
using go;

#nullable enable

namespace go {
namespace crypto {
namespace ed25519 {
namespace @internal
{
    public static partial class edwards25519_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct projP1xP1
        {
            // Constructors
            public projP1xP1(NilType _)
            {
                this.X = default;
                this.Y = default;
                this.Z = default;
                this.T = default;
            }

            public projP1xP1(field.Element X = default, field.Element Y = default, field.Element Z = default, field.Element T = default)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
                this.T = T;
            }

            // Enable comparisons between nil and projP1xP1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(projP1xP1 value, NilType nil) => value.Equals(default(projP1xP1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(projP1xP1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, projP1xP1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, projP1xP1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator projP1xP1(NilType nil) => default(projP1xP1);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static projP1xP1 projP1xP1_cast(dynamic value)
        {
            return new projP1xP1(value.X, value.Y, value.Z, value.T);
        }
    }
}}}}