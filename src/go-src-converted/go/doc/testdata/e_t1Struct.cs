//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:35 UTC
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
        [PromotedStruct(typeof(t2))]
        public partial struct T1
        {
            // t1 structure promotion - sourced from value copy
            private readonly ptr<t1> m_t1Ref;

            private ref t1 t1_val => ref m_t1Ref.Value;

            // t2 structure promotion - sourced from value copy
            private readonly ptr<t2> m_t2Ref;

            private ref t2 t2_val => ref m_t2Ref.Value;

            // Constructors
            public T1(NilType _)
            {
                this.m_t1Ref = new ptr<t1>(new t1(nil));
                this.m_t2Ref = new ptr<t2>(new t2(nil));
            }

            public T1(t1 t1 = default, t2 t2 = default)
            {
                this.m_t1Ref = new ptr<t1>(t1);
                this.m_t2Ref = new ptr<t2>(t2);
            }

            // Enable comparisons between nil and T1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T1 value, NilType nil) => value.Equals(default(T1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1(NilType nil) => default(T1);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T1 T1_cast(dynamic value)
        {
            return new T1(value.t1, value.t2);
        }
    }
}}