//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:41:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.@internal.abi_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct makeFuncCtxt
        {
            // Constructors
            public makeFuncCtxt(NilType _)
            {
                this.fn = default;
                this.stack = default;
                this.argLen = default;
                this.regPtrs = default;
            }

            public makeFuncCtxt(System.UIntPtr fn = default, ref ptr<bitVector> stack = default, System.UIntPtr argLen = default, abi.IntArgRegBitmap regPtrs = default)
            {
                this.fn = fn;
                this.stack = stack;
                this.argLen = argLen;
                this.regPtrs = regPtrs;
            }

            // Enable comparisons between nil and makeFuncCtxt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(makeFuncCtxt value, NilType nil) => value.Equals(default(makeFuncCtxt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(makeFuncCtxt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, makeFuncCtxt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, makeFuncCtxt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator makeFuncCtxt(NilType nil) => default(makeFuncCtxt);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static makeFuncCtxt makeFuncCtxt_cast(dynamic value)
        {
            return new makeFuncCtxt(value.fn, ref value.stack, value.argLen, value.regPtrs);
        }
    }
}