//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;

#nullable enable

namespace go
{
    public static partial class strconv_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NumError
        {
            // Constructors
            public NumError(NilType _)
            {
                this.Func = default;
                this.Num = default;
                this.Err = default;
            }

            public NumError(@string Func = default, @string Num = default, error Err = default)
            {
                this.Func = Func;
                this.Num = Num;
                this.Err = Err;
            }

            // Enable comparisons between nil and NumError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NumError value, NilType nil) => value.Equals(default(NumError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NumError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NumError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NumError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NumError(NilType nil) => default(NumError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NumError NumError_cast(dynamic value)
        {
            return new NumError(value.Func, value.Num, value.Err);
        }
    }
}