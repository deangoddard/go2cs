//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:36 UTC
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
        public partial struct CryptoReportRNG
        {
            // Constructors
            public CryptoReportRNG(NilType _)
            {
                this.Type = default;
                this.Seedsize = default;
            }

            public CryptoReportRNG(array<byte> Type = default, uint Seedsize = default)
            {
                this.Type = Type;
                this.Seedsize = Seedsize;
            }

            // Enable comparisons between nil and CryptoReportRNG struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoReportRNG value, NilType nil) => value.Equals(default(CryptoReportRNG));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoReportRNG value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoReportRNG value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoReportRNG value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoReportRNG(NilType nil) => default(CryptoReportRNG);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoReportRNG CryptoReportRNG_cast(dynamic value)
        {
            return new CryptoReportRNG(value.Type, value.Seedsize);
        }
    }
}}}}}}