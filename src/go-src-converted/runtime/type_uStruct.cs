//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(structtype))]
        private partial struct u
        {
            // structtype structure promotion - sourced from value copy
            private readonly ptr<structtype> m_structtypeRef;

            private ref structtype structtype_val => ref m_structtypeRef.Value;

            public ref _type typ => ref m_structtypeRef.Value.typ;

            public ref name pkgPath => ref m_structtypeRef.Value.pkgPath;

            public ref slice<structfield> fields => ref m_structtypeRef.Value.fields;

            // Constructors
            public u(NilType _)
            {
                this.m_structtypeRef = new ptr<structtype>(new structtype(nil));
                this.u = default;
            }

            public u(structtype structtype = default, uncommontype u = default)
            {
                this.m_structtypeRef = new ptr<structtype>(structtype);
                this.u = u;
            }

            // Enable comparisons between nil and u struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(u value, NilType nil) => value.Equals(default(u));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(u value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, u value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, u value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator u(NilType nil) => default(u);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static u u_cast(dynamic value)
        {
            return new u(value.structtype, value.u);
        }
    }
}