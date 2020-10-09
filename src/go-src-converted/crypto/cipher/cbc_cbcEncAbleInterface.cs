//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:52:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using subtle = go.crypto.@internal.subtle_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface cbcEncAble
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static cbcEncAble As<T>(in T target) => (cbcEncAble<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static cbcEncAble As<T>(ptr<T> target_ptr) => (cbcEncAble<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static cbcEncAble? As(object target) =>
                typeof(cbcEncAble<>).CreateInterfaceHandler<cbcEncAble>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class cbcEncAble<T> : cbcEncAble
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public cbcEncAble(in T target) => m_target = target;

            public cbcEncAble(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate BlockMode NewCBCEncrypterByPtr(ptr<T> value, slice<byte> iv);
            private delegate BlockMode NewCBCEncrypterByVal(T value, slice<byte> iv);

            private static readonly NewCBCEncrypterByPtr? s_NewCBCEncrypterByPtr;
            private static readonly NewCBCEncrypterByVal? s_NewCBCEncrypterByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public BlockMode NewCBCEncrypter(slice<byte> iv)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_NewCBCEncrypterByPtr is null || !m_target_is_ptr)
                    return s_NewCBCEncrypterByVal!(target, iv);

                return s_NewCBCEncrypterByPtr(m_target_ptr, iv);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static cbcEncAble()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("NewCBCEncrypter");

                if (!(extensionMethod is null))
                    s_NewCBCEncrypterByPtr = extensionMethod.CreateStaticDelegate(typeof(NewCBCEncrypterByPtr)) as NewCBCEncrypterByPtr;

                extensionMethod = targetType.GetExtensionMethod("NewCBCEncrypter");

                if (!(extensionMethod is null))
                    s_NewCBCEncrypterByVal = extensionMethod.CreateStaticDelegate(typeof(NewCBCEncrypterByVal)) as NewCBCEncrypterByVal;

                if (s_NewCBCEncrypterByPtr is null && s_NewCBCEncrypterByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement cbcEncAble.NewCBCEncrypter method", new Exception("NewCBCEncrypter"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator cbcEncAble<T>(in ptr<T> target_ptr) => new cbcEncAble<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator cbcEncAble<T>(in T target) => new cbcEncAble<T>(target);

            // Enable comparisons between nil and cbcEncAble<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cbcEncAble<T> value, NilType nil) => Activator.CreateInstance<cbcEncAble<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cbcEncAble<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cbcEncAble<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cbcEncAble<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class cipher_cbcEncAbleExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.cipher_package.cbcEncAble target)
        {
            try
            {
                return ((go.crypto.cipher_package.cbcEncAble<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.cipher_package.cbcEncAble target, out T result)
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
        public static object? _(this go.crypto.cipher_package.cbcEncAble target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.cipher_package.cbcEncAble<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.crypto.cipher_package.cbcEncAble target, Type type, out object? result)
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