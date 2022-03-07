//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using net = go.net_package;
using url = go.net.url_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rfc2821Mailbox
        {
            // Constructors
            public rfc2821Mailbox(NilType _)
            {
                this.local = default;
                this.domain = default;
            }

            public rfc2821Mailbox(@string local = default, @string domain = default)
            {
                this.local = local;
                this.domain = domain;
            }

            // Enable comparisons between nil and rfc2821Mailbox struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rfc2821Mailbox value, NilType nil) => value.Equals(default(rfc2821Mailbox));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rfc2821Mailbox value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rfc2821Mailbox value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rfc2821Mailbox value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rfc2821Mailbox(NilType nil) => default(rfc2821Mailbox);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rfc2821Mailbox rfc2821Mailbox_cast(dynamic value)
        {
            return new rfc2821Mailbox(value.local, value.domain);
        }
    }
}}