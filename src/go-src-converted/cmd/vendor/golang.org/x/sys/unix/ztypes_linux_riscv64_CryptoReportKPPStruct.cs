//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CryptoReportKPP
        {
            // Constructors
            public CryptoReportKPP(NilType _)
            {
                this.Type = default;
            }

            public CryptoReportKPP(array<byte> Type = default)
            {
                this.Type = Type;
            }

            // Enable comparisons between nil and CryptoReportKPP struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoReportKPP value, NilType nil) => value.Equals(default(CryptoReportKPP));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoReportKPP value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoReportKPP value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoReportKPP value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoReportKPP(NilType nil) => default(CryptoReportKPP);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoReportKPP CryptoReportKPP_cast(dynamic value)
        {
            return new CryptoReportKPP(value.Type);
        }
    }
}}}}}}