//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:17:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        private partial struct devReader
        {
            // Constructors
            public devReader(NilType _)
            {
                this.name = default;
                this.f = default;
                this.mu = default;
                this.used = default;
            }

            public devReader(@string name = default, io.Reader f = default, sync.Mutex mu = default, int used = default)
            {
                this.name = name;
                this.f = f;
                this.mu = mu;
                this.used = used;
            }

            // Enable comparisons between nil and devReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(devReader value, NilType nil) => value.Equals(default(devReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(devReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, devReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, devReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator devReader(NilType nil) => default(devReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static devReader devReader_cast(dynamic value)
        {
            return new devReader(value.name, value.f, value.mu, value.used);
        }
    }
}}