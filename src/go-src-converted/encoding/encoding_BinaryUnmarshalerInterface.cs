//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class encoding_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface BinaryUnmarshaler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static BinaryUnmarshaler As<T>(in T target) => (BinaryUnmarshaler<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static BinaryUnmarshaler As<T>(ptr<T> target_ptr) => (BinaryUnmarshaler<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static BinaryUnmarshaler? As(object target) =>
                typeof(BinaryUnmarshaler<>).CreateInterfaceHandler<BinaryUnmarshaler>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class BinaryUnmarshaler<T> : BinaryUnmarshaler
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

            public BinaryUnmarshaler(in T target) => m_target = target;

            public BinaryUnmarshaler(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error UnmarshalBinaryByPtr(ptr<T> value, slice<byte> data);
            private delegate error UnmarshalBinaryByVal(T value, slice<byte> data);

            private static readonly UnmarshalBinaryByPtr? s_UnmarshalBinaryByPtr;
            private static readonly UnmarshalBinaryByVal? s_UnmarshalBinaryByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error UnmarshalBinary(slice<byte> data)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_UnmarshalBinaryByPtr is null || !m_target_is_ptr)
                    return s_UnmarshalBinaryByVal!(target, data);

                return s_UnmarshalBinaryByPtr(m_target_ptr!, data);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static BinaryUnmarshaler()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("UnmarshalBinary");

                if (extensionMethod is not null)
                    s_UnmarshalBinaryByPtr = extensionMethod.CreateStaticDelegate(typeof(UnmarshalBinaryByPtr)) as UnmarshalBinaryByPtr;

                extensionMethod = targetType.GetExtensionMethod("UnmarshalBinary");

                if (extensionMethod is not null)
                    s_UnmarshalBinaryByVal = extensionMethod.CreateStaticDelegate(typeof(UnmarshalBinaryByVal)) as UnmarshalBinaryByVal;

                if (s_UnmarshalBinaryByPtr is null && s_UnmarshalBinaryByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement BinaryUnmarshaler.UnmarshalBinary method", new Exception("UnmarshalBinary"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator BinaryUnmarshaler<T>(in ptr<T> target_ptr) => new BinaryUnmarshaler<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator BinaryUnmarshaler<T>(in T target) => new BinaryUnmarshaler<T>(target);

            // Enable comparisons between nil and BinaryUnmarshaler<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BinaryUnmarshaler<T> value, NilType nil) => Activator.CreateInstance<BinaryUnmarshaler<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BinaryUnmarshaler<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BinaryUnmarshaler<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BinaryUnmarshaler<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class encoding_BinaryUnmarshalerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.encoding_package.BinaryUnmarshaler target)
        {
            try
            {
                return ((go.encoding_package.BinaryUnmarshaler<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.encoding_package.BinaryUnmarshaler target, out T result)
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
        public static object? _(this go.encoding_package.BinaryUnmarshaler target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.encoding_package.BinaryUnmarshaler<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.encoding_package.BinaryUnmarshaler target, Type type, out object? result)
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