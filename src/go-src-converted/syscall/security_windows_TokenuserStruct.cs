//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Tokenuser
        {
            // Constructors
            public Tokenuser(NilType _)
            {
                this.User = default;
            }

            public Tokenuser(SIDAndAttributes User = default)
            {
                this.User = User;
            }

            // Enable comparisons between nil and Tokenuser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tokenuser value, NilType nil) => value.Equals(default(Tokenuser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tokenuser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tokenuser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tokenuser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tokenuser(NilType nil) => default(Tokenuser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tokenuser Tokenuser_cast(dynamic value)
        {
            return new Tokenuser(value.User);
        }
    }
}