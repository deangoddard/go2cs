//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:22:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class idna_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct idnaTrie
        {
            // Constructors
            public idnaTrie(NilType _)
            {
            }
            // Enable comparisons between nil and idnaTrie struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(idnaTrie value, NilType nil) => value.Equals(default(idnaTrie));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(idnaTrie value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, idnaTrie value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, idnaTrie value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator idnaTrie(NilType nil) => default(idnaTrie);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static idnaTrie idnaTrie_cast(dynamic value)
        {
            return new idnaTrie();
        }
    }
}}}}