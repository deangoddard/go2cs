//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(stackWorkBufHdr))]
        private partial struct stackWorkBuf
        {
            // stackWorkBufHdr structure promotion - sourced from value copy
            private readonly ptr<stackWorkBufHdr> m_stackWorkBufHdrRef;

            private ref stackWorkBufHdr stackWorkBufHdr_val => ref m_stackWorkBufHdrRef.Value;

            public ref ptr<stackWorkBuf> next => ref m_stackWorkBufHdrRef.Value.next;

            // Constructors
            public stackWorkBuf(NilType _)
            {
                this.m_stackWorkBufHdrRef = new ptr<stackWorkBufHdr>(new stackWorkBufHdr(nil));
                this.obj = default;
            }

            public stackWorkBuf(stackWorkBufHdr stackWorkBufHdr = default, array<System.UIntPtr> obj = default)
            {
                this.m_stackWorkBufHdrRef = new ptr<stackWorkBufHdr>(stackWorkBufHdr);
                this.obj = obj;
            }

            // Enable comparisons between nil and stackWorkBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stackWorkBuf value, NilType nil) => value.Equals(default(stackWorkBuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stackWorkBuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stackWorkBuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stackWorkBuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stackWorkBuf(NilType nil) => default(stackWorkBuf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stackWorkBuf stackWorkBuf_cast(dynamic value)
        {
            return new stackWorkBuf(value.stackWorkBufHdr, value.obj);
        }
    }
}