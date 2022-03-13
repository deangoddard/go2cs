//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:43:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Result
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Result As<T>(in T target) => (Result<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Result As<T>(ptr<T> target_ptr) => (Result<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Result? As(object target) =>
                typeof(Result<>).CreateInterfaceHandler<Result>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Result<T> : Result
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

            public Result(in T target) => m_target = target;

            public Result(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (long, error) LastInsertIdByPtr(ptr<T> value);
            private delegate (long, error) LastInsertIdByVal(T value);

            private static readonly LastInsertIdByPtr? s_LastInsertIdByPtr;
            private static readonly LastInsertIdByVal? s_LastInsertIdByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) LastInsertId()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_LastInsertIdByPtr is null || !m_target_is_ptr)
                    return s_LastInsertIdByVal!(target);

                return s_LastInsertIdByPtr(m_target_ptr!);
            }

            private delegate (long, error) RowsAffectedByPtr(ptr<T> value);
            private delegate (long, error) RowsAffectedByVal(T value);

            private static readonly RowsAffectedByPtr? s_RowsAffectedByPtr;
            private static readonly RowsAffectedByVal? s_RowsAffectedByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) RowsAffected()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_RowsAffectedByPtr is null || !m_target_is_ptr)
                    return s_RowsAffectedByVal!(target);

                return s_RowsAffectedByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Result()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("LastInsertId");

                if (extensionMethod is not null)
                    s_LastInsertIdByPtr = extensionMethod.CreateStaticDelegate(typeof(LastInsertIdByPtr)) as LastInsertIdByPtr;

                extensionMethod = targetType.GetExtensionMethod("LastInsertId");

                if (extensionMethod is not null)
                    s_LastInsertIdByVal = extensionMethod.CreateStaticDelegate(typeof(LastInsertIdByVal)) as LastInsertIdByVal;

                if (s_LastInsertIdByPtr is null && s_LastInsertIdByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Result.LastInsertId method", new Exception("LastInsertId"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("RowsAffected");

                if (extensionMethod is not null)
                    s_RowsAffectedByPtr = extensionMethod.CreateStaticDelegate(typeof(RowsAffectedByPtr)) as RowsAffectedByPtr;

                extensionMethod = targetType.GetExtensionMethod("RowsAffected");

                if (extensionMethod is not null)
                    s_RowsAffectedByVal = extensionMethod.CreateStaticDelegate(typeof(RowsAffectedByVal)) as RowsAffectedByVal;

                if (s_RowsAffectedByPtr is null && s_RowsAffectedByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Result.RowsAffected method", new Exception("RowsAffected"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Result<T>(in ptr<T> target_ptr) => new Result<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Result<T>(in T target) => new Result<T>(target);

            // Enable comparisons between nil and Result<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Result<T> value, NilType nil) => Activator.CreateInstance<Result<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Result<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Result<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Result<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class sql_ResultExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.database.sql_package.Result target)
        {
            try
            {
                return ((go.database.sql_package.Result<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.database.sql_package.Result target, out T result)
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
        public static object? _(this go.database.sql_package.Result target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.database.sql_package.Result<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.database.sql_package.Result target, Type type, out object? result)
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