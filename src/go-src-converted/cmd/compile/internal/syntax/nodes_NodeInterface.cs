//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using src = go.cmd.@internal.src_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
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

            public Node(in T target) => m_target = target;

            public Node(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate src.Pos PosByRef(ref T value);
            private delegate src.Pos PosByVal(T value);

            private static readonly PosByRef s_PosByRef;
            private static readonly PosByVal s_PosByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public src.Pos Pos()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_PosByRef is null)
                    return s_PosByVal!(target);

                return s_PosByRef(ref target);
            }

            private delegate src.Pos aNodeByRef(ref T value);
            private delegate src.Pos aNodeByVal(T value);

            private static readonly aNodeByRef s_aNodeByRef;
            private static readonly aNodeByVal s_aNodeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public src.Pos aNode()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_aNodeByRef is null)
                    return s_aNodeByVal!(target);

                return s_aNodeByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Node()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Pos");

                if (!(extensionMethod is null))
                    s_PosByRef = extensionMethod.CreateStaticDelegate(typeof(PosByRef)) as PosByRef;

                if (s_PosByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Pos");

                    if (!(extensionMethod is null))
                        s_PosByVal = extensionMethod.CreateStaticDelegate(typeof(PosByVal)) as PosByVal;
                }

                if (s_PosByRef is null && s_PosByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.Pos method", new Exception("Pos"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("aNode");

                if (!(extensionMethod is null))
                    s_aNodeByRef = extensionMethod.CreateStaticDelegate(typeof(aNodeByRef)) as aNodeByRef;

                if (s_aNodeByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("aNode");

                    if (!(extensionMethod is null))
                        s_aNodeByVal = extensionMethod.CreateStaticDelegate(typeof(aNodeByVal)) as aNodeByVal;
                }

                if (s_aNodeByRef is null && s_aNodeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.aNode method", new Exception("aNode"));
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
}}}}

namespace go
{
    public static class syntax_NodeExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.compile.@internal.syntax_package.Node target)
        {
            try
            {
                return ((go.cmd.compile.@internal.syntax_package.Node<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.compile.@internal.syntax_package.Node target, out T result)
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
        public static object? _(this go.cmd.compile.@internal.syntax_package.Node target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.compile.@internal.syntax_package.Node<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.compile.@internal.syntax_package.Node target, Type type, out object? result)
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