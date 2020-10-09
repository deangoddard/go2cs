//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using errors = go.errors_package;
using image = go.image_package;
using color = go.image.color_package;
using io = go.io_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace image
{
    public static partial class jpeg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface writer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static writer As<T>(in T target) => (writer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static writer As<T>(ptr<T> target_ptr) => (writer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static writer? As(object target) =>
                typeof(writer<>).CreateInterfaceHandler<writer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class writer<T> : writer
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

            public writer(in T target) => m_target = target;

            public writer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error FlushByPtr(ptr<T> value);
            private delegate error FlushByVal(T value);

            private static readonly FlushByPtr? s_FlushByPtr;
            private static readonly FlushByVal? s_FlushByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Flush()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_FlushByPtr is null || !m_target_is_ptr)
                    return s_FlushByVal!(target);

                return s_FlushByPtr(m_target_ptr);
            }

            private delegate (long, error) WriteByPtr(ptr<T> value, slice<byte> p);
            private delegate (long, error) WriteByVal(T value, slice<byte> p);

            private static readonly WriteByPtr? s_WriteByPtr;
            private static readonly WriteByVal? s_WriteByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Write(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_WriteByPtr is null || !m_target_is_ptr)
                    return s_WriteByVal!(target, p);

                return s_WriteByPtr(m_target_ptr, p);
            }

            private delegate error WriteByteByPtr(ptr<T> value, byte c);
            private delegate error WriteByteByVal(T value, byte c);

            private static readonly WriteByteByPtr? s_WriteByteByPtr;
            private static readonly WriteByteByVal? s_WriteByteByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error WriteByte(byte c)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_WriteByteByPtr is null || !m_target_is_ptr)
                    return s_WriteByteByVal!(target, c);

                return s_WriteByteByPtr(m_target_ptr, c);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static writer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Flush");

                if (!(extensionMethod is null))
                    s_FlushByPtr = extensionMethod.CreateStaticDelegate(typeof(FlushByPtr)) as FlushByPtr;

                extensionMethod = targetType.GetExtensionMethod("Flush");

                if (!(extensionMethod is null))
                    s_FlushByVal = extensionMethod.CreateStaticDelegate(typeof(FlushByVal)) as FlushByVal;

                if (s_FlushByPtr is null && s_FlushByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement writer.Flush method", new Exception("Flush"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Write");

                if (!(extensionMethod is null))
                    s_WriteByPtr = extensionMethod.CreateStaticDelegate(typeof(WriteByPtr)) as WriteByPtr;

                extensionMethod = targetType.GetExtensionMethod("Write");

                if (!(extensionMethod is null))
                    s_WriteByVal = extensionMethod.CreateStaticDelegate(typeof(WriteByVal)) as WriteByVal;

                if (s_WriteByPtr is null && s_WriteByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement writer.Write method", new Exception("Write"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("WriteByte");

                if (!(extensionMethod is null))
                    s_WriteByteByPtr = extensionMethod.CreateStaticDelegate(typeof(WriteByteByPtr)) as WriteByteByPtr;

                extensionMethod = targetType.GetExtensionMethod("WriteByte");

                if (!(extensionMethod is null))
                    s_WriteByteByVal = extensionMethod.CreateStaticDelegate(typeof(WriteByteByVal)) as WriteByteByVal;

                if (s_WriteByteByPtr is null && s_WriteByteByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement writer.WriteByte method", new Exception("WriteByte"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator writer<T>(in ptr<T> target_ptr) => new writer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator writer<T>(in T target) => new writer<T>(target);

            // Enable comparisons between nil and writer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(writer<T> value, NilType nil) => Activator.CreateInstance<writer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(writer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, writer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, writer<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class jpeg_writerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.image.jpeg_package.writer target)
        {
            try
            {
                return ((go.image.jpeg_package.writer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.image.jpeg_package.writer target, out T result)
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
        public static object? _(this go.image.jpeg_package.writer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.image.jpeg_package.writer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.image.jpeg_package.writer target, Type type, out object? result)
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