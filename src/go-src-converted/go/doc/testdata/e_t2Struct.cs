//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class e_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(t1))]
        public partial struct T2
        {
            // t1 structure promotion - sourced from value copy
            private readonly ptr<t1> m_t1Ref;

            private ref t1 t1_val => ref m_t1Ref.Value;

            // Constructors
            public T2(NilType _)
            {
                this.m_t1Ref = new ptr<t1>(new t1(nil));
            }

            public T2(t1 t1 = default)
            {
                this.m_t1Ref = new ptr<t1>(t1);
            }

            // Enable comparisons between nil and T2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T2 value, NilType nil) => value.Equals(default(T2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T2(NilType nil) => default(T2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T2 T2_cast(dynamic value)
        {
            return new T2(value.t1);
        }
    }
}}