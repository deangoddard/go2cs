//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:43 UTC
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
using http = go.net.http_package;
using regexp = go.regexp_package;
using time = go.time_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class plugin_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Writer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Writer As<T>(in T target) => (Writer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Writer As<T>(ptr<T> target_ptr) => (Writer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Writer? As(object target) =>
                typeof(Writer<>).CreateInterfaceHandler<Writer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Writer<T> : Writer
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

            public Writer(in T target) => m_target = target;

            public Writer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (io.WriteCloser, error) OpenByRef(ref T value, @string name);
            private delegate (io.WriteCloser, error) OpenByVal(T value, @string name);

            private static readonly OpenByRef s_OpenByRef;
            private static readonly OpenByVal s_OpenByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (io.WriteCloser, error) Open(@string name)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_OpenByRef is null)
                    return s_OpenByVal!(target, name);

                return s_OpenByRef(ref target, name);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Writer()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Open");

                if (!(extensionMethod is null))
                    s_OpenByRef = extensionMethod.CreateStaticDelegate(typeof(OpenByRef)) as OpenByRef;

                if (s_OpenByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Open");

                    if (!(extensionMethod is null))
                        s_OpenByVal = extensionMethod.CreateStaticDelegate(typeof(OpenByVal)) as OpenByVal;
                }

                if (s_OpenByRef is null && s_OpenByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Writer.Open method", new Exception("Open"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Writer<T>(in ptr<T> target_ptr) => new Writer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Writer<T>(in T target) => new Writer<T>(target);

            // Enable comparisons between nil and Writer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Writer<T> value, NilType nil) => Activator.CreateInstance<Writer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Writer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Writer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Writer<T> value) => value != nil;
        }
    }
}}}}}}}

namespace go
{
    public static class plugin_WriterExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.github.com.google.pprof.@internal.plugin_package.Writer target)
        {
            try
            {
                return ((go.cmd.vendor.github.com.google.pprof.@internal.plugin_package.Writer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.github.com.google.pprof.@internal.plugin_package.Writer target, out T result)
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
        public static object? _(this go.cmd.vendor.github.com.google.pprof.@internal.plugin_package.Writer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.github.com.google.pprof.@internal.plugin_package.Writer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.github.com.google.pprof.@internal.plugin_package.Writer target, Type type, out object? result)
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