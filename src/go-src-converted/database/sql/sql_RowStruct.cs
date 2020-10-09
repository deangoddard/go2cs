//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Row
        {
            // Constructors
            public Row(NilType _)
            {
                this.err = default;
                this.rows = default;
            }

            public Row(error err = default, ref ptr<Rows> rows = default)
            {
                this.err = err;
                this.rows = rows;
            }

            // Enable comparisons between nil and Row struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Row value, NilType nil) => value.Equals(default(Row));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Row value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Row value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Row value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Row(NilType nil) => default(Row);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Row Row_cast(dynamic value)
        {
            return new Row(value.err, ref value.rows);
        }
    }
}}