//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:24:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct debugLogWriter
        {
            // Constructors
            public debugLogWriter(NilType _)
            {
                this.write = default;
                this.data = default;
                this.tick = default;
                this.nano = default;
                this.r = default;
                this.buf = default;
            }

            public debugLogWriter(ulong write = default, debugLogBuf data = default, ulong tick = default, ulong nano = default, debugLogReader r = default, array<byte> buf = default)
            {
                this.write = write;
                this.data = data;
                this.tick = tick;
                this.nano = nano;
                this.r = r;
                this.buf = buf;
            }

            // Enable comparisons between nil and debugLogWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(debugLogWriter value, NilType nil) => value.Equals(default(debugLogWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(debugLogWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, debugLogWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, debugLogWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugLogWriter(NilType nil) => default(debugLogWriter);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static debugLogWriter debugLogWriter_cast(dynamic value)
        {
            return new debugLogWriter(value.write, value.data, value.tick, value.nano, value.r, value.buf);
        }
    }
}