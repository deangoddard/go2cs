//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:30:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using go;

namespace go {
namespace crypto
{
    public static partial class rand_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rngReader
        {
            // Constructors
            public rngReader(NilType _)
            {
                this.prov = default;
                this.mu = default;
            }

            public rngReader(syscall.Handle prov = default, sync.Mutex mu = default)
            {
                this.prov = prov;
                this.mu = mu;
            }

            // Enable comparisons between nil and rngReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rngReader value, NilType nil) => value.Equals(default(rngReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rngReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rngReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rngReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rngReader(NilType nil) => default(rngReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rngReader rngReader_cast(dynamic value)
        {
            return new rngReader(value.prov, value.mu);
        }
    }
}}