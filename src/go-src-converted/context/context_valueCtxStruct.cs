//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using time = go.time_package;

namespace go
{
    public static partial class context_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct valueCtx
        {
            // Context.Deadline function promotion
            private delegate void DeadlineByVal(T value);
            private delegate void DeadlineByRef(ref T value);

            private static readonly DeadlineByVal s_DeadlineByVal;
            private static readonly DeadlineByRef s_DeadlineByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Deadline() => s_DeadlineByRef?.Invoke(ref this) ?? s_DeadlineByVal?.Invoke(this) ?? Context?.Deadline() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Context.Done function promotion
            private delegate void DoneByVal(T value);
            private delegate void DoneByRef(ref T value);

            private static readonly DoneByVal s_DoneByVal;
            private static readonly DoneByRef s_DoneByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Done() => s_DoneByRef?.Invoke(ref this) ?? s_DoneByVal?.Invoke(this) ?? Context?.Done() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Context.Err function promotion
            private delegate void ErrByVal(T value);
            private delegate void ErrByRef(ref T value);

            private static readonly ErrByVal s_ErrByVal;
            private static readonly ErrByRef s_ErrByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Err() => s_ErrByRef?.Invoke(ref this) ?? s_ErrByVal?.Invoke(this) ?? Context?.Err() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Context.Value function promotion
            private delegate void ValueByVal(T value, object key);
            private delegate void ValueByRef(ref T value, object key);

            private static readonly ValueByVal s_ValueByVal;
            private static readonly ValueByRef s_ValueByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Value(object key) => s_ValueByRef?.Invoke(ref this, key) ?? s_ValueByVal?.Invoke(this, key) ?? Context?.Value(key) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static valueCtx()
            {
                Type targetType = typeof(valueCtx);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Deadline");

                if ((object)extensionMethod != null)
                {
                    s_DeadlineByRef = extensionMethod.CreateStaticDelegate(typeof(DeadlineByRef)) as DeadlineByRef;

                    if ((object)s_DeadlineByRef == null)
                        s_DeadlineByVal = extensionMethod.CreateStaticDelegate(typeof(DeadlineByVal)) as DeadlineByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Done");

                if ((object)extensionMethod != null)
                {
                    s_DoneByRef = extensionMethod.CreateStaticDelegate(typeof(DoneByRef)) as DoneByRef;

                    if ((object)s_DoneByRef == null)
                        s_DoneByVal = extensionMethod.CreateStaticDelegate(typeof(DoneByVal)) as DoneByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Err");

                if ((object)extensionMethod != null)
                {
                    s_ErrByRef = extensionMethod.CreateStaticDelegate(typeof(ErrByRef)) as ErrByRef;

                    if ((object)s_ErrByRef == null)
                        s_ErrByVal = extensionMethod.CreateStaticDelegate(typeof(ErrByVal)) as ErrByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Value");

                if ((object)extensionMethod != null)
                {
                    s_ValueByRef = extensionMethod.CreateStaticDelegate(typeof(ValueByRef)) as ValueByRef;

                    if ((object)s_ValueByRef == null)
                        s_ValueByVal = extensionMethod.CreateStaticDelegate(typeof(ValueByVal)) as ValueByVal;
                }
            }

            // Constructors
            public valueCtx(NilType _)
            {
                this.Context = default;
            }

            public valueCtx(Context Context = default)
            {
                this.Context = Context;
            }

            // Enable comparisons between nil and valueCtx struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(valueCtx value, NilType nil) => value.Equals(default(valueCtx));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(valueCtx value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, valueCtx value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, valueCtx value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator valueCtx(NilType nil) => default(valueCtx);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static valueCtx valueCtx_cast(dynamic value)
        {
            return new valueCtx(value.Context);
        }
    }
}