//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes {
namespace copylock {
namespace testdata {
namespace src
{
    public static partial class a_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(L1))]
        public partial struct L0
        {
            // L1 structure promotion - sourced from value copy
            private readonly ptr<L1> m_L1Ref;

            private ref L1 L1_val => ref m_L1Ref.Value;

            public ref L2 l => ref m_L1Ref.Value.l;

            // Constructors
            public L0(NilType _)
            {
                this.m_L1Ref = new ptr<L1>(new L1(nil));
            }

            public L0(L1 L1 = default)
            {
                this.m_L1Ref = new ptr<L1>(L1);
            }

            // Enable comparisons between nil and L0 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(L0 value, NilType nil) => value.Equals(default(L0));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(L0 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, L0 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, L0 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator L0(NilType nil) => default(L0);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static L0 L0_cast(dynamic value)
        {
            return new L0(value.L1);
        }
    }
}}}}}}}}}}