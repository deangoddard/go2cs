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
        public partial interface UnmarshalerAttr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UnmarshalerAttr As<T>(in T target) => (UnmarshalerAttr<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UnmarshalerAttr As<T>(ptr<T> target_ptr) => (UnmarshalerAttr<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UnmarshalerAttr? As(object target) =>
                typeof(UnmarshalerAttr<>).CreateInterfaceHandler<UnmarshalerAttr>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class UnmarshalerAttr<T> : UnmarshalerAttr
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

            public UnmarshalerAttr(in T target) => m_target = target;

            public UnmarshalerAttr(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error UnmarshalXMLAttrByPtr(ptr<T> value, Attr attr);
            private delegate error UnmarshalXMLAttrByVal(T value, Attr attr);

            private static readonly UnmarshalXMLAttrByPtr? s_UnmarshalXMLAttrByPtr;
            private static readonly UnmarshalXMLAttrByVal? s_UnmarshalXMLAttrByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error UnmarshalXMLAttr(Attr attr)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_UnmarshalXMLAttrByPtr is null || !m_target_is_ptr)
                    return s_UnmarshalXMLAttrByVal!(target, attr);

                return s_UnmarshalXMLAttrByPtr(m_target_ptr!, attr);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static UnmarshalerAttr()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("UnmarshalXMLAttr");

                if (extensionMethod is not null)
                    s_UnmarshalXMLAttrByPtr = extensionMethod.CreateStaticDelegate(typeof(UnmarshalXMLAttrByPtr)) as UnmarshalXMLAttrByPtr;

                extensionMethod = targetType.GetExtensionMethod("UnmarshalXMLAttr");

                if (extensionMethod is not null)
                    s_UnmarshalXMLAttrByVal = extensionMethod.CreateStaticDelegate(typeof(UnmarshalXMLAttrByVal)) as UnmarshalXMLAttrByVal;

                if (s_UnmarshalXMLAttrByPtr is null && s_UnmarshalXMLAttrByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement UnmarshalerAttr.UnmarshalXMLAttr method", new Exception("UnmarshalXMLAttr"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator UnmarshalerAttr<T>(in ptr<T> target_ptr) => new UnmarshalerAttr<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator UnmarshalerAttr<T>(in T target) => new UnmarshalerAttr<T>(target);

            // Enable comparisons between nil and UnmarshalerAttr<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnmarshalerAttr<T> value, NilType nil) => Activator.CreateInstance<UnmarshalerAttr<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnmarshalerAttr<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnmarshalerAttr<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnmarshalerAttr<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class xml_UnmarshalerAttrExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.encoding.xml_package.UnmarshalerAttr target)
        {
            try
            {
                return ((go.encoding.xml_package.UnmarshalerAttr<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.encoding.xml_package.UnmarshalerAttr target, out T result)
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
        public static object? _(this go.encoding.xml_package.UnmarshalerAttr target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.encoding.xml_package.UnmarshalerAttr<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.encoding.xml_package.UnmarshalerAttr target, Type type, out object? result)
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