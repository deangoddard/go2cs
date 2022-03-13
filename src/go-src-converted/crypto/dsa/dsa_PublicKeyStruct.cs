//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using io = go.io_package;
using big = go.math.big_package;
using randutil = go.crypto.@internal.randutil_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class dsa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(Parameters))]
        public partial struct PublicKey
        {
            // Parameters structure promotion - sourced from value copy
            private readonly ptr<Parameters> m_ParametersRef;

            private ref Parameters Parameters_val => ref m_ParametersRef.Value;

            public ref ptr<big.Int> P => ref m_ParametersRef.Value.P;

            public ref ptr<big.Int> Q => ref m_ParametersRef.Value.Q;

            public ref ptr<big.Int> G => ref m_ParametersRef.Value.G;

            // Constructors
            public PublicKey(NilType _)
            {
                this.m_ParametersRef = new ptr<Parameters>(new Parameters(nil));
                this.Y = default;
            }

            public PublicKey(Parameters Parameters = default, ref ptr<big.Int> Y = default)
            {
                this.m_ParametersRef = new ptr<Parameters>(Parameters);
                this.Y = Y;
            }

            // Enable comparisons between nil and PublicKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PublicKey value, NilType nil) => value.Equals(default(PublicKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PublicKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PublicKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PublicKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PublicKey(NilType nil) => default(PublicKey);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static PublicKey PublicKey_cast(dynamic value)
        {
            return new PublicKey(value.Parameters, ref value.Y);
        }
    }
}}