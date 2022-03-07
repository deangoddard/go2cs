//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using exec = go.os.exec_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal
{
    public static partial class testenv_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Testing
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Testing As<T>(in T target) => (Testing<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Testing As<T>(ptr<T> target_ptr) => (Testing<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Testing? As(object target) =>
                typeof(Testing<>).CreateInterfaceHandler<Testing>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Testing<T> : Testing
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

            public Testing(in T target) => m_target = target;

            public Testing(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void SkipfByPtr(ptr<T> value, @string format, params object[] args);
            private delegate void SkipfByVal(T value, @string format, params object[] args);

            private static readonly SkipfByPtr? s_SkipfByPtr;
            private static readonly SkipfByVal? s_SkipfByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Skipf(@string format, params object[] args)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SkipfByPtr is null || !m_target_is_ptr)
                {
                    s_SkipfByVal!(target, format, args);
                    return;
                }

                s_SkipfByPtr(m_target_ptr!, format, args);
                return;
            }

            private delegate void FatalfByPtr(ptr<T> value, @string format, params object[] args);
            private delegate void FatalfByVal(T value, @string format, params object[] args);

            private static readonly FatalfByPtr? s_FatalfByPtr;
            private static readonly FatalfByVal? s_FatalfByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Fatalf(@string format, params object[] args)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_FatalfByPtr is null || !m_target_is_ptr)
                {
                    s_FatalfByVal!(target, format, args);
                    return;
                }

                s_FatalfByPtr(m_target_ptr!, format, args);
                return;
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Testing()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Skipf");

                if (extensionMethod is not null)
                    s_SkipfByPtr = extensionMethod.CreateStaticDelegate(typeof(SkipfByPtr)) as SkipfByPtr;

                extensionMethod = targetType.GetExtensionMethod("Skipf");

                if (extensionMethod is not null)
                    s_SkipfByVal = extensionMethod.CreateStaticDelegate(typeof(SkipfByVal)) as SkipfByVal;

                if (s_SkipfByPtr is null && s_SkipfByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Testing.Skipf method", new Exception("Skipf"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Fatalf");

                if (extensionMethod is not null)
                    s_FatalfByPtr = extensionMethod.CreateStaticDelegate(typeof(FatalfByPtr)) as FatalfByPtr;

                extensionMethod = targetType.GetExtensionMethod("Fatalf");

                if (extensionMethod is not null)
                    s_FatalfByVal = extensionMethod.CreateStaticDelegate(typeof(FatalfByVal)) as FatalfByVal;

                if (s_FatalfByPtr is null && s_FatalfByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Testing.Fatalf method", new Exception("Fatalf"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Testing<T>(in ptr<T> target_ptr) => new Testing<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Testing<T>(in T target) => new Testing<T>(target);

            // Enable comparisons between nil and Testing<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Testing<T> value, NilType nil) => Activator.CreateInstance<Testing<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Testing<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Testing<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Testing<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class testenv_TestingExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.golang.org.x.tools.@internal.testenv_package.Testing target)
        {
            try
            {
                return ((go.golang.org.x.tools.@internal.testenv_package.Testing<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.golang.org.x.tools.@internal.testenv_package.Testing target, out T result)
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
        public static object? _(this go.golang.org.x.tools.@internal.testenv_package.Testing target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.golang.org.x.tools.@internal.testenv_package.Testing<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.golang.org.x.tools.@internal.testenv_package.Testing target, Type type, out object? result)
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