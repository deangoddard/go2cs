//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:24:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface innerPrinter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static innerPrinter As<T>(in T target) => (innerPrinter<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static innerPrinter As<T>(ptr<T> target_ptr) => (innerPrinter<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static innerPrinter? As(object target) =>
                typeof(innerPrinter<>).CreateInterfaceHandler<innerPrinter>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class innerPrinter<T> : innerPrinter
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

            public innerPrinter(in T target) => m_target = target;

            public innerPrinter(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void printInnerByPtr(ptr<T> value, ptr<printState> _p0);
            private delegate void printInnerByVal(T value, ptr<printState> _p0);

            private static readonly printInnerByPtr? s_printInnerByPtr;
            private static readonly printInnerByVal? s_printInnerByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void printInner(ptr<printState> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_printInnerByPtr is null || !m_target_is_ptr)
                {
                    s_printInnerByVal!(target, _p0);
                    return;
                }

                s_printInnerByPtr(m_target_ptr!, _p0);
                return;
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static innerPrinter()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("printInner");

                if (extensionMethod is not null)
                    s_printInnerByPtr = extensionMethod.CreateStaticDelegate(typeof(printInnerByPtr)) as printInnerByPtr;

                extensionMethod = targetType.GetExtensionMethod("printInner");

                if (extensionMethod is not null)
                    s_printInnerByVal = extensionMethod.CreateStaticDelegate(typeof(printInnerByVal)) as printInnerByVal;

                if (s_printInnerByPtr is null && s_printInnerByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement innerPrinter.printInner method", new Exception("printInner"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator innerPrinter<T>(in ptr<T> target_ptr) => new innerPrinter<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator innerPrinter<T>(in T target) => new innerPrinter<T>(target);

            // Enable comparisons between nil and innerPrinter<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(innerPrinter<T> value, NilType nil) => Activator.CreateInstance<innerPrinter<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(innerPrinter<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, innerPrinter<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, innerPrinter<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class demangle_innerPrinterExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.innerPrinter target)
        {
            try
            {
                return ((go.cmd.vendor.github.com.ianlancetaylor.demangle_package.innerPrinter<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.innerPrinter target, out T result)
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
        public static object? _(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.innerPrinter target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.github.com.ianlancetaylor.demangle_package.innerPrinter<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.innerPrinter target, Type type, out object? result)
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