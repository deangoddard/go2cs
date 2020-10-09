//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:44:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd
{
    public static partial class pkg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface ExportedInterface
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ExportedInterface As<T>(in T target) => (ExportedInterface<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ExportedInterface As<T>(ptr<T> target_ptr) => (ExportedInterface<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ExportedInterface? As(object target) =>
                typeof(ExportedInterface<>).CreateInterfaceHandler<ExportedInterface>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class ExportedInterface<T> : ExportedInterface
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

            public ExportedInterface(in T target) => m_target = target;

            public ExportedInterface(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void ExportedMethodByPtr(ptr<T> value);
            private delegate void ExportedMethodByVal(T value);

            private static readonly ExportedMethodByPtr? s_ExportedMethodByPtr;
            private static readonly ExportedMethodByVal? s_ExportedMethodByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void ExportedMethod()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ExportedMethodByPtr is null || !m_target_is_ptr)
                {
                    s_ExportedMethodByVal!(target);
                    return;
                }

                s_ExportedMethodByPtr(m_target_ptr);
                return;
                
            }

            private delegate void unexportedMethodByPtr(ptr<T> value);
            private delegate void unexportedMethodByVal(T value);

            private static readonly unexportedMethodByPtr? s_unexportedMethodByPtr;
            private static readonly unexportedMethodByVal? s_unexportedMethodByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void unexportedMethod()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_unexportedMethodByPtr is null || !m_target_is_ptr)
                {
                    s_unexportedMethodByVal!(target);
                    return;
                }

                s_unexportedMethodByPtr(m_target_ptr);
                return;
                
            }

            private delegate (long, error) ReadByPtr(ptr<T> value, slice<byte> p);
            private delegate (long, error) ReadByVal(T value, slice<byte> p);

            private static readonly ReadByPtr? s_ReadByPtr;
            private static readonly ReadByVal? s_ReadByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Read(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadByPtr is null || !m_target_is_ptr)
                    return s_ReadByVal!(target, p);

                return s_ReadByPtr(m_target_ptr, p);
            }

            private delegate @string ErrorByPtr(ptr<T> value);
            private delegate @string ErrorByVal(T value);

            private static readonly ErrorByPtr? s_ErrorByPtr;
            private static readonly ErrorByVal? s_ErrorByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Error()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ErrorByPtr is null || !m_target_is_ptr)
                    return s_ErrorByVal!(target);

                return s_ErrorByPtr(m_target_ptr);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static ExportedInterface()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ExportedMethod");

                if (!(extensionMethod is null))
                    s_ExportedMethodByPtr = extensionMethod.CreateStaticDelegate(typeof(ExportedMethodByPtr)) as ExportedMethodByPtr;

                extensionMethod = targetType.GetExtensionMethod("ExportedMethod");

                if (!(extensionMethod is null))
                    s_ExportedMethodByVal = extensionMethod.CreateStaticDelegate(typeof(ExportedMethodByVal)) as ExportedMethodByVal;

                if (s_ExportedMethodByPtr is null && s_ExportedMethodByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ExportedInterface.ExportedMethod method", new Exception("ExportedMethod"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("unexportedMethod");

                if (!(extensionMethod is null))
                    s_unexportedMethodByPtr = extensionMethod.CreateStaticDelegate(typeof(unexportedMethodByPtr)) as unexportedMethodByPtr;

                extensionMethod = targetType.GetExtensionMethod("unexportedMethod");

                if (!(extensionMethod is null))
                    s_unexportedMethodByVal = extensionMethod.CreateStaticDelegate(typeof(unexportedMethodByVal)) as unexportedMethodByVal;

                if (s_unexportedMethodByPtr is null && s_unexportedMethodByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ExportedInterface.unexportedMethod method", new Exception("unexportedMethod"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Read");

                if (!(extensionMethod is null))
                    s_ReadByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadByPtr)) as ReadByPtr;

                extensionMethod = targetType.GetExtensionMethod("Read");

                if (!(extensionMethod is null))
                    s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;

                if (s_ReadByPtr is null && s_ReadByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ExportedInterface.Read method", new Exception("Read"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Error");

                if (!(extensionMethod is null))
                    s_ErrorByPtr = extensionMethod.CreateStaticDelegate(typeof(ErrorByPtr)) as ErrorByPtr;

                extensionMethod = targetType.GetExtensionMethod("Error");

                if (!(extensionMethod is null))
                    s_ErrorByVal = extensionMethod.CreateStaticDelegate(typeof(ErrorByVal)) as ErrorByVal;

                if (s_ErrorByPtr is null && s_ErrorByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ExportedInterface.Error method", new Exception("Error"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ExportedInterface<T>(in ptr<T> target_ptr) => new ExportedInterface<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ExportedInterface<T>(in T target) => new ExportedInterface<T>(target);

            // Enable comparisons between nil and ExportedInterface<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ExportedInterface<T> value, NilType nil) => Activator.CreateInstance<ExportedInterface<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ExportedInterface<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ExportedInterface<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ExportedInterface<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class pkg_ExportedInterfaceExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.doc.pkg_package.ExportedInterface target)
        {
            try
            {
                return ((go.cmd.doc.pkg_package.ExportedInterface<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.doc.pkg_package.ExportedInterface target, out T result)
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
        public static object? _(this go.cmd.doc.pkg_package.ExportedInterface target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.doc.pkg_package.ExportedInterface<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.doc.pkg_package.ExportedInterface target, Type type, out object? result)
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