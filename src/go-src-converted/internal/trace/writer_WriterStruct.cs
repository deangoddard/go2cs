//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:04:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using go;

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(bytes.Buffer))]
        public partial struct Writer
        {
            // Buffer structure promotion - sourced from value copy
            private readonly ptr<Buffer> m_BufferRef;

            private ref Buffer Buffer_val => ref m_BufferRef.Value;

            public ref slice<byte> buf => ref m_BufferRef.Value.buf;

            public ref long off => ref m_BufferRef.Value.off;

            public ref array<byte> bootstrap => ref m_BufferRef.Value.bootstrap;

            public ref readOp lastRead => ref m_BufferRef.Value.lastRead;

            // Constructors
            public Writer(NilType _)
            {
                this.m_BufferRef = new ptr<bytes.Buffer>(new bytes.Buffer(nil));
            }

            public Writer(bytes.Buffer Buffer = default)
            {
                this.m_BufferRef = new ptr<bytes.Buffer>(Buffer);
            }

            // Enable comparisons between nil and Writer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Writer value, NilType nil) => value.Equals(default(Writer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Writer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Writer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Writer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Writer(NilType nil) => default(Writer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Writer Writer_cast(dynamic value)
        {
            return new Writer(value.Buffer);
        }
    }
}}