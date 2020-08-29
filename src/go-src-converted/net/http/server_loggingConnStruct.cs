//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:44 UTC
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
        private partial struct loggingConn
        {
            // Conn.Read function promotion
            private delegate error ReadByVal(T value, slice<byte> b);
            private delegate error ReadByRef(ref T value, slice<byte> b);

            private static readonly ReadByVal s_ReadByVal;
            private static readonly ReadByRef s_ReadByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Read(slice<byte> b) => s_ReadByRef?.Invoke(ref this, b) ?? s_ReadByVal?.Invoke(this, b) ?? Conn?.Read(b) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Conn.Write function promotion
            private delegate error WriteByVal(T value, slice<byte> b);
            private delegate error WriteByRef(ref T value, slice<byte> b);

            private static readonly WriteByVal s_WriteByVal;
            private static readonly WriteByRef s_WriteByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Write(slice<byte> b) => s_WriteByRef?.Invoke(ref this, b) ?? s_WriteByVal?.Invoke(this, b) ?? Conn?.Write(b) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Conn.Close function promotion
            private delegate error CloseByVal(T value);
            private delegate error CloseByRef(ref T value);

            private static readonly CloseByVal s_CloseByVal;
            private static readonly CloseByRef s_CloseByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Close() => s_CloseByRef?.Invoke(ref this) ?? s_CloseByVal?.Invoke(this) ?? Conn?.Close() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Conn.LocalAddr function promotion
            private delegate error LocalAddrByVal(T value);
            private delegate error LocalAddrByRef(ref T value);

            private static readonly LocalAddrByVal s_LocalAddrByVal;
            private static readonly LocalAddrByRef s_LocalAddrByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error LocalAddr() => s_LocalAddrByRef?.Invoke(ref this) ?? s_LocalAddrByVal?.Invoke(this) ?? Conn?.LocalAddr() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Conn.RemoteAddr function promotion
            private delegate error RemoteAddrByVal(T value);
            private delegate error RemoteAddrByRef(ref T value);

            private static readonly RemoteAddrByVal s_RemoteAddrByVal;
            private static readonly RemoteAddrByRef s_RemoteAddrByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error RemoteAddr() => s_RemoteAddrByRef?.Invoke(ref this) ?? s_RemoteAddrByVal?.Invoke(this) ?? Conn?.RemoteAddr() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Conn.SetDeadline function promotion
            private delegate error SetDeadlineByVal(T value, time.Time t);
            private delegate error SetDeadlineByRef(ref T value, time.Time t);

            private static readonly SetDeadlineByVal s_SetDeadlineByVal;
            private static readonly SetDeadlineByRef s_SetDeadlineByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error SetDeadline(time.Time t) => s_SetDeadlineByRef?.Invoke(ref this, t) ?? s_SetDeadlineByVal?.Invoke(this, t) ?? Conn?.SetDeadline(t) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Conn.SetReadDeadline function promotion
            private delegate error SetReadDeadlineByVal(T value, time.Time t);
            private delegate error SetReadDeadlineByRef(ref T value, time.Time t);

            private static readonly SetReadDeadlineByVal s_SetReadDeadlineByVal;
            private static readonly SetReadDeadlineByRef s_SetReadDeadlineByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error SetReadDeadline(time.Time t) => s_SetReadDeadlineByRef?.Invoke(ref this, t) ?? s_SetReadDeadlineByVal?.Invoke(this, t) ?? Conn?.SetReadDeadline(t) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Conn.SetWriteDeadline function promotion
            private delegate error SetWriteDeadlineByVal(T value, time.Time t);
            private delegate error SetWriteDeadlineByRef(ref T value, time.Time t);

            private static readonly SetWriteDeadlineByVal s_SetWriteDeadlineByVal;
            private static readonly SetWriteDeadlineByRef s_SetWriteDeadlineByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error SetWriteDeadline(time.Time t) => s_SetWriteDeadlineByRef?.Invoke(ref this, t) ?? s_SetWriteDeadlineByVal?.Invoke(this, t) ?? Conn?.SetWriteDeadline(t) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static loggingConn()
            {
                Type targetType = typeof(loggingConn);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Read");

                if ((object)extensionMethod != null)
                {
                    s_ReadByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByRef)) as ReadByRef;

                    if ((object)s_ReadByRef == null)
                        s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Write");

                if ((object)extensionMethod != null)
                {
                    s_WriteByRef = extensionMethod.CreateStaticDelegate(typeof(WriteByRef)) as WriteByRef;

                    if ((object)s_WriteByRef == null)
                        s_WriteByVal = extensionMethod.CreateStaticDelegate(typeof(WriteByVal)) as WriteByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Close");

                if ((object)extensionMethod != null)
                {
                    s_CloseByRef = extensionMethod.CreateStaticDelegate(typeof(CloseByRef)) as CloseByRef;

                    if ((object)s_CloseByRef == null)
                        s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("LocalAddr");

                if ((object)extensionMethod != null)
                {
                    s_LocalAddrByRef = extensionMethod.CreateStaticDelegate(typeof(LocalAddrByRef)) as LocalAddrByRef;

                    if ((object)s_LocalAddrByRef == null)
                        s_LocalAddrByVal = extensionMethod.CreateStaticDelegate(typeof(LocalAddrByVal)) as LocalAddrByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("RemoteAddr");

                if ((object)extensionMethod != null)
                {
                    s_RemoteAddrByRef = extensionMethod.CreateStaticDelegate(typeof(RemoteAddrByRef)) as RemoteAddrByRef;

                    if ((object)s_RemoteAddrByRef == null)
                        s_RemoteAddrByVal = extensionMethod.CreateStaticDelegate(typeof(RemoteAddrByVal)) as RemoteAddrByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("SetDeadline");

                if ((object)extensionMethod != null)
                {
                    s_SetDeadlineByRef = extensionMethod.CreateStaticDelegate(typeof(SetDeadlineByRef)) as SetDeadlineByRef;

                    if ((object)s_SetDeadlineByRef == null)
                        s_SetDeadlineByVal = extensionMethod.CreateStaticDelegate(typeof(SetDeadlineByVal)) as SetDeadlineByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("SetReadDeadline");

                if ((object)extensionMethod != null)
                {
                    s_SetReadDeadlineByRef = extensionMethod.CreateStaticDelegate(typeof(SetReadDeadlineByRef)) as SetReadDeadlineByRef;

                    if ((object)s_SetReadDeadlineByRef == null)
                        s_SetReadDeadlineByVal = extensionMethod.CreateStaticDelegate(typeof(SetReadDeadlineByVal)) as SetReadDeadlineByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("SetWriteDeadline");

                if ((object)extensionMethod != null)
                {
                    s_SetWriteDeadlineByRef = extensionMethod.CreateStaticDelegate(typeof(SetWriteDeadlineByRef)) as SetWriteDeadlineByRef;

                    if ((object)s_SetWriteDeadlineByRef == null)
                        s_SetWriteDeadlineByVal = extensionMethod.CreateStaticDelegate(typeof(SetWriteDeadlineByVal)) as SetWriteDeadlineByVal;
                }
            }

            // Constructors
            public loggingConn(NilType _)
            {
                this.name = default;
                this.Conn = default;
            }

            public loggingConn(@string name = default, net.Conn Conn = default)
            {
                this.name = name;
                this.Conn = Conn;
            }

            // Enable comparisons between nil and loggingConn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(loggingConn value, NilType nil) => value.Equals(default(loggingConn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(loggingConn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, loggingConn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, loggingConn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator loggingConn(NilType nil) => default(loggingConn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static loggingConn loggingConn_cast(dynamic value)
        {
            return new loggingConn(value.name, value.Conn);
        }
    }
}}