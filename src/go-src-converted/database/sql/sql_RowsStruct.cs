//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:01 UTC
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
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Rows
        {
            // Constructors
            public Rows(NilType _)
            {
                this.dc = default;
                this.releaseConn = default;
                this.rowsi = default;
                this.cancel = default;
                this.closeStmt = default;
                this.closemu = default;
                this.closed = default;
                this.lasterr = default;
                this.lastcols = default;
            }

            public Rows(ref ptr<driverConn> dc = default, Action<error> releaseConn = default, driver.Rows rowsi = default, Action cancel = default, ref ptr<driverStmt> closeStmt = default, sync.RWMutex closemu = default, bool closed = default, error lasterr = default, slice<driver.Value> lastcols = default)
            {
                this.dc = dc;
                this.releaseConn = releaseConn;
                this.rowsi = rowsi;
                this.cancel = cancel;
                this.closeStmt = closeStmt;
                this.closemu = closemu;
                this.closed = closed;
                this.lasterr = lasterr;
                this.lastcols = lastcols;
            }

            // Enable comparisons between nil and Rows struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Rows value, NilType nil) => value.Equals(default(Rows));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Rows value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Rows value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Rows value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Rows(NilType nil) => default(Rows);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Rows Rows_cast(dynamic value)
        {
            return new Rows(ref value.dc, value.releaseConn, value.rowsi, value.cancel, ref value.closeStmt, value.closemu, value.closed, value.lasterr, value.lastcols);
        }
    }
}}