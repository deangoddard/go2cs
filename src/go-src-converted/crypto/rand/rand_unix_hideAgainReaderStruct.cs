//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:53:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using binary = go.encoding.binary_package;
using io = go.io_package;
using os = go.os_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class rand_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct hideAgainReader
        {
            // Constructors
            public hideAgainReader(NilType _)
            {
                this.r = default;
            }

            public hideAgainReader(io.Reader r = default)
            {
                this.r = r;
            }

            // Enable comparisons between nil and hideAgainReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hideAgainReader value, NilType nil) => value.Equals(default(hideAgainReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hideAgainReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hideAgainReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hideAgainReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hideAgainReader(NilType nil) => default(hideAgainReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static hideAgainReader hideAgainReader_cast(dynamic value)
        {
            return new hideAgainReader(value.r);
        }
    }
}}