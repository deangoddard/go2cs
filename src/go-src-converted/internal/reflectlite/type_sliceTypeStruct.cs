//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:12:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using unsafeheader = go.@internal.unsafeheader_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class reflectlite_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(rtype))]
        private partial struct sliceType
        {
            // rtype structure promotion - sourced from value copy
            private readonly ptr<rtype> m_rtypeRef;

            private ref rtype rtype_val => ref m_rtypeRef.Value;

            public ref System.UIntPtr size => ref m_rtypeRef.Value.size;

            public ref System.UIntPtr ptrdata => ref m_rtypeRef.Value.ptrdata;

            public ref uint hash => ref m_rtypeRef.Value.hash;

            public ref tflag tflag => ref m_rtypeRef.Value.tflag;

            public ref byte align => ref m_rtypeRef.Value.align;

            public ref byte fieldAlign => ref m_rtypeRef.Value.fieldAlign;

            public ref byte kind => ref m_rtypeRef.Value.kind;

            public ref Func<unsafe.Pointer, unsafe.Pointer, bool> equal => ref m_rtypeRef.Value.equal;

            public ref ptr<byte> gcdata => ref m_rtypeRef.Value.gcdata;

            public ref nameOff str => ref m_rtypeRef.Value.str;

            public ref typeOff ptrToThis => ref m_rtypeRef.Value.ptrToThis;

            // Constructors
            public sliceType(NilType _)
            {
                this.m_rtypeRef = new ptr<rtype>(new rtype(nil));
                this.elem = default;
            }

            public sliceType(rtype rtype = default, ref ptr<rtype> elem = default)
            {
                this.m_rtypeRef = new ptr<rtype>(rtype);
                this.elem = elem;
            }

            // Enable comparisons between nil and sliceType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sliceType value, NilType nil) => value.Equals(default(sliceType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sliceType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sliceType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sliceType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sliceType(NilType nil) => default(sliceType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sliceType sliceType_cast(dynamic value)
        {
            return new sliceType(value.rtype, ref value.elem);
        }
    }
}}