//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ast = go.go.ast_package;
using token = go.go.token_package;
using lazyregexp = go.@internal.lazyregexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class doc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct data
        {
            // Constructors
            public data(NilType _)
            {
                this.n = default;
                this.swap = default;
                this.less = default;
            }

            public data(nint n = default, Action<nint, nint> swap = default, Func<nint, nint, bool> less = default)
            {
                this.n = n;
                this.swap = swap;
                this.less = less;
            }

            // Enable comparisons between nil and data struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(data value, NilType nil) => value.Equals(default(data));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(data value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, data value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, data value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator data(NilType nil) => default(data);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static data data_cast(dynamic value)
        {
            return new data(value.n, value.swap, value.less);
        }
    }
}}