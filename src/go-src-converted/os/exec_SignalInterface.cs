//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using testlog = go.@internal.testlog_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using syscall = go.syscall_package;
using time = go.time_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Signal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Signal As<T>(in T target) => (Signal<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Signal As<T>(ptr<T> target_ptr) => (Signal<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Signal? As(object target) =>
                typeof(Signal<>).CreateInterfaceHandler<Signal>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Signal<T> : Signal
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

            public Signal(in T target) => m_target = target;

            public Signal(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string StringByRef(ref T value);
            private delegate @string StringByVal(T value);

            private static readonly StringByRef s_StringByRef;
            private static readonly StringByVal s_StringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string String()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_StringByRef is null)
                    return s_StringByVal!(target);

                return s_StringByRef(ref target);
            }

            private delegate @string SignalByRef(ref T value);
            private delegate @string SignalByVal(T value);

            private static readonly SignalByRef s_SignalByRef;
            private static readonly SignalByVal s_SignalByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Signal()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_SignalByRef is null)
                    return s_SignalByVal!(target);

                return s_SignalByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Signal()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByRef = extensionMethod.CreateStaticDelegate(typeof(StringByRef)) as StringByRef;

                if (s_StringByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("String");

                    if (!(extensionMethod is null))
                        s_StringByVal = extensionMethod.CreateStaticDelegate(typeof(StringByVal)) as StringByVal;
                }

                if (s_StringByRef is null && s_StringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Signal.String method", new Exception("String"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Signal");

                if (!(extensionMethod is null))
                    s_SignalByRef = extensionMethod.CreateStaticDelegate(typeof(SignalByRef)) as SignalByRef;

                if (s_SignalByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Signal");

                    if (!(extensionMethod is null))
                        s_SignalByVal = extensionMethod.CreateStaticDelegate(typeof(SignalByVal)) as SignalByVal;
                }

                if (s_SignalByRef is null && s_SignalByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Signal.Signal method", new Exception("Signal"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Signal<T>(in ptr<T> target_ptr) => new Signal<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Signal<T>(in T target) => new Signal<T>(target);

            // Enable comparisons between nil and Signal<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Signal<T> value, NilType nil) => Activator.CreateInstance<Signal<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Signal<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Signal<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Signal<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class os_SignalExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.os_package.Signal target)
        {
            try
            {
                return ((go.os_package.Signal<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.os_package.Signal target, out T result)
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
        public static object? _(this go.os_package.Signal target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.os_package.Signal<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.os_package.Signal target, Type type, out object? result)
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