//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:51:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class dwarf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Context
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Context As<T>(in T target) => (Context<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Context As<T>(ptr<T> target_ptr) => (Context<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Context? As(object target) =>
                typeof(Context<>).CreateInterfaceHandler<Context>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Context<T> : Context
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

            public Context(in T target) => m_target = target;

            public Context(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void PtrSizeByRef(ref T value);
            private delegate void PtrSizeByVal(T value);

            private static readonly PtrSizeByRef s_PtrSizeByRef;
            private static readonly PtrSizeByVal s_PtrSizeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void PtrSize()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_PtrSizeByRef is null)
                {
                    s_PtrSizeByVal!(target);
                    return;
                }

                s_PtrSizeByRef(ref target);
                return;
                
            }

            private delegate void AddIntByRef(ref T value, Sym s, long size, long i);
            private delegate void AddIntByVal(T value, Sym s, long size, long i);

            private static readonly AddIntByRef s_AddIntByRef;
            private static readonly AddIntByVal s_AddIntByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void AddInt(Sym s, long size, long i)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddIntByRef is null)
                {
                    s_AddIntByVal!(target, s, size, i);
                    return;
                }

                s_AddIntByRef(ref target, s, size, i);
                return;
                
            }

            private delegate void AddBytesByRef(ref T value, Sym s, slice<byte> b);
            private delegate void AddBytesByVal(T value, Sym s, slice<byte> b);

            private static readonly AddBytesByRef s_AddBytesByRef;
            private static readonly AddBytesByVal s_AddBytesByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void AddBytes(Sym s, slice<byte> b)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddBytesByRef is null)
                {
                    s_AddBytesByVal!(target, s, b);
                    return;
                }

                s_AddBytesByRef(ref target, s, b);
                return;
                
            }

            private delegate void AddAddressByRef(ref T value, Sym s, object t, long ofs);
            private delegate void AddAddressByVal(T value, Sym s, object t, long ofs);

            private static readonly AddAddressByRef s_AddAddressByRef;
            private static readonly AddAddressByVal s_AddAddressByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void AddAddress(Sym s, object t, long ofs)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddAddressByRef is null)
                {
                    s_AddAddressByVal!(target, s, t, ofs);
                    return;
                }

                s_AddAddressByRef(ref target, s, t, ofs);
                return;
                
            }

            private delegate void AddCURelativeAddressByRef(ref T value, Sym s, object t, long ofs);
            private delegate void AddCURelativeAddressByVal(T value, Sym s, object t, long ofs);

            private static readonly AddCURelativeAddressByRef s_AddCURelativeAddressByRef;
            private static readonly AddCURelativeAddressByVal s_AddCURelativeAddressByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void AddCURelativeAddress(Sym s, object t, long ofs)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddCURelativeAddressByRef is null)
                {
                    s_AddCURelativeAddressByVal!(target, s, t, ofs);
                    return;
                }

                s_AddCURelativeAddressByRef(ref target, s, t, ofs);
                return;
                
            }

            private delegate void AddSectionOffsetByRef(ref T value, Sym s, long size, object t, long ofs);
            private delegate void AddSectionOffsetByVal(T value, Sym s, long size, object t, long ofs);

            private static readonly AddSectionOffsetByRef s_AddSectionOffsetByRef;
            private static readonly AddSectionOffsetByVal s_AddSectionOffsetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void AddSectionOffset(Sym s, long size, object t, long ofs)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddSectionOffsetByRef is null)
                {
                    s_AddSectionOffsetByVal!(target, s, size, t, ofs);
                    return;
                }

                s_AddSectionOffsetByRef(ref target, s, size, t, ofs);
                return;
                
            }

            private delegate void CurrentOffsetByRef(ref T value, Sym s);
            private delegate void CurrentOffsetByVal(T value, Sym s);

            private static readonly CurrentOffsetByRef s_CurrentOffsetByRef;
            private static readonly CurrentOffsetByVal s_CurrentOffsetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void CurrentOffset(Sym s)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_CurrentOffsetByRef is null)
                {
                    s_CurrentOffsetByVal!(target, s);
                    return;
                }

                s_CurrentOffsetByRef(ref target, s);
                return;
                
            }

            private delegate void RecordDclReferenceByRef(ref T value, Sym from, Sym to, long dclIdx, long inlIndex);
            private delegate void RecordDclReferenceByVal(T value, Sym from, Sym to, long dclIdx, long inlIndex);

            private static readonly RecordDclReferenceByRef s_RecordDclReferenceByRef;
            private static readonly RecordDclReferenceByVal s_RecordDclReferenceByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void RecordDclReference(Sym from, Sym to, long dclIdx, long inlIndex)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_RecordDclReferenceByRef is null)
                {
                    s_RecordDclReferenceByVal!(target, from, to, dclIdx, inlIndex);
                    return;
                }

                s_RecordDclReferenceByRef(ref target, from, to, dclIdx, inlIndex);
                return;
                
            }

            private delegate void RecordChildDieOffsetsByRef(ref T value, Sym s, slice<ref Var> vars, slice<int> offsets);
            private delegate void RecordChildDieOffsetsByVal(T value, Sym s, slice<ref Var> vars, slice<int> offsets);

            private static readonly RecordChildDieOffsetsByRef s_RecordChildDieOffsetsByRef;
            private static readonly RecordChildDieOffsetsByVal s_RecordChildDieOffsetsByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void RecordChildDieOffsets(Sym s, slice<ref Var> vars, slice<int> offsets)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_RecordChildDieOffsetsByRef is null)
                {
                    s_RecordChildDieOffsetsByVal!(target, s, vars, offsets);
                    return;
                }

                s_RecordChildDieOffsetsByRef(ref target, s, vars, offsets);
                return;
                
            }

            private delegate void AddStringByRef(ref T value, Sym s, @string v);
            private delegate void AddStringByVal(T value, Sym s, @string v);

            private static readonly AddStringByRef s_AddStringByRef;
            private static readonly AddStringByVal s_AddStringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void AddString(Sym s, @string v)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddStringByRef is null)
                {
                    s_AddStringByVal!(target, s, v);
                    return;
                }

                s_AddStringByRef(ref target, s, v);
                return;
                
            }

            private delegate void AddFileRefByRef(ref T value, Sym s, object f);
            private delegate void AddFileRefByVal(T value, Sym s, object f);

            private static readonly AddFileRefByRef s_AddFileRefByRef;
            private static readonly AddFileRefByVal s_AddFileRefByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void AddFileRef(Sym s, object f)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddFileRefByRef is null)
                {
                    s_AddFileRefByVal!(target, s, f);
                    return;
                }

                s_AddFileRefByRef(ref target, s, f);
                return;
                
            }

            private delegate void LogfByRef(ref T value, @string format, params object[] args);
            private delegate void LogfByVal(T value, @string format, params object[] args);

            private static readonly LogfByRef s_LogfByRef;
            private static readonly LogfByVal s_LogfByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Logf(@string format, params object[] args)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_LogfByRef is null)
                {
                    s_LogfByVal!(target, format, args);
                    return;
                }

                s_LogfByRef(ref target, format, args);
                return;
                
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Context()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("PtrSize");

                if (!(extensionMethod is null))
                    s_PtrSizeByRef = extensionMethod.CreateStaticDelegate(typeof(PtrSizeByRef)) as PtrSizeByRef;

                if (s_PtrSizeByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("PtrSize");

                    if (!(extensionMethod is null))
                        s_PtrSizeByVal = extensionMethod.CreateStaticDelegate(typeof(PtrSizeByVal)) as PtrSizeByVal;
                }

                if (s_PtrSizeByRef is null && s_PtrSizeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.PtrSize method", new Exception("PtrSize"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AddInt");

                if (!(extensionMethod is null))
                    s_AddIntByRef = extensionMethod.CreateStaticDelegate(typeof(AddIntByRef)) as AddIntByRef;

                if (s_AddIntByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AddInt");

                    if (!(extensionMethod is null))
                        s_AddIntByVal = extensionMethod.CreateStaticDelegate(typeof(AddIntByVal)) as AddIntByVal;
                }

                if (s_AddIntByRef is null && s_AddIntByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.AddInt method", new Exception("AddInt"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AddBytes");

                if (!(extensionMethod is null))
                    s_AddBytesByRef = extensionMethod.CreateStaticDelegate(typeof(AddBytesByRef)) as AddBytesByRef;

                if (s_AddBytesByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AddBytes");

                    if (!(extensionMethod is null))
                        s_AddBytesByVal = extensionMethod.CreateStaticDelegate(typeof(AddBytesByVal)) as AddBytesByVal;
                }

                if (s_AddBytesByRef is null && s_AddBytesByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.AddBytes method", new Exception("AddBytes"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AddAddress");

                if (!(extensionMethod is null))
                    s_AddAddressByRef = extensionMethod.CreateStaticDelegate(typeof(AddAddressByRef)) as AddAddressByRef;

                if (s_AddAddressByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AddAddress");

                    if (!(extensionMethod is null))
                        s_AddAddressByVal = extensionMethod.CreateStaticDelegate(typeof(AddAddressByVal)) as AddAddressByVal;
                }

                if (s_AddAddressByRef is null && s_AddAddressByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.AddAddress method", new Exception("AddAddress"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AddCURelativeAddress");

                if (!(extensionMethod is null))
                    s_AddCURelativeAddressByRef = extensionMethod.CreateStaticDelegate(typeof(AddCURelativeAddressByRef)) as AddCURelativeAddressByRef;

                if (s_AddCURelativeAddressByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AddCURelativeAddress");

                    if (!(extensionMethod is null))
                        s_AddCURelativeAddressByVal = extensionMethod.CreateStaticDelegate(typeof(AddCURelativeAddressByVal)) as AddCURelativeAddressByVal;
                }

                if (s_AddCURelativeAddressByRef is null && s_AddCURelativeAddressByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.AddCURelativeAddress method", new Exception("AddCURelativeAddress"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AddSectionOffset");

                if (!(extensionMethod is null))
                    s_AddSectionOffsetByRef = extensionMethod.CreateStaticDelegate(typeof(AddSectionOffsetByRef)) as AddSectionOffsetByRef;

                if (s_AddSectionOffsetByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AddSectionOffset");

                    if (!(extensionMethod is null))
                        s_AddSectionOffsetByVal = extensionMethod.CreateStaticDelegate(typeof(AddSectionOffsetByVal)) as AddSectionOffsetByVal;
                }

                if (s_AddSectionOffsetByRef is null && s_AddSectionOffsetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.AddSectionOffset method", new Exception("AddSectionOffset"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("CurrentOffset");

                if (!(extensionMethod is null))
                    s_CurrentOffsetByRef = extensionMethod.CreateStaticDelegate(typeof(CurrentOffsetByRef)) as CurrentOffsetByRef;

                if (s_CurrentOffsetByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("CurrentOffset");

                    if (!(extensionMethod is null))
                        s_CurrentOffsetByVal = extensionMethod.CreateStaticDelegate(typeof(CurrentOffsetByVal)) as CurrentOffsetByVal;
                }

                if (s_CurrentOffsetByRef is null && s_CurrentOffsetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.CurrentOffset method", new Exception("CurrentOffset"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("RecordDclReference");

                if (!(extensionMethod is null))
                    s_RecordDclReferenceByRef = extensionMethod.CreateStaticDelegate(typeof(RecordDclReferenceByRef)) as RecordDclReferenceByRef;

                if (s_RecordDclReferenceByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("RecordDclReference");

                    if (!(extensionMethod is null))
                        s_RecordDclReferenceByVal = extensionMethod.CreateStaticDelegate(typeof(RecordDclReferenceByVal)) as RecordDclReferenceByVal;
                }

                if (s_RecordDclReferenceByRef is null && s_RecordDclReferenceByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.RecordDclReference method", new Exception("RecordDclReference"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("RecordChildDieOffsets");

                if (!(extensionMethod is null))
                    s_RecordChildDieOffsetsByRef = extensionMethod.CreateStaticDelegate(typeof(RecordChildDieOffsetsByRef)) as RecordChildDieOffsetsByRef;

                if (s_RecordChildDieOffsetsByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("RecordChildDieOffsets");

                    if (!(extensionMethod is null))
                        s_RecordChildDieOffsetsByVal = extensionMethod.CreateStaticDelegate(typeof(RecordChildDieOffsetsByVal)) as RecordChildDieOffsetsByVal;
                }

                if (s_RecordChildDieOffsetsByRef is null && s_RecordChildDieOffsetsByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.RecordChildDieOffsets method", new Exception("RecordChildDieOffsets"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AddString");

                if (!(extensionMethod is null))
                    s_AddStringByRef = extensionMethod.CreateStaticDelegate(typeof(AddStringByRef)) as AddStringByRef;

                if (s_AddStringByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AddString");

                    if (!(extensionMethod is null))
                        s_AddStringByVal = extensionMethod.CreateStaticDelegate(typeof(AddStringByVal)) as AddStringByVal;
                }

                if (s_AddStringByRef is null && s_AddStringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.AddString method", new Exception("AddString"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("AddFileRef");

                if (!(extensionMethod is null))
                    s_AddFileRefByRef = extensionMethod.CreateStaticDelegate(typeof(AddFileRefByRef)) as AddFileRefByRef;

                if (s_AddFileRefByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("AddFileRef");

                    if (!(extensionMethod is null))
                        s_AddFileRefByVal = extensionMethod.CreateStaticDelegate(typeof(AddFileRefByVal)) as AddFileRefByVal;
                }

                if (s_AddFileRefByRef is null && s_AddFileRefByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.AddFileRef method", new Exception("AddFileRef"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Logf");

                if (!(extensionMethod is null))
                    s_LogfByRef = extensionMethod.CreateStaticDelegate(typeof(LogfByRef)) as LogfByRef;

                if (s_LogfByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Logf");

                    if (!(extensionMethod is null))
                        s_LogfByVal = extensionMethod.CreateStaticDelegate(typeof(LogfByVal)) as LogfByVal;
                }

                if (s_LogfByRef is null && s_LogfByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Context.Logf method", new Exception("Logf"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Context<T>(in ptr<T> target_ptr) => new Context<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Context<T>(in T target) => new Context<T>(target);

            // Enable comparisons between nil and Context<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Context<T> value, NilType nil) => Activator.CreateInstance<Context<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Context<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Context<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Context<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class dwarf_ContextExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.@internal.dwarf_package.Context target)
        {
            try
            {
                return ((go.cmd.@internal.dwarf_package.Context<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.@internal.dwarf_package.Context target, out T result)
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
        public static object? _(this go.cmd.@internal.dwarf_package.Context target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.@internal.dwarf_package.Context<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.@internal.dwarf_package.Context target, Type type, out object? result)
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