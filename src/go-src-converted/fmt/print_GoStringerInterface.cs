//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:07:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmtsort = go.@internal.fmtsort_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class fmt_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface GoStringer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static GoStringer As<T>(in T target) => (GoStringer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static GoStringer As<T>(ptr<T> target_ptr) => (GoStringer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static GoStringer? As(object target) =>
                typeof(GoStringer<>).CreateInterfaceHandler<GoStringer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class GoStringer<T> : GoStringer
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

            public GoStringer(in T target) => m_target = target;

            public GoStringer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string GoStringByPtr(ptr<T> value);
            private delegate @string GoStringByVal(T value);

            private static readonly GoStringByPtr? s_GoStringByPtr;
            private static readonly GoStringByVal? s_GoStringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string GoString()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_GoStringByPtr is null || !m_target_is_ptr)
                    return s_GoStringByVal!(target);

                return s_GoStringByPtr(m_target_ptr);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static GoStringer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("GoString");

                if (!(extensionMethod is null))
                    s_GoStringByPtr = extensionMethod.CreateStaticDelegate(typeof(GoStringByPtr)) as GoStringByPtr;

                extensionMethod = targetType.GetExtensionMethod("GoString");

                if (!(extensionMethod is null))
                    s_GoStringByVal = extensionMethod.CreateStaticDelegate(typeof(GoStringByVal)) as GoStringByVal;

                if (s_GoStringByPtr is null && s_GoStringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement GoStringer.GoString method", new Exception("GoString"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator GoStringer<T>(in ptr<T> target_ptr) => new GoStringer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator GoStringer<T>(in T target) => new GoStringer<T>(target);

            // Enable comparisons between nil and GoStringer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(GoStringer<T> value, NilType nil) => Activator.CreateInstance<GoStringer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(GoStringer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, GoStringer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, GoStringer<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class fmt_GoStringerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.fmt_package.GoStringer target)
        {
            try
            {
                return ((go.fmt_package.GoStringer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.fmt_package.GoStringer target, out T result)
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
        public static object? _(this go.fmt_package.GoStringer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.fmt_package.GoStringer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.fmt_package.GoStringer target, Type type, out object? result)
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