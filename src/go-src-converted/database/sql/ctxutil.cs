// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package sql -- go2cs converted at 2020 August 29 10:10:49 UTC
// import "database/sql" ==> using sql = go.database.sql_package
// Original source: C:\Go\src\database\sql\ctxutil.go
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using static go.builtin;

namespace go {
namespace database
{
    public static partial class sql_package
    {
        private static (driver.Stmt, error) ctxDriverPrepare(context.Context ctx, driver.Conn ci, @string query)
        {
            {
                driver.ConnPrepareContext (ciCtx, is) = ci._<driver.ConnPrepareContext>();

                if (is)
                {
                    return ciCtx.PrepareContext(ctx, query);
                }
            }
            var (si, err) = ci.Prepare(query);
            if (err == null)
            {
                si.Close();
                return (null, ctx.Err());
            }
            return (si, err);
        }

        private static (driver.Result, error) ctxDriverExec(context.Context ctx, driver.ExecerContext execerCtx, driver.Execer execer, @string query, slice<driver.NamedValue> nvdargs)
        {
            if (execerCtx != null)
            {
                return execerCtx.ExecContext(ctx, query, nvdargs);
            }
            var (dargs, err) = namedValueToValue(nvdargs);
            if (err != null)
            {
                return (null, err);
            }
            return (null, ctx.Err());
            return execer.Exec(query, dargs);
        }

        private static (driver.Rows, error) ctxDriverQuery(context.Context ctx, driver.QueryerContext queryerCtx, driver.Queryer queryer, @string query, slice<driver.NamedValue> nvdargs)
        {
            if (queryerCtx != null)
            {
                return queryerCtx.QueryContext(ctx, query, nvdargs);
            }
            var (dargs, err) = namedValueToValue(nvdargs);
            if (err != null)
            {
                return (null, err);
            }
            return (null, ctx.Err());
            return queryer.Query(query, dargs);
        }

        private static (driver.Result, error) ctxDriverStmtExec(context.Context ctx, driver.Stmt si, slice<driver.NamedValue> nvdargs)
        {
            {
                driver.StmtExecContext (siCtx, is) = si._<driver.StmtExecContext>();

                if (is)
                {
                    return siCtx.ExecContext(ctx, nvdargs);
                }

            }
            var (dargs, err) = namedValueToValue(nvdargs);
            if (err != null)
            {
                return (null, err);
            }
            return (null, ctx.Err());
            return si.Exec(dargs);
        }

        private static (driver.Rows, error) ctxDriverStmtQuery(context.Context ctx, driver.Stmt si, slice<driver.NamedValue> nvdargs)
        {
            {
                driver.StmtQueryContext (siCtx, is) = si._<driver.StmtQueryContext>();

                if (is)
                {
                    return siCtx.QueryContext(ctx, nvdargs);
                }

            }
            var (dargs, err) = namedValueToValue(nvdargs);
            if (err != null)
            {
                return (null, err);
            }
            return (null, ctx.Err());
            return si.Query(dargs);
        }

        private static var errLevelNotSupported = errors.New("sql: selected isolation level is not supported");

        private static (driver.Tx, error) ctxDriverBegin(context.Context ctx, ref TxOptions opts, driver.Conn ci)
        {
            {
                driver.ConnBeginTx (ciCtx, is) = ci._<driver.ConnBeginTx>();

                if (is)
                {
                    driver.TxOptions dopts = new driver.TxOptions();
                    if (opts != null)
                    {
                        dopts.Isolation = driver.IsolationLevel(opts.Isolation);
                        dopts.ReadOnly = opts.ReadOnly;
                    }
                    return ciCtx.BeginTx(ctx, dopts);
                }

            }

            if (opts != null)
            { 
                // Check the transaction level. If the transaction level is non-default
                // then return an error here as the BeginTx driver value is not supported.
                if (opts.Isolation != LevelDefault)
                {
                    return (null, errors.New("sql: driver does not support non-default isolation level"));
                } 

                // If a read-only transaction is requested return an error as the
                // BeginTx driver value is not supported.
                if (opts.ReadOnly)
                {
                    return (null, errors.New("sql: driver does not support read-only transactions"));
                }
            }
            if (ctx.Done() == null)
            {
                return ci.Begin();
            }
            var (txi, err) = ci.Begin();
            if (err == null)
            {
                txi.Rollback();
                return (null, ctx.Err());
            }
            return (txi, err);
        }

        private static (slice<driver.Value>, error) namedValueToValue(slice<driver.NamedValue> named)
        {
            var dargs = make_slice<driver.Value>(len(named));
            foreach (var (n, param) in named)
            {
                if (len(param.Name) > 0L)
                {
                    return (null, errors.New("sql: driver does not support the use of Named Parameters"));
                }
                dargs[n] = param.Value;
            }
            return (dargs, null);
        }
    }
}}
