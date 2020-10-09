//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:40:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Decl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Decl As<T>(in T target) => (Decl<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Decl As<T>(ptr<T> target_ptr) => (Decl<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Decl? As(object target) =>
                typeof(Decl<>).CreateInterfaceHandler<Decl>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Decl<T> : Decl
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public Decl(in T target) => m_target = target;

            public Decl(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void aDeclByPtr(ptr<T> value);
            private delegate void aDeclByVal(T value);

            private static readonly aDeclByPtr? s_aDeclByPtr;
            private static readonly aDeclByVal? s_aDeclByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void aDecl()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_aDeclByPtr is null || !m_target_is_ptr)
                {
                    s_aDeclByVal!(target);
                    return;
                }

                s_aDeclByPtr(m_target_ptr);
                return;
                
            }

            private delegate Pos PosByPtr(ptr<T> value);
            private delegate Pos PosByVal(T value);

            private static readonly PosByPtr? s_PosByPtr;
            private static readonly PosByVal? s_PosByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Pos Pos()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_PosByPtr is null || !m_target_is_ptr)
                    return s_PosByVal!(target);

                return s_PosByPtr(m_target_ptr);
            }

            private delegate Pos aNodeByPtr(ptr<T> value);
            private delegate Pos aNodeByVal(T value);

            private static readonly aNodeByPtr? s_aNodeByPtr;
            private static readonly aNodeByVal? s_aNodeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Pos aNode()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_aNodeByPtr is null || !m_target_is_ptr)
                    return s_aNodeByVal!(target);

                return s_aNodeByPtr(m_target_ptr);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static Decl()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("aDecl");

                if (!(extensionMethod is null))
                    s_aDeclByPtr = extensionMethod.CreateStaticDelegate(typeof(aDeclByPtr)) as aDeclByPtr;

                extensionMethod = targetType.GetExtensionMethod("aDecl");

                if (!(extensionMethod is null))
                    s_aDeclByVal = extensionMethod.CreateStaticDelegate(typeof(aDeclByVal)) as aDeclByVal;

                if (s_aDeclByPtr is null && s_aDeclByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Decl.aDecl method", new Exception("aDecl"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Pos");

                if (!(extensionMethod is null))
                    s_PosByPtr = extensionMethod.CreateStaticDelegate(typeof(PosByPtr)) as PosByPtr;

                extensionMethod = targetType.GetExtensionMethod("Pos");

                if (!(extensionMethod is null))
                    s_PosByVal = extensionMethod.CreateStaticDelegate(typeof(PosByVal)) as PosByVal;

                if (s_PosByPtr is null && s_PosByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Decl.Pos method", new Exception("Pos"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("aNode");

                if (!(extensionMethod is null))
                    s_aNodeByPtr = extensionMethod.CreateStaticDelegate(typeof(aNodeByPtr)) as aNodeByPtr;

                extensionMethod = targetType.GetExtensionMethod("aNode");

                if (!(extensionMethod is null))
                    s_aNodeByVal = extensionMethod.CreateStaticDelegate(typeof(aNodeByVal)) as aNodeByVal;

                if (s_aNodeByPtr is null && s_aNodeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Decl.aNode method", new Exception("aNode"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Decl<T>(in ptr<T> target_ptr) => new Decl<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Decl<T>(in T target) => new Decl<T>(target);

            // Enable comparisons between nil and Decl<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Decl<T> value, NilType nil) => Activator.CreateInstance<Decl<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Decl<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Decl<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Decl<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class syntax_DeclExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.compile.@internal.syntax_package.Decl target)
        {
            try
            {
                return ((go.cmd.compile.@internal.syntax_package.Decl<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.compile.@internal.syntax_package.Decl target, out T result)
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
        public static object? _(this go.cmd.compile.@internal.syntax_package.Decl target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.compile.@internal.syntax_package.Decl<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.compile.@internal.syntax_package.Decl target, Type type, out object? result)
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