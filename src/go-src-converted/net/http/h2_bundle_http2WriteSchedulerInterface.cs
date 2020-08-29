//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using context = go.context_package;
using rand = go.crypto.rand_package;
using tls = go.crypto.tls_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using math = go.math_package;
using mathrand = go.math.rand_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using hpack = go.golang_org.x.net.http2.hpack_package;
using idna = go.golang_org.x.net.idna_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface http2WriteScheduler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2WriteScheduler As<T>(in T target) => (http2WriteScheduler<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2WriteScheduler As<T>(ptr<T> target_ptr) => (http2WriteScheduler<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2WriteScheduler? As(object target) =>
                typeof(http2WriteScheduler<>).CreateInterfaceHandler<http2WriteScheduler>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class http2WriteScheduler<T> : http2WriteScheduler
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.Value;

                    return ref m_target;
                }
            }

            public http2WriteScheduler(in T target) => m_target = target;

            public http2WriteScheduler(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (http2FrameWriteRequest, bool) OpenStreamByRef(ref T value, uint streamID, http2OpenStreamOptions options);
            private delegate (http2FrameWriteRequest, bool) OpenStreamByVal(T value, uint streamID, http2OpenStreamOptions options);

            private static readonly OpenStreamByRef s_OpenStreamByRef;
            private static readonly OpenStreamByVal s_OpenStreamByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (http2FrameWriteRequest, bool) OpenStream(uint streamID, http2OpenStreamOptions options)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_OpenStreamByRef is null)
                    return s_OpenStreamByVal!(target, streamID, options);

                return s_OpenStreamByRef(ref target, streamID, options);
            }

            private delegate (http2FrameWriteRequest, bool) CloseStreamByRef(ref T value, uint streamID);
            private delegate (http2FrameWriteRequest, bool) CloseStreamByVal(T value, uint streamID);

            private static readonly CloseStreamByRef s_CloseStreamByRef;
            private static readonly CloseStreamByVal s_CloseStreamByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (http2FrameWriteRequest, bool) CloseStream(uint streamID)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_CloseStreamByRef is null)
                    return s_CloseStreamByVal!(target, streamID);

                return s_CloseStreamByRef(ref target, streamID);
            }

            private delegate (http2FrameWriteRequest, bool) AdjustStreamByRef(ref T value, uint streamID, http2PriorityParam priority);
            private delegate (http2FrameWriteRequest, bool) AdjustStreamByVal(T value, uint streamID, http2PriorityParam priority);

            private static readonly AdjustStreamByRef s_AdjustStreamByRef;
            private static readonly AdjustStreamByVal s_AdjustStreamByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (http2FrameWriteRequest, bool) AdjustStream(uint streamID, http2PriorityParam priority)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AdjustStreamByRef is null)
                    return s_AdjustStreamByVal!(target, streamID, priority);

                return s_AdjustStreamByRef(ref target, streamID, priority);
            }

            private delegate (http2FrameWriteRequest, bool) PushByRef(ref T value, http2FrameWriteRequest wr);
            private delegate (http2FrameWriteRequest, bool) PushByVal(T value, http2FrameWriteRequest wr);

            private static readonly PushByRef s_PushByRef;
            private static readonly PushByVal s_PushByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (http2FrameWriteRequest, bool) Push(http2FrameWriteRequest wr)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_PushByRef is null)
                    return s_PushByVal!(target, wr);

                return s_PushByRef(ref target, wr);
            }

            private delegate (http2FrameWriteRequest, bool) PopByRef(ref T value);
            private delegate (http2FrameWriteRequest, bool) PopByVal(T value);

            private static readonly PopByRef s_PopByRef;
            private static readonly PopByVal s_PopByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (http2FrameWriteRequest, bool) Pop()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_PopByRef is null)
                    return s_PopByVal!(target);

                return s_PopByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static http2WriteScheduler()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("OpenStream");

                if (!(extensionMethod is null))
                    s_OpenStreamByRef = extensionMethod.CreateStaticDelegate(typeof(OpenStreamByRef)) as OpenStreamByRef;

                if (s_OpenStreamByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("OpenStream");

                    if (!(extensionMethod is null))
                        s_OpenStreamByVal = extensionMethod.CreateStaticDelegate(typeof(OpenStreamByVal)) as OpenStreamByVal;
                }

                if (s_OpenStreamByRef is null && s_OpenStreamByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2WriteScheduler.OpenStream method", new Exception("OpenStream"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("CloseStream");

                if (!(extensionMethod is null))
                    s_CloseStreamByRef = extensionMethod.CreateStaticDelegate(typeof(CloseStreamByRef)) as CloseStreamByRef;

                if (s_CloseStreamByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("CloseStream");

                    if (!(extensionMethod is null))
                        s_CloseStreamByVal = extensionMethod.CreateStaticDelegate(typeof(CloseStreamByVal)) as CloseStreamByVal;
                }

                if (s_CloseStreamByRef is null && s_CloseStreamByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2WriteScheduler.CloseStream method", new Exception("CloseStream"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AdjustStream");

                if (!(extensionMethod is null))
                    s_AdjustStreamByRef = extensionMethod.CreateStaticDelegate(typeof(AdjustStreamByRef)) as AdjustStreamByRef;

                if (s_AdjustStreamByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AdjustStream");

                    if (!(extensionMethod is null))
                        s_AdjustStreamByVal = extensionMethod.CreateStaticDelegate(typeof(AdjustStreamByVal)) as AdjustStreamByVal;
                }

                if (s_AdjustStreamByRef is null && s_AdjustStreamByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2WriteScheduler.AdjustStream method", new Exception("AdjustStream"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Push");

                if (!(extensionMethod is null))
                    s_PushByRef = extensionMethod.CreateStaticDelegate(typeof(PushByRef)) as PushByRef;

                if (s_PushByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Push");

                    if (!(extensionMethod is null))
                        s_PushByVal = extensionMethod.CreateStaticDelegate(typeof(PushByVal)) as PushByVal;
                }

                if (s_PushByRef is null && s_PushByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2WriteScheduler.Push method", new Exception("Push"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Pop");

                if (!(extensionMethod is null))
                    s_PopByRef = extensionMethod.CreateStaticDelegate(typeof(PopByRef)) as PopByRef;

                if (s_PopByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Pop");

                    if (!(extensionMethod is null))
                        s_PopByVal = extensionMethod.CreateStaticDelegate(typeof(PopByVal)) as PopByVal;
                }

                if (s_PopByRef is null && s_PopByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2WriteScheduler.Pop method", new Exception("Pop"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator http2WriteScheduler<T>(in ptr<T> target_ptr) => new http2WriteScheduler<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator http2WriteScheduler<T>(in T target) => new http2WriteScheduler<T>(target);

            // Enable comparisons between nil and http2WriteScheduler<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2WriteScheduler<T> value, NilType nil) => Activator.CreateInstance<http2WriteScheduler<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2WriteScheduler<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2WriteScheduler<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2WriteScheduler<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class http_http2WriteSchedulerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net.http_package.http2WriteScheduler target)
        {
            try
            {
                return ((go.net.http_package.http2WriteScheduler<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net.http_package.http2WriteScheduler target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.net.http_package.http2WriteScheduler target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net.http_package.http2WriteScheduler<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.net.http_package.http2WriteScheduler target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}