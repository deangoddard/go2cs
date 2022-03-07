//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using hmac = go.crypto.hmac_package;
using md5 = go.crypto.md5_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace net
{
    public static partial class smtp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Auth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Auth As<T>(in T target) => (Auth<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Auth As<T>(ptr<T> target_ptr) => (Auth<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Auth? As(object target) =>
                typeof(Auth<>).CreateInterfaceHandler<Auth>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Auth<T> : Auth
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

            public Auth(in T target) => m_target = target;

            public Auth(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (slice<byte>, error) StartByPtr(ptr<T> value, ptr<ServerInfo> server);
            private delegate (slice<byte>, error) StartByVal(T value, ptr<ServerInfo> server);

            private static readonly StartByPtr? s_StartByPtr;
            private static readonly StartByVal? s_StartByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Start(ptr<ServerInfo> server)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_StartByPtr is null || !m_target_is_ptr)
                    return s_StartByVal!(target, server);

                return s_StartByPtr(m_target_ptr!, server);
            }

            private delegate (slice<byte>, error) NextByPtr(ptr<T> value, slice<byte> fromServer, bool more);
            private delegate (slice<byte>, error) NextByVal(T value, slice<byte> fromServer, bool more);

            private static readonly NextByPtr? s_NextByPtr;
            private static readonly NextByVal? s_NextByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Next(slice<byte> fromServer, bool more)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_NextByPtr is null || !m_target_is_ptr)
                    return s_NextByVal!(target, fromServer, more);

                return s_NextByPtr(m_target_ptr!, fromServer, more);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Auth()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Start");

                if (extensionMethod is not null)
                    s_StartByPtr = extensionMethod.CreateStaticDelegate(typeof(StartByPtr)) as StartByPtr;

                extensionMethod = targetType.GetExtensionMethod("Start");

                if (extensionMethod is not null)
                    s_StartByVal = extensionMethod.CreateStaticDelegate(typeof(StartByVal)) as StartByVal;

                if (s_StartByPtr is null && s_StartByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Auth.Start method", new Exception("Start"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Next");

                if (extensionMethod is not null)
                    s_NextByPtr = extensionMethod.CreateStaticDelegate(typeof(NextByPtr)) as NextByPtr;

                extensionMethod = targetType.GetExtensionMethod("Next");

                if (extensionMethod is not null)
                    s_NextByVal = extensionMethod.CreateStaticDelegate(typeof(NextByVal)) as NextByVal;

                if (s_NextByPtr is null && s_NextByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Auth.Next method", new Exception("Next"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Auth<T>(in ptr<T> target_ptr) => new Auth<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Auth<T>(in T target) => new Auth<T>(target);

            // Enable comparisons between nil and Auth<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Auth<T> value, NilType nil) => Activator.CreateInstance<Auth<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Auth<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Auth<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Auth<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class smtp_AuthExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net.smtp_package.Auth target)
        {
            try
            {
                return ((go.net.smtp_package.Auth<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net.smtp_package.Auth target, out T result)
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
        public static object? _(this go.net.smtp_package.Auth target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net.smtp_package.Auth<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net.smtp_package.Auth target, Type type, out object? result)
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