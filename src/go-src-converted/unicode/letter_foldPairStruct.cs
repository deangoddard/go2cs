//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class unicode_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct foldPair
        {
            // Constructors
            public foldPair(NilType _)
            {
                this.From = default;
                this.To = default;
            }

            public foldPair(ushort From = default, ushort To = default)
            {
                this.From = From;
                this.To = To;
            }

            // Enable comparisons between nil and foldPair struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(foldPair value, NilType nil) => value.Equals(default(foldPair));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(foldPair value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, foldPair value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, foldPair value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator foldPair(NilType nil) => default(foldPair);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static foldPair foldPair_cast(dynamic value)
        {
            return new foldPair(value.From, value.To);
        }
    }
}