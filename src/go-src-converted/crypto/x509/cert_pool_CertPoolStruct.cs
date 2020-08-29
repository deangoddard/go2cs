//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:28:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using pem = go.encoding.pem_package;
using errors = go.errors_package;
using runtime = go.runtime_package;
using go;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CertPool
        {
            // Constructors
            public CertPool(NilType _)
            {
                this.bySubjectKeyId = default;
                this.byName = default;
                this.certs = default;
            }

            public CertPool(map<@string, slice<long>> bySubjectKeyId = default, map<@string, slice<long>> byName = default, slice<ref Certificate> certs = default)
            {
                this.bySubjectKeyId = bySubjectKeyId;
                this.byName = byName;
                this.certs = certs;
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

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertPool CertPool_cast(dynamic value)
        {
            return new CertPool(value.bySubjectKeyId, value.byName, value.certs);
        }
    }
}}