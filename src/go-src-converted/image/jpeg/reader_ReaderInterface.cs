//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using image = go.image_package;
using color = go.image.color_package;
using imageutil = go.image.@internal.imageutil_package;
using io = go.io_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace image
{
    public static partial class jpeg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Reader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Reader As<T>(in T target) => (Reader<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Reader As<T>(ptr<T> target_ptr) => (Reader<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Reader? As(object target) =>
                typeof(Reader<>).CreateInterfaceHandler<Reader>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Reader<T> : Reader
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

            public Reader(in T target) => m_target = target;

            public Reader(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (byte, error) ReadByteByRef(ref T value);
            private delegate (byte, error) ReadByteByVal(T value);

            private static readonly ReadByteByRef s_ReadByteByRef;
            private static readonly ReadByteByVal s_ReadByteByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (byte, error) ReadByte()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadByteByRef is null)
                    return s_ReadByteByVal!(target);

                return s_ReadByteByRef(ref target);
            }

            private delegate (long, error) ReadByRef(ref T value, slice<byte> p);
            private delegate (long, error) ReadByVal(T value, slice<byte> p);

            private static readonly ReadByRef s_ReadByRef;
            private static readonly ReadByVal s_ReadByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Read(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadByRef is null)
                    return s_ReadByVal!(target, p);

                return s_ReadByRef(ref target, p);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Reader()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("ReadByte");

                if (!(extensionMethod is null))
                    s_ReadByteByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByteByRef)) as ReadByteByRef;

                if (s_ReadByteByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ReadByte");

                    if (!(extensionMethod is null))
                        s_ReadByteByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByteByVal)) as ReadByteByVal;
                }

                if (s_ReadByteByRef is null && s_ReadByteByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Reader.ReadByte method", new Exception("ReadByte"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Read");

                if (!(extensionMethod is null))
                    s_ReadByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByRef)) as ReadByRef;

                if (s_ReadByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Read");

                    if (!(extensionMethod is null))
                        s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;
                }

                if (s_ReadByRef is null && s_ReadByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Reader.Read method", new Exception("Read"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Reader<T>(in ptr<T> target_ptr) => new Reader<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Reader<T>(in T target) => new Reader<T>(target);

            // Enable comparisons between nil and Reader<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reader<T> value, NilType nil) => Activator.CreateInstance<Reader<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reader<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reader<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reader<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class jpeg_ReaderExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.image.jpeg_package.Reader target)
        {
            try
            {
                return ((go.image.jpeg_package.Reader<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.image.jpeg_package.Reader target, out T result)
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
        public static object? _(this go.image.jpeg_package.Reader target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.image.jpeg_package.Reader<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.image.jpeg_package.Reader target, Type type, out object? result)
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