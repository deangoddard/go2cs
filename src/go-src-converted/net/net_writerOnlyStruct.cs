//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:16:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using errors = go.errors_package;
using poll = go.@internal.poll_package;
using io = go.io_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct writerOnly
        {
            // Writer.Write function promotion
            private delegate (nint, error) WriteByVal(T value, slice<byte> p);
            private delegate (nint, error) WriteByRef(ref T value, slice<byte> p);

            private static readonly WriteByVal s_WriteByVal;
            private static readonly WriteByRef s_WriteByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (nint, error) Write(slice<byte> p) => s_WriteByRef?.Invoke(ref this, p) ?? s_WriteByVal?.Invoke(this, p) ?? Writer?.Write(p) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static writerOnly()
            {
                Type targetType = typeof(writerOnly);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Write");

                if (extensionMethod is not null)
                {
                    s_WriteByRef = extensionMethod.CreateStaticDelegate(typeof(WriteByRef)) as WriteByRef;

                    if (s_WriteByRef is null)
                        s_WriteByVal = extensionMethod.CreateStaticDelegate(typeof(WriteByVal)) as WriteByVal;
                }
            }

            // Constructors
            public writerOnly(NilType _)
            {
                this.Writer = default;
            }

            public writerOnly(io.Writer Writer = default)
            {
                this.Writer = Writer;
            }

            // Enable comparisons between nil and writerOnly struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(writerOnly value, NilType nil) => value.Equals(default(writerOnly));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(writerOnly value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, writerOnly value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, writerOnly value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator writerOnly(NilType nil) => default(writerOnly);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static writerOnly writerOnly_cast(dynamic value)
        {
            return new writerOnly(value.Writer);
        }
    }
}