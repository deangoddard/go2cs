//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:37:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace dns
{
    public static partial class dnsmessage_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct header
        {
            // Constructors
            public header(NilType _)
            {
                this.id = default;
                this.bits = default;
                this.questions = default;
                this.answers = default;
                this.authorities = default;
                this.additionals = default;
            }

            public header(ushort id = default, ushort bits = default, ushort questions = default, ushort answers = default, ushort authorities = default, ushort additionals = default)
            {
                this.id = id;
                this.bits = bits;
                this.questions = questions;
                this.answers = answers;
                this.authorities = authorities;
                this.additionals = additionals;
            }

            // Enable comparisons between nil and header struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(header value, NilType nil) => value.Equals(default(header));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(header value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, header value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, header value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator header(NilType nil) => default(header);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static header header_cast(dynamic value)
        {
            return new header(value.id, value.bits, value.questions, value.answers, value.authorities, value.additionals);
        }
    }
}}}}}}