//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:54:11 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(Time))]
        public partial struct EmbedSelector
        {
            // Time structure promotion - sourced from value copy
            private readonly ptr<Time> m_TimeRef;

            private ref Time Time_val => ref m_TimeRef.Value;

            // Constructors
            public EmbedSelector(NilType _)
            {
                this.m_TimeRef = new ptr<Time>(new Time(nil));
            }

            public EmbedSelector(Time Time = default)
            {
                this.m_TimeRef = new ptr<Time>(Time);
            }

            // Enable comparisons between nil and EmbedSelector struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EmbedSelector value, NilType nil) => value.Equals(default(EmbedSelector));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EmbedSelector value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EmbedSelector value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EmbedSelector value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EmbedSelector(NilType nil) => default(EmbedSelector);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static EmbedSelector EmbedSelector_cast(dynamic value)
        {
            return new EmbedSelector(value.Time);
        }
    }
}}}}}}