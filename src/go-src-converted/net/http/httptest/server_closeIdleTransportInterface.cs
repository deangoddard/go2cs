//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using tls = go.crypto.tls_package;
using x509 = go.crypto.x509_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using log = go.log_package;
using net = go.net_package;
using http = go.net.http_package;
using testcert = go.net.http.@internal.testcert_package;
using os = go.os_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace net {
namespace http
{
    public static partial class httptest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface closeIdleTransport
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static closeIdleTransport As<T>(in T target) => (closeIdleTransport<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static closeIdleTransport As<T>(ptr<T> target_ptr) => (closeIdleTransport<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static closeIdleTransport? As(object target) =>
                typeof(closeIdleTransport<>).CreateInterfaceHandler<closeIdleTransport>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class closeIdleTransport<T> : closeIdleTransport
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

            public closeIdleTransport(in T target) => m_target = target;

            public closeIdleTransport(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void CloseIdleConnectionsByPtr(ptr<T> value);
            private delegate void CloseIdleConnectionsByVal(T value);

            private static readonly CloseIdleConnectionsByPtr? s_CloseIdleConnectionsByPtr;
            private static readonly CloseIdleConnectionsByVal? s_CloseIdleConnectionsByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void CloseIdleConnections()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_CloseIdleConnectionsByPtr is null || !m_target_is_ptr)
                {
                    s_CloseIdleConnectionsByVal!(target);
                    return;
                }

                s_CloseIdleConnectionsByPtr(m_target_ptr!);
                return;
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static closeIdleTransport()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("CloseIdleConnections");

                if (extensionMethod is not null)
                    s_CloseIdleConnectionsByPtr = extensionMethod.CreateStaticDelegate(typeof(CloseIdleConnectionsByPtr)) as CloseIdleConnectionsByPtr;

                extensionMethod = targetType.GetExtensionMethod("CloseIdleConnections");

                if (extensionMethod is not null)
                    s_CloseIdleConnectionsByVal = extensionMethod.CreateStaticDelegate(typeof(CloseIdleConnectionsByVal)) as CloseIdleConnectionsByVal;

                if (s_CloseIdleConnectionsByPtr is null && s_CloseIdleConnectionsByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement closeIdleTransport.CloseIdleConnections method", new Exception("CloseIdleConnections"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator closeIdleTransport<T>(in ptr<T> target_ptr) => new closeIdleTransport<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator closeIdleTransport<T>(in T target) => new closeIdleTransport<T>(target);

            // Enable comparisons between nil and closeIdleTransport<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(closeIdleTransport<T> value, NilType nil) => Activator.CreateInstance<closeIdleTransport<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(closeIdleTransport<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, closeIdleTransport<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, closeIdleTransport<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class httptest_closeIdleTransportExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net.http.httptest_package.closeIdleTransport target)
        {
            try
            {
                return ((go.net.http.httptest_package.closeIdleTransport<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net.http.httptest_package.closeIdleTransport target, out T result)
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
        public static object? _(this go.net.http.httptest_package.closeIdleTransport target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net.http.httptest_package.closeIdleTransport<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net.http.httptest_package.closeIdleTransport target, Type type, out object? result)
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