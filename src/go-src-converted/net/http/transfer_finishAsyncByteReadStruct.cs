//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using @internal = go.net.http.@internal_package;
using textproto = go.net.textproto_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct finishAsyncByteRead
        {
            // Constructors
            public finishAsyncByteRead(NilType _)
            {
                this.tw = default;
            }

            public finishAsyncByteRead(ref ptr<transferWriter> tw = default)
            {
                this.tw = tw;
            }

            // Enable comparisons between nil and finishAsyncByteRead struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(finishAsyncByteRead value, NilType nil) => value.Equals(default(finishAsyncByteRead));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(finishAsyncByteRead value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, finishAsyncByteRead value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, finishAsyncByteRead value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator finishAsyncByteRead(NilType nil) => default(finishAsyncByteRead);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static finishAsyncByteRead finishAsyncByteRead_cast(dynamic value)
        {
            return new finishAsyncByteRead(ref value.tw);
        }
    }
}}