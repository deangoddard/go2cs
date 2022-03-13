//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:57:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using log = go.log_package;
using os = go.os_package;
using strings = go.strings_package;
using scanner = go.text.scanner_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace asm {
namespace @internal
{
    public static partial class lex_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial interface TokenReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TokenReader As<T>(in T target) => (TokenReader<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TokenReader As<T>(ptr<T> target_ptr) => (TokenReader<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TokenReader? As(object target) =>
                typeof(TokenReader<>).CreateInterfaceHandler<TokenReader>(target);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public class TokenReader<T> : TokenReader
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

            public TokenReader(in T target) => m_target = target;

            public TokenReader(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate nint NextByPtr(ptr<T> value);
            private delegate nint NextByVal(T value);

            private static readonly NextByPtr? s_NextByPtr;
            private static readonly NextByVal? s_NextByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Next()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_NextByPtr is null || !m_target_is_ptr)
                    return s_NextByVal!(target);

                return s_NextByPtr(m_target_ptr!);
            }

            private delegate nint TextByPtr(ptr<T> value);
            private delegate nint TextByVal(T value);

            private static readonly TextByPtr? s_TextByPtr;
            private static readonly TextByVal? s_TextByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Text()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_TextByPtr is null || !m_target_is_ptr)
                    return s_TextByVal!(target);

                return s_TextByPtr(m_target_ptr!);
            }

            private delegate nint FileByPtr(ptr<T> value);
            private delegate nint FileByVal(T value);

            private static readonly FileByPtr? s_FileByPtr;
            private static readonly FileByVal? s_FileByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint File()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_FileByPtr is null || !m_target_is_ptr)
                    return s_FileByVal!(target);

                return s_FileByPtr(m_target_ptr!);
            }

            private delegate nint BaseByPtr(ptr<T> value);
            private delegate nint BaseByVal(T value);

            private static readonly BaseByPtr? s_BaseByPtr;
            private static readonly BaseByVal? s_BaseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Base()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_BaseByPtr is null || !m_target_is_ptr)
                    return s_BaseByVal!(target);

                return s_BaseByPtr(m_target_ptr!);
            }

            private delegate nint SetBaseByPtr(ptr<T> value, ptr<src.PosBase> _p0);
            private delegate nint SetBaseByVal(T value, ptr<src.PosBase> _p0);

            private static readonly SetBaseByPtr? s_SetBaseByPtr;
            private static readonly SetBaseByVal? s_SetBaseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint SetBase(ptr<src.PosBase> _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SetBaseByPtr is null || !m_target_is_ptr)
                    return s_SetBaseByVal!(target, _p0);

                return s_SetBaseByPtr(m_target_ptr!, _p0);
            }

            private delegate nint LineByPtr(ptr<T> value);
            private delegate nint LineByVal(T value);

            private static readonly LineByPtr? s_LineByPtr;
            private static readonly LineByVal? s_LineByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Line()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_LineByPtr is null || !m_target_is_ptr)
                    return s_LineByVal!(target);

                return s_LineByPtr(m_target_ptr!);
            }

            private delegate nint ColByPtr(ptr<T> value);
            private delegate nint ColByVal(T value);

            private static readonly ColByPtr? s_ColByPtr;
            private static readonly ColByVal? s_ColByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Col()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_ColByPtr is null || !m_target_is_ptr)
                    return s_ColByVal!(target);

                return s_ColByPtr(m_target_ptr!);
            }

            private delegate nint CloseByPtr(ptr<T> value);
            private delegate nint CloseByVal(T value);

            private static readonly CloseByPtr? s_CloseByPtr;
            private static readonly CloseByVal? s_CloseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public nint Close()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_CloseByPtr is null || !m_target_is_ptr)
                    return s_CloseByVal!(target);

                return s_CloseByPtr(m_target_ptr!);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static TokenReader()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Next");

                if (extensionMethod is not null)
                    s_NextByPtr = extensionMethod.CreateStaticDelegate(typeof(NextByPtr)) as NextByPtr;

                extensionMethod = targetType.GetExtensionMethod("Next");

                if (extensionMethod is not null)
                    s_NextByVal = extensionMethod.CreateStaticDelegate(typeof(NextByVal)) as NextByVal;

                if (s_NextByPtr is null && s_NextByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.Next method", new Exception("Next"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Text");

                if (extensionMethod is not null)
                    s_TextByPtr = extensionMethod.CreateStaticDelegate(typeof(TextByPtr)) as TextByPtr;

                extensionMethod = targetType.GetExtensionMethod("Text");

                if (extensionMethod is not null)
                    s_TextByVal = extensionMethod.CreateStaticDelegate(typeof(TextByVal)) as TextByVal;

                if (s_TextByPtr is null && s_TextByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.Text method", new Exception("Text"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("File");

                if (extensionMethod is not null)
                    s_FileByPtr = extensionMethod.CreateStaticDelegate(typeof(FileByPtr)) as FileByPtr;

                extensionMethod = targetType.GetExtensionMethod("File");

                if (extensionMethod is not null)
                    s_FileByVal = extensionMethod.CreateStaticDelegate(typeof(FileByVal)) as FileByVal;

                if (s_FileByPtr is null && s_FileByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.File method", new Exception("File"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Base");

                if (extensionMethod is not null)
                    s_BaseByPtr = extensionMethod.CreateStaticDelegate(typeof(BaseByPtr)) as BaseByPtr;

                extensionMethod = targetType.GetExtensionMethod("Base");

                if (extensionMethod is not null)
                    s_BaseByVal = extensionMethod.CreateStaticDelegate(typeof(BaseByVal)) as BaseByVal;

                if (s_BaseByPtr is null && s_BaseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.Base method", new Exception("Base"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("SetBase");

                if (extensionMethod is not null)
                    s_SetBaseByPtr = extensionMethod.CreateStaticDelegate(typeof(SetBaseByPtr)) as SetBaseByPtr;

                extensionMethod = targetType.GetExtensionMethod("SetBase");

                if (extensionMethod is not null)
                    s_SetBaseByVal = extensionMethod.CreateStaticDelegate(typeof(SetBaseByVal)) as SetBaseByVal;

                if (s_SetBaseByPtr is null && s_SetBaseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.SetBase method", new Exception("SetBase"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Line");

                if (extensionMethod is not null)
                    s_LineByPtr = extensionMethod.CreateStaticDelegate(typeof(LineByPtr)) as LineByPtr;

                extensionMethod = targetType.GetExtensionMethod("Line");

                if (extensionMethod is not null)
                    s_LineByVal = extensionMethod.CreateStaticDelegate(typeof(LineByVal)) as LineByVal;

                if (s_LineByPtr is null && s_LineByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.Line method", new Exception("Line"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Col");

                if (extensionMethod is not null)
                    s_ColByPtr = extensionMethod.CreateStaticDelegate(typeof(ColByPtr)) as ColByPtr;

                extensionMethod = targetType.GetExtensionMethod("Col");

                if (extensionMethod is not null)
                    s_ColByVal = extensionMethod.CreateStaticDelegate(typeof(ColByVal)) as ColByVal;

                if (s_ColByPtr is null && s_ColByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.Col method", new Exception("Col"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Close");

                if (extensionMethod is not null)
                    s_CloseByPtr = extensionMethod.CreateStaticDelegate(typeof(CloseByPtr)) as CloseByPtr;

                extensionMethod = targetType.GetExtensionMethod("Close");

                if (extensionMethod is not null)
                    s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;

                if (s_CloseByPtr is null && s_CloseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TokenReader.Close method", new Exception("Close"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator TokenReader<T>(in ptr<T> target_ptr) => new TokenReader<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator TokenReader<T>(in T target) => new TokenReader<T>(target);

            // Enable comparisons between nil and TokenReader<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TokenReader<T> value, NilType nil) => Activator.CreateInstance<TokenReader<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TokenReader<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TokenReader<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TokenReader<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class lex_TokenReaderExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.asm.@internal.lex_package.TokenReader target)
        {
            try
            {
                return ((go.cmd.asm.@internal.lex_package.TokenReader<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.2.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.asm.@internal.lex_package.TokenReader target, out T result)
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
        public static object? _(this go.cmd.asm.@internal.lex_package.TokenReader target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.asm.@internal.lex_package.TokenReader<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.asm.@internal.lex_package.TokenReader target, Type type, out object? result)
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