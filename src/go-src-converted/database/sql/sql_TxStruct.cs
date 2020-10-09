//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:29 UTC
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
        public partial struct Tx
        {
            // Constructors
            public Tx(NilType _)
            {
                this.db = default;
                this.closemu = default;
                this.dc = default;
                this.txi = default;
                this.releaseConn = default;
                this.done = default;
                this.keepConnOnRollback = default;
                this.cancel = default;
                this.ctx = default;
            }

            public Tx(ref ptr<DB> db = default, sync.RWMutex closemu = default, ref ptr<driverConn> dc = default, driver.Tx txi = default, Action<error> releaseConn = default, int done = default, bool keepConnOnRollback = default, Action cancel = default, context.Context ctx = default)
            {
                this.db = db;
                this.closemu = closemu;
                this.dc = dc;
                this.txi = txi;
                this.releaseConn = releaseConn;
                this.done = done;
                this.keepConnOnRollback = keepConnOnRollback;
                this.cancel = cancel;
                this.ctx = ctx;
            }

            // Enable comparisons between nil and Tx struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tx value, NilType nil) => value.Equals(default(Tx));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tx value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tx value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tx value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tx(NilType nil) => default(Tx);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tx Tx_cast(dynamic value)
        {
            return new Tx(ref value.db, value.closemu, ref value.dc, value.txi, value.releaseConn, value.done, value.keepConnOnRollback, value.cancel, value.ctx);
        }
    }
}}