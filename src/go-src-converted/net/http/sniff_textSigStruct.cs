//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct textSig
        {
            // Constructors
            public textSig(NilType _)
            {
            }
            // Enable comparisons between nil and textSig struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(textSig value, NilType nil) => value.Equals(default(textSig));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(textSig value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, textSig value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, textSig value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator textSig(NilType nil) => default(textSig);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static textSig textSig_cast(dynamic value)
        {
            return new textSig();
        }
    }
}}