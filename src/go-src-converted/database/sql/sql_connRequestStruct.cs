//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        private partial struct connRequest
        {
            // Constructors
            public connRequest(NilType _)
            {
                this.conn = default;
                this.err = default;
            }

            public connRequest(ref ptr<driverConn> conn = default, error err = default)
            {
                this.conn = conn;
                this.err = err;
            }

            // Enable comparisons between nil and connRequest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(connRequest value, NilType nil) => value.Equals(default(connRequest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(connRequest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, connRequest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, connRequest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator connRequest(NilType nil) => default(connRequest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static connRequest connRequest_cast(dynamic value)
        {
            return new connRequest(ref value.conn, value.err);
        }
    }
}}