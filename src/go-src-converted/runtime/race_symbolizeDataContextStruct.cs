//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:11:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct symbolizeDataContext
        {
            // Constructors
            public symbolizeDataContext(NilType _)
            {
                this.addr = default;
                this.heap = default;
                this.start = default;
                this.size = default;
                this.name = default;
                this.file = default;
                this.line = default;
                this.res = default;
            }

            public symbolizeDataContext(System.UIntPtr addr = default, System.UIntPtr heap = default, System.UIntPtr start = default, System.UIntPtr size = default, ref ptr<byte> name = default, ref ptr<byte> file = default, System.UIntPtr line = default, System.UIntPtr res = default)
            {
                this.addr = addr;
                this.heap = heap;
                this.start = start;
                this.size = size;
                this.name = name;
                this.file = file;
                this.line = line;
                this.res = res;
            }

            // Enable comparisons between nil and symbolizeDataContext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(symbolizeDataContext value, NilType nil) => value.Equals(default(symbolizeDataContext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(symbolizeDataContext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, symbolizeDataContext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, symbolizeDataContext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator symbolizeDataContext(NilType nil) => default(symbolizeDataContext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static symbolizeDataContext symbolizeDataContext_cast(dynamic value)
        {
            return new symbolizeDataContext(value.addr, value.heap, value.start, value.size, ref value.name, ref value.file, value.line, value.res);
        }
    }
}