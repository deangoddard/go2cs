//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using sha256 = go.crypto.sha256_package;
using base64 = go.encoding.base64_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using ed25519 = go.golang.org.x.crypto.ed25519_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class note_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Signer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Signer As<T>(in T target) => (Signer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Signer As<T>(ptr<T> target_ptr) => (Signer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Signer? As(object target) =>
                typeof(Signer<>).CreateInterfaceHandler<Signer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Signer<T> : Signer
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

            public Signer(in T target) => m_target = target;

            public Signer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (slice<byte>, error) NameByPtr(ptr<T> value);
            private delegate (slice<byte>, error) NameByVal(T value);

            private static readonly NameByPtr? s_NameByPtr;
            private static readonly NameByVal? s_NameByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Name()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_NameByPtr is null || !m_target_is_ptr)
                    return s_NameByVal!(target);

                return s_NameByPtr(m_target_ptr!);
            }

            private delegate (slice<byte>, error) KeyHashByPtr(ptr<T> value);
            private delegate (slice<byte>, error) KeyHashByVal(T value);

            private static readonly KeyHashByPtr? s_KeyHashByPtr;
            private static readonly KeyHashByVal? s_KeyHashByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) KeyHash()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_KeyHashByPtr is null || !m_target_is_ptr)
                    return s_KeyHashByVal!(target);

                return s_KeyHashByPtr(m_target_ptr!);
            }

            private delegate (slice<byte>, error) SignByPtr(ptr<T> value, slice<byte> msg);
            private delegate (slice<byte>, error) SignByVal(T value, slice<byte> msg);

            private static readonly SignByPtr? s_SignByPtr;
            private static readonly SignByVal? s_SignByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Sign(slice<byte> msg)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SignByPtr is null || !m_target_is_ptr)
                    return s_SignByVal!(target, msg);

                return s_SignByPtr(m_target_ptr!, msg);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Signer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Name");

                if (extensionMethod is not null)
                    s_NameByPtr = extensionMethod.CreateStaticDelegate(typeof(NameByPtr)) as NameByPtr;

                extensionMethod = targetType.GetExtensionMethod("Name");

                if (extensionMethod is not null)
                    s_NameByVal = extensionMethod.CreateStaticDelegate(typeof(NameByVal)) as NameByVal;

                if (s_NameByPtr is null && s_NameByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Signer.Name method", new Exception("Name"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("KeyHash");

                if (extensionMethod is not null)
                    s_KeyHashByPtr = extensionMethod.CreateStaticDelegate(typeof(KeyHashByPtr)) as KeyHashByPtr;

                extensionMethod = targetType.GetExtensionMethod("KeyHash");

                if (extensionMethod is not null)
                    s_KeyHashByVal = extensionMethod.CreateStaticDelegate(typeof(KeyHashByVal)) as KeyHashByVal;

                if (s_KeyHashByPtr is null && s_KeyHashByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Signer.KeyHash method", new Exception("KeyHash"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Sign");

                if (extensionMethod is not null)
                    s_SignByPtr = extensionMethod.CreateStaticDelegate(typeof(SignByPtr)) as SignByPtr;

                extensionMethod = targetType.GetExtensionMethod("Sign");

                if (extensionMethod is not null)
                    s_SignByVal = extensionMethod.CreateStaticDelegate(typeof(SignByVal)) as SignByVal;

                if (s_SignByPtr is null && s_SignByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Signer.Sign method", new Exception("Sign"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Signer<T>(in ptr<T> target_ptr) => new Signer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Signer<T>(in T target) => new Signer<T>(target);

            // Enable comparisons between nil and Signer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Signer<T> value, NilType nil) => Activator.CreateInstance<Signer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Signer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Signer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Signer<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class note_SignerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.golang.org.x.mod.sumdb.note_package.Signer target)
        {
            try
            {
                return ((go.golang.org.x.mod.sumdb.note_package.Signer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.golang.org.x.mod.sumdb.note_package.Signer target, out T result)
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
        public static object? _(this go.golang.org.x.mod.sumdb.note_package.Signer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.golang.org.x.mod.sumdb.note_package.Signer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.golang.org.x.mod.sumdb.note_package.Signer target, Type type, out object? result)
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