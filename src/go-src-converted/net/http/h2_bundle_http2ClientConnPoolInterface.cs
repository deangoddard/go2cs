//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using hpack = go.golang.org.x.net.http2.hpack_package;
using idna = go.golang.org.x.net.idna_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface http2ClientConnPool
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2ClientConnPool As<T>(in T target) => (http2ClientConnPool<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2ClientConnPool As<T>(ptr<T> target_ptr) => (http2ClientConnPool<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2ClientConnPool? As(object target) =>
                typeof(http2ClientConnPool<>).CreateInterfaceHandler<http2ClientConnPool>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class http2ClientConnPool<T> : http2ClientConnPool
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && m_target_ptr is not null)
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public http2ClientConnPool(in T target) => m_target = target;

            public http2ClientConnPool(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (ptr<http2ClientConn>, error) GetClientConnByPtr(ptr<T> value, ptr<Request> req, @string addr);
            private delegate (ptr<http2ClientConn>, error) GetClientConnByVal(T value, ptr<Request> req, @string addr);

            private static readonly GetClientConnByPtr? s_GetClientConnByPtr;
            private static readonly GetClientConnByVal? s_GetClientConnByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<http2ClientConn>, error) GetClientConn(ptr<Request> req, @string addr)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_GetClientConnByPtr is null || !m_target_is_ptr)
                    return s_GetClientConnByVal!(target, req, addr);

                return s_GetClientConnByPtr(m_target_ptr!, req, addr);
            }

            private delegate (ptr<http2ClientConn>, error) MarkDeadByPtr(ptr<T> value, ptr<http2ClientConn> _p0);
            private delegate (ptr<http2ClientConn>, error) MarkDeadByVal(T value, ptr<http2ClientConn> _p0);

            private static readonly MarkDeadByPtr? s_MarkDeadByPtr;
            private static readonly MarkDeadByVal? s_MarkDeadByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<http2ClientConn>, error) MarkDead(ptr<http2ClientConn> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_MarkDeadByPtr is null || !m_target_is_ptr)
                    return s_MarkDeadByVal!(target, _p0);

                return s_MarkDeadByPtr(m_target_ptr!, _p0);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static http2ClientConnPool()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("GetClientConn");

                if (extensionMethod is not null)
                    s_GetClientConnByPtr = extensionMethod.CreateStaticDelegate(typeof(GetClientConnByPtr)) as GetClientConnByPtr;

                extensionMethod = targetType.GetExtensionMethod("GetClientConn");

                if (extensionMethod is not null)
                    s_GetClientConnByVal = extensionMethod.CreateStaticDelegate(typeof(GetClientConnByVal)) as GetClientConnByVal;

                if (s_GetClientConnByPtr is null && s_GetClientConnByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2ClientConnPool.GetClientConn method", new Exception("GetClientConn"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("MarkDead");

                if (extensionMethod is not null)
                    s_MarkDeadByPtr = extensionMethod.CreateStaticDelegate(typeof(MarkDeadByPtr)) as MarkDeadByPtr;

                extensionMethod = targetType.GetExtensionMethod("MarkDead");

                if (extensionMethod is not null)
                    s_MarkDeadByVal = extensionMethod.CreateStaticDelegate(typeof(MarkDeadByVal)) as MarkDeadByVal;

                if (s_MarkDeadByPtr is null && s_MarkDeadByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2ClientConnPool.MarkDead method", new Exception("MarkDead"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator http2ClientConnPool<T>(in ptr<T> target_ptr) => new http2ClientConnPool<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator http2ClientConnPool<T>(in T target) => new http2ClientConnPool<T>(target);

            // Enable comparisons between nil and http2ClientConnPool<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2ClientConnPool<T> value, NilType nil) => Activator.CreateInstance<http2ClientConnPool<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2ClientConnPool<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2ClientConnPool<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2ClientConnPool<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class http_http2ClientConnPoolExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net.http_package.http2ClientConnPool target)
        {
            try
            {
                return ((go.net.http_package.http2ClientConnPool<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net.http_package.http2ClientConnPool target, out T result)
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

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.net.http_package.http2ClientConnPool target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net.http_package.http2ClientConnPool<>).GetExplicitGenericConversionOperator(type));

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

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.net.http_package.http2ClientConnPool target, Type type, out object? result)
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