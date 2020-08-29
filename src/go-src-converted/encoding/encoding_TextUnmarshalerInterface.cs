//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:35:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class encoding_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface TextUnmarshaler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TextUnmarshaler As<T>(in T target) => (TextUnmarshaler<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TextUnmarshaler As<T>(ptr<T> target_ptr) => (TextUnmarshaler<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TextUnmarshaler? As(object target) =>
                typeof(TextUnmarshaler<>).CreateInterfaceHandler<TextUnmarshaler>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class TextUnmarshaler<T> : TextUnmarshaler
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

            public TextUnmarshaler(in T target) => m_target = target;

            public TextUnmarshaler(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error UnmarshalTextByRef(ref T value, slice<byte> text);
            private delegate error UnmarshalTextByVal(T value, slice<byte> text);

            private static readonly UnmarshalTextByRef s_UnmarshalTextByRef;
            private static readonly UnmarshalTextByVal s_UnmarshalTextByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error UnmarshalText(slice<byte> text)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_UnmarshalTextByRef is null)
                    return s_UnmarshalTextByVal!(target, text);

                return s_UnmarshalTextByRef(ref target, text);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static TextUnmarshaler()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("UnmarshalText");

                if (!(extensionMethod is null))
                    s_UnmarshalTextByRef = extensionMethod.CreateStaticDelegate(typeof(UnmarshalTextByRef)) as UnmarshalTextByRef;

                if (s_UnmarshalTextByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("UnmarshalText");

                    if (!(extensionMethod is null))
                        s_UnmarshalTextByVal = extensionMethod.CreateStaticDelegate(typeof(UnmarshalTextByVal)) as UnmarshalTextByVal;
                }

                if (s_UnmarshalTextByRef is null && s_UnmarshalTextByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TextUnmarshaler.UnmarshalText method", new Exception("UnmarshalText"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator TextUnmarshaler<T>(in ptr<T> target_ptr) => new TextUnmarshaler<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator TextUnmarshaler<T>(in T target) => new TextUnmarshaler<T>(target);

            // Enable comparisons between nil and TextUnmarshaler<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TextUnmarshaler<T> value, NilType nil) => Activator.CreateInstance<TextUnmarshaler<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TextUnmarshaler<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TextUnmarshaler<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TextUnmarshaler<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class encoding_TextUnmarshalerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.encoding_package.TextUnmarshaler target)
        {
            try
            {
                return ((go.encoding_package.TextUnmarshaler<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.encoding_package.TextUnmarshaler target, out T result)
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
        public static object? _(this go.encoding_package.TextUnmarshaler target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.encoding_package.TextUnmarshaler<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.encoding_package.TextUnmarshaler target, Type type, out object? result)
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