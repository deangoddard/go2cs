//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using gzip = go.compress.gzip_package;
using list = go.container.list_package;
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using url = go.net.url_package;
using os = go.os_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using proxy = go.golang_org.x.net.proxy_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct readerAndCloser
        {
            // Reader.Read function promotion
            private delegate (long, error) ReadByVal(T value, slice<byte> p);
            private delegate (long, error) ReadByRef(ref T value, slice<byte> p);

            private static readonly ReadByVal s_ReadByVal;
            private static readonly ReadByRef s_ReadByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Read(slice<byte> p) => s_ReadByRef?.Invoke(ref this, p) ?? s_ReadByVal?.Invoke(this, p) ?? Reader?.Read(p) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Closer.Close function promotion
            private delegate error CloseByVal(T value);
            private delegate error CloseByRef(ref T value);

            private static readonly CloseByVal s_CloseByVal;
            private static readonly CloseByRef s_CloseByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Close() => s_CloseByRef?.Invoke(ref this) ?? s_CloseByVal?.Invoke(this) ?? Closer?.Close() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static readerAndCloser()
            {
                Type targetType = typeof(readerAndCloser);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Read");

                if ((object)extensionMethod != null)
                {
                    s_ReadByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByRef)) as ReadByRef;

                    if ((object)s_ReadByRef == null)
                        s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Close");

                if ((object)extensionMethod != null)
                {
                    s_CloseByRef = extensionMethod.CreateStaticDelegate(typeof(CloseByRef)) as CloseByRef;

                    if ((object)s_CloseByRef == null)
                        s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;
                }
            }

            // Constructors
            public readerAndCloser(NilType _)
            {
                this.Reader = default;
                this.Closer = default;
            }

            public readerAndCloser(io.Reader Reader = default, io.Closer Closer = default)
            {
                this.Reader = Reader;
                this.Closer = Closer;
            }

            // Enable comparisons between nil and readerAndCloser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(readerAndCloser value, NilType nil) => value.Equals(default(readerAndCloser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(readerAndCloser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, readerAndCloser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, readerAndCloser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readerAndCloser(NilType nil) => default(readerAndCloser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static readerAndCloser readerAndCloser_cast(dynamic value)
        {
            return new readerAndCloser(value.Reader, value.Closer);
        }
    }
}}