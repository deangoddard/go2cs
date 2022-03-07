//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:18:23 UTC
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
        private partial struct p224Curve
        {
            // Constructors
            public p224Curve(NilType _)
            {
                this.ptr<CurveParams> = default;
                this.gx = default;
                this.gy = default;
                this.b = default;
            }

            public p224Curve(ref ptr<CurveParams> ptr<CurveParams> = default, p224FieldElement gx = default, p224FieldElement gy = default, p224FieldElement b = default)
            {
                this.ptr<CurveParams> = ptr<CurveParams>;
                this.gx = gx;
                this.gy = gy;
                this.b = b;
            }

            // Enable comparisons between nil and p224Curve struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(p224Curve value, NilType nil) => value.Equals(default(p224Curve));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(p224Curve value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, p224Curve value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, p224Curve value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator p224Curve(NilType nil) => default(p224Curve);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static p224Curve p224Curve_cast(dynamic value)
        {
            return new p224Curve(ref value.ptr<CurveParams>, value.gx, value.gy, value.b);
        }
    }
}}