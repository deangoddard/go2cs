//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:07:57 UTC
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
using errors = go.errors_package;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text
{
    public static partial class transform_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface SpanningTransformer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static SpanningTransformer As<T>(in T target) => (SpanningTransformer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static SpanningTransformer As<T>(ptr<T> target_ptr) => (SpanningTransformer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static SpanningTransformer? As(object target) =>
                typeof(SpanningTransformer<>).CreateInterfaceHandler<SpanningTransformer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class SpanningTransformer<T> : SpanningTransformer
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

            public SpanningTransformer(in T target) => m_target = target;

            public SpanningTransformer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (long, error) SpanByPtr(ptr<T> value, slice<byte> src, bool atEOF);
            private delegate (long, error) SpanByVal(T value, slice<byte> src, bool atEOF);

            private static readonly SpanByPtr? s_SpanByPtr;
            private static readonly SpanByVal? s_SpanByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Span(slice<byte> src, bool atEOF)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_SpanByPtr is null || !m_target_is_ptr)
                    return s_SpanByVal!(target, src, atEOF);

                return s_SpanByPtr(m_target_ptr, src, atEOF);
            }

            private delegate (long, long, error) TransformByPtr(ptr<T> value, slice<byte> dst, slice<byte> src, bool atEOF);
            private delegate (long, long, error) TransformByVal(T value, slice<byte> dst, slice<byte> src, bool atEOF);

            private static readonly TransformByPtr? s_TransformByPtr;
            private static readonly TransformByVal? s_TransformByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, long, error) Transform(slice<byte> dst, slice<byte> src, bool atEOF)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_TransformByPtr is null || !m_target_is_ptr)
                    return s_TransformByVal!(target, dst, src, atEOF);

                return s_TransformByPtr(m_target_ptr, dst, src, atEOF);
            }

            private delegate (long, long, error) ResetByPtr(ptr<T> value);
            private delegate (long, long, error) ResetByVal(T value);

            private static readonly ResetByPtr? s_ResetByPtr;
            private static readonly ResetByVal? s_ResetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, long, error) Reset()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ResetByPtr is null || !m_target_is_ptr)
                    return s_ResetByVal!(target);

                return s_ResetByPtr(m_target_ptr);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static SpanningTransformer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Span");

                if (!(extensionMethod is null))
                    s_SpanByPtr = extensionMethod.CreateStaticDelegate(typeof(SpanByPtr)) as SpanByPtr;

                extensionMethod = targetType.GetExtensionMethod("Span");

                if (!(extensionMethod is null))
                    s_SpanByVal = extensionMethod.CreateStaticDelegate(typeof(SpanByVal)) as SpanByVal;

                if (s_SpanByPtr is null && s_SpanByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement SpanningTransformer.Span method", new Exception("Span"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Transform");

                if (!(extensionMethod is null))
                    s_TransformByPtr = extensionMethod.CreateStaticDelegate(typeof(TransformByPtr)) as TransformByPtr;

                extensionMethod = targetType.GetExtensionMethod("Transform");

                if (!(extensionMethod is null))
                    s_TransformByVal = extensionMethod.CreateStaticDelegate(typeof(TransformByVal)) as TransformByVal;

                if (s_TransformByPtr is null && s_TransformByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement SpanningTransformer.Transform method", new Exception("Transform"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Reset");

                if (!(extensionMethod is null))
                    s_ResetByPtr = extensionMethod.CreateStaticDelegate(typeof(ResetByPtr)) as ResetByPtr;

                extensionMethod = targetType.GetExtensionMethod("Reset");

                if (!(extensionMethod is null))
                    s_ResetByVal = extensionMethod.CreateStaticDelegate(typeof(ResetByVal)) as ResetByVal;

                if (s_ResetByPtr is null && s_ResetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement SpanningTransformer.Reset method", new Exception("Reset"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator SpanningTransformer<T>(in ptr<T> target_ptr) => new SpanningTransformer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator SpanningTransformer<T>(in T target) => new SpanningTransformer<T>(target);

            // Enable comparisons between nil and SpanningTransformer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SpanningTransformer<T> value, NilType nil) => Activator.CreateInstance<SpanningTransformer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SpanningTransformer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SpanningTransformer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SpanningTransformer<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class transform_SpanningTransformerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.vendor.golang.org.x.text.transform_package.SpanningTransformer target)
        {
            try
            {
                return ((go.vendor.golang.org.x.text.transform_package.SpanningTransformer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.vendor.golang.org.x.text.transform_package.SpanningTransformer target, out T result)
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
        public static object? _(this go.vendor.golang.org.x.text.transform_package.SpanningTransformer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.vendor.golang.org.x.text.transform_package.SpanningTransformer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.vendor.golang.org.x.text.transform_package.SpanningTransformer target, Type type, out object? result)
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