//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CertEnhKeyUsage
        {
            // Constructors
            public CertEnhKeyUsage(NilType _)
            {
                this.Length = default;
                this.UsageIdentifiers = default;
            }

            public CertEnhKeyUsage(uint Length = default, ref ptr<ptr<byte>> UsageIdentifiers = default)
            {
                this.Length = Length;
                this.UsageIdentifiers = UsageIdentifiers;
            }

            // Enable comparisons between nil and CertEnhKeyUsage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertEnhKeyUsage value, NilType nil) => value.Equals(default(CertEnhKeyUsage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertEnhKeyUsage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertEnhKeyUsage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertEnhKeyUsage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertEnhKeyUsage(NilType nil) => default(CertEnhKeyUsage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertEnhKeyUsage CertEnhKeyUsage_cast(dynamic value)
        {
            return new CertEnhKeyUsage(value.Length, ref value.UsageIdentifiers);
        }
    }
}}}}}}