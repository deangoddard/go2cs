//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(structType))]
        private partial struct structTypeFixed32
        {
            // structType structure promotion - sourced from value copy
            private readonly ptr<structType> m_structTypeRef;

            private ref structType structType_val => ref m_structTypeRef.Value;

            public ref name pkgPath => ref m_structTypeRef.Value.pkgPath;

            public ref slice<structField> fields => ref m_structTypeRef.Value.fields;

            // Constructors
            public structTypeFixed32(NilType _)
            {
                this.m_structTypeRef = new ptr<structType>(new structType(nil));
                this.u = default;
                this.m = default;
            }

            public structTypeFixed32(structType structType = default, uncommonType u = default, array<method> m = default)
            {
                this.m_structTypeRef = new ptr<structType>(structType);
                this.u = u;
                this.m = m;
            }

            // Enable comparisons between nil and structTypeFixed32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(structTypeFixed32 value, NilType nil) => value.Equals(default(structTypeFixed32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(structTypeFixed32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, structTypeFixed32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, structTypeFixed32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator structTypeFixed32(NilType nil) => default(structTypeFixed32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static structTypeFixed32 structTypeFixed32_cast(dynamic value)
        {
            return new structTypeFixed32(value.structType, value.u, value.m);
        }
    }
}