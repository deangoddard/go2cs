//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:44:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using zlib = go.compress.zlib_package;
using binary = go.encoding.binary_package;
using crc32 = go.hash.crc32_package;
using image = go.image_package;
using color = go.image.color_package;
using io = go.io_package;
using strconv = go.strconv_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace image
{
    public static partial class png_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface EncoderBufferPool
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static EncoderBufferPool As<T>(in T target) => (EncoderBufferPool<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static EncoderBufferPool As<T>(ptr<T> target_ptr) => (EncoderBufferPool<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static EncoderBufferPool? As(object target) =>
                typeof(EncoderBufferPool<>).CreateInterfaceHandler<EncoderBufferPool>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class EncoderBufferPool<T> : EncoderBufferPool
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

            public EncoderBufferPool(in T target) => m_target = target;

            public EncoderBufferPool(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate ptr<EncoderBuffer> GetByPtr(ptr<T> value);
            private delegate ptr<EncoderBuffer> GetByVal(T value);

            private static readonly GetByPtr? s_GetByPtr;
            private static readonly GetByVal? s_GetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<EncoderBuffer> Get()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_GetByPtr is null || !m_target_is_ptr)
                    return s_GetByVal!(target);

                return s_GetByPtr(m_target_ptr!);
            }

            private delegate ptr<EncoderBuffer> PutByPtr(ptr<T> value, ptr<EncoderBuffer> _p0);
            private delegate ptr<EncoderBuffer> PutByVal(T value, ptr<EncoderBuffer> _p0);

            private static readonly PutByPtr? s_PutByPtr;
            private static readonly PutByVal? s_PutByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<EncoderBuffer> Put(ptr<EncoderBuffer> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_PutByPtr is null || !m_target_is_ptr)
                    return s_PutByVal!(target, _p0);

                return s_PutByPtr(m_target_ptr!, _p0);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static EncoderBufferPool()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Get");

                if (extensionMethod is not null)
                    s_GetByPtr = extensionMethod.CreateStaticDelegate(typeof(GetByPtr)) as GetByPtr;

                extensionMethod = targetType.GetExtensionMethod("Get");

                if (extensionMethod is not null)
                    s_GetByVal = extensionMethod.CreateStaticDelegate(typeof(GetByVal)) as GetByVal;

                if (s_GetByPtr is null && s_GetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement EncoderBufferPool.Get method", new Exception("Get"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Put");

                if (extensionMethod is not null)
                    s_PutByPtr = extensionMethod.CreateStaticDelegate(typeof(PutByPtr)) as PutByPtr;

                extensionMethod = targetType.GetExtensionMethod("Put");

                if (extensionMethod is not null)
                    s_PutByVal = extensionMethod.CreateStaticDelegate(typeof(PutByVal)) as PutByVal;

                if (s_PutByPtr is null && s_PutByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement EncoderBufferPool.Put method", new Exception("Put"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator EncoderBufferPool<T>(in ptr<T> target_ptr) => new EncoderBufferPool<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator EncoderBufferPool<T>(in T target) => new EncoderBufferPool<T>(target);

            // Enable comparisons between nil and EncoderBufferPool<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EncoderBufferPool<T> value, NilType nil) => Activator.CreateInstance<EncoderBufferPool<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EncoderBufferPool<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EncoderBufferPool<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EncoderBufferPool<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class png_EncoderBufferPoolExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.image.png_package.EncoderBufferPool target)
        {
            try
            {
                return ((go.image.png_package.EncoderBufferPool<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.image.png_package.EncoderBufferPool target, out T result)
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
        public static object? _(this go.image.png_package.EncoderBufferPool target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.image.png_package.EncoderBufferPool<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.image.png_package.EncoderBufferPool target, Type type, out object? result)
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