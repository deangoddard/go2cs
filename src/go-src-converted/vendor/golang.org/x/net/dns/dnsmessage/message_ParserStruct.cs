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
        public partial struct Parser
        {
            // Constructors
            public Parser(NilType _)
            {
                this.msg = default;
                this.header = default;
                this.section = default;
                this.off = default;
                this.index = default;
                this.resHeaderValid = default;
                this.resHeader = default;
            }

            public Parser(slice<byte> msg = default, header header = default, section section = default, nint off = default, nint index = default, bool resHeaderValid = default, ResourceHeader resHeader = default)
            {
                this.msg = msg;
                this.header = header;
                this.section = section;
                this.off = off;
                this.index = index;
                this.resHeaderValid = resHeaderValid;
                this.resHeader = resHeader;
            }

            // Enable comparisons between nil and Parser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Parser value, NilType nil) => value.Equals(default(Parser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Parser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Parser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Parser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Parser(NilType nil) => default(Parser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Parser Parser_cast(dynamic value)
        {
            return new Parser(value.msg, value.header, value.section, value.off, value.index, value.resHeaderValid, value.resHeader);
        }
    }
}}}}}}