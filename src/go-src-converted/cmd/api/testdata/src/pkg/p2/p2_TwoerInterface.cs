//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:54:11 UTC
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
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p2_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Twoer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Twoer As<T>(in T target) => (Twoer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Twoer As<T>(ptr<T> target_ptr) => (Twoer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Twoer? As(object target) =>
                typeof(Twoer<>).CreateInterfaceHandler<Twoer>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Twoer<T> : Twoer
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

            public Twoer(in T target) => m_target = target;

            public Twoer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void PackageTwoMethByPtr(ptr<T> value);
            private delegate void PackageTwoMethByVal(T value);

            private static readonly PackageTwoMethByPtr? s_PackageTwoMethByPtr;
            private static readonly PackageTwoMethByVal? s_PackageTwoMethByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void PackageTwoMeth()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_PackageTwoMethByPtr is null || !m_target_is_ptr)
                {
                    s_PackageTwoMethByVal!(target);
                    return;
                }

                s_PackageTwoMethByPtr(m_target_ptr!);
                return;
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Twoer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("PackageTwoMeth");

                if (extensionMethod is not null)
                    s_PackageTwoMethByPtr = extensionMethod.CreateStaticDelegate(typeof(PackageTwoMethByPtr)) as PackageTwoMethByPtr;

                extensionMethod = targetType.GetExtensionMethod("PackageTwoMeth");

                if (extensionMethod is not null)
                    s_PackageTwoMethByVal = extensionMethod.CreateStaticDelegate(typeof(PackageTwoMethByVal)) as PackageTwoMethByVal;

                if (s_PackageTwoMethByPtr is null && s_PackageTwoMethByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Twoer.PackageTwoMeth method", new Exception("PackageTwoMeth"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Twoer<T>(in ptr<T> target_ptr) => new Twoer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Twoer<T>(in T target) => new Twoer<T>(target);

            // Enable comparisons between nil and Twoer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Twoer<T> value, NilType nil) => Activator.CreateInstance<Twoer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Twoer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Twoer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Twoer<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class p2_TwoerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.api.testdata.src.pkg.p2_package.Twoer target)
        {
            try
            {
                return ((go.cmd.api.testdata.src.pkg.p2_package.Twoer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.api.testdata.src.pkg.p2_package.Twoer target, out T result)
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
        public static object? _(this go.cmd.api.testdata.src.pkg.p2_package.Twoer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.api.testdata.src.pkg.p2_package.Twoer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.api.testdata.src.pkg.p2_package.Twoer target, Type type, out object? result)
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