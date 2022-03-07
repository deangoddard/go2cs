//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:32:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using flate = go.compress.flate_package;
using errors = go.errors_package;
using hash = go.hash_package;
using adler32 = go.hash.adler32_package;
using io = go.io_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace compress
{
    public static partial class zlib_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Resetter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Resetter As<T>(in T target) => (Resetter<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Resetter As<T>(ptr<T> target_ptr) => (Resetter<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Resetter? As(object target) =>
                typeof(Resetter<>).CreateInterfaceHandler<Resetter>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Resetter<T> : Resetter
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

            public Resetter(in T target) => m_target = target;

            public Resetter(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error ResetByPtr(ptr<T> value, io.Reader r, slice<byte> dict);
            private delegate error ResetByVal(T value, io.Reader r, slice<byte> dict);

            private static readonly ResetByPtr? s_ResetByPtr;
            private static readonly ResetByVal? s_ResetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Reset(io.Reader r, slice<byte> dict)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_ResetByPtr is null || !m_target_is_ptr)
                    return s_ResetByVal!(target, r, dict);

                return s_ResetByPtr(m_target_ptr!, r, dict);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Resetter()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Reset");

                if (extensionMethod is not null)
                    s_ResetByPtr = extensionMethod.CreateStaticDelegate(typeof(ResetByPtr)) as ResetByPtr;

                extensionMethod = targetType.GetExtensionMethod("Reset");

                if (extensionMethod is not null)
                    s_ResetByVal = extensionMethod.CreateStaticDelegate(typeof(ResetByVal)) as ResetByVal;

                if (s_ResetByPtr is null && s_ResetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Resetter.Reset method", new Exception("Reset"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Resetter<T>(in ptr<T> target_ptr) => new Resetter<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Resetter<T>(in T target) => new Resetter<T>(target);

            // Enable comparisons between nil and Resetter<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Resetter<T> value, NilType nil) => Activator.CreateInstance<Resetter<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Resetter<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Resetter<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Resetter<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class zlib_ResetterExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.compress.zlib_package.Resetter target)
        {
            try
            {
                return ((go.compress.zlib_package.Resetter<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.compress.zlib_package.Resetter target, out T result)
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
        public static object? _(this go.compress.zlib_package.Resetter target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.compress.zlib_package.Resetter<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.compress.zlib_package.Resetter target, Type type, out object? result)
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