//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:29:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using errors = go.errors_package;
using poll = go.@internal.poll_package;
using io = go.io_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface timeout
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static timeout As<T>(in T target) => (timeout<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static timeout As<T>(ptr<T> target_ptr) => (timeout<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static timeout? As(object target) =>
                typeof(timeout<>).CreateInterfaceHandler<timeout>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class timeout<T> : timeout
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

            public timeout(in T target) => m_target = target;

            public timeout(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate bool TimeoutByPtr(ptr<T> value);
            private delegate bool TimeoutByVal(T value);

            private static readonly TimeoutByPtr? s_TimeoutByPtr;
            private static readonly TimeoutByVal? s_TimeoutByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Timeout()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_TimeoutByPtr is null || !m_target_is_ptr)
                    return s_TimeoutByVal!(target);

                return s_TimeoutByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static timeout()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Timeout");

                if (extensionMethod is not null)
                    s_TimeoutByPtr = extensionMethod.CreateStaticDelegate(typeof(TimeoutByPtr)) as TimeoutByPtr;

                extensionMethod = targetType.GetExtensionMethod("Timeout");

                if (extensionMethod is not null)
                    s_TimeoutByVal = extensionMethod.CreateStaticDelegate(typeof(TimeoutByVal)) as TimeoutByVal;

                if (s_TimeoutByPtr is null && s_TimeoutByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement timeout.Timeout method", new Exception("Timeout"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator timeout<T>(in ptr<T> target_ptr) => new timeout<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator timeout<T>(in T target) => new timeout<T>(target);

            // Enable comparisons between nil and timeout<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(timeout<T> value, NilType nil) => Activator.CreateInstance<timeout<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(timeout<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, timeout<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, timeout<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class net_timeoutExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net_package.timeout target)
        {
            try
            {
                return ((go.net_package.timeout<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net_package.timeout target, out T result)
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
        public static object? _(this go.net_package.timeout target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net_package.timeout<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net_package.timeout target, Type type, out object? result)
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