//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:53 UTC
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

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class io_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface ReadSeeker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ReadSeeker As<T>(in T target) => (ReadSeeker<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ReadSeeker As<T>(ptr<T> target_ptr) => (ReadSeeker<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ReadSeeker? As(object target) =>
                typeof(ReadSeeker<>).CreateInterfaceHandler<ReadSeeker>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class ReadSeeker<T> : ReadSeeker
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

            public ReadSeeker(in T target) => m_target = target;

            public ReadSeeker(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
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

            private delegate (long, error) SeekByRef(ref T value, long offset, long whence);
            private delegate (long, error) SeekByVal(T value, long offset, long whence);

            private static readonly SeekByRef s_SeekByRef;
            private static readonly SeekByVal s_SeekByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Seek(long offset, long whence)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_SeekByRef is null)
                    return s_SeekByVal!(target, offset, whence);

                return s_SeekByRef(ref target, offset, whence);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static ReadSeeker()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

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
                    throw new NotImplementedException($"{targetType.FullName} does not implement ReadSeeker.Read method", new Exception("Read"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Seek");

                if (!(extensionMethod is null))
                    s_SeekByRef = extensionMethod.CreateStaticDelegate(typeof(SeekByRef)) as SeekByRef;

                if (s_SeekByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Seek");

                    if (!(extensionMethod is null))
                        s_SeekByVal = extensionMethod.CreateStaticDelegate(typeof(SeekByVal)) as SeekByVal;
                }

                if (s_SeekByRef is null && s_SeekByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ReadSeeker.Seek method", new Exception("Seek"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ReadSeeker<T>(in ptr<T> target_ptr) => new ReadSeeker<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ReadSeeker<T>(in T target) => new ReadSeeker<T>(target);

            // Enable comparisons between nil and ReadSeeker<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ReadSeeker<T> value, NilType nil) => Activator.CreateInstance<ReadSeeker<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ReadSeeker<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ReadSeeker<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ReadSeeker<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class io_ReadSeekerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.io_package.ReadSeeker target)
        {
            try
            {
                return ((go.io_package.ReadSeeker<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.io_package.ReadSeeker target, out T result)
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
        public static object? _(this go.io_package.ReadSeeker target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.io_package.ReadSeeker<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.io_package.ReadSeeker target, Type type, out object? result)
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