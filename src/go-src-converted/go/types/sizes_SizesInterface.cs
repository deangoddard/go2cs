//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:42:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Sizes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sizes As<T>(in T target) => (Sizes<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sizes As<T>(ptr<T> target_ptr) => (Sizes<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sizes? As(object target) =>
                typeof(Sizes<>).CreateInterfaceHandler<Sizes>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Sizes<T> : Sizes
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

            public Sizes(in T target) => m_target = target;

            public Sizes(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate long AlignofByPtr(ptr<T> value, Type T);
            private delegate long AlignofByVal(T value, Type T);

            private static readonly AlignofByPtr? s_AlignofByPtr;
            private static readonly AlignofByVal? s_AlignofByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long Alignof(Type T)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_AlignofByPtr is null || !m_target_is_ptr)
                    return s_AlignofByVal!(target, T);

                return s_AlignofByPtr(m_target_ptr!, T);
            }

            private delegate long OffsetsofByPtr(ptr<T> value, slice<ptr<Var>> fields);
            private delegate long OffsetsofByVal(T value, slice<ptr<Var>> fields);

            private static readonly OffsetsofByPtr? s_OffsetsofByPtr;
            private static readonly OffsetsofByVal? s_OffsetsofByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long Offsetsof(slice<ptr<Var>> fields)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_OffsetsofByPtr is null || !m_target_is_ptr)
                    return s_OffsetsofByVal!(target, fields);

                return s_OffsetsofByPtr(m_target_ptr!, fields);
            }

            private delegate long SizeofByPtr(ptr<T> value, Type T);
            private delegate long SizeofByVal(T value, Type T);

            private static readonly SizeofByPtr? s_SizeofByPtr;
            private static readonly SizeofByVal? s_SizeofByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long Sizeof(Type T)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SizeofByPtr is null || !m_target_is_ptr)
                    return s_SizeofByVal!(target, T);

                return s_SizeofByPtr(m_target_ptr!, T);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Sizes()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Alignof");

                if (extensionMethod is not null)
                    s_AlignofByPtr = extensionMethod.CreateStaticDelegate(typeof(AlignofByPtr)) as AlignofByPtr;

                extensionMethod = targetType.GetExtensionMethod("Alignof");

                if (extensionMethod is not null)
                    s_AlignofByVal = extensionMethod.CreateStaticDelegate(typeof(AlignofByVal)) as AlignofByVal;

                if (s_AlignofByPtr is null && s_AlignofByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sizes.Alignof method", new Exception("Alignof"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Offsetsof");

                if (extensionMethod is not null)
                    s_OffsetsofByPtr = extensionMethod.CreateStaticDelegate(typeof(OffsetsofByPtr)) as OffsetsofByPtr;

                extensionMethod = targetType.GetExtensionMethod("Offsetsof");

                if (extensionMethod is not null)
                    s_OffsetsofByVal = extensionMethod.CreateStaticDelegate(typeof(OffsetsofByVal)) as OffsetsofByVal;

                if (s_OffsetsofByPtr is null && s_OffsetsofByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sizes.Offsetsof method", new Exception("Offsetsof"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Sizeof");

                if (extensionMethod is not null)
                    s_SizeofByPtr = extensionMethod.CreateStaticDelegate(typeof(SizeofByPtr)) as SizeofByPtr;

                extensionMethod = targetType.GetExtensionMethod("Sizeof");

                if (extensionMethod is not null)
                    s_SizeofByVal = extensionMethod.CreateStaticDelegate(typeof(SizeofByVal)) as SizeofByVal;

                if (s_SizeofByPtr is null && s_SizeofByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sizes.Sizeof method", new Exception("Sizeof"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sizes<T>(in ptr<T> target_ptr) => new Sizes<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sizes<T>(in T target) => new Sizes<T>(target);

            // Enable comparisons between nil and Sizes<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sizes<T> value, NilType nil) => Activator.CreateInstance<Sizes<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sizes<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sizes<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sizes<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class types_SizesExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.go.types_package.Sizes target)
        {
            try
            {
                return ((go.go.types_package.Sizes<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.go.types_package.Sizes target, out T result)
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
        public static object? _(this go.go.types_package.Sizes target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.go.types_package.Sizes<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.go.types_package.Sizes target, Type type, out object? result)
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