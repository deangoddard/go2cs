//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:27:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using poll = go.@internal.poll_package;
using io = go.io_package;
using os = go.os_package;
using syscall = go.syscall_package;
using time = go.time_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface buffersWriter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static buffersWriter As<T>(in T target) => (buffersWriter<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static buffersWriter As<T>(ptr<T> target_ptr) => (buffersWriter<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static buffersWriter? As(object target) =>
                typeof(buffersWriter<>).CreateInterfaceHandler<buffersWriter>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class buffersWriter<T> : buffersWriter
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

            public buffersWriter(in T target) => m_target = target;

            public buffersWriter(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (long, error) writeBuffersByRef(ref T value, ref Buffers _p0);
            private delegate (long, error) writeBuffersByVal(T value, ref Buffers _p0);

            private static readonly writeBuffersByRef s_writeBuffersByRef;
            private static readonly writeBuffersByVal s_writeBuffersByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) writeBuffers(ref Buffers _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_writeBuffersByRef is null)
                    return s_writeBuffersByVal!(target, _p0);

                return s_writeBuffersByRef(ref target, _p0);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static buffersWriter()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("writeBuffers");

                if (!(extensionMethod is null))
                    s_writeBuffersByRef = extensionMethod.CreateStaticDelegate(typeof(writeBuffersByRef)) as writeBuffersByRef;

                if (s_writeBuffersByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("writeBuffers");

                    if (!(extensionMethod is null))
                        s_writeBuffersByVal = extensionMethod.CreateStaticDelegate(typeof(writeBuffersByVal)) as writeBuffersByVal;
                }

                if (s_writeBuffersByRef is null && s_writeBuffersByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement buffersWriter.writeBuffers method", new Exception("writeBuffers"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator buffersWriter<T>(in ptr<T> target_ptr) => new buffersWriter<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator buffersWriter<T>(in T target) => new buffersWriter<T>(target);

            // Enable comparisons between nil and buffersWriter<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(buffersWriter<T> value, NilType nil) => Activator.CreateInstance<buffersWriter<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(buffersWriter<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, buffersWriter<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, buffersWriter<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class net_buffersWriterExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net_package.buffersWriter target)
        {
            try
            {
                return ((go.net_package.buffersWriter<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net_package.buffersWriter target, out T result)
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
        public static object? _(this go.net_package.buffersWriter target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net_package.buffersWriter<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net_package.buffersWriter target, Type type, out object? result)
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