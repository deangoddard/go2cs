//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:08:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class norm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nfcTrie
        {
            // Constructors
            public nfcTrie(NilType _)
            {
            }
            // Enable comparisons between nil and nfcTrie struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nfcTrie value, NilType nil) => value.Equals(default(nfcTrie));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nfcTrie value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nfcTrie value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nfcTrie value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nfcTrie(NilType nil) => default(nfcTrie);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nfcTrie nfcTrie_cast(dynamic value)
        {
            return new nfcTrie();
        }
    }
}}}}}}