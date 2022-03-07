//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fiat = go.crypto.elliptic.@internal.fiat_package;
using big = go.math.big_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class elliptic_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct p521Point
        {
            // Constructors
            public p521Point(NilType _)
            {
                this.x = default;
                this.y = default;
                this.z = default;
            }

            public p521Point(ref ptr<fiat.P521Element> x = default, ref ptr<fiat.P521Element> y = default, ref ptr<fiat.P521Element> z = default)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            // Enable comparisons between nil and p521Point struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(p521Point value, NilType nil) => value.Equals(default(p521Point));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(p521Point value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, p521Point value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, p521Point value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator p521Point(NilType nil) => default(p521Point);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static p521Point p521Point_cast(dynamic value)
        {
            return new p521Point(ref value.x, ref value.y, ref value.z);
        }
    }
}}