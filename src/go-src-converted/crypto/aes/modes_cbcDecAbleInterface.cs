//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:32:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using cipher = go.crypto.cipher_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class aes_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface cbcDecAble
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static cbcDecAble As<T>(in T target) => (cbcDecAble<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static cbcDecAble As<T>(ptr<T> target_ptr) => (cbcDecAble<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static cbcDecAble? As(object target) =>
                typeof(cbcDecAble<>).CreateInterfaceHandler<cbcDecAble>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class cbcDecAble<T> : cbcDecAble
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

            public cbcDecAble(in T target) => m_target = target;

            public cbcDecAble(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate cipher.BlockMode NewCBCDecrypterByPtr(ptr<T> value, slice<byte> iv);
            private delegate cipher.BlockMode NewCBCDecrypterByVal(T value, slice<byte> iv);

            private static readonly NewCBCDecrypterByPtr? s_NewCBCDecrypterByPtr;
            private static readonly NewCBCDecrypterByVal? s_NewCBCDecrypterByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public cipher.BlockMode NewCBCDecrypter(slice<byte> iv)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_NewCBCDecrypterByPtr is null || !m_target_is_ptr)
                    return s_NewCBCDecrypterByVal!(target, iv);

                return s_NewCBCDecrypterByPtr(m_target_ptr!, iv);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static cbcDecAble()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("NewCBCDecrypter");

                if (extensionMethod is not null)
                    s_NewCBCDecrypterByPtr = extensionMethod.CreateStaticDelegate(typeof(NewCBCDecrypterByPtr)) as NewCBCDecrypterByPtr;

                extensionMethod = targetType.GetExtensionMethod("NewCBCDecrypter");

                if (extensionMethod is not null)
                    s_NewCBCDecrypterByVal = extensionMethod.CreateStaticDelegate(typeof(NewCBCDecrypterByVal)) as NewCBCDecrypterByVal;

                if (s_NewCBCDecrypterByPtr is null && s_NewCBCDecrypterByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement cbcDecAble.NewCBCDecrypter method", new Exception("NewCBCDecrypter"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator cbcDecAble<T>(in ptr<T> target_ptr) => new cbcDecAble<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator cbcDecAble<T>(in T target) => new cbcDecAble<T>(target);

            // Enable comparisons between nil and cbcDecAble<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cbcDecAble<T> value, NilType nil) => Activator.CreateInstance<cbcDecAble<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cbcDecAble<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cbcDecAble<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cbcDecAble<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class aes_cbcDecAbleExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.aes_package.cbcDecAble target)
        {
            try
            {
                return ((go.crypto.aes_package.cbcDecAble<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.aes_package.cbcDecAble target, out T result)
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
        public static object? _(this go.crypto.aes_package.cbcDecAble target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.aes_package.cbcDecAble<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.crypto.aes_package.cbcDecAble target, Type type, out object? result)
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