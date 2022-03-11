//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:36:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using image = go.image_package;
using color = go.image.color_package;
using imageutil = go.image.@internal.imageutil_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace image
{
    public static partial class draw_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface RGBA64Image
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RGBA64Image As<T>(in T target) => (RGBA64Image<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RGBA64Image As<T>(ptr<T> target_ptr) => (RGBA64Image<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RGBA64Image? As(object target) =>
                typeof(RGBA64Image<>).CreateInterfaceHandler<RGBA64Image>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class RGBA64Image<T> : RGBA64Image
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

            public RGBA64Image(in T target) => m_target = target;

            public RGBA64Image(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void SetByPtr(ptr<T> value, nint x, nint y, color.Color c);
            private delegate void SetByVal(T value, nint x, nint y, color.Color c);

            private static readonly SetByPtr? s_SetByPtr;
            private static readonly SetByVal? s_SetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Set(nint x, nint y, color.Color c)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SetByPtr is null || !m_target_is_ptr)
                {
                    s_SetByVal!(target, x, y, c);
                    return;
                }

                s_SetByPtr(m_target_ptr!, x, y, c);
                return;
            }

            private delegate void SetRGBA64ByPtr(ptr<T> value, nint x, nint y, color.RGBA64 c);
            private delegate void SetRGBA64ByVal(T value, nint x, nint y, color.RGBA64 c);

            private static readonly SetRGBA64ByPtr? s_SetRGBA64ByPtr;
            private static readonly SetRGBA64ByVal? s_SetRGBA64ByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void SetRGBA64(nint x, nint y, color.RGBA64 c)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SetRGBA64ByPtr is null || !m_target_is_ptr)
                {
                    s_SetRGBA64ByVal!(target, x, y, c);
                    return;
                }

                s_SetRGBA64ByPtr(m_target_ptr!, x, y, c);
                return;
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static RGBA64Image()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Set");

                if (extensionMethod is not null)
                    s_SetByPtr = extensionMethod.CreateStaticDelegate(typeof(SetByPtr)) as SetByPtr;

                extensionMethod = targetType.GetExtensionMethod("Set");

                if (extensionMethod is not null)
                    s_SetByVal = extensionMethod.CreateStaticDelegate(typeof(SetByVal)) as SetByVal;

                if (s_SetByPtr is null && s_SetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RGBA64Image.Set method", new Exception("Set"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("SetRGBA64");

                if (extensionMethod is not null)
                    s_SetRGBA64ByPtr = extensionMethod.CreateStaticDelegate(typeof(SetRGBA64ByPtr)) as SetRGBA64ByPtr;

                extensionMethod = targetType.GetExtensionMethod("SetRGBA64");

                if (extensionMethod is not null)
                    s_SetRGBA64ByVal = extensionMethod.CreateStaticDelegate(typeof(SetRGBA64ByVal)) as SetRGBA64ByVal;

                if (s_SetRGBA64ByPtr is null && s_SetRGBA64ByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RGBA64Image.SetRGBA64 method", new Exception("SetRGBA64"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RGBA64Image<T>(in ptr<T> target_ptr) => new RGBA64Image<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RGBA64Image<T>(in T target) => new RGBA64Image<T>(target);

            // Enable comparisons between nil and RGBA64Image<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RGBA64Image<T> value, NilType nil) => Activator.CreateInstance<RGBA64Image<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RGBA64Image<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RGBA64Image<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RGBA64Image<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class draw_RGBA64ImageExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.image.draw_package.RGBA64Image target)
        {
            try
            {
                return ((go.image.draw_package.RGBA64Image<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.image.draw_package.RGBA64Image target, out T result)
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
        public static object? _(this go.image.draw_package.RGBA64Image target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.image.draw_package.RGBA64Image<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.image.draw_package.RGBA64Image target, Type type, out object? result)
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