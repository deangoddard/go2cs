//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:24:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface AST
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static AST As<T>(in T target) => (AST<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static AST As<T>(ptr<T> target_ptr) => (AST<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static AST? As(object target) =>
                typeof(AST<>).CreateInterfaceHandler<AST>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class AST<T> : AST
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

            public AST(in T target) => m_target = target;

            public AST(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string printByPtr(ptr<T> value, ptr<printState> _p0);
            private delegate @string printByVal(T value, ptr<printState> _p0);

            private static readonly printByPtr? s_printByPtr;
            private static readonly printByVal? s_printByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string print(ptr<printState> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_printByPtr is null || !m_target_is_ptr)
                    return s_printByVal!(target, _p0);

                return s_printByPtr(m_target_ptr!, _p0);
            }

            private delegate @string TraverseByPtr(ptr<T> value, Func<AST, bool> _p0);
            private delegate @string TraverseByVal(T value, Func<AST, bool> _p0);

            private static readonly TraverseByPtr? s_TraverseByPtr;
            private static readonly TraverseByVal? s_TraverseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Traverse(Func<AST, bool> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_TraverseByPtr is null || !m_target_is_ptr)
                    return s_TraverseByVal!(target, _p0);

                return s_TraverseByPtr(m_target_ptr!, _p0);
            }

            private delegate @string CopyByPtr(ptr<T> value, Func<AST, AST> copy, Func<AST, bool> skip);
            private delegate @string CopyByVal(T value, Func<AST, AST> copy, Func<AST, bool> skip);

            private static readonly CopyByPtr? s_CopyByPtr;
            private static readonly CopyByVal? s_CopyByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Copy(Func<AST, AST> copy, Func<AST, bool> skip)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_CopyByPtr is null || !m_target_is_ptr)
                    return s_CopyByVal!(target, copy, skip);

                return s_CopyByPtr(m_target_ptr!, copy, skip);
            }

            private delegate @string GoStringByPtr(ptr<T> value);
            private delegate @string GoStringByVal(T value);

            private static readonly GoStringByPtr? s_GoStringByPtr;
            private static readonly GoStringByVal? s_GoStringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string GoString()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_GoStringByPtr is null || !m_target_is_ptr)
                    return s_GoStringByVal!(target);

                return s_GoStringByPtr(m_target_ptr!);
            }

            private delegate @string goStringByPtr(ptr<T> value, nint indent, @string field);
            private delegate @string goStringByVal(T value, nint indent, @string field);

            private static readonly goStringByPtr? s_goStringByPtr;
            private static readonly goStringByVal? s_goStringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string goString(nint indent, @string field)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_goStringByPtr is null || !m_target_is_ptr)
                    return s_goStringByVal!(target, indent, field);

                return s_goStringByPtr(m_target_ptr!, indent, field);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static AST()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("print");

                if (extensionMethod is not null)
                    s_printByPtr = extensionMethod.CreateStaticDelegate(typeof(printByPtr)) as printByPtr;

                extensionMethod = targetType.GetExtensionMethod("print");

                if (extensionMethod is not null)
                    s_printByVal = extensionMethod.CreateStaticDelegate(typeof(printByVal)) as printByVal;

                if (s_printByPtr is null && s_printByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AST.print method", new Exception("print"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Traverse");

                if (extensionMethod is not null)
                    s_TraverseByPtr = extensionMethod.CreateStaticDelegate(typeof(TraverseByPtr)) as TraverseByPtr;

                extensionMethod = targetType.GetExtensionMethod("Traverse");

                if (extensionMethod is not null)
                    s_TraverseByVal = extensionMethod.CreateStaticDelegate(typeof(TraverseByVal)) as TraverseByVal;

                if (s_TraverseByPtr is null && s_TraverseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AST.Traverse method", new Exception("Traverse"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Copy");

                if (extensionMethod is not null)
                    s_CopyByPtr = extensionMethod.CreateStaticDelegate(typeof(CopyByPtr)) as CopyByPtr;

                extensionMethod = targetType.GetExtensionMethod("Copy");

                if (extensionMethod is not null)
                    s_CopyByVal = extensionMethod.CreateStaticDelegate(typeof(CopyByVal)) as CopyByVal;

                if (s_CopyByPtr is null && s_CopyByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AST.Copy method", new Exception("Copy"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("GoString");

                if (extensionMethod is not null)
                    s_GoStringByPtr = extensionMethod.CreateStaticDelegate(typeof(GoStringByPtr)) as GoStringByPtr;

                extensionMethod = targetType.GetExtensionMethod("GoString");

                if (extensionMethod is not null)
                    s_GoStringByVal = extensionMethod.CreateStaticDelegate(typeof(GoStringByVal)) as GoStringByVal;

                if (s_GoStringByPtr is null && s_GoStringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AST.GoString method", new Exception("GoString"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("goString");

                if (extensionMethod is not null)
                    s_goStringByPtr = extensionMethod.CreateStaticDelegate(typeof(goStringByPtr)) as goStringByPtr;

                extensionMethod = targetType.GetExtensionMethod("goString");

                if (extensionMethod is not null)
                    s_goStringByVal = extensionMethod.CreateStaticDelegate(typeof(goStringByVal)) as goStringByVal;

                if (s_goStringByPtr is null && s_goStringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement AST.goString method", new Exception("goString"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator AST<T>(in ptr<T> target_ptr) => new AST<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator AST<T>(in T target) => new AST<T>(target);

            // Enable comparisons between nil and AST<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AST<T> value, NilType nil) => Activator.CreateInstance<AST<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AST<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AST<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AST<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class demangle_ASTExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.AST target)
        {
            try
            {
                return ((go.cmd.vendor.github.com.ianlancetaylor.demangle_package.AST<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.AST target, out T result)
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
        public static object? _(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.AST target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.github.com.ianlancetaylor.demangle_package.AST<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.github.com.ianlancetaylor.demangle_package.AST target, Type type, out object? result)
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