//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using regexp = go.regexp_package;
using time = go.time_package;
using internaldriver = go.github.com.google.pprof.@internal.driver_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface UI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UI As<T>(in T target) => (UI<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UI As<T>(ptr<T> target_ptr) => (UI<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static UI? As(object target) =>
                typeof(UI<>).CreateInterfaceHandler<UI>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class UI<T> : UI
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

            public UI(in T target) => m_target = target;

            public UI(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string ReadLineByRef(ref T value, @string prompt);
            private delegate @string ReadLineByVal(T value, @string prompt);

            private static readonly ReadLineByRef s_ReadLineByRef;
            private static readonly ReadLineByVal s_ReadLineByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string ReadLine(@string prompt)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadLineByRef is null)
                    return s_ReadLineByVal!(target, prompt);

                return s_ReadLineByRef(ref target, prompt);
            }

            private delegate @string PrintByRef(ref T value, params object _p0);
            private delegate @string PrintByVal(T value, params object _p0);

            private static readonly PrintByRef s_PrintByRef;
            private static readonly PrintByVal s_PrintByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Print(params object _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_PrintByRef is null)
                    return s_PrintByVal!(target, _p0);

                return s_PrintByRef(ref target, _p0);
            }

            private delegate @string PrintErrByRef(ref T value, params object _p0);
            private delegate @string PrintErrByVal(T value, params object _p0);

            private static readonly PrintErrByRef s_PrintErrByRef;
            private static readonly PrintErrByVal s_PrintErrByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string PrintErr(params object _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_PrintErrByRef is null)
                    return s_PrintErrByVal!(target, _p0);

                return s_PrintErrByRef(ref target, _p0);
            }

            private delegate @string IsTerminalByRef(ref T value);
            private delegate @string IsTerminalByVal(T value);

            private static readonly IsTerminalByRef s_IsTerminalByRef;
            private static readonly IsTerminalByVal s_IsTerminalByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string IsTerminal()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_IsTerminalByRef is null)
                    return s_IsTerminalByVal!(target);

                return s_IsTerminalByRef(ref target);
            }

            private delegate @string SetAutoCompleteByRef(ref T value, Func<@string, @string> complete);
            private delegate @string SetAutoCompleteByVal(T value, Func<@string, @string> complete);

            private static readonly SetAutoCompleteByRef s_SetAutoCompleteByRef;
            private static readonly SetAutoCompleteByVal s_SetAutoCompleteByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string SetAutoComplete(Func<@string, @string> complete)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_SetAutoCompleteByRef is null)
                    return s_SetAutoCompleteByVal!(target, complete);

                return s_SetAutoCompleteByRef(ref target, complete);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static UI()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("ReadLine");

                if (!(extensionMethod is null))
                    s_ReadLineByRef = extensionMethod.CreateStaticDelegate(typeof(ReadLineByRef)) as ReadLineByRef;

                if (s_ReadLineByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ReadLine");

                    if (!(extensionMethod is null))
                        s_ReadLineByVal = extensionMethod.CreateStaticDelegate(typeof(ReadLineByVal)) as ReadLineByVal;
                }

                if (s_ReadLineByRef is null && s_ReadLineByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement UI.ReadLine method", new Exception("ReadLine"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Print");

                if (!(extensionMethod is null))
                    s_PrintByRef = extensionMethod.CreateStaticDelegate(typeof(PrintByRef)) as PrintByRef;

                if (s_PrintByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Print");

                    if (!(extensionMethod is null))
                        s_PrintByVal = extensionMethod.CreateStaticDelegate(typeof(PrintByVal)) as PrintByVal;
                }

                if (s_PrintByRef is null && s_PrintByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement UI.Print method", new Exception("Print"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("PrintErr");

                if (!(extensionMethod is null))
                    s_PrintErrByRef = extensionMethod.CreateStaticDelegate(typeof(PrintErrByRef)) as PrintErrByRef;

                if (s_PrintErrByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("PrintErr");

                    if (!(extensionMethod is null))
                        s_PrintErrByVal = extensionMethod.CreateStaticDelegate(typeof(PrintErrByVal)) as PrintErrByVal;
                }

                if (s_PrintErrByRef is null && s_PrintErrByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement UI.PrintErr method", new Exception("PrintErr"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("IsTerminal");

                if (!(extensionMethod is null))
                    s_IsTerminalByRef = extensionMethod.CreateStaticDelegate(typeof(IsTerminalByRef)) as IsTerminalByRef;

                if (s_IsTerminalByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("IsTerminal");

                    if (!(extensionMethod is null))
                        s_IsTerminalByVal = extensionMethod.CreateStaticDelegate(typeof(IsTerminalByVal)) as IsTerminalByVal;
                }

                if (s_IsTerminalByRef is null && s_IsTerminalByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement UI.IsTerminal method", new Exception("IsTerminal"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("SetAutoComplete");

                if (!(extensionMethod is null))
                    s_SetAutoCompleteByRef = extensionMethod.CreateStaticDelegate(typeof(SetAutoCompleteByRef)) as SetAutoCompleteByRef;

                if (s_SetAutoCompleteByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("SetAutoComplete");

                    if (!(extensionMethod is null))
                        s_SetAutoCompleteByVal = extensionMethod.CreateStaticDelegate(typeof(SetAutoCompleteByVal)) as SetAutoCompleteByVal;
                }

                if (s_SetAutoCompleteByRef is null && s_SetAutoCompleteByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement UI.SetAutoComplete method", new Exception("SetAutoComplete"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator UI<T>(in ptr<T> target_ptr) => new UI<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator UI<T>(in T target) => new UI<T>(target);

            // Enable comparisons between nil and UI<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UI<T> value, NilType nil) => Activator.CreateInstance<UI<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UI<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UI<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UI<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class driver_UIExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.github.com.google.pprof.driver_package.UI target)
        {
            try
            {
                return ((go.cmd.vendor.github.com.google.pprof.driver_package.UI<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.github.com.google.pprof.driver_package.UI target, out T result)
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
        public static object? _(this go.cmd.vendor.github.com.google.pprof.driver_package.UI target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.github.com.google.pprof.driver_package.UI<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.github.com.google.pprof.driver_package.UI target, Type type, out object? result)
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