//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:12:26 UTC
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
        private partial struct structtype
        {
            // Constructors
            public structtype(NilType _)
            {
                this.typ = default;
                this.pkgPath = default;
                this.fields = default;
            }

            public structtype(_type typ = default, name pkgPath = default, slice<structfield> fields = default)
            {
                this.typ = typ;
                this.pkgPath = pkgPath;
                this.fields = fields;
            }

            // Enable comparisons between nil and structtype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(structtype value, NilType nil) => value.Equals(default(structtype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(structtype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, structtype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, structtype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator structtype(NilType nil) => default(structtype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static structtype structtype_cast(dynamic value)
        {
            return new structtype(value.typ, value.pkgPath, value.fields);
        }
    }
}