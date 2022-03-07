//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using big = go.math.big_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class elliptic_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct p256Curve
        {
            // Constructors
            public p256Curve(NilType _)
            {
                this.ptr<CurveParams> = default;
            }

            public p256Curve(ref ptr<CurveParams> ptr<CurveParams> = default)
            {
                this.ptr<CurveParams> = ptr<CurveParams>;
            }

            // Enable comparisons between nil and p256Curve struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(p256Curve value, NilType nil) => value.Equals(default(p256Curve));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(p256Curve value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, p256Curve value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, p256Curve value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator p256Curve(NilType nil) => default(p256Curve);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static p256Curve p256Curve_cast(dynamic value)
        {
            return new p256Curve(ref value.ptr<CurveParams>);
        }
    }
}}