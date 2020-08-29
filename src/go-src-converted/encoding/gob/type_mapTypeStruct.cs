//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:35:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using os = go.os_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(CommonType))]
        private partial struct mapType
        {
            // CommonType structure promotion - sourced from value copy
            private readonly ptr<CommonType> m_CommonTypeRef;

            private ref CommonType CommonType_val => ref m_CommonTypeRef.Value;

            public ref @string Name => ref m_CommonTypeRef.Value.Name;

            public ref typeId Id => ref m_CommonTypeRef.Value.Id;

            // Constructors
            public mapType(NilType _)
            {
                this.m_CommonTypeRef = new ptr<CommonType>(new CommonType(nil));
                this.Key = default;
                this.Elem = default;
            }

            public mapType(CommonType CommonType = default, typeId Key = default, typeId Elem = default)
            {
                this.m_CommonTypeRef = new ptr<CommonType>(CommonType);
                this.Key = Key;
                this.Elem = Elem;
            }

            // Enable comparisons between nil and mapType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mapType value, NilType nil) => value.Equals(default(mapType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mapType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mapType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mapType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mapType(NilType nil) => default(mapType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mapType mapType_cast(dynamic value)
        {
            return new mapType(value.CommonType, value.Key, value.Elem);
        }
    }
}}