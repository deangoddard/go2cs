//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using unsafeheader = go.@internal.unsafeheader_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class reflectlite_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct method
        {
            // Constructors
            public method(NilType _)
            {
                this.name = default;
                this.mtyp = default;
                this.ifn = default;
                this.tfn = default;
            }

            public method(nameOff name = default, typeOff mtyp = default, textOff ifn = default, textOff tfn = default)
            {
                this.name = name;
                this.mtyp = mtyp;
                this.ifn = ifn;
                this.tfn = tfn;
            }

            // Enable comparisons between nil and method struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(method value, NilType nil) => value.Equals(default(method));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(method value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, method value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, method value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator method(NilType nil) => default(method);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static method method_cast(dynamic value)
        {
            return new method(value.name, value.mtyp, value.ifn, value.tfn);
        }
    }
}}