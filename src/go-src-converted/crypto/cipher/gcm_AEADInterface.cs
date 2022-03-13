//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:32:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using subtleoverlap = go.crypto.@internal.subtle_package;
using subtle = go.crypto.subtle_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface AEAD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static AEAD As<T>(in T target) => (AEAD<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static AEAD As<T>(ptr<T> target_ptr) => (AEAD<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static AEAD? As(object target) =>
                typeof(AEAD<>).CreateInterfaceHandler<AEAD>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class AEAD<T> : AEAD
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

            public AEAD(in T target) => m_target = target;

            public AEAD(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (slice<byte>, error) NonceSizeByPtr(ptr<T> value);
            private delegate (slice<byte>, error) NonceSizeByVal(T value);

            private static readonly NonceSizeByPtr? s_NonceSizeByPtr;
            private static readonly NonceSizeByVal? s_NonceSizeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) NonceSize()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_NonceSizeByPtr is null || !m_target_is_ptr)
                    return s_NonceSizeByVal!(target);

                return s_NonceSizeByPtr(m_target_ptr!);
            }

            private delegate (slice<byte>, error) OverheadByPtr(ptr<T> value);
            private delegate (slice<byte>, error) OverheadByVal(T value);

            private static readonly OverheadByPtr? s_OverheadByPtr;
            private static readonly OverheadByVal? s_OverheadByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Overhead()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_OverheadByPtr is null || !m_target_is_ptr)
                    return s_OverheadByVal!(target);

                return s_OverheadByPtr(m_target_ptr!);
            }

            private delegate (slice<byte>, error) SealByPtr(ptr<T> value, slice<byte> dst, slice<byte> nonce, slice<byte> plaintext, slice<byte> additionalData);
            private delegate (slice<byte>, error) SealByVal(T value, slice<byte> dst, slice<byte> nonce, slice<byte> plaintext, slice<byte> additionalData);

            private static readonly SealByPtr? s_SealByPtr;
            private static readonly SealByVal? s_SealByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Seal(slice<byte> dst, slice<byte> nonce, slice<byte> plaintext, slice<byte> additionalData)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SealByPtr is null || !m_target_is_ptr)
                    return s_SealByVal!(target, dst, nonce, plaintext, additionalData);

                return s_SealByPtr(m_target_ptr!, dst, nonce, plaintext, additionalData);
            }

            private delegate (slice<byte>, error) OpenByPtr(ptr<T> value, slice<byte> dst, slice<byte> nonce, slice<byte> ciphertext, slice<byte> additionalData);
            private delegate (slice<byte>, error) OpenByVal(T value, slice<byte> dst, slice<byte> nonce, slice<byte> ciphertext, slice<byte> additionalData);

            private static readonly OpenByPtr? s_OpenByPtr;
            private static readonly OpenByVal? s_OpenByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Open(slice<byte> dst, slice<byte> nonce, slice<byte> ciphertext, slice<byte> additionalData)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_OpenByPtr is null || !m_target_is_ptr)
                    return s_OpenByVal!(target, dst, nonce, ciphertext, additionalData);

                return s_OpenByPtr(m_target_ptr!, dst, nonce, ciphertext, additionalData);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static AEAD()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("NonceSize");

                if (extensionMethod is not null)
                    s_NonceSizeByPtr = extensionMethod.CreateStaticDelegate(typeof(NonceSizeByPtr)) as NonceSizeByPtr;

                extensionMethod = targetType.GetExtensionMethod("NonceSize");

                if (extensionMethod is not null)
                    s_NonceSizeByVal = extensionMethod.CreateStaticDelegate(typeof(NonceSizeByVal)) as NonceSizeByVal;

                if (s_NonceSizeByPtr is null && s_NonceSizeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AEAD.NonceSize method", new Exception("NonceSize"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Overhead");

                if (extensionMethod is not null)
                    s_OverheadByPtr = extensionMethod.CreateStaticDelegate(typeof(OverheadByPtr)) as OverheadByPtr;

                extensionMethod = targetType.GetExtensionMethod("Overhead");

                if (extensionMethod is not null)
                    s_OverheadByVal = extensionMethod.CreateStaticDelegate(typeof(OverheadByVal)) as OverheadByVal;

                if (s_OverheadByPtr is null && s_OverheadByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AEAD.Overhead method", new Exception("Overhead"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Seal");

                if (extensionMethod is not null)
                    s_SealByPtr = extensionMethod.CreateStaticDelegate(typeof(SealByPtr)) as SealByPtr;

                extensionMethod = targetType.GetExtensionMethod("Seal");

                if (extensionMethod is not null)
                    s_SealByVal = extensionMethod.CreateStaticDelegate(typeof(SealByVal)) as SealByVal;

                if (s_SealByPtr is null && s_SealByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AEAD.Seal method", new Exception("Seal"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Open");

                if (extensionMethod is not null)
                    s_OpenByPtr = extensionMethod.CreateStaticDelegate(typeof(OpenByPtr)) as OpenByPtr;

                extensionMethod = targetType.GetExtensionMethod("Open");

                if (extensionMethod is not null)
                    s_OpenByVal = extensionMethod.CreateStaticDelegate(typeof(OpenByVal)) as OpenByVal;

                if (s_OpenByPtr is null && s_OpenByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AEAD.Open method", new Exception("Open"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator AEAD<T>(in ptr<T> target_ptr) => new AEAD<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator AEAD<T>(in T target) => new AEAD<T>(target);

            // Enable comparisons between nil and AEAD<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AEAD<T> value, NilType nil) => Activator.CreateInstance<AEAD<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AEAD<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AEAD<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AEAD<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class cipher_AEADExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.cipher_package.AEAD target)
        {
            try
            {
                return ((go.crypto.cipher_package.AEAD<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.cipher_package.AEAD target, out T result)
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
        public static object? _(this go.crypto.cipher_package.AEAD target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.cipher_package.AEAD<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.crypto.cipher_package.AEAD target, Type type, out object? result)
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