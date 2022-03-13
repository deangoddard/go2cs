//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:59:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using sync = go.sync_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Object
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Object As<T>(in T target) => (Object<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Object As<T>(ptr<T> target_ptr) => (Object<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Object? As(object target) =>
                typeof(Object<>).CreateInterfaceHandler<Object>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Object<T> : Object
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

            public Object(in T target) => m_target = target;

            public Object(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate ptr<Type> PosByPtr(ptr<T> value);
            private delegate ptr<Type> PosByVal(T value);

            private static readonly PosByPtr? s_PosByPtr;
            private static readonly PosByVal? s_PosByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Type> Pos()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_PosByPtr is null || !m_target_is_ptr)
                    return s_PosByVal!(target);

                return s_PosByPtr(m_target_ptr!);
            }

            private delegate ptr<Type> SymByPtr(ptr<T> value);
            private delegate ptr<Type> SymByVal(T value);

            private static readonly SymByPtr? s_SymByPtr;
            private static readonly SymByVal? s_SymByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Type> Sym()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SymByPtr is null || !m_target_is_ptr)
                    return s_SymByVal!(target);

                return s_SymByPtr(m_target_ptr!);
            }

            private delegate ptr<Type> TypeByPtr(ptr<T> value);
            private delegate ptr<Type> TypeByVal(T value);

            private static readonly TypeByPtr? s_TypeByPtr;
            private static readonly TypeByVal? s_TypeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Type> Type()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_TypeByPtr is null || !m_target_is_ptr)
                    return s_TypeByVal!(target);

                return s_TypeByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Object()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Pos");

                if (extensionMethod is not null)
                    s_PosByPtr = extensionMethod.CreateStaticDelegate(typeof(PosByPtr)) as PosByPtr;

                extensionMethod = targetType.GetExtensionMethod("Pos");

                if (extensionMethod is not null)
                    s_PosByVal = extensionMethod.CreateStaticDelegate(typeof(PosByVal)) as PosByVal;

                if (s_PosByPtr is null && s_PosByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Object.Pos method", new Exception("Pos"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Sym");

                if (extensionMethod is not null)
                    s_SymByPtr = extensionMethod.CreateStaticDelegate(typeof(SymByPtr)) as SymByPtr;

                extensionMethod = targetType.GetExtensionMethod("Sym");

                if (extensionMethod is not null)
                    s_SymByVal = extensionMethod.CreateStaticDelegate(typeof(SymByVal)) as SymByVal;

                if (s_SymByPtr is null && s_SymByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Object.Sym method", new Exception("Sym"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Type");

                if (extensionMethod is not null)
                    s_TypeByPtr = extensionMethod.CreateStaticDelegate(typeof(TypeByPtr)) as TypeByPtr;

                extensionMethod = targetType.GetExtensionMethod("Type");

                if (extensionMethod is not null)
                    s_TypeByVal = extensionMethod.CreateStaticDelegate(typeof(TypeByVal)) as TypeByVal;

                if (s_TypeByPtr is null && s_TypeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Object.Type method", new Exception("Type"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Object<T>(in ptr<T> target_ptr) => new Object<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Object<T>(in T target) => new Object<T>(target);

            // Enable comparisons between nil and Object<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Object<T> value, NilType nil) => Activator.CreateInstance<Object<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Object<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Object<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Object<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class types_ObjectExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.compile.@internal.types_package.Object target)
        {
            try
            {
                return ((go.cmd.compile.@internal.types_package.Object<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.compile.@internal.types_package.Object target, out T result)
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
        public static object? _(this go.cmd.compile.@internal.types_package.Object target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.compile.@internal.types_package.Object<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.compile.@internal.types_package.Object target, Type type, out object? result)
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