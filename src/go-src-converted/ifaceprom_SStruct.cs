//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct S
        {
            // I.one function promotion
            private delegate @string oneByVal(T value);
            private delegate @string oneByRef(ref T value);

            private static readonly oneByVal s_oneByVal;
            private static readonly oneByRef s_oneByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string one() => s_oneByRef?.Invoke(ref this) ?? s_oneByVal?.Invoke(this) ?? I?.one() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // I.two function promotion
            private delegate @string twoByVal(T value);
            private delegate @string twoByRef(ref T value);

            private static readonly twoByVal s_twoByVal;
            private static readonly twoByRef s_twoByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string two() => s_twoByRef?.Invoke(ref this) ?? s_twoByVal?.Invoke(this) ?? I?.two() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static S()
            {
                Type targetType = typeof(S);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("one");

                if (extensionMethod is not null)
                {
                    s_oneByRef = extensionMethod.CreateStaticDelegate(typeof(oneByRef)) as oneByRef;

                    if (s_oneByRef is null)
                        s_oneByVal = extensionMethod.CreateStaticDelegate(typeof(oneByVal)) as oneByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("two");

                if (extensionMethod is not null)
                {
                    s_twoByRef = extensionMethod.CreateStaticDelegate(typeof(twoByRef)) as twoByRef;

                    if (s_twoByRef is null)
                        s_twoByVal = extensionMethod.CreateStaticDelegate(typeof(twoByVal)) as twoByVal;
                }
            }

            // Constructors
            public S(NilType _)
            {
                this.I = default;
            }

            public S(I I = default)
            {
                this.I = I;
            }

            // Enable comparisons between nil and S struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S value, NilType nil) => value.Equals(default(S));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S(NilType nil) => default(S);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static S S_cast(dynamic value)
        {
            return new S(value.I);
        }
    }
}