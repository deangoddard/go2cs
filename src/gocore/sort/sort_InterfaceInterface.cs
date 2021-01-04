//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class sort_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Interface
        {
        #if NET5_0
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Interface As<T>(in T target) => 
                (Interface<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Interface As<T>(ptr<T> target_ptr) => 
                (Interface<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Interface? As(object target) =>
                typeof(Interface<>).CreateInterfaceHandler<Interface>(target);
        #endif
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Interface<T> : Interface
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

            public Interface(in T target) => m_target = target;

            public Interface(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate nint LenByPtr(ptr<T> value);
            private delegate nint LenByVal(T value);

            private static readonly LenByPtr? s_LenByPtr;
            private static readonly LenByVal? s_LenByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Len()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_LenByPtr is null || !m_target_is_ptr)
                    return s_LenByVal!(target);

                return s_LenByPtr(m_target_ptr!);
            }

            private delegate bool LessByPtr(ptr<T> value, nint i, nint j);
            private delegate bool LessByVal(T value, nint i, nint j);

            private static readonly LessByPtr? s_LessByPtr;
            private static readonly LessByVal? s_LessByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Less(nint i, nint j)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_LessByPtr is null || !m_target_is_ptr)
                    return s_LessByVal!(target, i, j);

                return s_LessByPtr(m_target_ptr!, i, j);
            }

            private delegate void SwapByPtr(ptr<T> value, nint i, nint j);
            private delegate void SwapByVal(T value, nint i, nint j);

            private static readonly SwapByPtr? s_SwapByPtr;
            private static readonly SwapByVal? s_SwapByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Swap(nint i, nint j)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_SwapByPtr is null || !m_target_is_ptr)
                {
                    s_SwapByVal!(target, i, j);
                    return;
                }

                s_SwapByPtr(m_target_ptr!, i, j);
            }
            
            public string? ToString(string? format, IFormatProvider? formatProvider) => format;

            //[DebuggerStepperBoundary]
            static Interface()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Len");

                if (!(extensionMethod is null))
                    s_LenByPtr = extensionMethod.CreateStaticDelegate(typeof(LenByPtr)) as LenByPtr;

                extensionMethod = targetType.GetExtensionMethod("Len");

                if (!(extensionMethod is null))
                    s_LenByVal = extensionMethod.CreateStaticDelegate(typeof(LenByVal)) as LenByVal;

                if (s_LenByPtr is null && s_LenByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Interface.Len method", new Exception("Len"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Less");

                if (!(extensionMethod is null))
                    s_LessByPtr = extensionMethod.CreateStaticDelegate(typeof(LessByPtr)) as LessByPtr;

                extensionMethod = targetType.GetExtensionMethod("Less");

                if (!(extensionMethod is null))
                    s_LessByVal = extensionMethod.CreateStaticDelegate(typeof(LessByVal)) as LessByVal;

                if (s_LessByPtr is null && s_LessByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Interface.Less method", new Exception("Less"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Swap");

                if (!(extensionMethod is null))
                    s_SwapByPtr = extensionMethod.CreateStaticDelegate(typeof(SwapByPtr)) as SwapByPtr;

                extensionMethod = targetType.GetExtensionMethod("Swap");

                if (!(extensionMethod is null))
                    s_SwapByVal = extensionMethod.CreateStaticDelegate(typeof(SwapByVal)) as SwapByVal;

                if (s_SwapByPtr is null && s_SwapByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Interface.Swap method", new Exception("Swap"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Interface<T>(in ptr<T> target_ptr) => new Interface<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Interface<T>(in T target) => new Interface<T>(target);

            // Enable comparisons between nil and Interface<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Interface<T> value, NilType nil) => Activator.CreateInstance<Interface<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Interface<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Interface<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Interface<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class sort_InterfaceExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.sort_package.Interface target)
        {
            try
            {
                return ((go.sort_package.Interface<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.sort_package.Interface target, out T result)
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
        public static object? _(this go.sort_package.Interface target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.sort_package.Interface<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.sort_package.Interface target, Type type, out object? result)
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
