//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct tileReader
        {
            // Constructors
            public tileReader(NilType _)
            {
                this.c = default;
            }

            public tileReader(ref ptr<Client> c = default)
            {
                this.c = c;
            }

            // Enable comparisons between nil and tileReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tileReader value, NilType nil) => value.Equals(default(tileReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tileReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tileReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tileReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tileReader(NilType nil) => default(tileReader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static tileReader tileReader_cast(dynamic value)
        {
            return new tileReader(ref value.c);
        }
    }
}}}}}}