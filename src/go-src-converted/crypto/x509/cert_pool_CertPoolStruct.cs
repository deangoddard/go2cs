//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using sha256 = go.crypto.sha256_package;
using pem = go.encoding.pem_package;
using errors = go.errors_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct CertPool
        {
            // Constructors
            public CertPool(NilType _)
            {
                this.byName = default;
                this.lazyCerts = default;
                this.haveSum = default;
            }

            public CertPool(map<@string, slice<nint>> byName = default, slice<lazyCert> lazyCerts = default, map<sum224, bool> haveSum = default)
            {
                this.byName = byName;
                this.lazyCerts = lazyCerts;
                this.haveSum = haveSum;
            }

            // Enable comparisons between nil and CertPool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertPool value, NilType nil) => value.Equals(default(CertPool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertPool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertPool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertPool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertPool(NilType nil) => default(CertPool);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static CertPool CertPool_cast(dynamic value)
        {
            return new CertPool(value.byName, value.lazyCerts, value.haveSum);
        }
    }
}}