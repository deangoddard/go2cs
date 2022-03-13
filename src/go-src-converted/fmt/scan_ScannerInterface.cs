//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:42:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using os = go.os_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class fmt_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Scanner
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Scanner As<T>(in T target) => (Scanner<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Scanner As<T>(ptr<T> target_ptr) => (Scanner<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Scanner? As(object target) =>
                typeof(Scanner<>).CreateInterfaceHandler<Scanner>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Scanner<T> : Scanner
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

            public Scanner(in T target) => m_target = target;

            public Scanner(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error ScanByPtr(ptr<T> value, ScanState state, int verb);
            private delegate error ScanByVal(T value, ScanState state, int verb);

            private static readonly ScanByPtr? s_ScanByPtr;
            private static readonly ScanByVal? s_ScanByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Scan(ScanState state, int verb)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_ScanByPtr is null || !m_target_is_ptr)
                    return s_ScanByVal!(target, state, verb);

                return s_ScanByPtr(m_target_ptr!, state, verb);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Scanner()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Scan");

                if (extensionMethod is not null)
                    s_ScanByPtr = extensionMethod.CreateStaticDelegate(typeof(ScanByPtr)) as ScanByPtr;

                extensionMethod = targetType.GetExtensionMethod("Scan");

                if (extensionMethod is not null)
                    s_ScanByVal = extensionMethod.CreateStaticDelegate(typeof(ScanByVal)) as ScanByVal;

                if (s_ScanByPtr is null && s_ScanByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Scanner.Scan method", new Exception("Scan"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Scanner<T>(in ptr<T> target_ptr) => new Scanner<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Scanner<T>(in T target) => new Scanner<T>(target);

            // Enable comparisons between nil and Scanner<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Scanner<T> value, NilType nil) => Activator.CreateInstance<Scanner<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Scanner<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Scanner<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Scanner<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class fmt_ScannerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.fmt_package.Scanner target)
        {
            try
            {
                return ((go.fmt_package.Scanner<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.fmt_package.Scanner target, out T result)
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
        public static object? _(this go.fmt_package.Scanner target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.fmt_package.Scanner<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.fmt_package.Scanner target, Type type, out object? result)
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