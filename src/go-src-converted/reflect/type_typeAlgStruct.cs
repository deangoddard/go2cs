//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typeAlg
        {
            // Constructors
            public typeAlg(NilType _)
            {
                this.hash = default;
                this.equal = default;
            }

            public typeAlg(Func<unsafe.Pointer, System.UIntPtr, System.UIntPtr> hash = default, Func<unsafe.Pointer, unsafe.Pointer, bool> equal = default)
            {
                this.hash = hash;
                this.equal = equal;
            }

            // Enable comparisons between nil and typeAlg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeAlg value, NilType nil) => value.Equals(default(typeAlg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeAlg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeAlg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeAlg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeAlg(NilType nil) => default(typeAlg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static typeAlg typeAlg_cast(dynamic value)
        {
            return new typeAlg(value.hash, value.equal);
        }
    }
}