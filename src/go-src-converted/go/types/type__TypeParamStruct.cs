//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:42:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using token = go.go.token_package;
using atomic = go.sync.atomic_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _TypeParam
        {
            // Constructors
            public _TypeParam(NilType _)
            {
                this.check = default;
                this.id = default;
                this.obj = default;
                this.index = default;
                this.bound = default;
            }

            public _TypeParam(ref ptr<Checker> check = default, ulong id = default, ref ptr<TypeName> obj = default, nint index = default, Type bound = default)
            {
                this.check = check;
                this.id = id;
                this.obj = obj;
                this.index = index;
                this.bound = bound;
            }

            // Enable comparisons between nil and _TypeParam struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_TypeParam value, NilType nil) => value.Equals(default(_TypeParam));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_TypeParam value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _TypeParam value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _TypeParam value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _TypeParam(NilType nil) => default(_TypeParam);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static _TypeParam _TypeParam_cast(dynamic value)
        {
            return new _TypeParam(ref value.check, value.id, ref value.obj, value.index, value.bound);
        }
    }
}}