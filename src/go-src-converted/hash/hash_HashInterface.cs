//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class hash_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface Hash
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Hash As<T>(in T target) => (Hash<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Hash As<T>(ptr<T> target_ptr) => (Hash<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Hash? As(object target) =>
                typeof(Hash<>).CreateInterfaceHandler<Hash>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class Hash<T> : Hash
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

            public Hash(in T target) => m_target = target;

            public Hash(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate nint SumByPtr(ptr<T> value, slice<byte> b);
            private delegate nint SumByVal(T value, slice<byte> b);

            private static readonly SumByPtr? s_SumByPtr;
            private static readonly SumByVal? s_SumByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Sum(slice<byte> b)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SumByPtr is null || !m_target_is_ptr)
                    return s_SumByVal!(target, b);

                return s_SumByPtr(m_target_ptr!, b);
            }

            private delegate nint ResetByPtr(ptr<T> value);
            private delegate nint ResetByVal(T value);

            private static readonly ResetByPtr? s_ResetByPtr;
            private static readonly ResetByVal? s_ResetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Reset()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_ResetByPtr is null || !m_target_is_ptr)
                    return s_ResetByVal!(target);

                return s_ResetByPtr(m_target_ptr!);
            }

            private delegate nint SizeByPtr(ptr<T> value);
            private delegate nint SizeByVal(T value);

            private static readonly SizeByPtr? s_SizeByPtr;
            private static readonly SizeByVal? s_SizeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Size()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SizeByPtr is null || !m_target_is_ptr)
                    return s_SizeByVal!(target);

                return s_SizeByPtr(m_target_ptr!);
            }

            private delegate nint BlockSizeByPtr(ptr<T> value);
            private delegate nint BlockSizeByVal(T value);

            private static readonly BlockSizeByPtr? s_BlockSizeByPtr;
            private static readonly BlockSizeByVal? s_BlockSizeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint BlockSize()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_BlockSizeByPtr is null || !m_target_is_ptr)
                    return s_BlockSizeByVal!(target);

                return s_BlockSizeByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Hash()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Sum");

                if (extensionMethod is not null)
                    s_SumByPtr = extensionMethod.CreateStaticDelegate(typeof(SumByPtr)) as SumByPtr;

                extensionMethod = targetType.GetExtensionMethod("Sum");

                if (extensionMethod is not null)
                    s_SumByVal = extensionMethod.CreateStaticDelegate(typeof(SumByVal)) as SumByVal;

                if (s_SumByPtr is null && s_SumByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Hash.Sum method", new Exception("Sum"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Reset");

                if (extensionMethod is not null)
                    s_ResetByPtr = extensionMethod.CreateStaticDelegate(typeof(ResetByPtr)) as ResetByPtr;

                extensionMethod = targetType.GetExtensionMethod("Reset");

                if (extensionMethod is not null)
                    s_ResetByVal = extensionMethod.CreateStaticDelegate(typeof(ResetByVal)) as ResetByVal;

                if (s_ResetByPtr is null && s_ResetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Hash.Reset method", new Exception("Reset"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Size");

                if (extensionMethod is not null)
                    s_SizeByPtr = extensionMethod.CreateStaticDelegate(typeof(SizeByPtr)) as SizeByPtr;

                extensionMethod = targetType.GetExtensionMethod("Size");

                if (extensionMethod is not null)
                    s_SizeByVal = extensionMethod.CreateStaticDelegate(typeof(SizeByVal)) as SizeByVal;

                if (s_SizeByPtr is null && s_SizeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Hash.Size method", new Exception("Size"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("BlockSize");

                if (extensionMethod is not null)
                    s_BlockSizeByPtr = extensionMethod.CreateStaticDelegate(typeof(BlockSizeByPtr)) as BlockSizeByPtr;

                extensionMethod = targetType.GetExtensionMethod("BlockSize");

                if (extensionMethod is not null)
                    s_BlockSizeByVal = extensionMethod.CreateStaticDelegate(typeof(BlockSizeByVal)) as BlockSizeByVal;

                if (s_BlockSizeByPtr is null && s_BlockSizeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Hash.BlockSize method", new Exception("BlockSize"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Hash<T>(in ptr<T> target_ptr) => new Hash<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Hash<T>(in T target) => new Hash<T>(target);

            // Enable comparisons between nil and Hash<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Hash<T> value, NilType nil) => Activator.CreateInstance<Hash<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Hash<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Hash<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Hash<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class hash_HashExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.hash_package.Hash target)
        {
            try
            {
                return ((go.hash_package.Hash<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.hash_package.Hash target, out T result)
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
        public static object? _(this go.hash_package.Hash target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.hash_package.Hash<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.hash_package.Hash target, Type type, out object? result)
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