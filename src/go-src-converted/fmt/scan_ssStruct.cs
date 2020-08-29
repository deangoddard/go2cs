//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:45:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using os = go.os_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;

namespace go
{
    public static partial class fmt_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(ssave))]
        private partial struct ss
        {
            // ssave structure promotion - sourced from value copy
            private readonly ptr<ssave> m_ssaveRef;

            private ref ssave ssave_val => ref m_ssaveRef.Value;

            public ref bool validSave => ref m_ssaveRef.Value.validSave;

            public ref bool nlIsEnd => ref m_ssaveRef.Value.nlIsEnd;

            public ref bool nlIsSpace => ref m_ssaveRef.Value.nlIsSpace;

            public ref long argLimit => ref m_ssaveRef.Value.argLimit;

            public ref long limit => ref m_ssaveRef.Value.limit;

            public ref long maxWid => ref m_ssaveRef.Value.maxWid;

            // Constructors
            public ss(NilType _)
            {
                this.rs = default;
                this.buf = default;
                this.count = default;
                this.atEOF = default;
                this.m_ssaveRef = new ptr<ssave>(new ssave(nil));
            }

            public ss(io.RuneScanner rs = default, buffer buf = default, long count = default, bool atEOF = default, ssave ssave = default)
            {
                this.rs = rs;
                this.buf = buf;
                this.count = count;
                this.atEOF = atEOF;
                this.m_ssaveRef = new ptr<ssave>(ssave);
            }

            // Enable comparisons between nil and ss struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ss value, NilType nil) => value.Equals(default(ss));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ss value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ss value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ss value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ss(NilType nil) => default(ss);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ss ss_cast(dynamic value)
        {
            return new ss(value.rs, value.buf, value.count, value.atEOF, value.ssave);
        }
    }
}