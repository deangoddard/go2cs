//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:20:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct helloRequestMsg
        {
            // Constructors
            public helloRequestMsg(NilType _)
            {
            }
            // Enable comparisons between nil and helloRequestMsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(helloRequestMsg value, NilType nil) => value.Equals(default(helloRequestMsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(helloRequestMsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, helloRequestMsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, helloRequestMsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator helloRequestMsg(NilType nil) => default(helloRequestMsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static helloRequestMsg helloRequestMsg_cast(dynamic value)
        {
            return new helloRequestMsg();
        }
    }
}}