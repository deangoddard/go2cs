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
        private partial struct typeInfo
        {
            // Constructors
            public typeInfo(NilType _)
            {
                this.id = default;
                this.encInit = default;
                this.encoder = default;
                this.wire = default;
            }

            public typeInfo(typeId id = default, sync.Mutex encInit = default, atomic.Value encoder = default, ref ptr<wireType> wire = default)
            {
                this.id = id;
                this.encInit = encInit;
                this.encoder = encoder;
                this.wire = wire;
            }

            // Enable comparisons between nil and typeInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeInfo value, NilType nil) => value.Equals(default(typeInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeInfo(NilType nil) => default(typeInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static typeInfo typeInfo_cast(dynamic value)
        {
            return new typeInfo(value.id, value.encInit, value.encoder, ref value.wire);
        }
    }
}}