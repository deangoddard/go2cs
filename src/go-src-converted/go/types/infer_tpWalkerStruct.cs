//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:42:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using token = go.go.token_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tpWalker
        {
            // Constructors
            public tpWalker(NilType _)
            {
                this.seen = default;
                this.tparams = default;
            }

            public tpWalker(map<Type, bool> seen = default, slice<ptr<TypeName>> tparams = default)
            {
                this.seen = seen;
                this.tparams = tparams;
            }

            // Enable comparisons between nil and tpWalker struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tpWalker value, NilType nil) => value.Equals(default(tpWalker));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tpWalker value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tpWalker value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tpWalker value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tpWalker(NilType nil) => default(tpWalker);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static tpWalker tpWalker_cast(dynamic value)
        {
            return new tpWalker(value.seen, value.tparams);
        }
    }
}}