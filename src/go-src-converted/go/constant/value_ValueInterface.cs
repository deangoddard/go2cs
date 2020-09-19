//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using math = go.math_package;
using big = go.math.big_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace go
{
    public static partial class constant_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Value As<T>(in T target) => (Value<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Value As<T>(ptr<T> target_ptr) => (Value<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Value? As(object target) =>
                typeof(Value<>).CreateInterfaceHandler<Value>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Value<T> : Value
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

            public Value(in T target) => m_target = target;

            public Value(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string KindByRef(ref T value);
            private delegate @string KindByVal(T value);

            private static readonly KindByRef s_KindByRef;
            private static readonly KindByVal s_KindByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Kind()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_KindByRef is null)
                    return s_KindByVal!(target);

                return s_KindByRef(ref target);
            }

            private delegate @string StringByRef(ref T value);
            private delegate @string StringByVal(T value);

            private static readonly StringByRef s_StringByRef;
            private static readonly StringByVal s_StringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string String()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_StringByRef is null)
                    return s_StringByVal!(target);

                return s_StringByRef(ref target);
            }

            private delegate @string ExactStringByRef(ref T value);
            private delegate @string ExactStringByVal(T value);

            private static readonly ExactStringByRef s_ExactStringByRef;
            private static readonly ExactStringByVal s_ExactStringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string ExactString()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ExactStringByRef is null)
                    return s_ExactStringByVal!(target);

                return s_ExactStringByRef(ref target);
            }

            private delegate @string implementsValueByRef(ref T value);
            private delegate @string implementsValueByVal(T value);

            private static readonly implementsValueByRef s_implementsValueByRef;
            private static readonly implementsValueByVal s_implementsValueByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string implementsValue()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_implementsValueByRef is null)
                    return s_implementsValueByVal!(target);

                return s_implementsValueByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Value()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Kind");

                if (!(extensionMethod is null))
                    s_KindByRef = extensionMethod.CreateStaticDelegate(typeof(KindByRef)) as KindByRef;

                if (s_KindByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Kind");

                    if (!(extensionMethod is null))
                        s_KindByVal = extensionMethod.CreateStaticDelegate(typeof(KindByVal)) as KindByVal;
                }

                if (s_KindByRef is null && s_KindByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.Kind method", new Exception("Kind"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByRef = extensionMethod.CreateStaticDelegate(typeof(StringByRef)) as StringByRef;

                if (s_StringByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("String");

                    if (!(extensionMethod is null))
                        s_StringByVal = extensionMethod.CreateStaticDelegate(typeof(StringByVal)) as StringByVal;
                }

                if (s_StringByRef is null && s_StringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.String method", new Exception("String"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("ExactString");

                if (!(extensionMethod is null))
                    s_ExactStringByRef = extensionMethod.CreateStaticDelegate(typeof(ExactStringByRef)) as ExactStringByRef;

                if (s_ExactStringByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ExactString");

                    if (!(extensionMethod is null))
                        s_ExactStringByVal = extensionMethod.CreateStaticDelegate(typeof(ExactStringByVal)) as ExactStringByVal;
                }

                if (s_ExactStringByRef is null && s_ExactStringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.ExactString method", new Exception("ExactString"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("implementsValue");

                if (!(extensionMethod is null))
                    s_implementsValueByRef = extensionMethod.CreateStaticDelegate(typeof(implementsValueByRef)) as implementsValueByRef;

                if (s_implementsValueByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("implementsValue");

                    if (!(extensionMethod is null))
                        s_implementsValueByVal = extensionMethod.CreateStaticDelegate(typeof(implementsValueByVal)) as implementsValueByVal;
                }

                if (s_implementsValueByRef is null && s_implementsValueByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.implementsValue method", new Exception("implementsValue"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Value<T>(in ptr<T> target_ptr) => new Value<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Value<T>(in T target) => new Value<T>(target);

            // Enable comparisons between nil and Value<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Value<T> value, NilType nil) => Activator.CreateInstance<Value<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Value<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Value<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Value<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class constant_ValueExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.go.constant_package.Value target)
        {
            try
            {
                return ((go.go.constant_package.Value<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.go.constant_package.Value target, out T result)
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
        public static object? _(this go.go.constant_package.Value target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.go.constant_package.Value<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.go.constant_package.Value target, Type type, out object? result)
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