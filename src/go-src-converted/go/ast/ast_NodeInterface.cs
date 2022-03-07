//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using token = go.go.token_package;
using strings = go.strings_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Node
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Node As<T>(in T target) => (Node<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Node As<T>(ptr<T> target_ptr) => (Node<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Node? As(object target) =>
                typeof(Node<>).CreateInterfaceHandler<Node>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Node<T> : Node
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

            public Node(in T target) => m_target = target;

            public Node(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate token.Pos PosByPtr(ptr<T> value);
            private delegate token.Pos PosByVal(T value);

            private static readonly PosByPtr? s_PosByPtr;
            private static readonly PosByVal? s_PosByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos Pos()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_PosByPtr is null || !m_target_is_ptr)
                    return s_PosByVal!(target);

                return s_PosByPtr(m_target_ptr!);
            }

            private delegate token.Pos EndByPtr(ptr<T> value);
            private delegate token.Pos EndByVal(T value);

            private static readonly EndByPtr? s_EndByPtr;
            private static readonly EndByVal? s_EndByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos End()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_EndByPtr is null || !m_target_is_ptr)
                    return s_EndByVal!(target);

                return s_EndByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Node()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Pos");

                if (extensionMethod is not null)
                    s_PosByPtr = extensionMethod.CreateStaticDelegate(typeof(PosByPtr)) as PosByPtr;

                extensionMethod = targetType.GetExtensionMethod("Pos");

                if (extensionMethod is not null)
                    s_PosByVal = extensionMethod.CreateStaticDelegate(typeof(PosByVal)) as PosByVal;

                if (s_PosByPtr is null && s_PosByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.Pos method", new Exception("Pos"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("End");

                if (extensionMethod is not null)
                    s_EndByPtr = extensionMethod.CreateStaticDelegate(typeof(EndByPtr)) as EndByPtr;

                extensionMethod = targetType.GetExtensionMethod("End");

                if (extensionMethod is not null)
                    s_EndByVal = extensionMethod.CreateStaticDelegate(typeof(EndByVal)) as EndByVal;

                if (s_EndByPtr is null && s_EndByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.End method", new Exception("End"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Node<T>(in ptr<T> target_ptr) => new Node<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Node<T>(in T target) => new Node<T>(target);

            // Enable comparisons between nil and Node<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Node<T> value, NilType nil) => Activator.CreateInstance<Node<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Node<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Node<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Node<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class ast_NodeExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.go.ast_package.Node target)
        {
            try
            {
                return ((go.go.ast_package.Node<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.go.ast_package.Node target, out T result)
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
        public static object? _(this go.go.ast_package.Node target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.go.ast_package.Node<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.go.ast_package.Node target, Type type, out object? result)
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