//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:56:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using path = go.path_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using module = go.golang.org.x.mod.module_package;
using note = go.golang.org.x.mod.sumdb.note_package;
using tlog = go.golang.org.x.mod.sumdb.tlog_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class sumdb_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct cached
        {
            // Constructors
            public cached(NilType _)
            {
                this.data = default;
                this.err = default;
            }

            public cached(slice<byte> data = default, error err = default)
            {
                this.data = data;
                this.err = err;
            }

            // Enable comparisons between nil and cached struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cached value, NilType nil) => value.Equals(default(cached));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cached value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cached value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cached value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cached(NilType nil) => default(cached);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static cached cached_cast(dynamic value)
        {
            return new cached(value.data, value.err);
        }
    }
}}}}}}