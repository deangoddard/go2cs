//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace @internal
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface message
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static message As<T>(in T target) => (message<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static message As<T>(ptr<T> target_ptr) => (message<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static message? As(object target) =>
                typeof(message<>).CreateInterfaceHandler<message>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class message<T> : message
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

            public message(in T target) => m_target = target;

            public message(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate slice<decoder> decoderByPtr(ptr<T> value);
            private delegate slice<decoder> decoderByVal(T value);

            private static readonly decoderByPtr? s_decoderByPtr;
            private static readonly decoderByVal? s_decoderByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public slice<decoder> decoder()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_decoderByPtr is null || !m_target_is_ptr)
                    return s_decoderByVal!(target);

                return s_decoderByPtr(m_target_ptr!);
            }

            private delegate slice<decoder> encodeByPtr(ptr<T> value, ptr<buffer> _p0);
            private delegate slice<decoder> encodeByVal(T value, ptr<buffer> _p0);

            private static readonly encodeByPtr? s_encodeByPtr;
            private static readonly encodeByVal? s_encodeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public slice<decoder> encode(ptr<buffer> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_encodeByPtr is null || !m_target_is_ptr)
                    return s_encodeByVal!(target, _p0);

                return s_encodeByPtr(m_target_ptr!, _p0);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static message()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("decoder");

                if (extensionMethod is not null)
                    s_decoderByPtr = extensionMethod.CreateStaticDelegate(typeof(decoderByPtr)) as decoderByPtr;

                extensionMethod = targetType.GetExtensionMethod("decoder");

                if (extensionMethod is not null)
                    s_decoderByVal = extensionMethod.CreateStaticDelegate(typeof(decoderByVal)) as decoderByVal;

                if (s_decoderByPtr is null && s_decoderByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement message.decoder method", new Exception("decoder"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("encode");

                if (extensionMethod is not null)
                    s_encodeByPtr = extensionMethod.CreateStaticDelegate(typeof(encodeByPtr)) as encodeByPtr;

                extensionMethod = targetType.GetExtensionMethod("encode");

                if (extensionMethod is not null)
                    s_encodeByVal = extensionMethod.CreateStaticDelegate(typeof(encodeByVal)) as encodeByVal;

                if (s_encodeByPtr is null && s_encodeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement message.encode method", new Exception("encode"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator message<T>(in ptr<T> target_ptr) => new message<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator message<T>(in T target) => new message<T>(target);

            // Enable comparisons between nil and message<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(message<T> value, NilType nil) => Activator.CreateInstance<message<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(message<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, message<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, message<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class profile_messageExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.@internal.profile_package.message target)
        {
            try
            {
                return ((go.@internal.profile_package.message<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.@internal.profile_package.message target, out T result)
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
        public static object? _(this go.@internal.profile_package.message target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.@internal.profile_package.message<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.@internal.profile_package.message target, Type type, out object? result)
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