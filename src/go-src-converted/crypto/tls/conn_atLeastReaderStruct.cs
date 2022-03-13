//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:35:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using cipher = go.crypto.cipher_package;
using subtle = go.crypto.subtle_package;
using x509 = go.crypto.x509_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using hash = go.hash_package;
using io = go.io_package;
using net = go.net_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct atLeastReader
        {
            // Constructors
            public atLeastReader(NilType _)
            {
                this.R = default;
                this.N = default;
            }

            public atLeastReader(io.Reader R = default, long N = default)
            {
                this.R = R;
                this.N = N;
            }

            // Enable comparisons between nil and atLeastReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(atLeastReader value, NilType nil) => value.Equals(default(atLeastReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(atLeastReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, atLeastReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, atLeastReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator atLeastReader(NilType nil) => default(atLeastReader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static atLeastReader atLeastReader_cast(dynamic value)
        {
            return new atLeastReader(value.R, value.N);
        }
    }
}}