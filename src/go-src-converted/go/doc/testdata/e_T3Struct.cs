//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace go
{
    public static partial class e_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(t1e))]
        [PromotedStruct(typeof(t2e))]
        public partial struct T3
        {
            // t1e structure promotion - sourced from value copy
            private readonly ptr<t1e> m_t1eRef;

            private ref t1e t1e_val => ref m_t1eRef.Value;

            // t2e structure promotion - sourced from value copy
            private readonly ptr<t2e> m_t2eRef;

            private ref t2e t2e_val => ref m_t2eRef.Value;

            // Constructors
            public T3(NilType _)
            {
                this.m_t1eRef = new ptr<t1e>(new t1e(nil));
                this.m_t2eRef = new ptr<t2e>(new t2e(nil));
            }

            public T3(t1e t1e = default, t2e t2e = default)
            {
                this.m_t1eRef = new ptr<t1e>(t1e);
                this.m_t2eRef = new ptr<t2e>(t2e);
            }

            // Enable comparisons between nil and T3 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T3 value, NilType nil) => value.Equals(default(T3));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T3 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T3 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T3 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T3(NilType nil) => default(T3);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T3 T3_cast(dynamic value)
        {
            return new T3(value.t1e, value.t2e);
        }
    }
}}