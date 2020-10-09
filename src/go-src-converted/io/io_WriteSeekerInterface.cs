//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class io_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface WriteSeeker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static WriteSeeker As<T>(in T target) => (WriteSeeker<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static WriteSeeker As<T>(ptr<T> target_ptr) => (WriteSeeker<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static WriteSeeker? As(object target) =>
                typeof(WriteSeeker<>).CreateInterfaceHandler<WriteSeeker>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class WriteSeeker<T> : WriteSeeker
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

            public WriteSeeker(in T target) => m_target = target;

            public WriteSeeker(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
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

            private delegate (long, error) SeekByPtr(ptr<T> value, long offset, long whence);
            private delegate (long, error) SeekByVal(T value, long offset, long whence);

            private static readonly SeekByPtr? s_SeekByPtr;
            private static readonly SeekByVal? s_SeekByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Seek(long offset, long whence)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_SeekByPtr is null || !m_target_is_ptr)
                    return s_SeekByVal!(target, offset, whence);

                return s_SeekByPtr(m_target_ptr, offset, whence);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static WriteSeeker()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Write");

                if (!(extensionMethod is null))
                    s_WriteByPtr = extensionMethod.CreateStaticDelegate(typeof(WriteByPtr)) as WriteByPtr;

                extensionMethod = targetType.GetExtensionMethod("Write");

                if (!(extensionMethod is null))
                    s_WriteByVal = extensionMethod.CreateStaticDelegate(typeof(WriteByVal)) as WriteByVal;

                if (s_WriteByPtr is null && s_WriteByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement WriteSeeker.Write method", new Exception("Write"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Seek");

                if (!(extensionMethod is null))
                    s_SeekByPtr = extensionMethod.CreateStaticDelegate(typeof(SeekByPtr)) as SeekByPtr;

                extensionMethod = targetType.GetExtensionMethod("Seek");

                if (!(extensionMethod is null))
                    s_SeekByVal = extensionMethod.CreateStaticDelegate(typeof(SeekByVal)) as SeekByVal;

                if (s_SeekByPtr is null && s_SeekByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement WriteSeeker.Seek method", new Exception("Seek"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator WriteSeeker<T>(in ptr<T> target_ptr) => new WriteSeeker<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator WriteSeeker<T>(in T target) => new WriteSeeker<T>(target);

            // Enable comparisons between nil and WriteSeeker<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(WriteSeeker<T> value, NilType nil) => Activator.CreateInstance<WriteSeeker<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(WriteSeeker<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, WriteSeeker<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, WriteSeeker<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class io_WriteSeekerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.io_package.WriteSeeker target)
        {
            try
            {
                return ((go.io_package.WriteSeeker<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.io_package.WriteSeeker target, out T result)
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
        public static object? _(this go.io_package.WriteSeeker target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.io_package.WriteSeeker<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.io_package.WriteSeeker target, Type type, out object? result)
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