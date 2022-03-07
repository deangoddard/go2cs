//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:14:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using hash = go.hash_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace hash
{
    public static partial class crc64_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct digest
        {
            // Constructors
            public digest(NilType _)
            {
                this.crc = default;
                this.tab = default;
            }

            public digest(ulong crc = default, ref ptr<Table> tab = default)
            {
                this.crc = crc;
                this.tab = tab;
            }

            // Enable comparisons between nil and digest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(digest value, NilType nil) => value.Equals(default(digest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(digest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, digest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, digest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator digest(NilType nil) => default(digest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static digest digest_cast(dynamic value)
        {
            return new digest(value.crc, ref value.tab);
        }
    }
}}