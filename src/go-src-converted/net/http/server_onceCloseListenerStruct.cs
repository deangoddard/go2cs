//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using rand = go.math.rand_package;
using net = go.net_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct onceCloseListener
        {
            // Listener.Accept function promotion
            private delegate Addr AcceptByVal(T value);
            private delegate Addr AcceptByRef(ref T value);

            private static readonly AcceptByVal s_AcceptByVal;
            private static readonly AcceptByRef s_AcceptByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Accept() => s_AcceptByRef?.Invoke(ref this) ?? s_AcceptByVal?.Invoke(this) ?? Listener?.Accept() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Listener.Close function promotion
            private delegate Addr CloseByVal(T value);
            private delegate Addr CloseByRef(ref T value);

            private static readonly CloseByVal s_CloseByVal;
            private static readonly CloseByRef s_CloseByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Close() => s_CloseByRef?.Invoke(ref this) ?? s_CloseByVal?.Invoke(this) ?? Listener?.Close() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Listener.Addr function promotion
            private delegate Addr AddrByVal(T value);
            private delegate Addr AddrByRef(ref T value);

            private static readonly AddrByVal s_AddrByVal;
            private static readonly AddrByRef s_AddrByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Addr() => s_AddrByRef?.Invoke(ref this) ?? s_AddrByVal?.Invoke(this) ?? Listener?.Addr() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static onceCloseListener()
            {
                Type targetType = typeof(onceCloseListener);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Accept");

                if (extensionMethod is not null)
                {
                    s_AcceptByRef = extensionMethod.CreateStaticDelegate(typeof(AcceptByRef)) as AcceptByRef;

                    if (s_AcceptByRef is null)
                        s_AcceptByVal = extensionMethod.CreateStaticDelegate(typeof(AcceptByVal)) as AcceptByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Close");

                if (extensionMethod is not null)
                {
                    s_CloseByRef = extensionMethod.CreateStaticDelegate(typeof(CloseByRef)) as CloseByRef;

                    if (s_CloseByRef is null)
                        s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Addr");

                if (extensionMethod is not null)
                {
                    s_AddrByRef = extensionMethod.CreateStaticDelegate(typeof(AddrByRef)) as AddrByRef;

                    if (s_AddrByRef is null)
                        s_AddrByVal = extensionMethod.CreateStaticDelegate(typeof(AddrByVal)) as AddrByVal;
                }
            }

            // Constructors
            public onceCloseListener(NilType _)
            {
                this.Listener = default;
                this.once = default;
                this.closeErr = default;
            }

            public onceCloseListener(net.Listener Listener = default, sync.Once once = default, error closeErr = default)
            {
                this.Listener = Listener;
                this.once = once;
                this.closeErr = closeErr;
            }

            // Enable comparisons between nil and onceCloseListener struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(onceCloseListener value, NilType nil) => value.Equals(default(onceCloseListener));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(onceCloseListener value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, onceCloseListener value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, onceCloseListener value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator onceCloseListener(NilType nil) => default(onceCloseListener);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static onceCloseListener onceCloseListener_cast(dynamic value)
        {
            return new onceCloseListener(value.Listener, value.once, value.closeErr);
        }
    }
}}