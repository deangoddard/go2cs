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
        private partial struct debugLogReader
        {
            // Constructors
            public debugLogReader(NilType _)
            {
                this.data = default;
                this.begin = default;
                this.end = default;
                this.tick = default;
                this.nano = default;
            }

            public debugLogReader(ref ptr<debugLogBuf> data = default, ulong begin = default, ulong end = default, ulong tick = default, ulong nano = default)
            {
                this.data = data;
                this.begin = begin;
                this.end = end;
                this.tick = tick;
                this.nano = nano;
            }

            // Enable comparisons between nil and debugLogReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(debugLogReader value, NilType nil) => value.Equals(default(debugLogReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(debugLogReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, debugLogReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, debugLogReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugLogReader(NilType nil) => default(debugLogReader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static debugLogReader debugLogReader_cast(dynamic value)
        {
            return new debugLogReader(ref value.data, value.begin, value.end, value.tick, value.nano);
        }
    }
}