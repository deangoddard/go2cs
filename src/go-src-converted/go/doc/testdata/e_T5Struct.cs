//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:40 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(T4))]
        public partial struct T5
        {
            // T4 structure promotion - sourced from value copy
            private readonly ptr<T4> m_T4Ref;

            private ref T4 T4_val => ref m_T4Ref.Value;

            // Constructors
            public T5(NilType _)
            {
                this.m_T4Ref = new ptr<T4>(new T4(nil));
            }

            public T5(T4 T4 = default)
            {
                this.m_T4Ref = new ptr<T4>(T4);
            }

            // Enable comparisons between nil and T5 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T5 value, NilType nil) => value.Equals(default(T5));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T5 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T5 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T5 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T5(NilType nil) => default(T5);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static T5 T5_cast(dynamic value)
        {
            return new T5(value.T4);
        }
    }
}}