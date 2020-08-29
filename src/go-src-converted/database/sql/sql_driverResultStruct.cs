//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct driverResult
        {
            // Locker.Lock function promotion
            private delegate void LockByVal(T value);
            private delegate void LockByRef(ref T value);

            private static readonly LockByVal s_LockByVal;
            private static readonly LockByRef s_LockByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Lock() => s_LockByRef?.Invoke(ref this) ?? s_LockByVal?.Invoke(this) ?? Locker?.Lock() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Locker.Unlock function promotion
            private delegate void UnlockByVal(T value);
            private delegate void UnlockByRef(ref T value);

            private static readonly UnlockByVal s_UnlockByVal;
            private static readonly UnlockByRef s_UnlockByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unlock() => s_UnlockByRef?.Invoke(ref this) ?? s_UnlockByVal?.Invoke(this) ?? Locker?.Unlock() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static driverResult()
            {
                Type targetType = typeof(driverResult);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Lock");

                if ((object)extensionMethod != null)
                {
                    s_LockByRef = extensionMethod.CreateStaticDelegate(typeof(LockByRef)) as LockByRef;

                    if ((object)s_LockByRef == null)
                        s_LockByVal = extensionMethod.CreateStaticDelegate(typeof(LockByVal)) as LockByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Unlock");

                if ((object)extensionMethod != null)
                {
                    s_UnlockByRef = extensionMethod.CreateStaticDelegate(typeof(UnlockByRef)) as UnlockByRef;

                    if ((object)s_UnlockByRef == null)
                        s_UnlockByVal = extensionMethod.CreateStaticDelegate(typeof(UnlockByVal)) as UnlockByVal;
                }
            }

            // Constructors
            public driverResult(NilType _)
            {
                this.Locker = default;
                this.resi = default;
            }

            public driverResult(sync.Locker Locker = default, driver.Result resi = default)
            {
                this.Locker = Locker;
                this.resi = resi;
            }

            // Enable comparisons between nil and driverResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(driverResult value, NilType nil) => value.Equals(default(driverResult));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(driverResult value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, driverResult value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, driverResult value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator driverResult(NilType nil) => default(driverResult);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static driverResult driverResult_cast(dynamic value)
        {
            return new driverResult(value.Locker, value.resi);
        }
    }
}}