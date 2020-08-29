//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface stmtConnGrabber
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static stmtConnGrabber As<T>(in T target) => (stmtConnGrabber<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static stmtConnGrabber As<T>(ptr<T> target_ptr) => (stmtConnGrabber<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static stmtConnGrabber? As(object target) =>
                typeof(stmtConnGrabber<>).CreateInterfaceHandler<stmtConnGrabber>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class stmtConnGrabber<T> : stmtConnGrabber
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

            public stmtConnGrabber(in T target) => m_target = target;

            public stmtConnGrabber(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate context.Context grabConnByRef(ref T value, context.Context _p0);
            private delegate context.Context grabConnByVal(T value, context.Context _p0);

            private static readonly grabConnByRef s_grabConnByRef;
            private static readonly grabConnByVal s_grabConnByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public context.Context grabConn(context.Context _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_grabConnByRef is null)
                    return s_grabConnByVal!(target, _p0);

                return s_grabConnByRef(ref target, _p0);
            }

            private delegate context.Context txCtxByRef(ref T value);
            private delegate context.Context txCtxByVal(T value);

            private static readonly txCtxByRef s_txCtxByRef;
            private static readonly txCtxByVal s_txCtxByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public context.Context txCtx()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_txCtxByRef is null)
                    return s_txCtxByVal!(target);

                return s_txCtxByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static stmtConnGrabber()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("grabConn");

                if (!(extensionMethod is null))
                    s_grabConnByRef = extensionMethod.CreateStaticDelegate(typeof(grabConnByRef)) as grabConnByRef;

                if (s_grabConnByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("grabConn");

                    if (!(extensionMethod is null))
                        s_grabConnByVal = extensionMethod.CreateStaticDelegate(typeof(grabConnByVal)) as grabConnByVal;
                }

                if (s_grabConnByRef is null && s_grabConnByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement stmtConnGrabber.grabConn method", new Exception("grabConn"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("txCtx");

                if (!(extensionMethod is null))
                    s_txCtxByRef = extensionMethod.CreateStaticDelegate(typeof(txCtxByRef)) as txCtxByRef;

                if (s_txCtxByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("txCtx");

                    if (!(extensionMethod is null))
                        s_txCtxByVal = extensionMethod.CreateStaticDelegate(typeof(txCtxByVal)) as txCtxByVal;
                }

                if (s_txCtxByRef is null && s_txCtxByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement stmtConnGrabber.txCtx method", new Exception("txCtx"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator stmtConnGrabber<T>(in ptr<T> target_ptr) => new stmtConnGrabber<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator stmtConnGrabber<T>(in T target) => new stmtConnGrabber<T>(target);

            // Enable comparisons between nil and stmtConnGrabber<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stmtConnGrabber<T> value, NilType nil) => Activator.CreateInstance<stmtConnGrabber<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stmtConnGrabber<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stmtConnGrabber<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stmtConnGrabber<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class sql_stmtConnGrabberExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.database.sql_package.stmtConnGrabber target)
        {
            try
            {
                return ((go.database.sql_package.stmtConnGrabber<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.database.sql_package.stmtConnGrabber target, out T result)
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
        public static object? _(this go.database.sql_package.stmtConnGrabber target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.database.sql_package.stmtConnGrabber<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.database.sql_package.stmtConnGrabber target, Type type, out object? result)
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