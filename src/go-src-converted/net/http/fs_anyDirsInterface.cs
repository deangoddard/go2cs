//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:21:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using fs = go.io.fs_package;
using mime = go.mime_package;
using multipart = go.mime.multipart_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface anyDirs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static anyDirs As<T>(in T target) => (anyDirs<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static anyDirs As<T>(ptr<T> target_ptr) => (anyDirs<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static anyDirs? As(object target) =>
                typeof(anyDirs<>).CreateInterfaceHandler<anyDirs>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class anyDirs<T> : anyDirs
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

            public anyDirs(in T target) => m_target = target;

            public anyDirs(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate bool lenByPtr(ptr<T> value);
            private delegate bool lenByVal(T value);

            private static readonly lenByPtr? s_lenByPtr;
            private static readonly lenByVal? s_lenByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool len()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_lenByPtr is null || !m_target_is_ptr)
                    return s_lenByVal!(target);

                return s_lenByPtr(m_target_ptr!);
            }

            private delegate bool nameByPtr(ptr<T> value, nint i);
            private delegate bool nameByVal(T value, nint i);

            private static readonly nameByPtr? s_nameByPtr;
            private static readonly nameByVal? s_nameByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool name(nint i)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_nameByPtr is null || !m_target_is_ptr)
                    return s_nameByVal!(target, i);

                return s_nameByPtr(m_target_ptr!, i);
            }

            private delegate bool isDirByPtr(ptr<T> value, nint i);
            private delegate bool isDirByVal(T value, nint i);

            private static readonly isDirByPtr? s_isDirByPtr;
            private static readonly isDirByVal? s_isDirByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool isDir(nint i)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_isDirByPtr is null || !m_target_is_ptr)
                    return s_isDirByVal!(target, i);

                return s_isDirByPtr(m_target_ptr!, i);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static anyDirs()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("len");

                if (extensionMethod is not null)
                    s_lenByPtr = extensionMethod.CreateStaticDelegate(typeof(lenByPtr)) as lenByPtr;

                extensionMethod = targetType.GetExtensionMethod("len");

                if (extensionMethod is not null)
                    s_lenByVal = extensionMethod.CreateStaticDelegate(typeof(lenByVal)) as lenByVal;

                if (s_lenByPtr is null && s_lenByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement anyDirs.len method", new Exception("len"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("name");

                if (extensionMethod is not null)
                    s_nameByPtr = extensionMethod.CreateStaticDelegate(typeof(nameByPtr)) as nameByPtr;

                extensionMethod = targetType.GetExtensionMethod("name");

                if (extensionMethod is not null)
                    s_nameByVal = extensionMethod.CreateStaticDelegate(typeof(nameByVal)) as nameByVal;

                if (s_nameByPtr is null && s_nameByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement anyDirs.name method", new Exception("name"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("isDir");

                if (extensionMethod is not null)
                    s_isDirByPtr = extensionMethod.CreateStaticDelegate(typeof(isDirByPtr)) as isDirByPtr;

                extensionMethod = targetType.GetExtensionMethod("isDir");

                if (extensionMethod is not null)
                    s_isDirByVal = extensionMethod.CreateStaticDelegate(typeof(isDirByVal)) as isDirByVal;

                if (s_isDirByPtr is null && s_isDirByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement anyDirs.isDir method", new Exception("isDir"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator anyDirs<T>(in ptr<T> target_ptr) => new anyDirs<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator anyDirs<T>(in T target) => new anyDirs<T>(target);

            // Enable comparisons between nil and anyDirs<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(anyDirs<T> value, NilType nil) => Activator.CreateInstance<anyDirs<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(anyDirs<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, anyDirs<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, anyDirs<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class http_anyDirsExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net.http_package.anyDirs target)
        {
            try
            {
                return ((go.net.http_package.anyDirs<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net.http_package.anyDirs target, out T result)
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
        public static object? _(this go.net.http_package.anyDirs target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net.http_package.anyDirs<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net.http_package.anyDirs target, Type type, out object? result)
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