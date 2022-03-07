//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using fs = go.io.fs_package;
using path = go.path_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace testing
{
    public static partial class fstest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fsOnly
        {
            // FS.Open function promotion
            private delegate (File, error) OpenByVal(T value, @string name);
            private delegate (File, error) OpenByRef(ref T value, @string name);

            private static readonly OpenByVal s_OpenByVal;
            private static readonly OpenByRef s_OpenByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (File, error) Open(@string name) => s_OpenByRef?.Invoke(ref this, name) ?? s_OpenByVal?.Invoke(this, name) ?? FS?.Open(name) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static fsOnly()
            {
                Type targetType = typeof(fsOnly);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Open");

                if (extensionMethod is not null)
                {
                    s_OpenByRef = extensionMethod.CreateStaticDelegate(typeof(OpenByRef)) as OpenByRef;

                    if (s_OpenByRef is null)
                        s_OpenByVal = extensionMethod.CreateStaticDelegate(typeof(OpenByVal)) as OpenByVal;
                }
            }

            // Constructors
            public fsOnly(NilType _)
            {
                this.FS = default;
            }

            public fsOnly(fs.FS FS = default)
            {
                this.FS = FS;
            }

            // Enable comparisons between nil and fsOnly struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fsOnly value, NilType nil) => value.Equals(default(fsOnly));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fsOnly value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fsOnly value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fsOnly value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fsOnly(NilType nil) => default(fsOnly);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fsOnly fsOnly_cast(dynamic value)
        {
            return new fsOnly(value.FS);
        }
    }
}}