//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:18:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(workbufhdr))]
        private partial struct workbuf
        {
            // workbufhdr structure promotion - sourced from value copy
            private readonly ptr<workbufhdr> m_workbufhdrRef;

            private ref workbufhdr workbufhdr_val => ref m_workbufhdrRef.Value;

            public ref lfnode node => ref m_workbufhdrRef.Value.node;

            public ref long nobj => ref m_workbufhdrRef.Value.nobj;

            // Constructors
            public workbuf(NilType _)
            {
                this.m_workbufhdrRef = new ptr<workbufhdr>(new workbufhdr(nil));
                this.obj = default;
            }

            public workbuf(workbufhdr workbufhdr = default, array<System.UIntPtr> obj = default)
            {
                this.m_workbufhdrRef = new ptr<workbufhdr>(workbufhdr);
                this.obj = obj;
            }

            // Enable comparisons between nil and workbuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(workbuf value, NilType nil) => value.Equals(default(workbuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(workbuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, workbuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, workbuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator workbuf(NilType nil) => default(workbuf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static workbuf workbuf_cast(dynamic value)
        {
            return new workbuf(value.workbufhdr, value.obj);
        }
    }
}