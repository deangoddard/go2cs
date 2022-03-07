//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using tls = go.crypto.tls_package;
using base64 = go.encoding.base64_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using net = go.net_package;
using textproto = go.net.textproto_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class smtp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dataCloser
        {            
            [DebuggerStepperBoundary]
            static dataCloser()
            {
                Type targetType = typeof(dataCloser);
                MethodInfo extensionMethod;
            }

            // Constructors
            public dataCloser(NilType _)
            {
                this.c = default;
                this.WriteCloser = default;
            }

            public dataCloser(ref ptr<Client> c = default, io.WriteCloser WriteCloser = default)
            {
                this.c = c;
                this.WriteCloser = WriteCloser;
            }

            // Enable comparisons between nil and dataCloser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dataCloser value, NilType nil) => value.Equals(default(dataCloser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dataCloser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dataCloser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dataCloser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dataCloser(NilType nil) => default(dataCloser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dataCloser dataCloser_cast(dynamic value)
        {
            return new dataCloser(ref value.c, value.WriteCloser);
        }
    }
}}