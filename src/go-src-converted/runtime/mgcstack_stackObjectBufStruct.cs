//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(stackObjectBufHdr))]
        private partial struct stackObjectBuf
        {
            // stackObjectBufHdr structure promotion - sourced from value copy
            private readonly ptr<stackObjectBufHdr> m_stackObjectBufHdrRef;

            private ref stackObjectBufHdr stackObjectBufHdr_val => ref m_stackObjectBufHdrRef.Value;

            public ref ptr<stackObjectBuf> next => ref m_stackObjectBufHdrRef.Value.next;

            // Constructors
            public stackObjectBuf(NilType _)
            {
                this.m_stackObjectBufHdrRef = new ptr<stackObjectBufHdr>(new stackObjectBufHdr(nil));
                this.obj = default;
            }

            public stackObjectBuf(stackObjectBufHdr stackObjectBufHdr = default, array<stackObject> obj = default)
            {
                this.m_stackObjectBufHdrRef = new ptr<stackObjectBufHdr>(stackObjectBufHdr);
                this.obj = obj;
            }

            // Enable comparisons between nil and stackObjectBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stackObjectBuf value, NilType nil) => value.Equals(default(stackObjectBuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stackObjectBuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stackObjectBuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stackObjectBuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stackObjectBuf(NilType nil) => default(stackObjectBuf);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static stackObjectBuf stackObjectBuf_cast(dynamic value)
        {
            return new stackObjectBuf(value.stackObjectBufHdr, value.obj);
        }
    }
}