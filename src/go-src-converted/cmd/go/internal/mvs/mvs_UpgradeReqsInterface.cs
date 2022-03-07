//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using sort = go.sort_package;
using sync = go.sync_package;
using par = go.cmd.go.@internal.par_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class mvs_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface UpgradeReqs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UpgradeReqs As<T>(in T target) => (UpgradeReqs<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UpgradeReqs As<T>(ptr<T> target_ptr) => (UpgradeReqs<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UpgradeReqs? As(object target) =>
                typeof(UpgradeReqs<>).CreateInterfaceHandler<UpgradeReqs>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class UpgradeReqs<T> : UpgradeReqs
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

            public UpgradeReqs(in T target) => m_target = target;

            public UpgradeReqs(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (module.Version, error) UpgradeByPtr(ptr<T> value, module.Version m);
            private delegate (module.Version, error) UpgradeByVal(T value, module.Version m);

            private static readonly UpgradeByPtr? s_UpgradeByPtr;
            private static readonly UpgradeByVal? s_UpgradeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Upgrade(module.Version m)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_UpgradeByPtr is null || !m_target_is_ptr)
                    return s_UpgradeByVal!(target, m);

                return s_UpgradeByPtr(m_target_ptr!, m);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static UpgradeReqs()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Upgrade");

                if (extensionMethod is not null)
                    s_UpgradeByPtr = extensionMethod.CreateStaticDelegate(typeof(UpgradeByPtr)) as UpgradeByPtr;

                extensionMethod = targetType.GetExtensionMethod("Upgrade");

                if (extensionMethod is not null)
                    s_UpgradeByVal = extensionMethod.CreateStaticDelegate(typeof(UpgradeByVal)) as UpgradeByVal;

                if (s_UpgradeByPtr is null && s_UpgradeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement UpgradeReqs.Upgrade method", new Exception("Upgrade"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator UpgradeReqs<T>(in ptr<T> target_ptr) => new UpgradeReqs<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator UpgradeReqs<T>(in T target) => new UpgradeReqs<T>(target);

            // Enable comparisons between nil and UpgradeReqs<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UpgradeReqs<T> value, NilType nil) => Activator.CreateInstance<UpgradeReqs<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UpgradeReqs<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UpgradeReqs<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UpgradeReqs<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class mvs_UpgradeReqsExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.go.@internal.mvs_package.UpgradeReqs target)
        {
            try
            {
                return ((go.cmd.go.@internal.mvs_package.UpgradeReqs<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.go.@internal.mvs_package.UpgradeReqs target, out T result)
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
        public static object? _(this go.cmd.go.@internal.mvs_package.UpgradeReqs target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.go.@internal.mvs_package.UpgradeReqs<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.go.@internal.mvs_package.UpgradeReqs target, Type type, out object? result)
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