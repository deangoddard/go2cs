//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:32:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Stream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Stream As<T>(in T target) => (Stream<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Stream As<T>(ptr<T> target_ptr) => (Stream<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Stream? As(object target) =>
                typeof(Stream<>).CreateInterfaceHandler<Stream>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Stream<T> : Stream
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

            public Stream(in T target) => m_target = target;

            public Stream(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void XORKeyStreamByPtr(ptr<T> value, slice<byte> dst, slice<byte> src);
            private delegate void XORKeyStreamByVal(T value, slice<byte> dst, slice<byte> src);

            private static readonly XORKeyStreamByPtr? s_XORKeyStreamByPtr;
            private static readonly XORKeyStreamByVal? s_XORKeyStreamByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void XORKeyStream(slice<byte> dst, slice<byte> src)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_XORKeyStreamByPtr is null || !m_target_is_ptr)
                {
                    s_XORKeyStreamByVal!(target, dst, src);
                    return;
                }

                s_XORKeyStreamByPtr(m_target_ptr!, dst, src);
                return;
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Stream()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("XORKeyStream");

                if (extensionMethod is not null)
                    s_XORKeyStreamByPtr = extensionMethod.CreateStaticDelegate(typeof(XORKeyStreamByPtr)) as XORKeyStreamByPtr;

                extensionMethod = targetType.GetExtensionMethod("XORKeyStream");

                if (extensionMethod is not null)
                    s_XORKeyStreamByVal = extensionMethod.CreateStaticDelegate(typeof(XORKeyStreamByVal)) as XORKeyStreamByVal;

                if (s_XORKeyStreamByPtr is null && s_XORKeyStreamByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Stream.XORKeyStream method", new Exception("XORKeyStream"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Stream<T>(in ptr<T> target_ptr) => new Stream<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Stream<T>(in T target) => new Stream<T>(target);

            // Enable comparisons between nil and Stream<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Stream<T> value, NilType nil) => Activator.CreateInstance<Stream<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Stream<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Stream<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Stream<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class cipher_StreamExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.cipher_package.Stream target)
        {
            try
            {
                return ((go.crypto.cipher_package.Stream<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.cipher_package.Stream target, out T result)
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
        public static object? _(this go.crypto.cipher_package.Stream target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.cipher_package.Stream<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.crypto.cipher_package.Stream target, Type type, out object? result)
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