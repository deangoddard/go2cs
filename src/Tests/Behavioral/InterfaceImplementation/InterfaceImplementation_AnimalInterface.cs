//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 03:07:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Animal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Animal As<T>(in T target) => (Animal<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Animal As<T>(ptr<T> target_ptr) => (Animal<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Animal? As(object target) =>
                typeof(Animal<>).CreateInterfaceHandler<Animal>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Animal<T> : Animal
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

            public Animal(in T target) => m_target = target;

            public Animal(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string TypeByPtr(ptr<T> value);
            private delegate @string TypeByVal(T value);

            private static readonly TypeByPtr? s_TypeByPtr;
            private static readonly TypeByVal? s_TypeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Type()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_TypeByPtr is null || !m_target_is_ptr)
                    return s_TypeByVal!(target);

                return s_TypeByPtr(m_target_ptr!);
            }

            private delegate @string SwimByPtr(ptr<T> value);
            private delegate @string SwimByVal(T value);

            private static readonly SwimByPtr? s_SwimByPtr;
            private static readonly SwimByVal? s_SwimByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Swim()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SwimByPtr is null || !m_target_is_ptr)
                    return s_SwimByVal!(target);

                return s_SwimByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Animal()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Type");

                if (extensionMethod is not null)
                    s_TypeByPtr = extensionMethod.CreateStaticDelegate(typeof(TypeByPtr)) as TypeByPtr;

                extensionMethod = targetType.GetExtensionMethod("Type");

                if (extensionMethod is not null)
                    s_TypeByVal = extensionMethod.CreateStaticDelegate(typeof(TypeByVal)) as TypeByVal;

                if (s_TypeByPtr is null && s_TypeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Animal.Type method", new Exception("Type"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Swim");

                if (extensionMethod is not null)
                    s_SwimByPtr = extensionMethod.CreateStaticDelegate(typeof(SwimByPtr)) as SwimByPtr;

                extensionMethod = targetType.GetExtensionMethod("Swim");

                if (extensionMethod is not null)
                    s_SwimByVal = extensionMethod.CreateStaticDelegate(typeof(SwimByVal)) as SwimByVal;

                if (s_SwimByPtr is null && s_SwimByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Animal.Swim method", new Exception("Swim"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Animal<T>(in ptr<T> target_ptr) => new Animal<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Animal<T>(in T target) => new Animal<T>(target);

            // Enable comparisons between nil and Animal<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Animal<T> value, NilType nil) => Activator.CreateInstance<Animal<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Animal<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Animal<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Animal<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class main_AnimalExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.main_package.Animal target)
        {
            try
            {
                return ((go.main_package.Animal<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.main_package.Animal target, out T result)
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
        public static object? _(this go.main_package.Animal target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.main_package.Animal<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.main_package.Animal target, Type type, out object? result)
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