//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:22:49 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2noCachedConnError
        {
            // Constructors
            public http2noCachedConnError(NilType _)
            {
            }
            // Enable comparisons between nil and http2noCachedConnError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2noCachedConnError value, NilType nil) => value.Equals(default(http2noCachedConnError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2noCachedConnError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2noCachedConnError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2noCachedConnError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2noCachedConnError(NilType nil) => default(http2noCachedConnError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static http2noCachedConnError http2noCachedConnError_cast(dynamic value)
        {
            return new http2noCachedConnError();
        }
    }
}}