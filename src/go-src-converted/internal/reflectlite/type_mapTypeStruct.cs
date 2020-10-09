//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        private partial struct mapType
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
            public mapType(NilType _)
            {
                this.m_rtypeRef = new ptr<rtype>(new rtype(nil));
                this.key = default;
                this.elem = default;
                this.bucket = default;
                this.hasher = default;
                this.keysize = default;
                this.valuesize = default;
                this.bucketsize = default;
                this.flags = default;
            }

            public mapType(rtype rtype = default, ref ptr<rtype> key = default, ref ptr<rtype> elem = default, ref ptr<rtype> bucket = default, Func<unsafe.Pointer, System.UIntPtr, System.UIntPtr> hasher = default, byte keysize = default, byte valuesize = default, ushort bucketsize = default, uint flags = default)
            {
                this.m_rtypeRef = new ptr<rtype>(rtype);
                this.key = key;
                this.elem = elem;
                this.bucket = bucket;
                this.hasher = hasher;
                this.keysize = keysize;
                this.valuesize = valuesize;
                this.bucketsize = bucketsize;
                this.flags = flags;
            }

            // Enable comparisons between nil and mapType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mapType value, NilType nil) => value.Equals(default(mapType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mapType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mapType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mapType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mapType(NilType nil) => default(mapType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mapType mapType_cast(dynamic value)
        {
            return new mapType(value.rtype, ref value.key, ref value.elem, ref value.bucket, value.hasher, value.keysize, value.valuesize, value.bucketsize, value.flags);
        }
    }
}}