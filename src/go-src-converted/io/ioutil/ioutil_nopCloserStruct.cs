//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using io = go.io_package;
using os = go.os_package;
using sort = go.sort_package;
using sync = go.sync_package;
using go;

namespace go {
namespace io
{
    public static partial class ioutil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nopCloser
        {
            // Reader.Read function promotion
            private delegate (long, error) ReadByVal(T value, slice<byte> p);
            private delegate (long, error) ReadByRef(ref T value, slice<byte> p);

            private static readonly ReadByVal s_ReadByVal;
            private static readonly ReadByRef s_ReadByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Read(slice<byte> p) => s_ReadByRef?.Invoke(ref this, p) ?? s_ReadByVal?.Invoke(this, p) ?? Reader?.Read(p) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static nopCloser()
            {
                Type targetType = typeof(nopCloser);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Read");

                if ((object)extensionMethod != null)
                {
                    s_ReadByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByRef)) as ReadByRef;

                    if ((object)s_ReadByRef == null)
                        s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;
                }
            }

            // Constructors
            public nopCloser(NilType _)
            {
                this.Reader = default;
            }

            public nopCloser(io.Reader Reader = default)
            {
                this.Reader = Reader;
            }

            // Enable comparisons between nil and nopCloser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nopCloser value, NilType nil) => value.Equals(default(nopCloser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nopCloser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nopCloser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nopCloser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nopCloser(NilType nil) => default(nopCloser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nopCloser nopCloser_cast(dynamic value)
        {
            return new nopCloser(value.Reader);
        }
    }
}}