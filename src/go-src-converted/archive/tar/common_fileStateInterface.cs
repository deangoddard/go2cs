//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:23:49 UTC
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
using fs = go.io.fs_package;
using math = go.math_package;
using path = go.path_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface fileState
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileState As<T>(in T target) => (fileState<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileState As<T>(ptr<T> target_ptr) => (fileState<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileState? As(object target) =>
                typeof(fileState<>).CreateInterfaceHandler<fileState>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class fileState<T> : fileState
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

            public fileState(in T target) => m_target = target;

            public fileState(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate long LogicalRemainingByPtr(ptr<T> value);
            private delegate long LogicalRemainingByVal(T value);

            private static readonly LogicalRemainingByPtr? s_LogicalRemainingByPtr;
            private static readonly LogicalRemainingByVal? s_LogicalRemainingByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long LogicalRemaining()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_LogicalRemainingByPtr is null || !m_target_is_ptr)
                    return s_LogicalRemainingByVal!(target);

                return s_LogicalRemainingByPtr(m_target_ptr!);
            }

            private delegate long PhysicalRemainingByPtr(ptr<T> value);
            private delegate long PhysicalRemainingByVal(T value);

            private static readonly PhysicalRemainingByPtr? s_PhysicalRemainingByPtr;
            private static readonly PhysicalRemainingByVal? s_PhysicalRemainingByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long PhysicalRemaining()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_PhysicalRemainingByPtr is null || !m_target_is_ptr)
                    return s_PhysicalRemainingByVal!(target);

                return s_PhysicalRemainingByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static fileState()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("LogicalRemaining");

                if (extensionMethod is not null)
                    s_LogicalRemainingByPtr = extensionMethod.CreateStaticDelegate(typeof(LogicalRemainingByPtr)) as LogicalRemainingByPtr;

                extensionMethod = targetType.GetExtensionMethod("LogicalRemaining");

                if (extensionMethod is not null)
                    s_LogicalRemainingByVal = extensionMethod.CreateStaticDelegate(typeof(LogicalRemainingByVal)) as LogicalRemainingByVal;

                if (s_LogicalRemainingByPtr is null && s_LogicalRemainingByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement fileState.LogicalRemaining method", new Exception("LogicalRemaining"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("PhysicalRemaining");

                if (extensionMethod is not null)
                    s_PhysicalRemainingByPtr = extensionMethod.CreateStaticDelegate(typeof(PhysicalRemainingByPtr)) as PhysicalRemainingByPtr;

                extensionMethod = targetType.GetExtensionMethod("PhysicalRemaining");

                if (extensionMethod is not null)
                    s_PhysicalRemainingByVal = extensionMethod.CreateStaticDelegate(typeof(PhysicalRemainingByVal)) as PhysicalRemainingByVal;

                if (s_PhysicalRemainingByPtr is null && s_PhysicalRemainingByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement fileState.PhysicalRemaining method", new Exception("PhysicalRemaining"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator fileState<T>(in ptr<T> target_ptr) => new fileState<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator fileState<T>(in T target) => new fileState<T>(target);

            // Enable comparisons between nil and fileState<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileState<T> value, NilType nil) => Activator.CreateInstance<fileState<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileState<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileState<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileState<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class tar_fileStateExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.archive.tar_package.fileState target)
        {
            try
            {
                return ((go.archive.tar_package.fileState<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.archive.tar_package.fileState target, out T result)
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
        public static object? _(this go.archive.tar_package.fileState target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.archive.tar_package.fileState<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.archive.tar_package.fileState target, Type type, out object? result)
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