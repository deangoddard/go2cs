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
        public partial struct CryptoReportBlkCipher
        {
            // Constructors
            public CryptoReportBlkCipher(NilType _)
            {
                this.Type = default;
                this.Geniv = default;
                this.Blocksize = default;
                this.Min_keysize = default;
                this.Max_keysize = default;
                this.Ivsize = default;
            }

            public CryptoReportBlkCipher(array<byte> Type = default, array<byte> Geniv = default, uint Blocksize = default, uint Min_keysize = default, uint Max_keysize = default, uint Ivsize = default)
            {
                this.Type = Type;
                this.Geniv = Geniv;
                this.Blocksize = Blocksize;
                this.Min_keysize = Min_keysize;
                this.Max_keysize = Max_keysize;
                this.Ivsize = Ivsize;
            }

            // Enable comparisons between nil and CryptoReportBlkCipher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoReportBlkCipher value, NilType nil) => value.Equals(default(CryptoReportBlkCipher));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoReportBlkCipher value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoReportBlkCipher value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoReportBlkCipher value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoReportBlkCipher(NilType nil) => default(CryptoReportBlkCipher);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoReportBlkCipher CryptoReportBlkCipher_cast(dynamic value)
        {
            return new CryptoReportBlkCipher(value.Type, value.Geniv, value.Blocksize, value.Min_keysize, value.Max_keysize, value.Ivsize);
        }
    }
}}}}}}