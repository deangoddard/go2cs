//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace sync
{
    public static partial class atomic_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ifaceWords
        {
            // Constructors
            public ifaceWords(NilType _)
            {
                this.typ = default;
                this.data = default;
            }

            public ifaceWords(unsafe.Pointer typ = default, unsafe.Pointer data = default)
            {
                this.typ = typ;
                this.data = data;
            }

            // Enable comparisons between nil and ifaceWords struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ifaceWords value, NilType nil) => value.Equals(default(ifaceWords));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ifaceWords value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ifaceWords value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ifaceWords value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ifaceWords(NilType nil) => default(ifaceWords);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ifaceWords ifaceWords_cast(dynamic value)
        {
            return new ifaceWords(value.typ, value.data);
        }
    }
}}