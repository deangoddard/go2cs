//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using unsafeheader = go.@internal.unsafeheader_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class reflectlite_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(structType))]
        private partial struct structTypeUncommon
        {
            // structType structure promotion - sourced from value copy
            private readonly ptr<structType> m_structTypeRef;

            private ref structType structType_val => ref m_structTypeRef.Value;

            public ref name pkgPath => ref m_structTypeRef.Value.pkgPath;

            public ref slice<structField> fields => ref m_structTypeRef.Value.fields;

            // Constructors
            public structTypeUncommon(NilType _)
            {
                this.m_structTypeRef = new ptr<structType>(new structType(nil));
                this.u = default;
            }

            public structTypeUncommon(structType structType = default, uncommonType u = default)
            {
                this.m_structTypeRef = new ptr<structType>(structType);
                this.u = u;
            }

            // Enable comparisons between nil and structTypeUncommon struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(structTypeUncommon value, NilType nil) => value.Equals(default(structTypeUncommon));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(structTypeUncommon value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, structTypeUncommon value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, structTypeUncommon value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator structTypeUncommon(NilType nil) => default(structTypeUncommon);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static structTypeUncommon structTypeUncommon_cast(dynamic value)
        {
            return new structTypeUncommon(value.structType, value.u);
        }
    }
}}