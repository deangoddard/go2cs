//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:26:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface File
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static File As<T>(in T target) => (File<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static File As<T>(ptr<T> target_ptr) => (File<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static File? As(object target) =>
                typeof(File<>).CreateInterfaceHandler<File>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class File<T> : File
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

            public File(in T target) => m_target = target;

            public File(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (io.ReadCloser, error) PathByPtr(ptr<T> value);
            private delegate (io.ReadCloser, error) PathByVal(T value);

            private static readonly PathByPtr? s_PathByPtr;
            private static readonly PathByVal? s_PathByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (io.ReadCloser, error) Path()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_PathByPtr is null || !m_target_is_ptr)
                    return s_PathByVal!(target);

                return s_PathByPtr(m_target_ptr!);
            }

            private delegate (io.ReadCloser, error) LstatByPtr(ptr<T> value);
            private delegate (io.ReadCloser, error) LstatByVal(T value);

            private static readonly LstatByPtr? s_LstatByPtr;
            private static readonly LstatByVal? s_LstatByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (io.ReadCloser, error) Lstat()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_LstatByPtr is null || !m_target_is_ptr)
                    return s_LstatByVal!(target);

                return s_LstatByPtr(m_target_ptr!);
            }

            private delegate (io.ReadCloser, error) OpenByPtr(ptr<T> value);
            private delegate (io.ReadCloser, error) OpenByVal(T value);

            private static readonly OpenByPtr? s_OpenByPtr;
            private static readonly OpenByVal? s_OpenByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (io.ReadCloser, error) Open()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_OpenByPtr is null || !m_target_is_ptr)
                    return s_OpenByVal!(target);

                return s_OpenByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static File()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Path");

                if (extensionMethod is not null)
                    s_PathByPtr = extensionMethod.CreateStaticDelegate(typeof(PathByPtr)) as PathByPtr;

                extensionMethod = targetType.GetExtensionMethod("Path");

                if (extensionMethod is not null)
                    s_PathByVal = extensionMethod.CreateStaticDelegate(typeof(PathByVal)) as PathByVal;

                if (s_PathByPtr is null && s_PathByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Path method", new Exception("Path"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Lstat");

                if (extensionMethod is not null)
                    s_LstatByPtr = extensionMethod.CreateStaticDelegate(typeof(LstatByPtr)) as LstatByPtr;

                extensionMethod = targetType.GetExtensionMethod("Lstat");

                if (extensionMethod is not null)
                    s_LstatByVal = extensionMethod.CreateStaticDelegate(typeof(LstatByVal)) as LstatByVal;

                if (s_LstatByPtr is null && s_LstatByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Lstat method", new Exception("Lstat"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Open");

                if (extensionMethod is not null)
                    s_OpenByPtr = extensionMethod.CreateStaticDelegate(typeof(OpenByPtr)) as OpenByPtr;

                extensionMethod = targetType.GetExtensionMethod("Open");

                if (extensionMethod is not null)
                    s_OpenByVal = extensionMethod.CreateStaticDelegate(typeof(OpenByVal)) as OpenByVal;

                if (s_OpenByPtr is null && s_OpenByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Open method", new Exception("Open"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator File<T>(in ptr<T> target_ptr) => new File<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator File<T>(in T target) => new File<T>(target);

            // Enable comparisons between nil and File<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(File<T> value, NilType nil) => Activator.CreateInstance<File<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(File<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, File<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, File<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class zip_FileExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.golang.org.x.mod.zip_package.File target)
        {
            try
            {
                return ((go.cmd.vendor.golang.org.x.mod.zip_package.File<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.golang.org.x.mod.zip_package.File target, out T result)
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
        public static object? _(this go.cmd.vendor.golang.org.x.mod.zip_package.File target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.golang.org.x.mod.zip_package.File<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.golang.org.x.mod.zip_package.File target, Type type, out object? result)
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