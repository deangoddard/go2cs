//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:00:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ir_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface OrigNode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OrigNode As<T>(in T target) => (OrigNode<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OrigNode As<T>(ptr<T> target_ptr) => (OrigNode<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OrigNode? As(object target) =>
                typeof(OrigNode<>).CreateInterfaceHandler<OrigNode>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class OrigNode<T> : OrigNode
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

            public OrigNode(in T target) => m_target = target;

            public OrigNode(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate Node OrigByPtr(ptr<T> value);
            private delegate Node OrigByVal(T value);

            private static readonly OrigByPtr? s_OrigByPtr;
            private static readonly OrigByVal? s_OrigByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Node Orig()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_OrigByPtr is null || !m_target_is_ptr)
                    return s_OrigByVal!(target);

                return s_OrigByPtr(m_target_ptr!);
            }

            private delegate Node SetOrigByPtr(ptr<T> value, Node _p0);
            private delegate Node SetOrigByVal(T value, Node _p0);

            private static readonly SetOrigByPtr? s_SetOrigByPtr;
            private static readonly SetOrigByVal? s_SetOrigByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Node SetOrig(Node _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SetOrigByPtr is null || !m_target_is_ptr)
                    return s_SetOrigByVal!(target, _p0);

                return s_SetOrigByPtr(m_target_ptr!, _p0);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static OrigNode()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Orig");

                if (extensionMethod is not null)
                    s_OrigByPtr = extensionMethod.CreateStaticDelegate(typeof(OrigByPtr)) as OrigByPtr;

                extensionMethod = targetType.GetExtensionMethod("Orig");

                if (extensionMethod is not null)
                    s_OrigByVal = extensionMethod.CreateStaticDelegate(typeof(OrigByVal)) as OrigByVal;

                if (s_OrigByPtr is null && s_OrigByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement OrigNode.Orig method", new Exception("Orig"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("SetOrig");

                if (extensionMethod is not null)
                    s_SetOrigByPtr = extensionMethod.CreateStaticDelegate(typeof(SetOrigByPtr)) as SetOrigByPtr;

                extensionMethod = targetType.GetExtensionMethod("SetOrig");

                if (extensionMethod is not null)
                    s_SetOrigByVal = extensionMethod.CreateStaticDelegate(typeof(SetOrigByVal)) as SetOrigByVal;

                if (s_SetOrigByPtr is null && s_SetOrigByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement OrigNode.SetOrig method", new Exception("SetOrig"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OrigNode<T>(in ptr<T> target_ptr) => new OrigNode<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OrigNode<T>(in T target) => new OrigNode<T>(target);

            // Enable comparisons between nil and OrigNode<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OrigNode<T> value, NilType nil) => Activator.CreateInstance<OrigNode<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OrigNode<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OrigNode<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OrigNode<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class ir_OrigNodeExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.compile.@internal.ir_package.OrigNode target)
        {
            try
            {
                return ((go.cmd.compile.@internal.ir_package.OrigNode<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.compile.@internal.ir_package.OrigNode target, out T result)
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
        public static object? _(this go.cmd.compile.@internal.ir_package.OrigNode target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.compile.@internal.ir_package.OrigNode<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.compile.@internal.ir_package.OrigNode target, Type type, out object? result)
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