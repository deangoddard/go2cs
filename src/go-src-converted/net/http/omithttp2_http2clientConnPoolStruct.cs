//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct http2clientConnPool
        {
            // Constructors
            public http2clientConnPool(NilType _)
            {
                this.mu = default;
                this.conns = default;
            }

            public http2clientConnPool(ref ptr<sync.Mutex> mu = default, map<@string, slice<object>> conns = default)
            {
                this.mu = mu;
                this.conns = conns;
            }

            // Enable comparisons between nil and http2clientConnPool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2clientConnPool value, NilType nil) => value.Equals(default(http2clientConnPool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2clientConnPool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2clientConnPool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2clientConnPool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2clientConnPool(NilType nil) => default(http2clientConnPool);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static http2clientConnPool http2clientConnPool_cast(dynamic value)
        {
            return new http2clientConnPool(ref value.mu, value.conns);
        }
    }
}}