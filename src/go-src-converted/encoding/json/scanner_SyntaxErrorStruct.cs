//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using strconv = go.strconv_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SyntaxError
        {
            // Constructors
            public SyntaxError(NilType _)
            {
                this.msg = default;
                this.Offset = default;
            }

            public SyntaxError(@string msg = default, long Offset = default)
            {
                this.msg = msg;
                this.Offset = Offset;
            }

            // Enable comparisons between nil and SyntaxError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SyntaxError value, NilType nil) => value.Equals(default(SyntaxError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SyntaxError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SyntaxError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SyntaxError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SyntaxError(NilType nil) => default(SyntaxError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SyntaxError SyntaxError_cast(dynamic value)
        {
            return new SyntaxError(value.msg, value.Offset);
        }
    }
}}