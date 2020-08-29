//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:28:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using subtle = go.crypto.subtle_package;
using errors = go.errors_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface gcmAble
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static gcmAble As<T>(in T target) => (gcmAble<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static gcmAble As<T>(ptr<T> target_ptr) => (gcmAble<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static gcmAble? As(object target) =>
                typeof(gcmAble<>).CreateInterfaceHandler<gcmAble>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class gcmAble<T> : gcmAble
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

            public gcmAble(in T target) => m_target = target;

            public gcmAble(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (AEAD, error) NewGCMByRef(ref T value, long _p0);
            private delegate (AEAD, error) NewGCMByVal(T value, long _p0);

            private static readonly NewGCMByRef s_NewGCMByRef;
            private static readonly NewGCMByVal s_NewGCMByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (AEAD, error) NewGCM(long _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_NewGCMByRef is null)
                    return s_NewGCMByVal!(target, _p0);

                return s_NewGCMByRef(ref target, _p0);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static gcmAble()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("NewGCM");

                if (!(extensionMethod is null))
                    s_NewGCMByRef = extensionMethod.CreateStaticDelegate(typeof(NewGCMByRef)) as NewGCMByRef;

                if (s_NewGCMByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("NewGCM");

                    if (!(extensionMethod is null))
                        s_NewGCMByVal = extensionMethod.CreateStaticDelegate(typeof(NewGCMByVal)) as NewGCMByVal;
                }

                if (s_NewGCMByRef is null && s_NewGCMByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement gcmAble.NewGCM method", new Exception("NewGCM"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator gcmAble<T>(in ptr<T> target_ptr) => new gcmAble<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator gcmAble<T>(in T target) => new gcmAble<T>(target);

            // Enable comparisons between nil and gcmAble<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcmAble<T> value, NilType nil) => Activator.CreateInstance<gcmAble<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcmAble<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcmAble<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcmAble<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class cipher_gcmAbleExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.cipher_package.gcmAble target)
        {
            try
            {
                return ((go.crypto.cipher_package.gcmAble<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.cipher_package.gcmAble target, out T result)
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
        public static object? _(this go.crypto.cipher_package.gcmAble target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.cipher_package.gcmAble<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.crypto.cipher_package.gcmAble target, Type type, out object? result)
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