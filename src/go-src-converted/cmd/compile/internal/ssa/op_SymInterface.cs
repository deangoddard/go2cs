//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:01:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.cmd.compile.@internal.abi_package;
using ir = go.cmd.compile.@internal.ir_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Sym
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sym As<T>(in T target) => (Sym<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sym As<T>(ptr<T> target_ptr) => (Sym<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sym? As(object target) =>
                typeof(Sym<>).CreateInterfaceHandler<Sym>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Sym<T> : Sym
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

            public Sym(in T target) => m_target = target;

            public Sym(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void CanBeAnSSASymByPtr(ptr<T> value);
            private delegate void CanBeAnSSASymByVal(T value);

            private static readonly CanBeAnSSASymByPtr? s_CanBeAnSSASymByPtr;
            private static readonly CanBeAnSSASymByVal? s_CanBeAnSSASymByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void CanBeAnSSASym()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_CanBeAnSSASymByPtr is null || !m_target_is_ptr)
                {
                    s_CanBeAnSSASymByVal!(target);
                    return;
                }

                s_CanBeAnSSASymByPtr(m_target_ptr!);
                return;
            }

            private delegate void CanBeAnSSAAuxByPtr(ptr<T> value);
            private delegate void CanBeAnSSAAuxByVal(T value);

            private static readonly CanBeAnSSAAuxByPtr? s_CanBeAnSSAAuxByPtr;
            private static readonly CanBeAnSSAAuxByVal? s_CanBeAnSSAAuxByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void CanBeAnSSAAux()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_CanBeAnSSAAuxByPtr is null || !m_target_is_ptr)
                {
                    s_CanBeAnSSAAuxByVal!(target);
                    return;
                }

                s_CanBeAnSSAAuxByPtr(m_target_ptr!);
                return;
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Sym()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("CanBeAnSSASym");

                if (extensionMethod is not null)
                    s_CanBeAnSSASymByPtr = extensionMethod.CreateStaticDelegate(typeof(CanBeAnSSASymByPtr)) as CanBeAnSSASymByPtr;

                extensionMethod = targetType.GetExtensionMethod("CanBeAnSSASym");

                if (extensionMethod is not null)
                    s_CanBeAnSSASymByVal = extensionMethod.CreateStaticDelegate(typeof(CanBeAnSSASymByVal)) as CanBeAnSSASymByVal;

                if (s_CanBeAnSSASymByPtr is null && s_CanBeAnSSASymByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sym.CanBeAnSSASym method", new Exception("CanBeAnSSASym"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("CanBeAnSSAAux");

                if (extensionMethod is not null)
                    s_CanBeAnSSAAuxByPtr = extensionMethod.CreateStaticDelegate(typeof(CanBeAnSSAAuxByPtr)) as CanBeAnSSAAuxByPtr;

                extensionMethod = targetType.GetExtensionMethod("CanBeAnSSAAux");

                if (extensionMethod is not null)
                    s_CanBeAnSSAAuxByVal = extensionMethod.CreateStaticDelegate(typeof(CanBeAnSSAAuxByVal)) as CanBeAnSSAAuxByVal;

                if (s_CanBeAnSSAAuxByPtr is null && s_CanBeAnSSAAuxByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sym.CanBeAnSSAAux method", new Exception("CanBeAnSSAAux"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sym<T>(in ptr<T> target_ptr) => new Sym<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sym<T>(in T target) => new Sym<T>(target);

            // Enable comparisons between nil and Sym<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sym<T> value, NilType nil) => Activator.CreateInstance<Sym<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sym<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sym<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sym<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class ssa_SymExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.compile.@internal.ssa_package.Sym target)
        {
            try
            {
                return ((go.cmd.compile.@internal.ssa_package.Sym<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.compile.@internal.ssa_package.Sym target, out T result)
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
        public static object? _(this go.cmd.compile.@internal.ssa_package.Sym target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.compile.@internal.ssa_package.Sym<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.compile.@internal.ssa_package.Sym target, Type type, out object? result)
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