//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:37 UTC
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
        public partial struct CryptoReportHash
        {
            // Constructors
            public CryptoReportHash(NilType _)
            {
                this.Type = default;
                this.Blocksize = default;
                this.Digestsize = default;
            }

            public CryptoReportHash(array<sbyte> Type = default, uint Blocksize = default, uint Digestsize = default)
            {
                this.Type = Type;
                this.Blocksize = Blocksize;
                this.Digestsize = Digestsize;
            }

            // Enable comparisons between nil and CryptoReportHash struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoReportHash value, NilType nil) => value.Equals(default(CryptoReportHash));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoReportHash value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoReportHash value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoReportHash value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoReportHash(NilType nil) => default(CryptoReportHash);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoReportHash CryptoReportHash_cast(dynamic value)
        {
            return new CryptoReportHash(value.Type, value.Blocksize, value.Digestsize);
        }
    }
}}}}}}