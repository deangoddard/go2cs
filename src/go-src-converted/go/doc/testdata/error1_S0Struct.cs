//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace go
{
    public static partial class error1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct S0
        {
            // error.Error function promotion
            private delegate @string ErrorByVal(T value);
            private delegate @string ErrorByRef(ref T value);

            private static readonly ErrorByVal s_ErrorByVal;
            private static readonly ErrorByRef s_ErrorByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Error() => s_ErrorByRef?.Invoke(ref this) ?? s_ErrorByVal?.Invoke(this) ?? error?.Error() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static S0()
            {
                Type targetType = typeof(S0);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Error");

                if ((object)extensionMethod != null)
                {
                    s_ErrorByRef = extensionMethod.CreateStaticDelegate(typeof(ErrorByRef)) as ErrorByRef;

                    if ((object)s_ErrorByRef == null)
                        s_ErrorByVal = extensionMethod.CreateStaticDelegate(typeof(ErrorByVal)) as ErrorByVal;
                }
            }

            // Constructors
            public S0(NilType _)
            {
                this.error = default;
            }

            public S0(error error = default)
            {
                this.error = error;
            }

            // Enable comparisons between nil and S0 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S0 value, NilType nil) => value.Equals(default(S0));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S0 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S0 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S0 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S0(NilType nil) => default(S0);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static S0 S0_cast(dynamic value)
        {
            return new S0(value.error);
        }
    }
}}