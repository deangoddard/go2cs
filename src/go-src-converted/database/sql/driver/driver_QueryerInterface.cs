//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:43:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using errors = go.errors_package;
using reflect = go.reflect_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Queryer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Queryer As<T>(in T target) => (Queryer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Queryer As<T>(ptr<T> target_ptr) => (Queryer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Queryer? As(object target) =>
                typeof(Queryer<>).CreateInterfaceHandler<Queryer>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Queryer<T> : Queryer
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

            public Queryer(in T target) => m_target = target;

            public Queryer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (Rows, error) QueryByPtr(ptr<T> value, @string query, slice<Value> args);
            private delegate (Rows, error) QueryByVal(T value, @string query, slice<Value> args);

            private static readonly QueryByPtr? s_QueryByPtr;
            private static readonly QueryByVal? s_QueryByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (Rows, error) Query(@string query, slice<Value> args)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_QueryByPtr is null || !m_target_is_ptr)
                    return s_QueryByVal!(target, query, args);

                return s_QueryByPtr(m_target_ptr!, query, args);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Queryer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Query");

                if (extensionMethod is not null)
                    s_QueryByPtr = extensionMethod.CreateStaticDelegate(typeof(QueryByPtr)) as QueryByPtr;

                extensionMethod = targetType.GetExtensionMethod("Query");

                if (extensionMethod is not null)
                    s_QueryByVal = extensionMethod.CreateStaticDelegate(typeof(QueryByVal)) as QueryByVal;

                if (s_QueryByPtr is null && s_QueryByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Queryer.Query method", new Exception("Query"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Queryer<T>(in ptr<T> target_ptr) => new Queryer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Queryer<T>(in T target) => new Queryer<T>(target);

            // Enable comparisons between nil and Queryer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Queryer<T> value, NilType nil) => Activator.CreateInstance<Queryer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Queryer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Queryer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Queryer<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class driver_QueryerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.database.sql.driver_package.Queryer target)
        {
            try
            {
                return ((go.database.sql.driver_package.Queryer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.database.sql.driver_package.Queryer target, out T result)
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
        public static object? _(this go.database.sql.driver_package.Queryer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.database.sql.driver_package.Queryer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.database.sql.driver_package.Queryer target, Type type, out object? result)
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