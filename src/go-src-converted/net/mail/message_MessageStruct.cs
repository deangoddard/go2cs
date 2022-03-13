//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:40:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using mime = go.mime_package;
using textproto = go.net.textproto_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class mail_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Message
        {
            // Constructors
            public Message(NilType _)
            {
                this.Header = default;
                this.Body = default;
            }

            public Message(Header Header = default, io.Reader Body = default)
            {
                this.Header = Header;
                this.Body = Body;
            }

            // Enable comparisons between nil and Message struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Message value, NilType nil) => value.Equals(default(Message));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Message value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Message value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Message value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Message(NilType nil) => default(Message);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Message Message_cast(dynamic value)
        {
            return new Message(value.Header, value.Body);
        }
    }
}}