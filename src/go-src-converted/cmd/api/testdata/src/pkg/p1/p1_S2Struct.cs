//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:43:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ptwo = go.p2_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(S))]
        public partial struct S2
        {
            // S structure promotion - sourced from value copy
            private readonly ptr<S> m_SRef;

            private ref S S_val => ref m_SRef.Value;

            public ref ptr<nint> Public => ref m_SRef.Value.Public;

            public ref ptr<nint> @private => ref m_SRef.Value.@private;

            public ref Time PublicTime => ref m_SRef.Value.PublicTime;

            // Constructors
            public S2(NilType _)
            {
                this.m_SRef = new ptr<S>(new S(nil));
                this.Extra = default;
            }

            public S2(S S = default, bool Extra = default)
            {
                this.m_SRef = new ptr<S>(S);
                this.Extra = Extra;
            }

            // Enable comparisons between nil and S2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S2 value, NilType nil) => value.Equals(default(S2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S2(NilType nil) => default(S2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static S2 S2_cast(dynamic value)
        {
            return new S2(value.S, value.Extra);
        }
    }
}}}}}}