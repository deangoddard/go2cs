//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:30:37 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(makeFuncCtxt))]
        private partial struct makeFuncImpl
        {
            // makeFuncCtxt structure promotion - sourced from value copy
            private readonly ptr<makeFuncCtxt> m_makeFuncCtxtRef;

            private ref makeFuncCtxt makeFuncCtxt_val => ref m_makeFuncCtxtRef.Value;

            public ref System.UIntPtr fn => ref m_makeFuncCtxtRef.Value.fn;

            public ref ptr<bitVector> stack => ref m_makeFuncCtxtRef.Value.stack;

            public ref System.UIntPtr argLen => ref m_makeFuncCtxtRef.Value.argLen;

            public ref abi.IntArgRegBitmap regPtrs => ref m_makeFuncCtxtRef.Value.regPtrs;

            // Constructors
            public makeFuncImpl(NilType _)
            {
                this.m_makeFuncCtxtRef = new ptr<makeFuncCtxt>(new makeFuncCtxt(nil));
                this.ftyp = default;
                this.fn = default;
            }

            public makeFuncImpl(makeFuncCtxt makeFuncCtxt = default, ref ptr<funcType> ftyp = default, Func<slice<Value>, slice<Value>> fn = default)
            {
                this.m_makeFuncCtxtRef = new ptr<makeFuncCtxt>(makeFuncCtxt);
                this.ftyp = ftyp;
                this.fn = fn;
            }

            // Enable comparisons between nil and makeFuncImpl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(makeFuncImpl value, NilType nil) => value.Equals(default(makeFuncImpl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(makeFuncImpl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, makeFuncImpl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, makeFuncImpl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator makeFuncImpl(NilType nil) => default(makeFuncImpl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static makeFuncImpl makeFuncImpl_cast(dynamic value)
        {
            return new makeFuncImpl(value.makeFuncCtxt, ref value.ftyp, value.fn);
        }
    }
}