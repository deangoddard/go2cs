//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:40:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using encoding = go.encoding_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace encoding
{
    public static partial class xml_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Unmarshaler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Unmarshaler As<T>(in T target) => (Unmarshaler<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Unmarshaler As<T>(ptr<T> target_ptr) => (Unmarshaler<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Unmarshaler? As(object target) =>
                typeof(Unmarshaler<>).CreateInterfaceHandler<Unmarshaler>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Unmarshaler<T> : Unmarshaler
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

            public Unmarshaler(in T target) => m_target = target;

            public Unmarshaler(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error UnmarshalXMLByPtr(ptr<T> value, ptr<Decoder> d, StartElement start);
            private delegate error UnmarshalXMLByVal(T value, ptr<Decoder> d, StartElement start);

            private static readonly UnmarshalXMLByPtr? s_UnmarshalXMLByPtr;
            private static readonly UnmarshalXMLByVal? s_UnmarshalXMLByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error UnmarshalXML(ptr<Decoder> d, StartElement start)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_UnmarshalXMLByPtr is null || !m_target_is_ptr)
                    return s_UnmarshalXMLByVal!(target, d, start);

                return s_UnmarshalXMLByPtr(m_target_ptr!, d, start);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Unmarshaler()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("UnmarshalXML");

                if (extensionMethod is not null)
                    s_UnmarshalXMLByPtr = extensionMethod.CreateStaticDelegate(typeof(UnmarshalXMLByPtr)) as UnmarshalXMLByPtr;

                extensionMethod = targetType.GetExtensionMethod("UnmarshalXML");

                if (extensionMethod is not null)
                    s_UnmarshalXMLByVal = extensionMethod.CreateStaticDelegate(typeof(UnmarshalXMLByVal)) as UnmarshalXMLByVal;

                if (s_UnmarshalXMLByPtr is null && s_UnmarshalXMLByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Unmarshaler.UnmarshalXML method", new Exception("UnmarshalXML"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Unmarshaler<T>(in ptr<T> target_ptr) => new Unmarshaler<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Unmarshaler<T>(in T target) => new Unmarshaler<T>(target);

            // Enable comparisons between nil and Unmarshaler<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Unmarshaler<T> value, NilType nil) => Activator.CreateInstance<Unmarshaler<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Unmarshaler<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Unmarshaler<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Unmarshaler<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class xml_UnmarshalerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.encoding.xml_package.Unmarshaler target)
        {
            try
            {
                return ((go.encoding.xml_package.Unmarshaler<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.encoding.xml_package.Unmarshaler target, out T result)
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
        public static object? _(this go.encoding.xml_package.Unmarshaler target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.encoding.xml_package.Unmarshaler<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.encoding.xml_package.Unmarshaler target, Type type, out object? result)
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