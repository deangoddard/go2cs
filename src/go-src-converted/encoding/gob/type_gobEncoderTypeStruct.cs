//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:00 UTC
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

#nullable enable

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(CommonType))]
        private partial struct gobEncoderType
        {
            // CommonType structure promotion - sourced from value copy
            private readonly ptr<CommonType> m_CommonTypeRef;

            private ref CommonType CommonType_val => ref m_CommonTypeRef.Value;

            public ref @string Name => ref m_CommonTypeRef.Value.Name;

            public ref typeId Id => ref m_CommonTypeRef.Value.Id;

            // Constructors
            public gobEncoderType(NilType _)
            {
                this.m_CommonTypeRef = new ptr<CommonType>(new CommonType(nil));
            }

            public gobEncoderType(CommonType CommonType = default)
            {
                this.m_CommonTypeRef = new ptr<CommonType>(CommonType);
            }

            // Enable comparisons between nil and gobEncoderType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gobEncoderType value, NilType nil) => value.Equals(default(gobEncoderType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gobEncoderType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gobEncoderType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gobEncoderType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gobEncoderType(NilType nil) => default(gobEncoderType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gobEncoderType gobEncoderType_cast(dynamic value)
        {
            return new gobEncoderType(value.CommonType);
        }
    }
}}