//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using crypto = go.crypto_package;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using des = go.crypto.des_package;
using hmac = go.crypto.hmac_package;
using rc4 = go.crypto.rc4_package;
using sha1 = go.crypto.sha1_package;
using sha256 = go.crypto.sha256_package;
using fmt = go.fmt_package;
using hash = go.hash_package;
using cpu = go.@internal.cpu_package;
using runtime = go.runtime_package;
using chacha20poly1305 = go.golang.org.x.crypto.chacha20poly1305_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface constantTimeHash
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static constantTimeHash As<T>(in T target) => (constantTimeHash<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static constantTimeHash As<T>(ptr<T> target_ptr) => (constantTimeHash<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static constantTimeHash? As(object target) =>
                typeof(constantTimeHash<>).CreateInterfaceHandler<constantTimeHash>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class constantTimeHash<T> : constantTimeHash
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

            public constantTimeHash(in T target) => m_target = target;

            public constantTimeHash(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate slice<byte> ConstantTimeSumByPtr(ptr<T> value, slice<byte> b);
            private delegate slice<byte> ConstantTimeSumByVal(T value, slice<byte> b);

            private static readonly ConstantTimeSumByPtr? s_ConstantTimeSumByPtr;
            private static readonly ConstantTimeSumByVal? s_ConstantTimeSumByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public slice<byte> ConstantTimeSum(slice<byte> b)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_ConstantTimeSumByPtr is null || !m_target_is_ptr)
                    return s_ConstantTimeSumByVal!(target, b);

                return s_ConstantTimeSumByPtr(m_target_ptr!, b);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static constantTimeHash()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ConstantTimeSum");

                if (extensionMethod is not null)
                    s_ConstantTimeSumByPtr = extensionMethod.CreateStaticDelegate(typeof(ConstantTimeSumByPtr)) as ConstantTimeSumByPtr;

                extensionMethod = targetType.GetExtensionMethod("ConstantTimeSum");

                if (extensionMethod is not null)
                    s_ConstantTimeSumByVal = extensionMethod.CreateStaticDelegate(typeof(ConstantTimeSumByVal)) as ConstantTimeSumByVal;

                if (s_ConstantTimeSumByPtr is null && s_ConstantTimeSumByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement constantTimeHash.ConstantTimeSum method", new Exception("ConstantTimeSum"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator constantTimeHash<T>(in ptr<T> target_ptr) => new constantTimeHash<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator constantTimeHash<T>(in T target) => new constantTimeHash<T>(target);

            // Enable comparisons between nil and constantTimeHash<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(constantTimeHash<T> value, NilType nil) => Activator.CreateInstance<constantTimeHash<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(constantTimeHash<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, constantTimeHash<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, constantTimeHash<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class tls_constantTimeHashExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.tls_package.constantTimeHash target)
        {
            try
            {
                return ((go.crypto.tls_package.constantTimeHash<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.tls_package.constantTimeHash target, out T result)
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
        public static object? _(this go.crypto.tls_package.constantTimeHash target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.tls_package.constantTimeHash<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.crypto.tls_package.constantTimeHash target, Type type, out object? result)
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