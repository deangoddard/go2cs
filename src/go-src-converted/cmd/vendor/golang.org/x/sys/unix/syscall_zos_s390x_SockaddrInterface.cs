//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:27:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Sockaddr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sockaddr As<T>(in T target) => (Sockaddr<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sockaddr As<T>(ptr<T> target_ptr) => (Sockaddr<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sockaddr? As(object target) =>
                typeof(Sockaddr<>).CreateInterfaceHandler<Sockaddr>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Sockaddr<T> : Sockaddr
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

            public Sockaddr(in T target) => m_target = target;

            public Sockaddr(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (unsafe.Pointer, _Socklen, error) sockaddrByPtr(ptr<T> value);
            private delegate (unsafe.Pointer, _Socklen, error) sockaddrByVal(T value);

            private static readonly sockaddrByPtr? s_sockaddrByPtr;
            private static readonly sockaddrByVal? s_sockaddrByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (unsafe.Pointer, _Socklen, error) sockaddr()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_sockaddrByPtr is null || !m_target_is_ptr)
                    return s_sockaddrByVal!(target);

                return s_sockaddrByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Sockaddr()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("sockaddr");

                if (extensionMethod is not null)
                    s_sockaddrByPtr = extensionMethod.CreateStaticDelegate(typeof(sockaddrByPtr)) as sockaddrByPtr;

                extensionMethod = targetType.GetExtensionMethod("sockaddr");

                if (extensionMethod is not null)
                    s_sockaddrByVal = extensionMethod.CreateStaticDelegate(typeof(sockaddrByVal)) as sockaddrByVal;

                if (s_sockaddrByPtr is null && s_sockaddrByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sockaddr.sockaddr method", new Exception("sockaddr"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sockaddr<T>(in ptr<T> target_ptr) => new Sockaddr<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sockaddr<T>(in T target) => new Sockaddr<T>(target);

            // Enable comparisons between nil and Sockaddr<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sockaddr<T> value, NilType nil) => Activator.CreateInstance<Sockaddr<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sockaddr<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sockaddr<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sockaddr<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class unix_SockaddrExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.golang.org.x.sys.unix_package.Sockaddr target)
        {
            try
            {
                return ((go.cmd.vendor.golang.org.x.sys.unix_package.Sockaddr<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.golang.org.x.sys.unix_package.Sockaddr target, out T result)
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
        public static object? _(this go.cmd.vendor.golang.org.x.sys.unix_package.Sockaddr target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.golang.org.x.sys.unix_package.Sockaddr<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.golang.org.x.sys.unix_package.Sockaddr target, Type type, out object? result)
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