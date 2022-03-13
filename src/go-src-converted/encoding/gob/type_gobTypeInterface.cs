//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:39:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using encoding = go.encoding_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using os = go.os_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface gobType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static gobType As<T>(in T target) => (gobType<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static gobType As<T>(ptr<T> target_ptr) => (gobType<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static gobType? As(object target) =>
                typeof(gobType<>).CreateInterfaceHandler<gobType>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class gobType<T> : gobType
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

            public gobType(in T target) => m_target = target;

            public gobType(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string idByPtr(ptr<T> value);
            private delegate @string idByVal(T value);

            private static readonly idByPtr? s_idByPtr;
            private static readonly idByVal? s_idByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string id()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_idByPtr is null || !m_target_is_ptr)
                    return s_idByVal!(target);

                return s_idByPtr(m_target_ptr!);
            }

            private delegate @string setIdByPtr(ptr<T> value, typeId id);
            private delegate @string setIdByVal(T value, typeId id);

            private static readonly setIdByPtr? s_setIdByPtr;
            private static readonly setIdByVal? s_setIdByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string setId(typeId id)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_setIdByPtr is null || !m_target_is_ptr)
                    return s_setIdByVal!(target, id);

                return s_setIdByPtr(m_target_ptr!, id);
            }

            private delegate @string nameByPtr(ptr<T> value);
            private delegate @string nameByVal(T value);

            private static readonly nameByPtr? s_nameByPtr;
            private static readonly nameByVal? s_nameByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string name()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_nameByPtr is null || !m_target_is_ptr)
                    return s_nameByVal!(target);

                return s_nameByPtr(m_target_ptr!);
            }

            private delegate @string stringByPtr(ptr<T> value);
            private delegate @string stringByVal(T value);

            private static readonly stringByPtr? s_stringByPtr;
            private static readonly stringByVal? s_stringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string string()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_stringByPtr is null || !m_target_is_ptr)
                    return s_stringByVal!(target);

                return s_stringByPtr(m_target_ptr!);
            }

            private delegate @string safeStringByPtr(ptr<T> value, map<typeId, bool> seen);
            private delegate @string safeStringByVal(T value, map<typeId, bool> seen);

            private static readonly safeStringByPtr? s_safeStringByPtr;
            private static readonly safeStringByVal? s_safeStringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string safeString(map<typeId, bool> seen)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_safeStringByPtr is null || !m_target_is_ptr)
                    return s_safeStringByVal!(target, seen);

                return s_safeStringByPtr(m_target_ptr!, seen);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static gobType()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("id");

                if (extensionMethod is not null)
                    s_idByPtr = extensionMethod.CreateStaticDelegate(typeof(idByPtr)) as idByPtr;

                extensionMethod = targetType.GetExtensionMethod("id");

                if (extensionMethod is not null)
                    s_idByVal = extensionMethod.CreateStaticDelegate(typeof(idByVal)) as idByVal;

                if (s_idByPtr is null && s_idByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement gobType.id method", new Exception("id"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("setId");

                if (extensionMethod is not null)
                    s_setIdByPtr = extensionMethod.CreateStaticDelegate(typeof(setIdByPtr)) as setIdByPtr;

                extensionMethod = targetType.GetExtensionMethod("setId");

                if (extensionMethod is not null)
                    s_setIdByVal = extensionMethod.CreateStaticDelegate(typeof(setIdByVal)) as setIdByVal;

                if (s_setIdByPtr is null && s_setIdByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement gobType.setId method", new Exception("setId"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("name");

                if (extensionMethod is not null)
                    s_nameByPtr = extensionMethod.CreateStaticDelegate(typeof(nameByPtr)) as nameByPtr;

                extensionMethod = targetType.GetExtensionMethod("name");

                if (extensionMethod is not null)
                    s_nameByVal = extensionMethod.CreateStaticDelegate(typeof(nameByVal)) as nameByVal;

                if (s_nameByPtr is null && s_nameByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement gobType.name method", new Exception("name"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("string");

                if (extensionMethod is not null)
                    s_stringByPtr = extensionMethod.CreateStaticDelegate(typeof(stringByPtr)) as stringByPtr;

                extensionMethod = targetType.GetExtensionMethod("string");

                if (extensionMethod is not null)
                    s_stringByVal = extensionMethod.CreateStaticDelegate(typeof(stringByVal)) as stringByVal;

                if (s_stringByPtr is null && s_stringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement gobType.string method", new Exception("string"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("safeString");

                if (extensionMethod is not null)
                    s_safeStringByPtr = extensionMethod.CreateStaticDelegate(typeof(safeStringByPtr)) as safeStringByPtr;

                extensionMethod = targetType.GetExtensionMethod("safeString");

                if (extensionMethod is not null)
                    s_safeStringByVal = extensionMethod.CreateStaticDelegate(typeof(safeStringByVal)) as safeStringByVal;

                if (s_safeStringByPtr is null && s_safeStringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement gobType.safeString method", new Exception("safeString"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator gobType<T>(in ptr<T> target_ptr) => new gobType<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator gobType<T>(in T target) => new gobType<T>(target);

            // Enable comparisons between nil and gobType<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gobType<T> value, NilType nil) => Activator.CreateInstance<gobType<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gobType<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gobType<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gobType<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class gob_gobTypeExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.encoding.gob_package.gobType target)
        {
            try
            {
                return ((go.encoding.gob_package.gobType<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.encoding.gob_package.gobType target, out T result)
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
        public static object? _(this go.encoding.gob_package.gobType target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.encoding.gob_package.gobType<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.encoding.gob_package.gobType target, Type type, out object? result)
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