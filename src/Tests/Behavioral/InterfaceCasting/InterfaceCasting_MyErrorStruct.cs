//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 20:12:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct MyError
        {
            // Constructors
            public MyError(NilType _)
            {
                this.description = default;
            }

            public MyError(@string description = default)
            {
                this.description = description;
            }

            // Enable comparisons between nil and MyError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyError value, NilType nil) => value.Equals(default(MyError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyError(NilType nil) => default(MyError);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static MyError MyError_cast(dynamic value)
        {
            return new MyError(value.description);
        }
    }
}