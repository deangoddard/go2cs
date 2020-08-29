//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:43 UTC
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
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using net = go.net_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct writerOnly
        {
            // Writer.Write function promotion
            private delegate (long, error) WriteByVal(T value, slice<byte> p);
            private delegate (long, error) WriteByRef(ref T value, slice<byte> p);

            private static readonly WriteByVal s_WriteByVal;
            private static readonly WriteByRef s_WriteByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Write(slice<byte> p) => s_WriteByRef?.Invoke(ref this, p) ?? s_WriteByVal?.Invoke(this, p) ?? Writer?.Write(p) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static writerOnly()
            {
                Type targetType = typeof(writerOnly);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Write");

                if ((object)extensionMethod != null)
                {
                    s_WriteByRef = extensionMethod.CreateStaticDelegate(typeof(WriteByRef)) as WriteByRef;

                    if ((object)s_WriteByRef == null)
                        s_WriteByVal = extensionMethod.CreateStaticDelegate(typeof(WriteByVal)) as WriteByVal;
                }
            }

            // Constructors
            public writerOnly(NilType _)
            {
                this.Writer = default;
            }

            public writerOnly(io.Writer Writer = default)
            {
                this.Writer = Writer;
            }

            // Enable comparisons between nil and writerOnly struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(writerOnly value, NilType nil) => value.Equals(default(writerOnly));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(writerOnly value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, writerOnly value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, writerOnly value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator writerOnly(NilType nil) => default(writerOnly);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static writerOnly writerOnly_cast(dynamic value)
        {
            return new writerOnly(value.Writer);
        }
    }
}}