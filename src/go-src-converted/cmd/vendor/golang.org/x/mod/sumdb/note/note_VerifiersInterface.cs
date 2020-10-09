//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:56:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class note_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Verifiers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Verifiers As<T>(in T target) => (Verifiers<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Verifiers As<T>(ptr<T> target_ptr) => (Verifiers<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Verifiers? As(object target) =>
                typeof(Verifiers<>).CreateInterfaceHandler<Verifiers>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Verifiers<T> : Verifiers
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

            public Verifiers(in T target) => m_target = target;

            public Verifiers(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (Verifier, error) VerifierByPtr(ptr<T> value, @string name, uint hash);
            private delegate (Verifier, error) VerifierByVal(T value, @string name, uint hash);

            private static readonly VerifierByPtr? s_VerifierByPtr;
            private static readonly VerifierByVal? s_VerifierByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (Verifier, error) Verifier(@string name, uint hash)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_VerifierByPtr is null || !m_target_is_ptr)
                    return s_VerifierByVal!(target, name, hash);

                return s_VerifierByPtr(m_target_ptr, name, hash);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static Verifiers()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Verifier");

                if (!(extensionMethod is null))
                    s_VerifierByPtr = extensionMethod.CreateStaticDelegate(typeof(VerifierByPtr)) as VerifierByPtr;

                extensionMethod = targetType.GetExtensionMethod("Verifier");

                if (!(extensionMethod is null))
                    s_VerifierByVal = extensionMethod.CreateStaticDelegate(typeof(VerifierByVal)) as VerifierByVal;

                if (s_VerifierByPtr is null && s_VerifierByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Verifiers.Verifier method", new Exception("Verifier"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Verifiers<T>(in ptr<T> target_ptr) => new Verifiers<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Verifiers<T>(in T target) => new Verifiers<T>(target);

            // Enable comparisons between nil and Verifiers<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Verifiers<T> value, NilType nil) => Activator.CreateInstance<Verifiers<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Verifiers<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Verifiers<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Verifiers<T> value) => value != nil;
        }
    }
}}}}}}}

namespace go
{
    public static class note_VerifiersExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.golang.org.x.mod.sumdb.note_package.Verifiers target)
        {
            try
            {
                return ((go.cmd.vendor.golang.org.x.mod.sumdb.note_package.Verifiers<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.golang.org.x.mod.sumdb.note_package.Verifiers target, out T result)
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
        public static object? _(this go.cmd.vendor.golang.org.x.mod.sumdb.note_package.Verifiers target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.golang.org.x.mod.sumdb.note_package.Verifiers<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.golang.org.x.mod.sumdb.note_package.Verifiers target, Type type, out object? result)
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