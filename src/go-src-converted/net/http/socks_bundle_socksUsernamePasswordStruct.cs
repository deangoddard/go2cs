//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using io = go.io_package;
using net = go.net_package;
using strconv = go.strconv_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct socksUsernamePassword
        {
            // Constructors
            public socksUsernamePassword(NilType _)
            {
                this.Username = default;
                this.Password = default;
            }

            public socksUsernamePassword(@string Username = default, @string Password = default)
            {
                this.Username = Username;
                this.Password = Password;
            }

            // Enable comparisons between nil and socksUsernamePassword struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(socksUsernamePassword value, NilType nil) => value.Equals(default(socksUsernamePassword));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(socksUsernamePassword value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, socksUsernamePassword value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, socksUsernamePassword value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator socksUsernamePassword(NilType nil) => default(socksUsernamePassword);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static socksUsernamePassword socksUsernamePassword_cast(dynamic value)
        {
            return new socksUsernamePassword(value.Username, value.Password);
        }
    }
}}