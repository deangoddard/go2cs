//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace text {
namespace template
{
    public static partial class parse_package
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

            private delegate ptr<Tree> TypeByPtr(ptr<T> value);
            private delegate ptr<Tree> TypeByVal(T value);

            private static readonly TypeByPtr? s_TypeByPtr;
            private static readonly TypeByVal? s_TypeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Tree> Type()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_TypeByPtr is null || !m_target_is_ptr)
                    return s_TypeByVal!(target);

                return s_TypeByPtr(m_target_ptr!);
            }

            private delegate ptr<Tree> StringByPtr(ptr<T> value);
            private delegate ptr<Tree> StringByVal(T value);

            private static readonly StringByPtr? s_StringByPtr;
            private static readonly StringByVal? s_StringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Tree> String()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_StringByPtr is null || !m_target_is_ptr)
                    return s_StringByVal!(target);

                return s_StringByPtr(m_target_ptr!);
            }

            private delegate ptr<Tree> CopyByPtr(ptr<T> value);
            private delegate ptr<Tree> CopyByVal(T value);

            private static readonly CopyByPtr? s_CopyByPtr;
            private static readonly CopyByVal? s_CopyByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Tree> Copy()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_CopyByPtr is null || !m_target_is_ptr)
                    return s_CopyByVal!(target);

                return s_CopyByPtr(m_target_ptr!);
            }

            private delegate ptr<Tree> PositionByPtr(ptr<T> value);
            private delegate ptr<Tree> PositionByVal(T value);

            private static readonly PositionByPtr? s_PositionByPtr;
            private static readonly PositionByVal? s_PositionByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Tree> Position()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_PositionByPtr is null || !m_target_is_ptr)
                    return s_PositionByVal!(target);

                return s_PositionByPtr(m_target_ptr!);
            }

            private delegate ptr<Tree> treeByPtr(ptr<T> value);
            private delegate ptr<Tree> treeByVal(T value);

            private static readonly treeByPtr? s_treeByPtr;
            private static readonly treeByVal? s_treeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Tree> tree()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_treeByPtr is null || !m_target_is_ptr)
                    return s_treeByVal!(target);

                return s_treeByPtr(m_target_ptr!);
            }

            private delegate ptr<Tree> writeToByPtr(ptr<T> value, ptr<strings.Builder> _p0);
            private delegate ptr<Tree> writeToByVal(T value, ptr<strings.Builder> _p0);

            private static readonly writeToByPtr? s_writeToByPtr;
            private static readonly writeToByVal? s_writeToByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ptr<Tree> writeTo(ptr<strings.Builder> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_writeToByPtr is null || !m_target_is_ptr)
                    return s_writeToByVal!(target, _p0);

                return s_writeToByPtr(m_target_ptr!, _p0);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static Node()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Type");

                if (extensionMethod is not null)
                    s_TypeByPtr = extensionMethod.CreateStaticDelegate(typeof(TypeByPtr)) as TypeByPtr;

                extensionMethod = targetType.GetExtensionMethod("Type");

                if (extensionMethod is not null)
                    s_TypeByVal = extensionMethod.CreateStaticDelegate(typeof(TypeByVal)) as TypeByVal;

                if (s_TypeByPtr is null && s_TypeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.Type method", new Exception("Type"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("String");

                if (extensionMethod is not null)
                    s_StringByPtr = extensionMethod.CreateStaticDelegate(typeof(StringByPtr)) as StringByPtr;

                extensionMethod = targetType.GetExtensionMethod("String");

                if (extensionMethod is not null)
                    s_StringByVal = extensionMethod.CreateStaticDelegate(typeof(StringByVal)) as StringByVal;

                if (s_StringByPtr is null && s_StringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.String method", new Exception("String"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Copy");

                if (extensionMethod is not null)
                    s_CopyByPtr = extensionMethod.CreateStaticDelegate(typeof(CopyByPtr)) as CopyByPtr;

                extensionMethod = targetType.GetExtensionMethod("Copy");

                if (extensionMethod is not null)
                    s_CopyByVal = extensionMethod.CreateStaticDelegate(typeof(CopyByVal)) as CopyByVal;

                if (s_CopyByPtr is null && s_CopyByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.Copy method", new Exception("Copy"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Position");

                if (extensionMethod is not null)
                    s_PositionByPtr = extensionMethod.CreateStaticDelegate(typeof(PositionByPtr)) as PositionByPtr;

                extensionMethod = targetType.GetExtensionMethod("Position");

                if (extensionMethod is not null)
                    s_PositionByVal = extensionMethod.CreateStaticDelegate(typeof(PositionByVal)) as PositionByVal;

                if (s_PositionByPtr is null && s_PositionByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.Position method", new Exception("Position"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("tree");

                if (extensionMethod is not null)
                    s_treeByPtr = extensionMethod.CreateStaticDelegate(typeof(treeByPtr)) as treeByPtr;

                extensionMethod = targetType.GetExtensionMethod("tree");

                if (extensionMethod is not null)
                    s_treeByVal = extensionMethod.CreateStaticDelegate(typeof(treeByVal)) as treeByVal;

                if (s_treeByPtr is null && s_treeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.tree method", new Exception("tree"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("writeTo");

                if (extensionMethod is not null)
                    s_writeToByPtr = extensionMethod.CreateStaticDelegate(typeof(writeToByPtr)) as writeToByPtr;

                extensionMethod = targetType.GetExtensionMethod("writeTo");

                if (extensionMethod is not null)
                    s_writeToByVal = extensionMethod.CreateStaticDelegate(typeof(writeToByVal)) as writeToByVal;

                if (s_writeToByPtr is null && s_writeToByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Node.writeTo method", new Exception("writeTo"));
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
}}}

namespace go
{
    public static class parse_NodeExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.text.template.parse_package.Node target)
        {
            try
            {
                return ((go.text.template.parse_package.Node<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.text.template.parse_package.Node target, out T result)
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
        public static object? _(this go.text.template.parse_package.Node target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.text.template.parse_package.Node<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.text.template.parse_package.Node target, Type type, out object? result)
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