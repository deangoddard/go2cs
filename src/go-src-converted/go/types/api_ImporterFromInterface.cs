//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:54 UTC
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
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface ImporterFrom
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ImporterFrom As<T>(in T target) => (ImporterFrom<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ImporterFrom As<T>(ptr<T> target_ptr) => (ImporterFrom<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ImporterFrom? As(object target) =>
                typeof(ImporterFrom<>).CreateInterfaceHandler<ImporterFrom>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class ImporterFrom<T> : ImporterFrom
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

            public ImporterFrom(in T target) => m_target = target;

            public ImporterFrom(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (ref Package, error) ImportFromByRef(ref T value, @string path, @string dir, ImportMode mode);
            private delegate (ref Package, error) ImportFromByVal(T value, @string path, @string dir, ImportMode mode);

            private static readonly ImportFromByRef s_ImportFromByRef;
            private static readonly ImportFromByVal s_ImportFromByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ref Package, error) ImportFrom(@string path, @string dir, ImportMode mode)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ImportFromByRef is null)
                    return s_ImportFromByVal!(target, path, dir, mode);

                return s_ImportFromByRef(ref target, path, dir, mode);
            }

            private delegate (ref Package, error) ImportByRef(ref T value, @string path);
            private delegate (ref Package, error) ImportByVal(T value, @string path);

            private static readonly ImportByRef s_ImportByRef;
            private static readonly ImportByVal s_ImportByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ref Package, error) Import(@string path)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ImportByRef is null)
                    return s_ImportByVal!(target, path);

                return s_ImportByRef(ref target, path);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static ImporterFrom()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("ImportFrom");

                if (!(extensionMethod is null))
                    s_ImportFromByRef = extensionMethod.CreateStaticDelegate(typeof(ImportFromByRef)) as ImportFromByRef;

                if (s_ImportFromByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ImportFrom");

                    if (!(extensionMethod is null))
                        s_ImportFromByVal = extensionMethod.CreateStaticDelegate(typeof(ImportFromByVal)) as ImportFromByVal;
                }

                if (s_ImportFromByRef is null && s_ImportFromByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ImporterFrom.ImportFrom method", new Exception("ImportFrom"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Import");

                if (!(extensionMethod is null))
                    s_ImportByRef = extensionMethod.CreateStaticDelegate(typeof(ImportByRef)) as ImportByRef;

                if (s_ImportByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Import");

                    if (!(extensionMethod is null))
                        s_ImportByVal = extensionMethod.CreateStaticDelegate(typeof(ImportByVal)) as ImportByVal;
                }

                if (s_ImportByRef is null && s_ImportByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ImporterFrom.Import method", new Exception("Import"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ImporterFrom<T>(in ptr<T> target_ptr) => new ImporterFrom<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ImporterFrom<T>(in T target) => new ImporterFrom<T>(target);

            // Enable comparisons between nil and ImporterFrom<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImporterFrom<T> value, NilType nil) => Activator.CreateInstance<ImporterFrom<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImporterFrom<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImporterFrom<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImporterFrom<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class types_ImporterFromExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.go.types_package.ImporterFrom target)
        {
            try
            {
                return ((go.go.types_package.ImporterFrom<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.go.types_package.ImporterFrom target, out T result)
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
        public static object? _(this go.go.types_package.ImporterFrom target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.go.types_package.ImporterFrom<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.go.types_package.ImporterFrom target, Type type, out object? result)
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