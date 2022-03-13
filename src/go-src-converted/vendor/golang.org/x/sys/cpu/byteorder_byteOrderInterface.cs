//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using runtime = go.runtime_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class cpu_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial interface byteOrder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static byteOrder As<T>(in T target) => (byteOrder<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static byteOrder As<T>(ptr<T> target_ptr) => (byteOrder<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static byteOrder? As(object target) =>
                typeof(byteOrder<>).CreateInterfaceHandler<byteOrder>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private class byteOrder<T> : byteOrder
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

            public byteOrder(in T target) => m_target = target;

            public byteOrder(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate ulong Uint32ByPtr(ptr<T> value, slice<byte> _p0);
            private delegate ulong Uint32ByVal(T value, slice<byte> _p0);

            private static readonly Uint32ByPtr? s_Uint32ByPtr;
            private static readonly Uint32ByVal? s_Uint32ByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ulong Uint32(slice<byte> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_Uint32ByPtr is null || !m_target_is_ptr)
                    return s_Uint32ByVal!(target, _p0);

                return s_Uint32ByPtr(m_target_ptr!, _p0);
            }

            private delegate ulong Uint64ByPtr(ptr<T> value, slice<byte> _p0);
            private delegate ulong Uint64ByVal(T value, slice<byte> _p0);

            private static readonly Uint64ByPtr? s_Uint64ByPtr;
            private static readonly Uint64ByVal? s_Uint64ByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ulong Uint64(slice<byte> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_Uint64ByPtr is null || !m_target_is_ptr)
                    return s_Uint64ByVal!(target, _p0);

                return s_Uint64ByPtr(m_target_ptr!, _p0);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static byteOrder()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Uint32");

                if (extensionMethod is not null)
                    s_Uint32ByPtr = extensionMethod.CreateStaticDelegate(typeof(Uint32ByPtr)) as Uint32ByPtr;

                extensionMethod = targetType.GetExtensionMethod("Uint32");

                if (extensionMethod is not null)
                    s_Uint32ByVal = extensionMethod.CreateStaticDelegate(typeof(Uint32ByVal)) as Uint32ByVal;

                if (s_Uint32ByPtr is null && s_Uint32ByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement byteOrder.Uint32 method", new Exception("Uint32"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Uint64");

                if (extensionMethod is not null)
                    s_Uint64ByPtr = extensionMethod.CreateStaticDelegate(typeof(Uint64ByPtr)) as Uint64ByPtr;

                extensionMethod = targetType.GetExtensionMethod("Uint64");

                if (extensionMethod is not null)
                    s_Uint64ByVal = extensionMethod.CreateStaticDelegate(typeof(Uint64ByVal)) as Uint64ByVal;

                if (s_Uint64ByPtr is null && s_Uint64ByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement byteOrder.Uint64 method", new Exception("Uint64"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator byteOrder<T>(in ptr<T> target_ptr) => new byteOrder<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator byteOrder<T>(in T target) => new byteOrder<T>(target);

            // Enable comparisons between nil and byteOrder<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byteOrder<T> value, NilType nil) => Activator.CreateInstance<byteOrder<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byteOrder<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byteOrder<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byteOrder<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class cpu_byteOrderExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.vendor.golang.org.x.sys.cpu_package.byteOrder target)
        {
            try
            {
                return ((go.vendor.golang.org.x.sys.cpu_package.byteOrder<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.vendor.golang.org.x.sys.cpu_package.byteOrder target, out T result)
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
        public static object? _(this go.vendor.golang.org.x.sys.cpu_package.byteOrder target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.vendor.golang.org.x.sys.cpu_package.byteOrder<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.vendor.golang.org.x.sys.cpu_package.byteOrder target, Type type, out object? result)
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