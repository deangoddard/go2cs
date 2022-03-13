//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using list = go.container.list_package;
using context = go.context_package;
using crypto = go.crypto_package;
using ecdsa = go.crypto.ecdsa_package;
using ed25519 = go.crypto.ed25519_package;
using elliptic = go.crypto.elliptic_package;
using rand = go.crypto.rand_package;
using rsa = go.crypto.rsa_package;
using sha512 = go.crypto.sha512_package;
using x509 = go.crypto.x509_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using net = go.net_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface handshakeMessage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static handshakeMessage As<T>(in T target) => (handshakeMessage<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static handshakeMessage As<T>(ptr<T> target_ptr) => (handshakeMessage<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static handshakeMessage? As(object target) =>
                typeof(handshakeMessage<>).CreateInterfaceHandler<handshakeMessage>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class handshakeMessage<T> : handshakeMessage
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

            public handshakeMessage(in T target) => m_target = target;

            public handshakeMessage(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate bool marshalByPtr(ptr<T> value);
            private delegate bool marshalByVal(T value);

            private static readonly marshalByPtr? s_marshalByPtr;
            private static readonly marshalByVal? s_marshalByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool marshal()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_marshalByPtr is null || !m_target_is_ptr)
                    return s_marshalByVal!(target);

                return s_marshalByPtr(m_target_ptr!);
            }

            private delegate bool unmarshalByPtr(ptr<T> value, slice<byte> _p0);
            private delegate bool unmarshalByVal(T value, slice<byte> _p0);

            private static readonly unmarshalByPtr? s_unmarshalByPtr;
            private static readonly unmarshalByVal? s_unmarshalByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool unmarshal(slice<byte> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_unmarshalByPtr is null || !m_target_is_ptr)
                    return s_unmarshalByVal!(target, _p0);

                return s_unmarshalByPtr(m_target_ptr!, _p0);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static handshakeMessage()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("marshal");

                if (extensionMethod is not null)
                    s_marshalByPtr = extensionMethod.CreateStaticDelegate(typeof(marshalByPtr)) as marshalByPtr;

                extensionMethod = targetType.GetExtensionMethod("marshal");

                if (extensionMethod is not null)
                    s_marshalByVal = extensionMethod.CreateStaticDelegate(typeof(marshalByVal)) as marshalByVal;

                if (s_marshalByPtr is null && s_marshalByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement handshakeMessage.marshal method", new Exception("marshal"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("unmarshal");

                if (extensionMethod is not null)
                    s_unmarshalByPtr = extensionMethod.CreateStaticDelegate(typeof(unmarshalByPtr)) as unmarshalByPtr;

                extensionMethod = targetType.GetExtensionMethod("unmarshal");

                if (extensionMethod is not null)
                    s_unmarshalByVal = extensionMethod.CreateStaticDelegate(typeof(unmarshalByVal)) as unmarshalByVal;

                if (s_unmarshalByPtr is null && s_unmarshalByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement handshakeMessage.unmarshal method", new Exception("unmarshal"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator handshakeMessage<T>(in ptr<T> target_ptr) => new handshakeMessage<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator handshakeMessage<T>(in T target) => new handshakeMessage<T>(target);

            // Enable comparisons between nil and handshakeMessage<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(handshakeMessage<T> value, NilType nil) => Activator.CreateInstance<handshakeMessage<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(handshakeMessage<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, handshakeMessage<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, handshakeMessage<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class tls_handshakeMessageExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.tls_package.handshakeMessage target)
        {
            try
            {
                return ((go.crypto.tls_package.handshakeMessage<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.tls_package.handshakeMessage target, out T result)
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
        public static object? _(this go.crypto.tls_package.handshakeMessage target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.tls_package.handshakeMessage<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.crypto.tls_package.handshakeMessage target, Type type, out object? result)
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