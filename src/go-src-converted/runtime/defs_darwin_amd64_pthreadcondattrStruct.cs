//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pthreadcondattr
        {
            // Constructors
            public pthreadcondattr(NilType _)
            {
                this.X__sig = default;
                this.X__opaque = default;
            }

            public pthreadcondattr(long X__sig = default, array<sbyte> X__opaque = default)
            {
                this.X__sig = X__sig;
                this.X__opaque = X__opaque;
            }

            // Enable comparisons between nil and pthreadcondattr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pthreadcondattr value, NilType nil) => value.Equals(default(pthreadcondattr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pthreadcondattr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pthreadcondattr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pthreadcondattr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthreadcondattr(NilType nil) => default(pthreadcondattr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pthreadcondattr pthreadcondattr_cast(dynamic value)
        {
            return new pthreadcondattr(value.X__sig, value.X__opaque);
        }
    }
}